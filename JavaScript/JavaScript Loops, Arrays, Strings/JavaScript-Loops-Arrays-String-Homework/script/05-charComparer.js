/**
 * Created by Kameliya on 22.7.2014 г..
 */
function compareChars(array1, array2) {
      var result = true;

    if (array1.length == array2.length) {
        for (var i = 0; i < array1.length; i++) {
            if (array1[i] !== array2[i]) {
                result = false;
                break;
            }
        }
    }
    else {
        result = false;
    }
    if (result == true) {
        return "Equal";
    }
    else {
        return "Not Equal";
    }
}