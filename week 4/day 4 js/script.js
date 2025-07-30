//task 1

var password = "p@$$"
var userInput ;

do {
    userInput = prompt("enter a password : ")
} while ( !(userInput == password))

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
    return result;
}

//task 4

function check() {
    var username = prompt("usrname ; ")
    var password = prompt("password: ")

    if (username = "ahmed" && password == "ahmed") {
        alert("wellcome te my systm")
    } else {
        throw new Error("wrong data enterd")

    }
}

try  {
     check()
}catch( erro){
    print(erro.massage)
}

//task 5
function gussANumber(){
    var number = parseInt(prompt("enter a number"))
    var roundNum = Math.random(0, 9)
    if (roundNum == number){
        alert("you gussed right")
    }else {
        alert("you  gussed worng")
    }
}
//task 6

function takeInput() {
    var isValid = false;
    var birthDate;

    do {
        birthDate = prompt("Enter yourbriday :");

        if (birthDate.length === 10 && birthDate[2] === '-' && birthDate[5] === '-') {
            isValid = true;
        } else {
            alert("wrong Format");
        }

    } while (!isValid);

    var parts = birthDate.split("-"); 
    var day = parseInt(parts[0]);
    var month = parseInt(parts[1]) - 1; 
    var year = parseInt(parts[2]);

    var date = new Date(year, month, day);

    alert("Valid data: " + date.toDateString());
}

//task 6
let input = prompt("Enter a string:").toLowerCase();
let a = 0, e = 0, i = 0, o = 0, u = 0;

for (let char of input) {
    switch (char) {
        case 'a': a++; break;
        case 'e': e++; break;
        case 'i': i++; break;
        case 'o': o++; break;
        case 'u': u++; break;
    }
}

console.log(`a = ${a}, e = ${e}, o = ${o}, u = ${u}, i = ${i}`);

//task 7 
function getName(dateString) {
    const date = new Date(dateString);
    const days = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
    return days[date.getDay()];
}
console.log(getName("2025-07-30")); 
console.log(getName("2025-08-02"));