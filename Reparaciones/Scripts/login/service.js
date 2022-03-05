
var Service = function () {

   
    var Post = function (url, data, funcallback, funError) {
        $.ajax({
            type: 'POST',
            url: url,
            data: JSON.stringify(data),
            contentType: "application/json; charset=utf-8",
            dataType: 'json',
            beforeSend: function (xhr) {
                xhr.setRequestHeader("Authorization", getAuthCookie());
            },
            success: function (result) {

                if (result.Model != undefined && result.Model != null && result.Model != "") {
                    result.Model = JSON.parse(result.Model);
                }

                funcallback(result)
            },
            error: function (err) {
                console.log(err);

            }
        });
    }
   

    return {
        Post: Post,
    }
}
///Se crea la instancia desde que se agrega el archivo para que este global
var objService = new Service();