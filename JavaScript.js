    function regexcheck() {

        var username = document.getElementById("usernamebox").value;
        var password = document.getElementById("passwordbox").value;
        if (/(?=.*[A-Z])(?=.*[a-z])(?=.*\d)[0-9a-zA-Z!-+]{8,}/.test(password)) {
            //RegexIsCorrect

            return true;
        }
        else {
            alert("Password must contain: \nAt least one upper case letter,\nOne lower case letter\nOne digit\nAtleast 8 characters long")
      }
  }
