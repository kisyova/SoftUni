/**
 * Created by Kameliya on 26.7.2014 г..
 */
function hideOddRows() {
    var rows = document.querySelectorAll("body table tr");

    for(var i = 0; i < rows.length; i += 2) {
        rows[i].style.display = "none";
    }
}

var button = document.getElementById("btnHideOddRows");
button.addEventListener("click", hideOddRows, false);