$(document).ready(function () {
  $("#input-product-id").change(function () {
    var productId = parseInt($(this).val());
    console.log(productId);
    getById(productId);
    // console.log(productId);
  });
});

const getById = (productId) => {
  if (productId) {
    $.ajax({
      url: "/Product/GetProduct/" + productId,
      type: "GET",
      success: function (data) {
        $("#product-input-id").val(data.id);

        $("#input-unit-id").val(data.unitId);
        console.log(data.unitId);

        $("#input-price").val(data.price);

        $("#input-quantity").on("input", function () {
          let quantity = parseInt($(this).val()) || 0;

          if (quantity < 0) {
            $(this).val(0);
            quantity = 0;
          }
          updateTotalPrice(data.price);
        });
        updateTotalPrice(data.price);
      },
      error: function () {
        window.location.reload();
      },
    });
  }
};

const updateTotalPrice = (price) => {
  let quantity = parseInt($("#input-quantity").val()) || 0;
  $("#input-total-price").val(price * quantity);
};
