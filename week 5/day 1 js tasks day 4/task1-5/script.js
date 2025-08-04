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

//Task 6 
//find the maximum and minimum numbers in an array.
let numbers = [42, 17, 8, 99, 23, 64, 12, 50];
let max = Math.max(...numbers) // spreate array 42 , 17 ...
let min = Math.min(...min)

console.log("Max:", max);
console.log("Min:", min);

//Task 7
//reverse an array without using the built-in reverse() method
function reverse(arr) {
    let reverseArray = []
    for(let i = arr.length-1 ; i>=0; i--) {
        reverseArray.push(arr[i])
    }
    return reverseArray 
}
console.log(reverse([1, 2, 3, 4])); 

//Task 8 
//an array of objects (e.g., products with name and price) 
//and returns an array of objects where each product has a discountedPrice property
let products = [
    { name: "Tooth Brush", price: 12.5 },
    { name: "Shampoo", price: 35.0 },
    { name: "Soap", price: 8.75 },
    { name: "Towel", price: 50.0 },
    { name: "Toothpaste", price: 22.0 },
    { name: "Face Wash", price: 40.0 }
];
products.forEach(product=> {
    products.discountedPrice  = product.price * 0.8 ;
}
);
//also i can use map 
let discountedArray = products.map(product => {
    return {
        name: product.name,
        price: product.price,
        discountedPrice: product.price * 0.8
    };
});

//Task 8
//Make a function that takes date string as a parameter,
//and returns the Day name (Saturday, Sunday,…) of the given date


function convertToDayName(stringData) {
    const days = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
    const date = new Date(stringData);
    return days[date.getDay()];
}