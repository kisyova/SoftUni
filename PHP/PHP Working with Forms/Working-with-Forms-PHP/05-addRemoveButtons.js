var i;
var j;

function addProgrammingLanguage() {
    j++;
    var pcDiv = document.createElement("div");
    pcDiv.setAttribute("id", "languages" + j);
    pcDiv.innerHTML = '<input type="text" name="languages"' + ' <select name="langLevel">' + '<option value="Beginner">Beginner</option>'
        + '<option value="Average">Average</option>' + '<option value="Advanced">Advanced</option>' + '<option value="Ninja">Ninja</option>' + '</select>'
    document.getElementById("newPCLangs").appendChild(pcDiv);
}

function removeProgrammingLanguage(ev) {
    var button = ev.target;
    if(button.name == "removeLang") {
        var parent = button.parentNode;
        var wrapper = parent.parentNode;
        wrapper.removeChild(parent);
}

function addLanguage() {
    j++;
    var langDiv = document.createElement("div");
    langDiv.setAttribute("id", "forLanguage" + i);
    langDiv.innerHTML = '<input type="text" name="forLanguage"' + ' <select name="comprLevel">' + '<option value="beginner">beginner</option>'
        + '<option value="intermediate">intermediate</option>' + '<option value="advanced">advanced</option>' + '</select>' +
        ' <select name="readLevel">' + '<option value="beginner">beginner</option>' + '<option value="intermediate">intermediate</option>'
        + '<option value="advanced">advanced</option>' + '</select>' + ' <select name="writeLevel">' + '<option value="beginner">beginner</option>'
        + '<option value="intermediate">intermediate</option>' + '<option value="advanced">advanced</option>' + '</select>'
    document.getElementById("otherLangs").appendChild(langDiv);
}

function removeLanguage(id) {
    i--;
    var langDiv = document.getElementById(id);
    document.getElementById("otherLangs").removeChild(langDiv);
}
}