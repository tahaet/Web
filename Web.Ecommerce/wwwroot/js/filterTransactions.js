
let currentPage = 1;
const itemsPerPage = 10;
function updatePagination(totalItems) {
  const totalPages = Math.ceil(totalItems / itemsPerPage);
  $("#paginationControls").empty();

  if (currentPage > 1) {
    $("#paginationControls").append(`
      <li class="page-item" id="prevPage">
          <button class="page-link" href="#" id="prevButton">Previous</button>
      </li>
    `);
  }

  const maxButtons = 5;
  let startPage, endPage;

  if (totalPages <= maxButtons) {
    startPage = 1;
    endPage = totalPages;
  } else {
    if (currentPage <= Math.ceil(maxButtons / 2)) {
      startPage = 1;
      endPage = maxButtons;
    } else if (currentPage + Math.floor(maxButtons / 2) >= totalPages) {
      startPage = totalPages - maxButtons + 1;
      endPage = totalPages;
    } else {
      startPage = currentPage - Math.floor(maxButtons / 2);
      endPage = currentPage + Math.floor(maxButtons / 2);
    }
  }

  for (let i = startPage; i <= endPage; i++) {
    const pageItem = $('<li class="page-item"></li>');
    const pageLink = $(`<button class="page-link">${i}</button>`);

    if (i === currentPage) {
      pageItem.addClass("active");
    }

    pageLink.on("click", function (e) {
      e.preventDefault();
      currentPage = i;
      fetchTransactions(currentPage);
    });

    pageItem.append(pageLink);
    $("#paginationControls").append(pageItem);
  }

  if (currentPage < totalPages) {
    $("#paginationControls").append(`
      <li class="page-item" id="nextPage">
          <button class="page-link" id="nextButton">Next</button>
      </li>
    `);
  }

  
  $("#nextButton").on("click", function (e) {
    e.preventDefault();
    if (currentPage < totalPages) {
      currentPage++;
      fetchTransactions(currentPage);
    }
  });

  
  $("#prevButton").on("click", function (e) {
    e.preventDefault();
    if (currentPage > 1) {
      currentPage--;
      fetchTransactions(currentPage);
    }
  });
}

function fetchTransactions(page) {
  var startDate = $("#startDate").val();
    var endDate = $("#endDate").val();
   
  $.ajax({
    url: "/Product/FilterTransactions",
    type: "GET",
    data: {
      start: startDate,
      end: endDate,
      page: page,
    },
    success: function (data) {
      updateTransactionTable(data.transactions);
      updatePagination(data.totalItems);
    },
    error: function (error) {
        toastr.error("Error while fetching transactions, please contact admin");
    },
  });
}

$(document).ready(function () {

  fetchTransactions(currentPage);

  $("#filterButton").on("click", function () {
    currentPage = 1;
    if (!$("#startDate").val() && !$("#endDate").val()) return;

    fetchTransactions(currentPage);
  });

  $("#clearButton").on("click", function () {
    $("#startDate").val("");
    $("#endDate").val("");
    currentPage = 1;
    fetchTransactions(currentPage);
  });
});

function updateTransactionTable(transactions) {
  if (!transactions || transactions.length === 0) {
    $("#tblTransactions").hide();
    $("#transactionResults").html(
      "<p>No transactions found for the selected dates.</p>"
    );
    return;
  }
  drawTable(transactions);
  $("#tblTransactions").show();
  $("#transactionResults").empty();
}
function drawTable(transactions) {
  var tbody = $("#tblTransactions tbody");
  tbody.empty();
  const rows = transactions.map(
    (item) =>
      `
                <tr>
                    <td>${item.productName || ""}</td>
                    <td>${item.quantity || ""}</td>
                    <td>${item.unitName || ""}</td>
                    <td>${item.totalPrice || ""}</td>
                    <td>${
                      new Date(item.date).toLocaleDateString("en-GB") || ""
                    }</td>
                </tr>
        `
  );
  tbody.append(rows);
}
