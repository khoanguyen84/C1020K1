var product = product || {};

product.showData =function(){
    $.ajax({
        url: 'https://localhost:44352/api/category/gets',
        method: 'GET',
        contentType: 'application/json',
        success : function(data){
            $('#tbProduct tbody').empty();
            for(let item of data){
                $('#tbProduct tbody').append(`
                                <tr>
                                    <td>${item.categoryId}</td>
                                    <td>${item.categoryName}</td>
                                </tr>
                            `);
            };
            $('#tbProduct').DataTable();
        }
    });
}

product.openModal = function(){
    $('#addEditProduct').modal('show');
    // $('.btn').notify("Hello world", 'success', {position: 'right'});
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
            url: "https://localhost:44392/api/products/save",
            method: "POST",
            contentType: 'application/json',
            dataType: 'json',
            data: JSON.stringify(saveObj),
            success: function (data) {
                if (data.success) {
                    product.showData();
                    $('#addEditProduct').modal('hide');
                    // $.notify(data.message, 'success');
                    $('.msg').notify(data.message, 'success', { position: "top right" });
                }else{
                    $.notify(data.message, 'error');
                }
                // bootbox.alert(data.message);
            }
        });
    }
}

product.init = function(){
    product.showData();
}

$(document).ready(function(){
    product.init();
});
