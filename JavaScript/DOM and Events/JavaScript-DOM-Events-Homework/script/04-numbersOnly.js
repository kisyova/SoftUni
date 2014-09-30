/**
 * Created by Kameliya on 26.7.2014 г..
 */
var input = document.getElementById("input");
var previousValue = " ";

function numbersOnlyField() {
   if(isNaN(input.value)) {
       input.style.background = "red";
       input.disabled = true;
       setTimeout(saveText, 1000);
   }
    else {
       previousValue = input.value;
   }
}

function saveText() {
    input.value = previousValue;
    input.focus();
}

input.addEventListener("input", numbersOnlyField, false);