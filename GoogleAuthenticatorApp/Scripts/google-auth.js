var validateKey = function () {
    var key = $('input[name="userkey"]').val();
    console.log(key);
    $.get("/Home/validatekey", { userKey: key }, function (res) {
        console.log("result " + res);
    })
}