function showCurrentTime() {
    let btn2 = document.getElementById("btn2");
    btn2.innerHTML = new Date();
    btn2.style.color = 'red';
    btn2.style.padding = '20px';
}

function reset() {
    let btn2 = document.getElementById("btn2");
    btn2.innerHTML = 'hover to show current time';
    btn2.style.color = 'black';
}

function show(ele) {
    ele.innerHTML = new Date();
    ele.style.color = 'red';
}

function hide(ele) {
    ele.innerHTML = 'hover to show current time';
    ele.style.color = 'black';
}

function showPassword() {
    document.getElementById('btn2').innerHTML = document.getElementById('pw').value;
}

function changeCountry() {
    document.getElementById('showValue').value = `${document.getElementsByName('country')[0].value} - ${document.getElementsByName('country')[0].options[document.getElementsByName('country')[0].selectedIndex].text}`
}