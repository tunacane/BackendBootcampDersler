$(document).ready(() => {
    getPost();
})


function getPost() {



    $.ajax({
        url: "https://fakestoreapi.com/products",
        // url: "https://fakestoreapi.com/carts",
        method: "GET",
        success: function (res) {
            res.forEach(item => {

                $("#posts").append(`
                    <div class="col-3 mb-3">
                    
  <div class="card" >
                 <img src="${item.image}" class="card-img-top" alt="${item.title}">
                    <div class="card-body">
                        <h5 class="card-title">${item.title}</h5>
                        <p class="card-text">${item.description}</p>
                    </div>
                    <ul class="list-group list-group-flush">
                        <li class="list-group-item">${item.price}</li>
                        <li class="list-group-item">${item.quantity}</li>
                        
                      
                    </ul>
                    <div class="card-body"> <a href="#" class="card-link">Card link</a> <a href="#" class="card-link">Another link</a>
                    </div>
            </div>
            </div>`)

            });

        }

    })
}