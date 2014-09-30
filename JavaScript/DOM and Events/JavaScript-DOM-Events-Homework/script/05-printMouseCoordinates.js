/**
 * Created by Kameliya on 26.7.2014 г..
 */
function findMouseCoordinates(event) {
    document.body.innerHTML += "X:" + event.pageX + "; Y:" + event.pageY + " Time:" + new Date() + "</br>";
}

document.addEventListener("mouseover", findMouseCoordinates, false);