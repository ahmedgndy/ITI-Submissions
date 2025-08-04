//Task 1 
//define an object representing a car with properties 
//like brand, model, and year, 
// and a method to display its details.

var car = { brand : "Bmw" , 
            model:"z66" ,
            year : 1999 ,
            display : function() {
                console.log(`Car brand :${this.brand} \nCar Model: ${this.model} \nCar Year : ${this.year}`)
            },
        
        }
//diplay information about the car       
car.display()