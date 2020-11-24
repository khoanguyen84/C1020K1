function inputSize() {
    let size = 0;
    do {
        size = +prompt('enter size value: ');
    }
    while (isNaN(size) || !Number.isInteger(size) || size < 0)
    return size;
}


function inputValue(msg) {
    let size = 0;
    do {
        size = +prompt(`${msg}: `);
    }
    while (isNaN(size) || !Number.isInteger(size) || size < 0)
    return size;
}

function createArray(size, svalue, evalue) {
    let arr = [];
    for (let i = 0; i < size; i++) {
        arr.push(Math.floor(Math.random() * (evalue - svalue + 1) + svalue));
    }
    return arr;
}

function printArray(arr) {
    return arr.join(', ');
}

function main() {
    let size = inputValue('enter size');
    let min = inputValue('enter min value');
    let max = 0;
    do {
        max = inputValue('enter max value');
    }
    while (max <= min);

    let arr = createArray(size, min, max);
    document.write(printArray(arr));
    console.log(printArray(arr));
    document.getElementsByTagName('p')[0].innerHTML = printArray(arr);
}

main();