$(document).ready(function () {
    $("#IndexForm").submit(function () {
        if ($("#inputEmailIndex").val().length == 0) {
            document.getElementById("inputEmailIndex").style.borderColor = "red";
            document.getElementById("inputEmailIndex").classList.add("input-text-error-class");
            document.getElementById("inputEmailIndex").placeholder = "Error! Email vacío";
            return false;
        }
        else if ($("#inputEmailIndex").val().length > 0) {
            if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test($("#inputEmailIndex").val())) {
                document.getElementById("inputEmailIndex").classList.remove("input-text-error-class");
                return true;
            } else {
                $('#inputEmailIndex').each(function () {
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