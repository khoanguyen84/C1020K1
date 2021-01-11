let khoa = {};
khoa.firstName = "Khoa";
khoa.lastName = "Nguyễn";
khoa.greeting = function() {
    return `My name is ${this.firstName} ${this.lastName}`;
}


let duong = {
    firstName: "Duong",
    lastName: "Nguyễn",
    greeting: function() {
        return `My name is ${this.firstName} ${this.lastName}`;
    }
}


function Person() {
    this.firstName;
    this.lastName;
    this.greeting = function() {
        return `My name is ${this.firstName} ${this.lastName}`;
    }
}

function Human() {
    let firstName;
    let lastName;
    this.setFN = function(fn) {
        firstName = fn;
    }
    this.getFN = function() {
        if (firstName == null) {
            return null;
        }
        let fn = firstName.split('');
        fn[fn.length - 1] = "*";
        return fn.join('');
    }
    this.greeting = function() {
        return `My name is ${firstName} ${lastName}`;
    }
}


function Student(fn, ln) {
    this.firstName = fn;
    this.lastName = ln;
    let email;
    this.setEmail = function(e) {
        email = e;
    }
    this.getEmail = function() {
        return email;
    }
    this.greeting = function() {
        return `My name is ${this.firstName} ${this.lastName} and my email is ${email}`;
    }
}

function drawCircle() {
    let canvas = document.getElementsByTagName('canvas')[0];
    let ctx = canvas.getContext('2d');
    ctx.beginPath();
    ctx.arc(100, 300, 100, 0, 2 * Math.PI * 10);
    ctx.stroke();
}

drawCircle();