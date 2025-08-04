//Task 1 
//define an objectcar with properties 
//brand, model, and year, 
//and display its details.

var car = { brand : "Bmw" , 
            model:"z66" ,
            year : 1999 ,
            display : function() {
                console.log(`Car brand :${this.brand} \nCar Model: ${this.model} \nCar Year : ${this.year}`)
            },
        
        }
//diplay information about the car       
car.display()

//Task 2
//loop through all the properties of
//an object and
for(propertie in car) {
    console.log("key: " + propertie)
    console.log("Value: " + car[propertie])
}

//Task 3
//a function that accepts an object 
//and returns a new object with the keys and values swapped
function swapKeyVaule(obj) {
    var swapped = {}
    for(key in obj) {
        if(obj.hasOwnProperty(key)) {
         swapped[obj[key]] = key 
        }
    }
    return swappedObject
}
const obj = { a: 1, b: 2 };
console.log(swapKeyVaule(obj))

//Task 4 
// create a "person" object that includes nested objects 
//for "address" and "job", and a method to display all details.
let person = {
     name: "Ahmed",
    age: 25,
    address : {address1 : "Fayoum - new Fayoum" ,
               address2 : "Fayoum - old Fayoum" },
    job : {currentJob : ".net Developer"},
    displayDetails :  function () {
        console.log(`Name: ${this.name}`);
        console.log(`Age: ${this.age}`);
        console.log(`Current Address: ${this.address.address1}`);
        console.log(`Old Address: ${this.address.address2}`);
        console.log(`Current Job: ${this.job.currentJob}`);
        console.log(`Previous Job: ${this.job.previousJob}`);
    }
}
//Task 5
//sort an array of objects by a specific property,
//such as age in an array of people objects.
let people = [
    { name: "Ahmed", age: 23 },
    { name: "Sara", age: 27 },
    { name: "Omar", age: 30 },
    { name: "Mona", age: 22 },
    { name: "Youssef", age: 25 }
];
people.sort(function(a , b) {return a["age"] - b["age"]})