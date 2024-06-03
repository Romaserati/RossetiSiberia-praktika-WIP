var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/services/getall' },
        "columns": [
            { data: 'name', width: "20%" },
            { data: 'category.categoryName', width: "15%" },
            { data: 'description', width: "20%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                            <a href="/admin/services/upsert?id=${data}" class="btn btn-primary mx-2">Редактировать</a>
                            <a onclick=Delete("/admin/services/delete/${data}") class="btn btn-danger mx-2">Удалить</a>
                    </div>`
                },
                width: "5%"
            },
        ],
        language: {
            "emptyTable": "Таблица пуста",
            "info": "Показано с _START_ по _END_ из _TOTAL_ элементов",
            "infoEmpty": "Показано с 0 по 0 из 0 элементов",
            "infoFiltered": "(Отфильтровано из _MAX_ элементов)",
            "search": "Поиск:",
            "zeroRecords": "Совпадений не найдено",
            "lengthMenu": "Показывать по _MENU_ элементов"
        }
    });
}

function Delete(url) {
    Swal.fire({
        title: "Вы уверены что хотите удалить?",
        text: "Услуга будет удалена навсегда",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        cancelButtonText: "Отмена",
        confirmButtonText: "Я согласен(на)"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    /*toastr.success(data.message);*/
                    Swal.fire({
                        title: "Удалено!",
                        text: data.message,
                        icon: "success"
                    });
                }
            });
        }
    });
}

