

function setCookie(key , value , expiersByMohth = 3) {
 let date = new Date(expiersData) 
 date.setMonth(date.getMonth() + expiersByMohth) 
 document.cookie = `${key}=${value}; expires=${date.toUTCString()}`
}

function getCookies() {
    return document.cookie.split("; ")
}

function checkCookiesValue() {
    let cookie = document.cookie
    return cookie.includes(value)
}