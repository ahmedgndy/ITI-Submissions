// task  1

var number = parseInt(prompt("enter a number to check for positive or negative or zero"));
alert (number>=0 ? (number>0 ? "positive": "zero " ): "negative")

//task 2

var result = confirm("do you want to proceed? ")
if (result){
    alert("You choose to proceed ")
}else {
    alert("action Canceled")
}