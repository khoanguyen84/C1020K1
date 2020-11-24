// for (let i = 1; i <= 20; i++) {
//     document.write(`${i}, `);
// }
// document.write(`<br>`);
// let i = 1;
// for (; i <= 20;) {
//     document.write(`${i}, `);
//     i++;
// }
// document.write(`<br>`);

// for (let i = 20; i > 0; i--) {
//     document.write(`${20-i + 1}, `);
// }
// document.write(`<br>`);
// for (let i = 1; i <= 20; i++) {
//     if (i % 2 == 0) {
//         document.write(`${i}, `);
//     }
// }
// document.write(`<br>`);
// for (let i = 2; i <= 20; i += 2) {
//     document.write(`${i}, `);
// }


// document.write(`<br>`);
// let count = 0;
// for (let i = 2; i <= 20; i += 2) {
//     document.write(`${i}, `);
//     count++;
//     if (count == 5) {
//         break;
//     }
// }

// document.write(`<br>`);
// for (let i = 2, count = 0; i <= 20 && count < 5; i += 2) {
//     document.write(`${i}, `);
//     count++;
// }

// let number = 0;
// do {
//     number = +prompt('enter number:')
// }
// while (isNaN(number) || !Number.isSafeInteger(number));

// let number = +prompt('enter number');
// while (isNaN(number) || !Number.isSafeInteger(number)) {
//     number = +prompt('enter number');
// }

// let number = +prompt('enter number');

// for (; isNaN(number) || !Number.isSafeInteger(number);) {
//     number = +prompt('enter number');
// }
// document.write(`<br>`);
// for (let i = 2, count = 0; i <= 20; i += 2) {
//     count++;
//     if (count < 3 || count > 5)
//         continue;
//     document.write(`${i}, `);
// }

// let str = "CodeGym Hue K1020";
// document.write(`<br>`);
// for (let i = 0; i < str.length; i++) {
//     document.write(`${str[i]}, `);
// }
// document.write(`<br>`);
// let str2 = "CodeGym Hue K1020";
// for (let c in str2.split("")) {
//     document.write(`${str2[c]}, `);
// }

// document.write(`<br>`);
// let str3 = "CodeGym Hue K1020";
// for (let c of str3.split("")) {
//     document.write(`${c}, `);
// }

// document.write(`<br>`);
// let str4 = "CodeGym Hue K1020";
// str4.split("").forEach(function(v, i) {
//     document.write(`${i}, `);
// })

// document.write(`<br>`);

// let tb = "<table border=1>"
// for (let j = 1; j < 10; j++) {
//     tb += "<tr>"
//     for (let i = 2; i < 10; i++) {
//         tb += `<td>${i} x ${j} = ${i*j}</td>`;
//     }
//     tb += "</tr>";
// }
// tb += "</table>";
// document.write(tb);

// let tb1 = "<table border=1>";
// let j = 1;
// while (j < 10) {
//     tb1 += "<tr>"
//     let i = 2;
//     while (i < 10) {
//         tb1 += `<td>${i} x ${j} = ${i*j}</td>`;
//         i++;
//     }
//     j++;
//     tb1 += "<tr>"
// }
// document.write(tb1);

// let tb2 = "<table border=1>";
// let k = 1;
// do {
//     tb2 += "<tr>"
//     let i = 2;
//     do {
//         tb2 += `<td>${i} x ${k} = ${i*k}</td>`;
//         i++;
//     }
//     while (i < 10)
//     k++;
//     tb2 += "<tr>"
// }
// while (k < 10)
// document.write(tb2);


let arr = [];
let size = 10;
for (let i = 0; i < size; i++) {
    arr[i] = Math.floor(Math.random() * 81 + 10);
}

for (let i = 0; i < size; i++) {
    document.write(`${arr[i]}, `);
}
document.write("<br>");
for (let i = size - 1; i >= 0; i--) {
    document.write(`${arr[size-i-1]}, `);
}
document.write("<br>");
let i = 0;
while (i < size) {
    document.write(`${arr[i]}, `);
    i++;
}
document.write("<br>");
let j = 0;
do {
    document.write(`${arr[j]}, `);
    j++;
}
while (j < size)
document.write("<br>");
for (let item in arr) {
    document.write(`${item}-${arr[item]}, `);
}
document.write("<br>");
for (let item of arr) {
    document.write(`${arr.indexOf(item)}-${item}, `);
}
document.write("<br>");
arr.forEach(function(v, i) {
    document.write(`${i}-${v}, `);
});
document.write("<br>");