function Create(url) {
    Swal.fire({
        title: "Подать заявку?",
        showDenyButton: true,
        confirmButtonText: "Создать заказ",
        denyButtonText: `Отмена`
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'POST',
                success: function (data) {
                    /*toastr.success(data.message);*/
                    Swal.fire({
                        position: "top-end",
                        icon: "success",
                        title: "Заявка подана, мы свяжемся с Вами в ближайшее время",
                        showConfirmButton: false,
                        timer: 1500
                    });
                }
            });
        }
        else if (result.isDenied) {
            Swal.fire("Заявка отменена", "", "info");
        }
    });
}