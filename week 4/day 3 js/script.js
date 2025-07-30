

task  1 (positive, negative, or zero)

var number = parseInt(prompt("enter a number to check for positive or negative or zero"));
alert(number >= 0 ? (number > 0 ? "positive" : "zero ") : "negative")

task 2

var result = confirm("do you want to proceed? ")
if (result) {
    alert("You choose to proceed ")
} else {
    alert("action Canceled")
}

task  3
var num = 10;
console.log(num % 2 === 0 ? "hi " : "helloo");

//task 4
var age ;
do {
     age = parseInt(prompt("enter you age"))
} while (age < 0)

var cata = "child"
switch (age) {
    case age >= 10:
        break;
    case age >= 18:
        cata = "teen"
        break;
    case age >= 50:
        cata = "grown"
        break
    default:
        cata = "old"

}
console.log("you are  " + cata)

//task 5
var dateHours = prompt("enter hours") ;

 if(dateHours<11) {
    console.log(dateHours + "am")
 }else {
     let temp = dateHours- 12
    console.log(temp+ "pm" )
 }






//task 6 


var word = prompt("enter a word");
alert(word[0].toUpperCase() + word.slice(1));
//task 7


    var ChoosenColor;
    var isFavorite;
    
    do {
        ChoosenColor = prompt("your favorite color is : ");
        isFavorite = confirm("is your favorite color " + ChoosenColor)

    } while (isFavorite)
     confirm("you choose " + ChoosenColor)


//task  9
var n1 = prompt("Enter date 1 (e.g., 2023-07-01):");
var n2 = prompt("Enter date 2 (e.g., 2023-07-30):");

var date1 = new Date(n1);
var date2 = new Date(n2);

var timeDifference = Math.abs(date2 - date1); 

var days = timeDifference / (1000 * 60 * 60 * 24); 

console.log("Difference in days: " + days);

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

