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
        header: {
            "if-match": // TODO figure out what to put here
        },
        data: {
            Name: document.getElementById("name").value,
            Color: document.getElementById("color").value,
            Size: document.getElementById("size").value,
            Gender: document.getElementById("gender").value
        },
        success: handleServerEvent
    });
}

function postVals() {
    $.ajax(serverURL, {
        method: "POST",
        data: ""
    });
}

function handleServerEvent(data) {
    var resultsDiv = document.getElementById("results");
    resultsDiv.textContent = JSON.parse(data);
}
