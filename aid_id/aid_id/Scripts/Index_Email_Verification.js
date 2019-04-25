$(document).ready(function () {
    //global vars
    var form = $("#IndexForm");
    var username = $("#inputEmail");
    var re = /\S+@@\S+\.\S+/;
    form.submit(function () {
        if (username.val().length == 0) {
            document.getElementById("inputEmail").style.borderColor = "red";
            document.getElementById("inputEmail").classList.add("input-text-error-class");
            document.getElementById("inputEmail").placeholder = "Error! Email vacío";
            return false;
        }
        else if (username.val().length > 0) {
            if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(username.val())) {
                document.getElementById("inputEmail").classList.remove("input-text-error-class");
                return true;
            } else {
                $('#inputEmail').each(function () {
                    $(this).val("");
                });
                document.getElementById("inputEmail").style.borderColor = "red";
                document.getElementById("inputEmail").classList.add("input-text-error-class");
                document.getElementById("inputEmail").placeholder = "Error! Email no valido";
                return false;
            }
        }
        else {
            return true;
        }
    });
});