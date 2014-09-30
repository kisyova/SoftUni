/**
 * Created by Kameliya on 25.7.2014 г..
 */
function likeUnlike() {
    var status = document.getElementById("buttonLike");

    if(status.value == "Like") {
        status.value = "Unlike";
    }
    else {
        status.value = "Like";
    }
}