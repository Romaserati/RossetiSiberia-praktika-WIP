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
                    if (!data.success) {
                        Swal.fire({
                            icon: "error",
                            title: "Упс...",
                            text: "Похоже, Вы не авторизованы!",
                        });
                    }
                    else {
                        Swal.fire("Заказ создан! Мы свяжемся с Вами в ближайшее время", "", "success");
                    }
                }
            });
        }
        else if (result.isDenied) {
            Swal.fire("Заявка отменена", "", "info");
        }
    });
}