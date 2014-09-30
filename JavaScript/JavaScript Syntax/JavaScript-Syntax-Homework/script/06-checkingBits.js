/**
 * Created by Kameliya on 21.7.2014 г..
 */
function bitChecker(intNumber) {
    var thirdBit = intNumber >> 3;
    return (thirdBit & 1) == 1;
}
console.log(bitChecker(333));
console.log(bitChecker(425));
console.log(bitChecker(2567564754));
