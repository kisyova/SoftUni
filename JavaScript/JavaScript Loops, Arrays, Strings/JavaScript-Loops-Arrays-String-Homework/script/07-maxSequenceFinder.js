/**
 * Created by Kameliya on 22.7.2014 г..
 */
function findMaxIncreasingSequence(sequence) {
    var currIncSequence = [sequence[0]];
    var maxIncSequence =[sequence[0]];

    for(var i = 0; i <= sequence.length; i++) {
        var currElement = sequence[i];
        var prevElement = sequence[i - 1];

        if(currElement > prevElement) {
            currIncSequence.push(currElement);

            if(i === sequence.length && maxIncSequence.length <= currIncSequence.length) {
                maxIncSequence = currIncSequence;
            }
        }
        else {

            if(maxIncSequence.length <= currIncSequence.length) {
                maxIncSequence= currIncSequence;
            }
            currIncSequence = [currElement];
        }
    }
    if(maxIncSequence.length === 1) {
        console.log("no");
    }
    else {
        console.log(maxIncSequence);
    }
}