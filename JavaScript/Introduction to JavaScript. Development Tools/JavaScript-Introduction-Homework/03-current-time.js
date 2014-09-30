/**
 * Created by Kameliya on 20.7.2014 г..
 */
var date = new Date();
var hour = date.getHours();
var min = date.getMinutes();

if(min < 10) {
    console.log(hour + ":0" + min);
}
else {
    console.log(hour + ":" + min);
}