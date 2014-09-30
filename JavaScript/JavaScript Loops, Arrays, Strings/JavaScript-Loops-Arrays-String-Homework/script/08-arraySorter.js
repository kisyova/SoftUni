/**
 * Created by Kameliya on 22.7.2014 г..
 */
function sortArray(array) {

    for(var i = 0; i <= array.length; i++) {
        var minimum = i;
        for(var j = i + 1; j <= array.length; j++) {
            if(array[j] < array[minimum]) {
                minimum = j;
            }
        }
        if(i != minimum) {
            swap(array, i, minimum);
        }
    }
    var result = array.join(", ");
    console.log(result);
}

function swap(array, first, second) {
    var a = array[first];
    array[first] = array[second];
    array[second] = a;
}