function RemoveRecord(e, Id) {
    var User = {
        Id: Id
    };
    $.ajax({
        type: "POST",
        url: '/Product/DeleteRecord',
        dataType: 'json',
        data: JSON.stringify(User),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            $.notify("Deleted!", "error");
            $(e).parents("tr").remove();
        },
        error: function (xhr, status, error) {
            alert(xhr.responseText);
        }
    });
    return false;
}