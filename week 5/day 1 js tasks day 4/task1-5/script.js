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