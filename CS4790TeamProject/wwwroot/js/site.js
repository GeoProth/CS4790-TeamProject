// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//Initialising DataTables
$(document).ready(function () {
    var table1 = $('#table_inventory').DataTable({
        responsive: true
    });

    var table2 = $('#table_inventory2').DataTable({
        responsive: true
    });

    var table3 = $('#table_orders').DataTable({
        responsive: true
    });

    var table4 = $('#table_orders2').DataTable({
        responsive: true
    });

    var table5 = $('#table_orders3').DataTable({
        responsive: true
    });

    var table6 = $('#table_orders4').DataTable({
        responsive: true
    });

    table1.column(1).visible(false);
    table1.column(3).visible(false);
    //table1.column(5).visible(false);
    table1.column(6).visible(false);
    table1.column(7).visible(false);
    table1.column(8).visible(false);
    table1.column(9).visible(false);
    //table1.column(6).visible(false);


    let today = new Date().toISOString().substr(0, 10);
    document.querySelector("#today").value = today;
    document.querySelector("#today2").value = today;

});


