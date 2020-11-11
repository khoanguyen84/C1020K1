const step = 10;
const increment = 10;
var deg = 0;

function init() {
    let ball = document.getElementById("ball");
    ball.style.width = "100px";
    ball.style.height = "100px";
    ball.style.position = "absolute";
    ball.style.left = 0;
    ball.style.top = 0;
    ball.style.transition = '.3s';
    window.addEventListener("keydown", controllBall);
}

function moveRight() {
    let ball = document.getElementById("ball");
    ball.style.transform = `rotate(${deg+=increment}deg)`;
    let ballWidth = parseInt(ball.style.width);
    let ballPosX = parseInt(ball.style.left);
    if (ballPosX + ballWidth + step < window.innerWidth) {
        ball.style.left = `${ballPosX + step}px`;
    }
}

function moveLeft() {
    let ball = document.getElementById("ball");
    ball.style.transform = `rotate(${deg-=increment}deg)`;
    let ballPosX = parseInt(ball.style.left);
    if (ballPosX > 0) {
        ball.style.left = `${ballPosX - step}px`;
    }
}

function moveDown() {
    let ball = document.getElementById("ball");
    ball.style.transform = `rotate(${deg+=increment}deg)`;
    let ballHeight = parseInt(ball.style.height);
    let ballPosY = parseInt(ball.style.top);
    if (ballPosY + ballHeight + step < window.innerHeight) {
        ball.style.top = `${ballPosY + step}px`;
    }
}

function moveUp() {
    let ball = document.getElementById("ball");
    ball.style.transform = `rotate(${deg-=increment}deg)`;
    let ballPosY = parseInt(ball.style.top);
    if (ballPosY > 0) {
        ball.style.top = `${ballPosY - step}px`;
    }
}

function controllBall(event) {
    switch (event.keyCode) {
        //move right
        case 39:
            {
                moveRight();
                break;
            }
            //move left
        case 37:
            {
                moveLeft();
                break;
            }
            //move down
        case 40:
            {
                moveDown();
                break;
            }
            //move up
        case 38:
            {
                moveUp();
                break;
            }
        default:
            {
                alert('please using one in four keys Left, Right, Up and Down');
            }
    }
}