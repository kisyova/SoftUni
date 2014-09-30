/**
 * Created by Kameliya on 23.7.2014 г..
 */
function findPalindromes(string) {
    var str = string.toLowerCase();

    var word = string.split(/\W+/);
    var palindrome = [];

    for (var i = 0; i < word.length; i++) {
        if (word[i] == word[i].split("").reverse().join("")) {
            palindrome.push(word[i]);
        }
    }
    return palindrome.join(", ");
}
