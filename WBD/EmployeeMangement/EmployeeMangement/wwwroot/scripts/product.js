var product = product || {};


product.showProducts = function () {
    $.ajax({
        url: '/Dashboard/Gets',
        method: "GET",
        contentType: 'application/json',
        success: function (data) {
            $('#tbProduct>tbody').empty();
            for(let item of data) {
                $('#tbProduct>tbody').append(`
                        <tr>
                            <td>${item.productId}</td>
                            <td>${item.productName}</td>
                            <td>${item.description}</td>
                            <td>${item.price}</td>
                            <td></td>
                        </tr>
                    `);
            };
            $('#tbProduct').dataTable();
        }
    });
}

product.openModal = function () {
    $('#addEditProduct').modal('show');
}

product.save = function () {
    if ($('#addEditProductForm').valid()) {
        var saveObj = {
            ProductId: parseInt($('#ProductId').val()),
            ProductName: $('#ProductName').val(),
            Price: parseFloat($('#Price').val()),
            Description: $('#Description').val()
        };
        $.ajax({
            url: "/Dashboard/Save",
            method: "POST",
            contentType: 'application/json',
            dataType: 'json',
            data: JSON.stringify(saveObj),
            success: function (data) {
                if (data.success) {
                    product.showProducts();
                    $('#addEditProduct').modal('hide');
                }
                bootbox.alert(data.message);
            }
        });
    }
}

product.init = function () {
    product.showProducts();
}

$(document).ready(function () {
    product.init();
});