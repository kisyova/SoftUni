/**
 * Created by Kameliya on 25.7.2014 г..
 */
function reverseWordInString(string) {
    var words = string.split(" ");
    var result = "";

    for(var i = 0; i < words.length; i++) {

        result += words[i].split("").reverse().join("") + " ";

    }
    return result.trim();
}