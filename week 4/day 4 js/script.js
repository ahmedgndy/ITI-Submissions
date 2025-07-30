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

function takeInput(){
    var isvalid = false
    do {
    var brithDate =  prompt("enter your brithDate: ") ;
    const dateRegex = /\d{4}-\d{2}-\d{2}/g; 
    isvalid = dateRegex.test(dateRegex)
    if(!isvalid){
        alert("you enterd wrong")
    }
    }while(isvalid)
    var slipbrithDate = brithDate.split("-")
    var date = new Date() ;
    date.setFullYear(parseInt(slipbrithDate[0]))
    date.setMonth(parseInt(slipbrithDate[1]))
    date.setDate(parseInt(slipbrithDate[2]))
    alert(date)
}