/**
 * Created by Kameliya on 23.7.2014 г..
 */
function findMostFreqNumber(array) {
    array.sort();

    var mostFreqNumber = [array[0]];
    var currNumber = [array[0]];
    var element = array[0];

    for(var i = 1; i <= array.length; i++) {
        if(array[i] === array[i - 1]) {
            currNumber.push(array[i]);

            if(i === array.length && mostFreqNumber.length <= currNumber.length) {
               mostFreqNumber = currNumber;
            }
              element = array[i];
        }
        else {
            if(mostFreqNumber.length < currNumber.length) {
                mostFreqNumber = currNumber;
            }
                    currNumber = [array[i]];
            }
        }
    var number = mostFreqNumber.length;
    console.log(element + " (" + number + " times)");
    }
