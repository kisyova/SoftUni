/**
 * Created by Kameliya on 21.7.2014 г..
 */
function treeHouseCompare(a, b) {
    var areaHouse = Math.pow(a, 2) + (Math.pow(a, 2) / 3);
    var areaTree = (b * 1 / 3 * b) + (Math.PI * Math.pow((2 / 3 * b), 2));
    if(areaHouse > areaTree) {
        console.log("house/" + areaHouse);
    }
    else if(areaTree > areaHouse) {
        console.log("tree/" + areaTree);
    }
    else {
        console.log("house=tree/" + areaHouse);
    }
}

console.log(treeHouseCompare(3, 2));
console.log(treeHouseCompare(3, 3));
console.log(treeHouseCompare(4, 5));