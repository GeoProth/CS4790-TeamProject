// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//Initialising DataTables
$(document).ready(function () {
    var table1 = $('#table_inventory').DataTable({

        columnDefs: [
            { width:198, targets: 10}
        ],
        responsive: true
    });

    var table2 = $('#table_inventory2').DataTable({
        columnDefs: [
            { width: 20, targets: 4}
        ],
        responsive: true
    });

    var table3 = $('#table_vendor').DataTable({
        responsive: true,
        "columnDefs": [
            { "orderable": false, "targets": 1 },
            { "orderable": false, "targets": 2 }
        ]
    });

    var table4 = $('#table_assemblies').DataTable({
        responsive: true,

        "columnDefs": [
            { "orderable": false, "targets": 1 },
            { "orderable": false, "targets": 2 }
        ]
    });

    var table5 = $('#table_POdetails').DataTable({
        responsive: true



    })

    $("#myInputAll").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myListAll li").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });

    $("#myInputPending").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myListPending li").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });

    $("#myInputReceived").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myListReceived li").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });

    $("#myInputOverdue").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#myListOverdue li").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });

  
    $("#Add").on("click", function () {
        $("#selectboxDIV").append("<label asp-for='itemID' class='control-label'></label><select name='itemID' id='listbox' class='form-control'> @foreach (var item in Model.allItems){<option value='@item.ItemId'>@item.ItemName</option>}</select>");
    });

    $("#Remove").on("click", function () {
        $("#selectboxDIV").children().last().remove();
    });
   

    //var table4 = $('#table_orders2').DataTable({
    //    responsive: true
    //});

    //var table5 = $('#table_orders3').DataTable({
    //    responsive: true
    //});

    //var table6 = $('#table_orders4').DataTable({
    //    responsive: true
    //});

    table1.column(1).visible(false);
    table1.column(3).visible(false);
    //table1.column(5).visible(false);
    table1.column(6).visible(false);
    table1.column(7).visible(false);
    table1.column(8).visible(false);
    table1.column(9).visible(false);


    //table2.column(4).visible(false);

    $('#today').val(new Date().toDateInputValue());
    $('#today2').val(new Date().toDateInputValue());



});

Date.prototype.toDateInputValue = (function () {
    var local = new Date(this);
    local.setMinutes(this.getMinutes() - this.getTimezoneOffset());
    return local.toJSON().slice(0, 10);
});
