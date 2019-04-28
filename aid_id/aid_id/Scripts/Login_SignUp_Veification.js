/*--------------------------------------------------------------------------------
*                          WRAPER FUNCTION
*--------------------------------------------------------------------------------*/
function helperGroup() {
    $(document).ready(function () {
        var bool = true;
        bool &= helperNotNull("inputName", "Requerido");
        bool &= helperNotNull("inputSurname", "Requerido");
        bool &= helperNumbers("inputAge", "Requerido", "No valido", 1, 110);
        bool &= helperNumbers("inputWeight", "Requerido", "No valido", 10, 200);
        bool &= helperNumbers("inputHeight", "Requerido", "No valido", 10, 200);
        bool &= helperPassword("inputPass1", "inputPass2", "Escribe las contraseñas", "Las contraseñas no coinciden", 6);
        bool &= helperMaxMin("inputGluMin", "inputGluMax", "Vacío", "Error, campos iguales", "MIN mayor que MAX");
        bool &= helperNumbers("inputInsTot", "Requerido", "No valido", 10, 200);
        bool &= helperNumbers("inputInsGlu", "Requerido", "No valido", 0, 51);
        bool &= helperNumbers("inputInsCh", "Requerido", "No valido", 0, 51);
        if (bool) {
            document.getElementById("sendRegister").removeAttribute('type');
            document.getElementById("sendRegister").setAttribute('type', 'submit');
            $('#RegisterForm').submit();
        }
        document.getElementById("sendRegister").removeAttribute('type');
        document.getElementById("sendRegister").setAttribute('type', 'button');
    });
}
/*--------------------------------------------------------------------------------
 *                              NOT NULL FUNCTION
 *--------------------------------------------------------------------------------*/
