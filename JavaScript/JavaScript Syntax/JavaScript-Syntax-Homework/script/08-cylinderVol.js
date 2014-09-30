/**
 * Created by Kameliya on 21.7.2014 г..
 */
function calcCylinderVol(radius, height) {
    var volume = Math.pow(radius, 2) * Math.PI * height;
    return volume.toFixed(3);
}

console.log(calcCylinderVol(2, 4));
console.log(calcCylinderVol(5, 8));
console.log(calcCylinderVol(12, 3));