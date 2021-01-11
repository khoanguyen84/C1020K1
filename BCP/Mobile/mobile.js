function Mobile() {
    this.battery = 100;
    this.draft = [];
    this.inbox = [];
    this.sent = [];
    this.status = false;

    this.checkStatus = function() {
        return this.status;
    }
    this.turnOn = function() {
        this.status = true;
    }
    this.turnOff = function() {
        this.status = false;
    }
    this.charge = function() {
        this.battery = 100;
    }
    this.compose = function(msg) {
        if (this.status) {
            this.draft.push(msg);
            this.battery -= 1;
        }
    }
    this.receive = function(mobile) {
        if (this.status) {
            let msg = mobile.draft.pop();
            this.inbox.push(msg);
            mobile.sent.push(msg);
            this.battery -= 1;
        }
    }
    this.send = function(mobile) {
        if (this.status) {
            let msg = this.draft.pop();
            mobile.inbox.push(msg);
            this.sent.push(msg);
            this.battery -= 1;
        }
    }

    this.showInbox = function() {
        if (this.status) {
            this.battery -= 1;
            return this.inbox;
        }

    }

    this.showSent = function() {
        if (this.status) {
            this.battery -= 1;
            return this.sent;
        }
    }
}

const iphone = 2;
const nokia = 1;

let nokia1 = new Mobile();
let iphone6 = new Mobile();

function power(device) {
    if (device == nokia) {
        if (nokia1.checkStatus()) {
            nokia1.turnOff();
            change("nokia", true);
        } else {
            nokia1.turnOn();
            change("nokia", false);
        }
    }
    if (device == iphone) {
        if (iphone6.checkStatus()) {
            iphone6.turnOff();
            change("iphone", true);
        } else {
            iphone6.turnOn();
            change("iphone", false);
        }
    }
}

function send(device) {
    if (device == nokia) {
        let msg = document.getElementById("nokia").getElementsByTagName("input")[0];
        nokia1.compose(msg.value);
        nokia1.send(iphone6);
        msg.value = "";
        showMessage(iphone);
    }
    if (device == iphone) {
        let msg = document.getElementById("iphone").getElementsByTagName("input")[0];
        iphone6.compose(msg.value);
        iphone6.send(nokia1);
        msg.value = "";
        showMessage(nokia);
    }
}

function change(device, disabled) {
    let btns = document.getElementById(device).getElementsByTagName("button");
    let msg = document.getElementById(device).getElementsByTagName("input")[0];
    for (let i = 0; i < btns.length; i++) {
        if (i != 1) {
            btns[i].disabled = disabled;
        }

    }
    msg.disabled = disabled;
}

function showMessage(device) {
    if (device == nokia) {
        let screenNokia = document.getElementById("screenNokia");
        screenNokia.innerHTML = "<ol>";
        for (let i = nokia1.showInbox().length - 1; i >= 0; i--) {
            screenNokia.innerHTML += `<li>${nokia1.showInbox()[i]}</li>`;
        }
        screenNokia.innerHTML += "</ol>";
    }
    if (device == iphone) {
        let screenIP = document.getElementById("screenIP");
        screenIP.innerHTML = "<ol>";
        for (let i = iphone6.showInbox().length - 1; i >= 0; i--) {
            screenIP.innerHTML += `<li>${iphone6.showInbox()[i]}</li>`;
        }
        screenIP.innerHTML += "</ol>";
    }
}

function ready() {
    if (!nokia1.checkStatus()) {
        change("nokia", true);
    }
    if (!iphone6.checkStatus()) {
        change("iphone", true);
    }
}

ready();