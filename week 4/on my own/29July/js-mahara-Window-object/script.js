
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