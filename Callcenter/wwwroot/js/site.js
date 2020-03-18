﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
"use strict";
const connection = new signalR.HubConnectionBuilder().withUrl("/Hub").withAutomaticReconnect().build();
connection.start().then(function () {
}).catch(function (err) {
    return console.error(err.toString());
});
connection.on("marked", function (id) {
    var element = document.getElementById(id);
    if (element && element != undefined && element != null && !element.classList.contains("marked")) {
        element.classList.add("other");
    }
});
connection.on("free", function (id) {
    var element = document.getElementById(id);
    if (element && element != undefined && element != null) {
        element.classList.remove("other");
    }
});
connection.on("delete", function (id) {
    var element = document.getElementById(id);
    if (element && element != undefined && element != null) {
        element.parentElement.removeChild(element);
    }
});
connection.on("filldata", function (data) {
    const id = document.getElementById('id')
    if (id && id != undefined && id != null) {
        id.value = data.id;
    }
    const phone = document.getElementById('phone')
    if (phone && phone != undefined && phone != null) {
        phone.value = data.phone;
    }
    const zip = document.getElementById('zip')
    if (zip && zip != undefined && zip != null) {
        zip.value = data.zip;
    }
    const radios = document.getElementsByName("request");
    if (radios && radios != undefined && radios != null) {
        for (var i = 0; i < radios.length; i++) {
            radios[i].checked = (radios[i].value == data.request);
        }
    }
});
connection.on("insert", function (entry) {
    const object = JSON.parse(entry);
    if (document.getElementById(object._id) !== null) {
        return;
    }
    object.timestamp = new Date(object.timestamp);

    switch (object.request) {
        case -1:
            object.request = "Fehler";
            break;
        case 1:
            object.request = "Einkäufe";
            break;
        case 2:
            object.request = "Haustiere";
            break;
        case 3:
            object.request = "Reparaturen";
            break;
        default:
            object.request = "Sonstiges";
            break;
    }
    object.cstring = object.marked ? "other" : "";

    $("#entries").find('tbody')
        .append($('<tr  id="' + object._id + '" class="' + object.cstring + '">')
            .append($('<td>')
                .append(object.timestamp.toLocaleString("de"))
            )
            .append($('<td>')
                .append(object.phone)
            )
            .append($('<td>')
                .append(object.request)
            )
            .append($('<td>')
                .append($('<button class="btn btn-secondary btn-sm btn-block" onclick="MarkItem(\'' + object._id + '\')">')
                    .append('<i class="fas fa-user-edit" title="In Bearbeitung nehmen">')
                )
            )
            .append($('<td>')
                .append($('<button class="btn btn-secondary btn-sm btn-block" onclick="DelItem(\'' + object._id + '\')">')
                    .append('<i class="fas fa-thumbs-up" title="Fertigstellen">')
                )
            )
        );
});

function MarkItem(elmid) {
    const element = document.getElementById(elmid);
    if (element.classList.contains("other")) {
        const isConfirmed = confirm("Dieser Eintrag wird bereits bearbeitet. Bitte bestätigen Sie, dass sie diesen Eintrag übernehmen möchten.");
        if (!isConfirmed) {
            return;
        }
        if (element.classList.contains("other")) {
            element.classList.remove("other");
        }
    }
    if (!element.classList.contains("marked")) {
        Array.from(document.getElementsByClassName("marked")).forEach(elm => {
            connection.invoke("FreeEntry", elm.id);
            Array.from(elm.getElementsByClassName("fa-times")).forEach(itm => {
                itm.classList.add("fa-user-edit");
                itm.classList.remove("fa-times");
            });
            elm.classList.remove("marked");
        });
        element.classList.add("marked");
        Array.from(element.getElementsByClassName("fa-user-edit")).forEach(itm => {
            itm.classList.add("fa-times");
            itm.classList.remove("fa-user-edit");
        });
        connection.invoke("MarkEntry", elmid);
    } else {
        element.classList.remove("marked");
        Array.from(element.getElementsByClassName("fa-times")).forEach(itm => {
            itm.classList.add("fa-user-edit");
            itm.classList.remove("fa-times");
        });
        connection.invoke("FreeEntry", elmid);
        document.getElementById('id').value = "";
        document.getElementById('phone').value = "";
        document.getElementById('zip').value = "";
        const radios = document.getElementsByName("request");
        for (var i = 0; i < radios.length; i++) {
            if (radios[i].checked) {
                radios[i].checked = false;
            }
        }
    }
}

function DelItem(elmid) {
    var element = document.getElementById(elmid);
    if (element.classList.contains("marked")) {
        connection.invoke("DeleteEntry", elmid);
        document.getElementById('id').value = "";
        document.getElementById('phone').value = "";
        document.getElementById('zip').value = "";
        const radios = document.getElementsByName("request");
        for (var i = 0; i < radios.length; i++) {
            if (radios[i].checked) {
                radios[i].checked = false;
            }
        }
    } else {
        alert("Element " + elmid + " nicht als bearbeitet Markiert");
    }
}
function AddItem() {
    var request;
    const radios = document.getElementsByName("request");
    for (var i = 0; i < radios.length; i++) {
        if (radios[i].checked) {
            request = radios[i].value;
        }
    }
    connection.invoke("AddOrModifyEntry",
        document.getElementById('id').value,
        document.getElementById('phone').value,
        document.getElementById('zip').value,
        request
    );
    document.getElementById('rftel').value = document.getElementById('phone').value;
    document.getElementById('rfzip').value = document.getElementById('zip').value;
    document.getElementById('rfreq').value = request;
    const requestFinish = document.getElementById('requestFinish');
    const requestForm = document.getElementById('requestForm');
    requestForm.classList.add("invisible");
    requestFinish.classList.remove("invisible");
    setTimeout(function () {
        requestFinish.classList.add("invisible");
        requestForm.classList.remove("invisible");
    }, 800);
    return false;
}