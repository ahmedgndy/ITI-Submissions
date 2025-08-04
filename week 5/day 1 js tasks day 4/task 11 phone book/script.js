
//task 11  Ask the user for operation through JS prompt
//If user enters “add”
//Ask him for the name of the contact and phone number
//Then create js object for that contact and add it to contacts array
//Then ask him for new operation and repeat
//If user enters “search”
//Ask him for something to search for
//Get the user input and search in the contacts array in name and phone
//Then show the user the full details of that contact
//Then ask him for new operation and repeat
//Bona
let contacts = []  ;
let operation = 0 
do {
 operation =parseInt(prompt("new contect 1\n search 2 \n  Quit 0")); 

    switch(operation){
        case 1 :
            addNewContect() ;
            break ;
        case 2 : 
            searchForAcontect();
            break ; 
    
    }
}while(operation != 0)

function addNewContect() {
    let contectName = prompt("Enter Contect name :"); 
    let contectNumber = prompt("Enter Contect number :"); 
    let contectInfo = {
        name : contectName,
        number :contectNumber
    }
    contacts.push(contectInfo);
}

function searchForAcontect() {
    let userSearch = prompt("Search for a Contect By name: ") ;
    let output = [] ; 
    contacts.forEach(contect => {
         if(contect.name.includes(userSearch)) {
          output.push(contect)
        }
    });
    
   alert(JSON.stringify(output , null , 2))
}