var serverURL = "http://localhost:53330/api/values";

function getVals() {
    $.ajax(serverURL, {
        method: "GET",
        success: handleServerEvent
    });
}

function patchVals() {
    
}

function postVals() {
    //
}

function handleServerEvent(data) {
    var resultsDiv = document.getElementById("results");
    resultsDiv.textContent = JSON.parse(data);
}
