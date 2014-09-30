/**
 * Created by Kameliya on 22.7.2014 г..
 */
function displayProperties() {
    var properties = [], property;
    for(property in document) {
        properties.push(property);
    }
    properties.sort();
    console.info(properties.join("\n"));
}