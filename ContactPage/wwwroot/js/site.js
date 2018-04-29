// Write your JavaScript code.

$(document).ready(function () {
    if ($("button[type=submit]").length === 1) {
        $("button[type=submit]").on("click", function (e) {
            if ($("input[id='phoneNumber']").length === 1) {
                if ($("input[id='phoneNumber']").val() !== "") {
                    if (false === /^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$/.test($("input[id='phoneNumber']").val())) {
                        // alert('The Phone Number Is Not Valid.');
                        document.getElementById("phoneNumber").setCustomValidity('The Phone Number Is Not Valid.');
                        // eventMsg is just an empty object so that click is properly triggered
                        $("button[type=submit]").click(eventMsg);
                        return false;
                    } else {
                        document.getElementById("phoneNumber").setCustomValidity('');
                    }
                }
            }
        });
    }
});