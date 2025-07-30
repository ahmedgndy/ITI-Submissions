//task 1

var password = "p@$$"
var userInput

do {
    userInput = prompt("enter a password : ")
} while (userInput == password)

//task 2

var sum = 0;
for (i = 0; i <= 100; i += 2) {
    sum += i;
}
console.log(sum);

//task 3

function calculate() {
    var fristNumber = parseFloat(prompt("enter number 1"));
    var operator = prompt("enter operator");
    var secondNumber = parseFloat(prompt("enter socend number"));
    var result = 0;

    switch (operator) {
        case "+":
            result = fristNumber + secondNumber;
            break;

        case "-":
            result = fristNumber - secondNumber;
            break;
        case "/":
            result = fristNumber / secondNumber;

            break;

        case "%":
            result = fristNumber / secondNumber;
            break;
    }
    return result ; 
}