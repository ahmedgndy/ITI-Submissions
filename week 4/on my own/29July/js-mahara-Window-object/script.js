
var win; 

function openWindow() {
    win =window.open("chiledWin.html","" ,"width=150 , height = 150")
}

function closWindow(){
    win.close()
}

function changeBackground(){
    win.document.bgColor= "red"  ;
    win.focus() ;
}

function moveToCoordinato() {
    win.moveTo(50, 50)
    win.focus()
}

function moveByCoordinato() {
    win.moveBy(50, 50)
    win.focus()
}

//Timer methouds
var timerId ;
function startAlert() {

   timeId = window.setInterval(function(){
    alert("alert every 2 second")
   } , 2000);//functionalty , time in miliseconde 
}

function stopAlert () {
    clearInterval(timerId)
}

function startTimeoutAlert() {

    window.setTimeout(function(){
    alert("alert onetime on click")
   } , 2000);//functionalty , time in miliseconde 
}



//timeout excused for one time
//but i can use something like  recursion to make it run forever

function startTimeOutUsingRecursion() {
    alert("alert onetime on click")
    //
    //
    //
    timerId = window.setTimeout(startTimeOutUsingRecursion , 2000);
}

function stoptimeOut() {
    clearTimeout(timerId)
}