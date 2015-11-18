var serverURL = "http://localhost:53330/api/values";

function getValues() {
    $.ajax(serverURL, {
        method: "GET",
        success: handleServerEvent
    });
}

function patchValues() {
    
}

function postValues() {
    //
}

function handleServerEvent() {
    //TODO
}