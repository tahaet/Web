using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using Web.Models.Validations;
using Web.Models.ViewModels;
using Transaction = Web.Models.Transaction;

namespace Web.Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ILogger<ProductController> logger;

        public ProductVM ProductVM { get; set; }

        public ProductController(ILogger<ProductController> logger, IUnitOfWork unitOfWork)
        {
            this.logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        [OutputCache(Duration = 10)]
        public async Task<IActionResult> Create()
        {
            var units = (await _unitOfWork.Unit.GetAllAsync())
                .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() })
                .ToList();

            var productVM = new ProductVM { Product = new Product(), UnitList = units };

            return View(productVM);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(ProductVM productVM)
        {
            var result = new ProductVMValidator().Validate(productVM);
            try
            {
                if (!result.IsValid)
                {
                    var units = (await _unitOfWork.Unit.GetAllAsync())
                        .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() })
                        .ToList();

                    foreach (var failure in result.Errors)
                    {
                        ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                    }

                    return View(new ProductVM { Product = productVM.Product, UnitList = units });
                }
                Product product = new Product
                {
                    Name = productVM.Product.Name,
                    UnitId = productVM.Product.UnitId,
                    Unit = null,
                    Price = productVM.Product.Price,
                    InitialQuantity = productVM.Product.InitialQuantity,
                };

                _unitOfWork.Product.Add(product);
                await _unitOfWork.SaveAsync();
                TempData["success"] = "New product was added successfully";
            }
            catch (System.Exception ex)
            {
                logger.LogError(ex.Message);
                TempData["error"] = "Something went wrong, please contact admin";
            }

            return RedirectToAction(nameof(Index));
        }

        [OutputCache(Duration = 10)]
        public async Task<IActionResult> AddTransaction()
        {
            TransactionVM transactionVM = new TransactionVM();

            try
            {
                transactionVM.ProductList = (await _unitOfWork.Product.GetAllAsync())
                    .ToList()
                    .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });

                transactionVM.UnitList = (await _unitOfWork.Unit.GetAllAsync()).Select(
                    x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }
                );
            }
            catch (System.Exception ex)
            {
                logger.LogError(ex.Message);
                TempData["error"] = "Something went wrong, please contact admin";
                RedirectToAction(nameof(Index));
            }

            return View(transactionVM);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddTransaction(TransactionVM transactionVM)
        {
            var result = new TransactionVMValidator().Validate(transactionVM);

            try
            {
                if (!result.IsValid)
                {
                    foreach (var failure in result.Errors)
                    {
                        ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                    }

                    var productList = (await _unitOfWork.Product.GetAllAsync())
                        .ToList()
                        .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });

                    var unitList = (await _unitOfWork.Unit.GetAllAsync()).Select(
                        x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }
                    );

                    return View(
                        new TransactionVM { ProductList = productList, UnitList = unitList }
                    );
                }
                ;

                _unitOfWork.Transaction.Add(
                    new Transaction
                    {
                        Date = transactionVM.Date,
                        ProductId = transactionVM.ProductId,
                        Quantity = transactionVM.Quantity,
                        TotalPrice = transactionVM.TotalPrice,
                    }
                );
                var product = await _unitOfWork.Product.GetAsync(x => x.Id == transactionVM.ProductId);
                product.InitialQuantity -= transactionVM.Quantity;
                _unitOfWork.Product.Update(product);
                await _unitOfWork.SaveAsync();

                TempData["success"] = "Transaction was add successfully";
            }
            catch (System.Exception ex)
            {
                logger.LogError(ex.Message);
                TempData["error"] = "Something went wrong, please contact admin";
            }
            return RedirectToAction(nameof(Transactions));
        }

        public IActionResult Transactions()
        {
            return View();
        }

        #region Api Calls
        [HttpGet]
        public async Task<IActionResult> GetProduct(int id)
        {
            if (id < 1)
                return BadRequest();
            try
            {
                var product = await _unitOfWork.Product.GetAsync(
                    x => x.Id == id,
                    includes: [nameof(Unit)]
                );
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            catch (System.Exception ex)
            {
                logger.LogError(ex.Message);
                TempData["error"] = "Something went wrong, please contact admin";
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public async Task<IActionResult> FilterTransactions(
            DateTime? start = null,
            DateTime? end = null,
            int page = 1
        )
        {
            if (start != null && end != null)
            {
                if (start.Value.CompareTo(end.Value) > 0)
                {
                    var temp = new DateTime();
                    temp = start.Value;
                    start = end;
                    end = temp;
                }
            }

            List<TransactionsView> transactions = new();
            int pageSize = 10;
            int totalItems = 0;
            try
            {

                var query = await _unitOfWork.TransactionsView.GetAllAsync();
                totalItems = query.Count();
                if (start.HasValue && end.HasValue)
                {
                    query = query.Where(x => x.Date >= start.Value && x.Date <= end.Value);
                    totalItems = query.Count();
                }
                else if (start.HasValue)
                {
                    query = query.Where(x => x.Date > start.Value);
                    totalItems = query.Count();
                }
                else if (end.HasValue)
                {
                    query = query.Where(x => x.Date < end.Value);
                    totalItems = query.Count();
                }

                transactions = await query
                    .OrderByDescending(x => x.Date)
                    .Skip(pageSize * (page - 1))
                    .Take(pageSize)
                    .ToListAsync();

            }
            catch (System.Exception ex)
            {
                logger.LogError(ex.Message);
                TempData["error"] = "Something went wrong, please contact admin.";
                return StatusCode(500);
            }

            return Json(new { transactions, totalItems });
        }
        #endregion
    }
}
