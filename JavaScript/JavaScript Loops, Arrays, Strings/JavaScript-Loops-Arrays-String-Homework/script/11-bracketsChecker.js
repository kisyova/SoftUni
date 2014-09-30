/**
 * Created by Kameliya on 23.7.2014 г..
 */
function checkBrackets(string){

    var counter = 0;
    for(var i = string.length - 1; i >= 0; i--) {
        if(string[i] === "(") {
            counter++;
        }
        else if(string[i] === ")") {
            counter--;
        }
    }
    if(counter !== 0) {
        console.log("Incorrect");
    }
    else {
        console.log("Correct");
    }
}