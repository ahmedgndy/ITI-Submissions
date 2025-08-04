

function checkForInput() {
  const urlParams =  new URLSearchParams(window.location.search)

  const usrename =  urlParams.get("username");
  const password = urlParams.get("password");
  console.log(usrename)
  if (usrename == "admin" && password =="123"){
    document.body.innerText = "welcome to this page"
  }
  else {
        document.body.innerText = "invalid data"

  }
}