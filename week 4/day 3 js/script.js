

// task  1

var number = parseInt(prompt("enter a number to check for positive or negative or zero"));
alert(number >= 0 ? (number > 0 ? "positive" : "zero ") : "negative")

//task 2

var result = confirm("do you want to proceed? ")
if (result) {
    alert("You choose to proceed ")
} else {
    alert("action Canceled")
}

//task  3
var num = 10;
console.log(num % 2 === 0 ? "hi " : "helloo");

//task 4
do {
    var age = parseInt(prompt("enter you age"))
} while (age < 0)

var cata = "chile"
switch (age) {
    case age <= 10:
        break;
    case age <= 18:
        cata = "teen"
        break;
    case age <= 50:
        cata = "grown"
        break
    default:
        cata = "old"

}
console.log("you are  " + cata)

//task 5







//task 6 


var word = prompt("enter a word");
alert(word[0].toUpperCase() + word.slice(1));
//task 7

do {
    var ChoosenColor;
    var isFavorite;
    var ischoosen;
    do {
        ChoosenColor = prompt("your favorite color is : ");
        isFavorite = confirm("is your favorite color " + ChoosenColor)

    } while (isFavorite)
    isChoosen = confirm("you choose " + ChoosenColor)
} while (isChoose)

//task  9
var n1 = parseInt(prompt("number 1"));
var n2 = parseInt(prompt("number 2"));

var differece = n1 - n2 ;
console.log(differece>=0 ? differece : -differece );

//task 10

var  massage = "Hello word" ;
var slice = massage.split(" ")
console.log(slice[1])

//task 11

var numberRound = 7.887

console.log(number.toFixed(2))

//task 12

var userInput = parseInt(prompt("enter a number"));

if (userInput%3 ==  0 && userInput%5 == 0){
    console.log("truuuue")
}