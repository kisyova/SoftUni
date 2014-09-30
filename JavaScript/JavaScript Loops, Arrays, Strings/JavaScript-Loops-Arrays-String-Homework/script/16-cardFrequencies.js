/**
 * Created by Kameliya on 24.7.2014 г..
 */
function findCardFrequencies(array) {

    function getUniqueElements(arr) {

        var newArr = [];

        for (var i in arr) {
            if (newArr.indexOf(arr[i]) === -1) {
                newArr.push(arr[i]);
            }
        }

        return newArr;
    }

    var cards = array.split(/[♣♦♥♠ ]+/);
    var frequencies = [];

    cards.pop();


    for (var i in cards) {
        if (cards[i] in frequencies) {
            frequencies[cards[i]]++;
        }
        else {
            frequencies[cards[i]] = 1;
        }
    }

    var cardsNumber = cards.length
    var outputString = '';

    cards = getUniqueElements(cards);

    for (i in cards) {
        var percent = (frequencies[cards[i]] / cardsNumber * 100).toFixed(2);
        outputString += cards[i] + ' -> ' + percent + '%\n';
    }

    return outputString;

}
console.log(findCardFrequencies('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦'));