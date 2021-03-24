var product = product || {};


product.showProducts = function(){
    var container = $('#pagination');
    container.pagination({
        dataSource: 'https://localhost:44392/api/products/Gets',
        locator: 'items',
        totalNumber: 25,
        pageSize: 10,
        showPageNumbers: true,
        showPrevious: true,
        showNext: true,
        showNavigator: true,
        showFirstOnEllipsisShow: true,
        showLastOnEllipsisShow: true,
        ajax: {
            beforeSend: function() {
            container.prev().html('Loading data from flickr.com ...');
        }
      },
      callback: function(response, pagination) {
        // console.log(22, response, pagination);
        var dataHtml = '';
        $.each(response, function (index, item) {
          dataHtml += `<div class="col-sm-4 col-md-3 mb-2">
                            <div class="card">
                                <h6 class="card-header">${item.productName}</h6>
                                <div class="card-body" style="height: 150px;">
                                    <p>${item.description}</p>
                                </div>
                                <div class="card-footer">
                                    <span class="text-muted">${item.price}</span>
                                    <a style="font-size: 14px" class="btn btn-secondary btn-sm float-right">Order Now</a>
                                </div>
                            </div>
                        </div>`;
        });

        container.prev().html(dataHtml);
      }
    })
    // $.ajax({
    //     url: 'https://localhost:44392/api/products/Gets',
    //     method: 'GET',
    //     contentType: 'application/json',
    //     success : function(data){
    //         $('.products').empty();
    //         for(let item of data){
    //             $('.products').append(`
    //                         <div class="col-sm-4 col-md-3 mb-2">
    //                             <div class="card">
    //                                 <h6 class="card-header">${item.productName}</h6>
    //                                 <div class="card-body" style="height: 150px;">
    //                                     <p>${item.description}</p>
    //                                 </div>
    //                                 <div class="card-footer">
    //                                     <span class="text-muted">${item.price}</span>
    //                                     <a style="font-size: 14px" class="btn btn-secondary btn-sm float-right">Order Now</a>
    //                                 </div>
    //                             </div>
    //                         </div>
    //                         `);
    //         };
    //     }
    // });
}

product.init = function(){
    product.showProducts();
}
$(document).ready(function(){
    product.init();    
});