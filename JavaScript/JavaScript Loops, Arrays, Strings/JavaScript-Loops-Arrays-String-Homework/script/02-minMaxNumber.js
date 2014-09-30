/**
 * Created by Kameliya on 22.7.2014 г..
 */
function findMinMaxNumber(value) {
    var numbers = value;

    numbers.sort(function () {
        return arguments[0] = arguments[1];
    })

    console.log("Max: %s", numbers[0]);
    console.log("Min: %s", numbers[numbers.length - 1]);
}