function helperNotNull(nameId, msgTxt) {
    if (document.getElementById(nameId).value == "") {
        document.getElementById(nameId).style.borderColor = "red";
        document.getElementById(nameId).classList.add("input-text-error-class");
        document.getElementById(nameId).placeholder = msgTxt;
        return false;
    } else {
        document.getElementById(nameId).style.borderColor = "";
        document.getElementById(nameId).classList.remove("input-text-error-class");
        return true;
    }
}
/*--------------------------------------------------------------------------------
*                              NUMBERS FUNCTION
*--------------------------------------------------------------------------------*/
function helperNumbers(nameId, msgTxt, msgTxt2, intMin, intMax) {
    if (document.getElementById(nameId).value > intMin && document.getElementById(nameId).value < intMax) {
        document.getElementById(nameId).style.borderColor = "";
        document.getElementById(nameId).classList.remove("input-text-error-class");
        return true;
    } else if (document.getElementById(nameId).value == "") {
        document.getElementById(nameId).value = "";
        document.getElementById(nameId).style.borderColor = "red";
        document.getElementById(nameId).classList.add("input-text-error-class");
        document.getElementById(nameId).placeholder = msgTxt;
    } else {
        document.getElementById(nameId).value = "";
        document.getElementById(nameId).style.borderColor = "red";
        document.getElementById(nameId).classList.add("input-text-error-class");
        document.getElementById(nameId).placeholder = msgTxt2;
    }
    return false;
}
/*--------------------------------------------------------------------------------
*                              PASSWORD FUNCTION
*--------------------------------------------------------------------------------*/
function helperPassword(namePass1, namePass2, msgTxt1, msgTxt2, minPass) {
    var sizePass1 = document.getElementById(namePass1).value.length;
    var sizePass2 = document.getElementById(namePass2).value.length;
    if (sizePass1 == 0 && sizePass2 == 0) {
        document.getElementById(namePass1).style.borderColor = "red";
        document.getElementById(namePass1).classList.add("input-text-error-class");
        document.getElementById(namePass1).placeholder = msgTxt1;
        document.getElementById(namePass2).style.borderColor = "red";
        document.getElementById(namePass2).classList.add("input-text-error-class");
        document.getElementById(namePass2).placeholder = msgTxt1;
    } else if (sizePass1 != sizePass2) {
        document.getElementById(namePass1).value = "";
        document.getElementById(namePass1).style.borderColor = "red";
        document.getElementById(namePass1).classList.add("input-text-error-class");
        document.getElementById(namePass1).placeholder = msgTxt2;
        document.getElementById(namePass2).value = "";
        document.getElementById(namePass2).style.borderColor = "red";
        document.getElementById(namePass2).classList.add("input-text-error-class");
        document.getElementById(namePass2).placeholder = msgTxt2;
    } else if (sizePass1 == sizePass2) {
        document.getElementById(namePass2).style.borderColor = "";
        document.getElementById(namePass2).classList.remove("input-text-error-class");
        document.getElementById(namePass1).style.borderColor = "";
        document.getElementById(namePass1).classList.remove("input-text-error-class");
        return true;
    }
    return false;
}
/*--------------------------------------------------------------------------------
*                              helperMaxMin FUNCTION
*
*--------------------------------------------------------------------------------*/
function helperMaxMin(nameIdMin, nameIdMax, msgTxt1, msgTxt2, msgTxt3) {
    if (document.getElementById(nameIdMin).value == "" && document.getElementById(nameIdMax).value == "") {
        document.getElementById(nameIdMin).style.borderColor = "red";
        document.getElementById(nameIdMin).classList.add("input-text-error-class");
        document.getElementById(nameIdMin).placeholder = msgTxt1;
        document.getElementById(nameIdMax).style.borderColor = "red";
        document.getElementById(nameIdMax).classList.add("input-text-error-class");
        document.getElementById(nameIdMax).placeholder = msgTxt1;
    } else if (document.getElementById(nameIdMin).value == "") {
        document.getElementById(nameIdMin).style.borderColor = "red";
        document.getElementById(nameIdMin).classList.add("input-text-error-class");
        document.getElementById(nameIdMin).placeholder = msgTxt1;
        document.getElementById(nameIdMax).style.borderColor = "";
        document.getElementById(nameIdMax).classList.remove("input-text-error-class");
    } else if (document.getElementById(nameIdMax).value == "") {
        document.getElementById(nameIdMax).style.borderColor = "red";
        document.getElementById(nameIdMax).classList.add("input-text-error-class");
        document.getElementById(nameIdMax).placeholder = msgTxt1;
        document.getElementById(nameIdMin).style.borderColor = "";
        document.getElementById(nameIdMin).classList.remove("input-text-error-class");
    } else if (parseInt(document.getElementById(nameIdMin).value) == parseInt(document.getElementById(nameIdMax).value)) {
        document.getElementById(nameIdMax).value = "";
        document.getElementById(nameIdMax).style.borderColor = "";
        document.getElementById(nameIdMax).classList.add("input-text-error-class");
        document.getElementById(nameIdMax).placeholder = msgTxt2;
        document.getElementById(nameIdMin).value = "";
        document.getElementById(nameIdMin).style.borderColor = "";
        document.getElementById(nameIdMin).classList.add("input-text-error-class");
        document.getElementById(nameIdMin).placeholder = msgTxt2;
    } else if (parseInt(document.getElementById(nameIdMin).value) > parseInt(document.getElementById(nameIdMax).value)) {
        document.getElementById(nameIdMax).value = "";
        document.getElementById(nameIdMax).style.borderColor = "";
        document.getElementById(nameIdMax).classList.add("input-text-error-class");
        document.getElementById(nameIdMax).placeholder = msgTxt3;
        document.getElementById(nameIdMin).value = "";
        document.getElementById(nameIdMin).style.borderColor = "";
        document.getElementById(nameIdMin).classList.add("input-text-error-class");
        document.getElementById(nameIdMin).placeholder = msgTxt3;
    }
    else {
        document.getElementById(nameIdMax).style.borderColor = "";
        document.getElementById(nameIdMax).classList.remove("input-text-error-class");
        document.getElementById(nameIdMin).style.borderColor = "";
        document.getElementById(nameIdMin).classList.remove("input-text-error-class");
        return true;
    }
    return false;
}