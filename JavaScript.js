{
    function loginclick() {
        document.alert("tal=fag");
        var nameRegex = /^[a-zA-Z\-]+$/;
        var validfirstUsername = document.frm.firstName.value.match(nameRegex);
        if (validUsername == null) {
            alert("Your first name is not valid. Only characters A-Z, a-z and '-' are  acceptable.");
            document.frm.firstName.focus();
            return false;
        }
    }
  function openregisterpage() {
        window.location.href = '#';
        document.alert("hey");
    }
     
  function regexcheck() {
      alert("funcion works");
      var username = document.getElementById("usernamebox").value;
      var password = document.getElementById("passwordbox").value;
      if (/(?=.*[A-Z])(?=.*[a-z])(?=.*\d)[0-9a-zA-Z!-+]{8,}/.test(password))
      {
          //RegexIsCorrect
          
          return true;
      }
      else {
          alert("Password must contain: \nAt least one upper case letter,\nOne lower case letter\nOne digit\nAtleast 8 characters long")
      }
  }


}
