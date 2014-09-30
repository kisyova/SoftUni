/**
 * Created by Kameliya on 23.7.2014 г..
 */
function findMostFreqWord(string) {
    var map = {};
    string = string.split(" ");

    for (var i = 0; i < string.length; i++) {
        varcount = 0;
        var name = string[i];
        for (var j = 0; j < string.length; j++) {
            if (string[i] === string[j]) {
                count++;
            }
        }
        map[string[i]] = count;
    }

    var frequent = 0;
    var frElement;
    for(var key in map){
        if (map[key] > frequent) {
            frequent = map[key];
            frElement = key;
        }
    }

    return frElement + " -> " + frequent + " times";

}