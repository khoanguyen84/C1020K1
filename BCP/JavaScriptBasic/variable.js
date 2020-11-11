var hello = "hello outside if";
console.log(hello);
if (true) {
    var hello = "hello inside if";
    console.log(hello);
}
console.log(hello);



let greeting = "Greeting outside if";
console.log(greeting);
if (true) {
    greeting = "Greeting inside if";
    console.log(greeting);
}
console.log(greeting);


let m = 9.5;
switch (Math.floor(m)) {
    case 9:
    case 10:
        {
            alert("xs");
            break;
        }
    case 8:
        {
            alert("g");
            break;
        }
    case 7:
        {
            alert("k");
            break;
        }
    case 6:
    case 5:
        {
            alert("tb");
            break;
        }
    case 4:
    case 3:
    case 3:
    case 1:
    case 0:
        {
            alert("y");
            break;
        }
    default:
        {
            alert("invalid");
        }
}

switch ((m < 0 && m > 10) ? 'invalid' : (m >= 9 ? 'xs' : (m >= 8 ? 'g' : (m >= 7) ? 'k' : (m >= 5 ? 'tb' : 'y')))) {
    case 'xs':
        {
            alert('xs');
            break;
        }
    case 'g':
        {
            alert('g');
            break;
        }
    case 'k':
        {
            alert('k');
            break;
        }
    case 'tb':
        {
            alert('tb');
            break;
        }
    case 'y':
        {
            alert('y');
            break;
        }
    default:
        {
            alert('invalid');
        }
}