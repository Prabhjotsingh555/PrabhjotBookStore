var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Category/GetAll",
            "type": "GET", // Specify the HTTP method
            "dataType": "json" // Specify the expected data type
        },
        "columns": [
            { "data": "name", "width": "60%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a href="/Admin/Category/Upsert/${data}" class="btn btn-success text-white" style="cursor:pointer">
                                <i class="fas fa-edit"></i>&nbsp;
                            </a>
                            <a onclick="Delete('/Admin/Category/Delete/${data}')" class="btn btn-danger text-white" style="cursor:pointer">
                                <i class="fas fa-trash-alt"></i>&nbsp;
                            </a>
                        </div>
                    `;
                },
                "width": "40%"
            }
        ],
        "error": function (xhr, error, thrown) {
            console.log("Ajax error:", error);
        }
    });
}

function Delete(url) {
    swal({
        title: "Are you sure you want to delete?",
        text: "You will not be able to restore the data!",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    } else {
                        toastr.error(data.message);
                    }
                },
                error: function (xhr, status, error) {
                    console.log("Ajax error:", error);
                }
            });
        }
    });
}
