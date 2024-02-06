function validateForm(){
    if( document.getElementById("fname").value != "" &&
        document.getElementById("lname").value != "" &&
        document.getElementById("destination").value != "" &&
        document.getElementById("street").value != "" &&
        document.getElementById("hNr").value != "" &&
        document.getElementById("plz").value != "" )
    {
        alert("Form abgeschickt!");
        return true;
    }
    else
    {
        alert("Bitte alle Mussfelder ausfüllen!");
        return false;
    }
}