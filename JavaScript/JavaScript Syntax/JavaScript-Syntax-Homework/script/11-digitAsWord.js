/**
 * Created by Kameliya on 21.7.2014 г..
 */
function convertDigitToWord(digit) {
    if(digit < 0 && digit >= 10) {
        console.log("Invalid number!");
    }
    else {
        switch(digit) {
            case 0: console.log("zero"); break;
            case 1: console.log("one"); break;
            case 2: console.log("two"); break;
            case 3: console.log("three"); break;
            case 4: console.log("four"); break;
            case 5: console.log("five"); break;
            case 6: console.log("six"); break;
            case 7: console.log("seven"); break;
            case 8: console.log("eight"); break;
            case 9: console.log("nine"); break;
            default: console.log("Invalid number"); break;
        }
    }
}

console.log(convertDigitToWord(8));
console.log(convertDigitToWord(3));
console.log(convertDigitToWord(5));