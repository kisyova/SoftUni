/**
 * Created by Kameliya on 21.7.2014 г..
 */
function checkDigit(num) {
    return Math.floor(num / 100) % 10 == 3;
}

console.log(checkDigit(1245));
console.log(checkDigit(25368));
console.log(checkDigit(123456));