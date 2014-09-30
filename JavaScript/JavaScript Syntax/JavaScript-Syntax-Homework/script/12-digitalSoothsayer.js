/**
 * Created by Kameliya on 21.7.2014 г..
 */
function sootsayer(years, lang, city, car) {
    var item1 = years[Math.floor(Math.random() * years.length)];
    var item2 = lang[Math.floor(Math.random() * lang.length)];
    var item3 = city[Math.floor(Math.random() * city.length)];
    var item4 = years[Math.floor(Math.random() * car.length)];

    return "You will work " + item1 + " years on " + item2 + ". \nYou will live in " + item3 + " and drive " + item4 + ".";
}

