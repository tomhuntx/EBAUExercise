// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let pressedLast;

// Remove all charts and display selected chart by id
// @param: The id of the chart with #
function ShowChart(chart) {
    var tables = document.getElementsByClassName("customer-table");
    for (let i = 0; i < tables.length; i++) {
        tables[i].style.display = "none";
    }

    // Allow buttons to disable tables if pressed twice
    if (chart !== pressedLast) {
        document.getElementById(chart).style.display = "inline-table";
        pressedLast = chart;
    }
    else {
        pressedLast = "";
    }
}

// Make and alert a call to the tasks api
function CallTasks() {
    const url = "/api/tasks";
    fetch(url)
        .then(
            response => response.text() // Get .json response
        ).then(
            html => alert(html) // Alert it
        );
}