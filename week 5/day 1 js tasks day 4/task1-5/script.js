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
