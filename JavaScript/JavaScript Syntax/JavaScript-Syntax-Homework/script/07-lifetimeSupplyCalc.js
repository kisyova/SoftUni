/**
 * Created by Kameliya on 21.7.2014 г..
 */
function calcSupply(nowAge, endAge, food) {

    var amountFood = food * (endAge - nowAge)* 365;
    var typeFood = "melon";

    console.log(amountFood + "kg of " + typeFood + " would be enough until I am " + endAge + " years old.");
}

console.log(calcSupply(38, 118, 0.5));
console.log(calcSupply(20, 87, 2));
console.log(calcSupply(16, 102, 1.1));