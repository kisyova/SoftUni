/**
 * Created by Kameliya on 25.7.2014 г..
 */
function biggerThanNeighbours(index, array) {
        if(index === 0 || index === array.length - 1) {
            return "only one neighbour";
        }
        else if(index >= array.length || index < 0) {
            return "invalid index";
        }
        else {
            if(array[index] > array[index - 1] && array[index] > array[index + 1]) {
                return "bigger";
            }
            else {
                return "not bigger";
            }
        }

}