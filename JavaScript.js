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


}