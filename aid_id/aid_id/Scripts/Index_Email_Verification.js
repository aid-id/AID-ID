$(document).ready(function () {
    //global vars
    $("#IndexForm").submit(function () {
        if ($("#inputEmail").val().length == 0) {
            document.getElementById("inputEmailIndex").style.borderColor = "red";
            document.getElementById("inputEmailIndex").classList.add("input-text-error-class");
            document.getElementById("inputEmailIndex").placeholder = "Error! Email vacío";
            return false;
        }
        else if ($("#inputEmail").val().length > 0) {
            if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(username.val())) {
                document.getElementById("inputEmailIndex").classList.remove("input-text-error-class");
                return true;
            } else {
                $('#inputEmail').each(function () {
                    $(this).val("");
                });
                document.getElementById("inputEmailIndex").style.borderColor = "red";
                document.getElementById("inputEmailIndex").classList.add("input-text-error-class");
                document.getElementById("inputEmailIndex").placeholder = "Error! Email no valido";
                return false;
            }
        }
        else {
            return true;
        }
    });
});