

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Category/GetAll"
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
                                <a class="btn btn-danger text-white" style="cursor:pointer" onclick="deleteCategory(${data})">
                                    <i class="fas fa-trash-alt"></i>&nbsp;
                                </a>
                            </div>
                            `;
                }, "width": "40%"
            }
        ]
    });
}

/*function deleteCategory(categoryId) {
    if (confirm("Are you sure you want to delete this category?")) {
      
        $.ajax({
            url: `/Admin/Category/Delete/${categoryId}`,
            method: "POST",
            success: function (response) {
         
                dataTable.ajax.reload();
            },
            error: function (error) {
            
                console.error(error);
            }
        });
    }
}
*/