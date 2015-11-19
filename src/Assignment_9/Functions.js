var serverURL = "http://localhost:53330/gargoyles";

function getVals() {
    $.ajax(serverURL, {
        method: "GET",
        success: handleServerEvent
    });
}

function patchVals() {
    $.ajax(serverURL, {
        method: "PATCH",

        // TODO figure out what to put in here
    });
}

function postVals() {
    //
}

function handleServerEvent(data) {
    var resultsDiv = document.getElementById("results");
    resultsDiv.textContent = JSON.parse(data);
}
