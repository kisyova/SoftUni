/**
 * Created by Kameliya on 25.7.2014 г..
 */
function findLargestBySumOfDigits(nums) {
    if(arguments.length < 1) {
        return undefined;
    }
    else {
        var sum = 0;
        for(var i = 0; i < nums.length; i++) {
            if(parseInt(nums[i]) !== nums[i]) {
                return undefined;
            }
            var current = Math.abs(nums[i]).toString();
            var currentSum = 0;
            for(var j = 0; j < current.length; j++) {
                currentSum += Number(current[j]);
            }
            if(currentSum >= sum) {
                sum = currentSum;
                var result = nums[i];
            }
        }
        return result;
    }
}

console.log(findLargestBySumOfDigits([5, 10, 15, 111]));
console.log(findLargestBySumOfDigits([33, 44, -99, 0, 20]));
console.log(findLargestBySumOfDigits(['hello']));
console.log(findLargestBySumOfDigits([5, 3.3]));