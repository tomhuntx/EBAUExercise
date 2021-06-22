// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Remove all charts and display selected chart by id
// @param: The id of the chart with #
function ShowChart(chart) {
    var tables = document.getElementsByClassName("customer-table");
    for (let i = 0; i < tables.length; i++) {
        tables[i].style.display = "inline-table";
    }

    //document.getElementById(chart).style.display = "inline-table";
}