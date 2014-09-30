/**
 * Created by Kameliya on 23.7.2014 г..
 */
function substringSearch(string) {

    var subString = string[0].toLowerCase();
    var text = string[1].toLowerCase();
    var counter = 0;

    for(var i = 0; i < text.length - subString.length; i++) {
        for(var j = 0; j < subString.length; j++) {
            if(subString[j] !== text[i + j]) {
                 break;
             }
            if(j === subString.length - 1 && subString[j] === text[i + j]) {
                counter++;
            }
        }

    }
    console.log(counter);
}
