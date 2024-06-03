function loadDataTable() {
    dataTable = $('#tblDataUsers').DataTable({
        "ajax": { url: '/admin/users/getall' },
        "columns": [
            { Data: 'lastName', width: "15%" },
            { Data: 'firstName', width: "15%" },
            { Data: 'middleName', width: "15%" },
            { Data: 'emailConfirmed', width: "15%" },
            { Data: 'phoneNumber', width: "15%" },
            { Data: 'email', width: "15%" },
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

$(document).ready(function () {
    loadDataTable();
});