
function change_password() {
    $("#myModal").modal();
}

$(".btnSave").click(function () {
    var old_Password = $(".old_Password").val();
    var new_Password = $(".new_Password").val();
    var re_type_Password = $(".re_type_Password").val();
    var Request = {
        old_password: old_Password,
        new_Password: new_Password,
        re_type_Password: re_type_Password,
    }
    if (new_Password == re_type_Password) {
        $.ajax({
            type: "POST",
            url: '/Profile/Change_password',
            dataType: 'json',
            data: JSON.stringify(Request),
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
                console.log(data,'data')
                setTimeout(function () {
                    window.location.reload();
                }, 1000);
            },
            error: function (xhr, status, error) {
                console.log(xhr.responseText);
            }
        });
    } else {
        alert('New password will same on Re-type')
    }
    
});
