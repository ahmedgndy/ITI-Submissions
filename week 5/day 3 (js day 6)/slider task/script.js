let intervalID ;
let index = 0;
let date ; 
let timer = 2000 ;

function getSilders(callback) {
    let url = "https://api.slingacademy.com/v1/sample-data/photos"
    let https = new XMLHttpRequest();
    https.open("GET" , url)
    https.onreadystatechange = function (){
    if(https.readyState === 4 && https.status === 200) {
        let data = JSON.parse(https.responseText)
       callback(data)
    }
}
  https.send()
}

function displaySilders() {
    getSilders( function(bannerData) {
        data = bannerData
        intervalID = makeInterval(timer);
    }
    )
}
function makeInterval(timer) {
    return  setInterval(() => {
        let title = document.getElementById("imageTitle")
        title.innerText = data.photos[index].title ;
        
        let img = document.getElementById("img");
        img.src =  data.photos[index].url ;
        index++;
        if(index >= data.photos.length) {
            index = 0 ;
        }
    }, timer)
}
function stopIterval(){
    clearInterval(intervalID)
}

function playIterval(speed){
    clearInterval(intervalID)
    intervalID = makeInterval(timer / speed) ;
}

function goBack(){
    index-- ;
    if(index < 0) {
        index = data.photos.length -1
    } 
    let title = document.getElementById("imageTitle")
     title.innerText = data.photos[index].title ;
        
    let img = document.getElementById("img");
     img.src =  data.photos[index].url ;
       if(index <= 0 ) {
            index = (data.photos.length-1) ;
        } 
}

function goForward(){
   
   
    let title = document.getElementById("imageTitle")
    title.innerText = data.photos[index].title ;
        
    let img = document.getElementById("img");
     img.src =  data.photos[index].url ;
     if(index >= data.photos.length) {
            index = 0 ;
    }else {
         index++ ;
    }
}
