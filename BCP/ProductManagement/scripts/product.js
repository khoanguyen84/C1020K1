 var products = ["Sony Xperia", "Nokia 6", "Xiaomi Redmi Note 4"];
 let oldName;


 function showProduct() {
     let tbody = document.getElementsByTagName('tbody')[0];
     tbody.innerHTML = "";
     for (let i = 0; i < products.length; i++) {
         tbody.innerHTML += `
                            <tr id='tr_${i}'>
                                <td>${products[i]}</td>
                                <td>
                                    <a href="javascript:;" class="btn btn-success" onclick="InlineEdit('${i}')">InlineEdit</a>
                                    <a href="javascript:;" class="btn btn-success" onclick="get('${products[i]}')">Modify</a>
                                    <a href="javascript:;" class="btn btn-success" onclick="editProduct('${products[i]}')">Edit</a>
                                    <a href="javascript:;" class="btn btn-danger" onclick="removeProduct('${products[i]}')">Delete</a>
                                </td>
                            </tr>`;
     }
 }

 function createProduct() {
     let pName = document.getElementById('productName').value;
     if (isNullOrEmpty(pName)) {
         alert('Product name is required!');
     } else {
         pName = stringFormat(pName);
         if (isExists(pName)) {
             alert('Product name is exists!');
         } else {
             products.push(pName);
             showProduct();
             reset();
         }
     }
 }

 function isNullOrEmpty(pName) {
     return pName == null || pName.trim() == '';
 }

 function stringFormat(pName) {
     pName = pName.trim();
     pName = pName.toLowerCase();
     while (pName.indexOf('  ') != -1) {
         pName = pName.replace('  ', ' ');
     }
     let newName = pName.split('');
     newName[0] = newName[0].toUpperCase();
     for (let i = 1; i < newName.length - 1; i++) {
         if (newName[i] == ' ' && newName[i + 1] != ' ') {
             newName[i + 1] = newName[i + 1].toUpperCase();
         }
     }

     return newName.join('');
 }

 function isExists(pName) {
     return products.indexOf(pName) != -1;
 }

 function reset() {
     document.getElementById('productName').value = "";
     document.getElementById('pName').value = "";
     oldName = "";
 }

 function editProduct(pName) {
     let newName = prompt('Enter new product name:');
     if (isNullOrEmpty(newName)) {
         alert('Product name is required!');
     } else {
         newName = stringFormat(newName);
         if (isExists(newName) && newName != pName) {
             alert('Product name is exists!');
         } else {
             products[products.indexOf(pName)] = newName;
             showProduct();
         }
     }
 }

 function get(pName) {
     document.getElementById('pName').value = pName;
     oldName = pName;
 }

 function modify() {
     let newName = document.getElementById('pName').value;
     if (isNullOrEmpty(newName)) {
         alert('Product name is required!');
     } else {
         newName = stringFormat(newName);
         if (isExists(newName) && newName != oldName) {
             alert('Product name is exists!');
         } else {
             products[products.indexOf(oldName)] = newName;
             showProduct();
             reset();
         }
     }
 }

 function InlineEdit(id) {
     let tr = document.getElementById(`tr_${id}`);
     let btn = tr.children[1].children[0];
     if (btn.innerHTML == 'InlineEdit') {
         tr.children[0].innerHTML = `<input id='pName_${id}' type='text' value='${products[id]}'>
                                        <a href='javascript:;' onclick='reset(${id})'>
                                            <i style='color:red;' class="fas fa-times">
                                            </i>
                                        </a>`;
         btn.innerHTML = 'Update';
         btn.classList.remove('btn-success');
         btn.classList.add('btn-danger');
     } else {
         let newName = document.getElementById(`pName_${id}`).value;
         if (isNullOrEmpty(newName)) {
             alert('Product name is required!');
         } else {
             newName = stringFormat(newName);
             if (isExists(newName) && newName != oldName) {
                 alert('Product name is exists!');
             } else {
                 products[id] = newName;
                 showProduct();
                 btn.innerHTML = 'InlineEdit';
                 btn.classList.remove('btn-danger');
                 btn.classList.add('btn-success');
             }
         }

     }

 }

 function reset(id) {
     let tr = document.getElementById(`tr_${id}`);
     let td = tr.children[0];
     let btn = tr.children[1].children[0];
     td.innerHTML = products[id];
     btn.innerHTML = 'InlineEdit';
     btn.classList.remove('btn-danger');
     btn.classList.add('btn-success');
 }

 function removeProduct(pName) {
     let isOK = confirm(`are you sure to remove ${pName}?`);
     if (isOK) {
         products.splice(products.indexOf(pName), 1);
         showProduct();
     }
 }

 function documentReady() {
     showProduct();
 }

 documentReady();