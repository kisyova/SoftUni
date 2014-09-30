/**
 * Created by Kameliya on 25.7.2014 г..
 */
function findNthDigit(array) {
    var num = array[0];
    var n = Math.abs(array[1]).toString().replace(".", "");

    if(n.length < num) {
        return "The number doesn't have " + num + " digits.";
    }
    else {
        return n.charAt(n.length - num);
    }
}