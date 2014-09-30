/**
 * Created by Kameliya on 22.7.2014 г..
 */
function findMaxSequence(array) {
    var sequence = [array[0]];
    var longestSeq = [array[0]];
    var maxLongSeq;

    for(maxLongSeq = 1; maxLongSeq <= array.length; maxLongSeq++) {
        var currElement = array[maxLongSeq];
        var prevElement = array[maxLongSeq - 1];

        if (currElement === prevElement) {
            sequence.push(currElement);

            if (maxLongSeq === array.length - 1 && longestSeq.length <= sequence.length) {
                longestSeq = sequence;
            }
        }
        else {
            if(longestSeq.length <= sequence.length) {
                longestSeq = sequence;
            }
            sequence = [currElement];
        }
    }

    console.log(longestSeq);
}