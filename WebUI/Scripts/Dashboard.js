function DeleteRation(Id) {
    swal({
        title: "Are you sure?",
        text: "Are you sure you want to delete this packet?",
        type: "warning",
        showCancelButton: true,
        confirmButtonClass: "btn-danger",
        confirmButtonText: "Yes, delete it!",
        cancelButtonText: "No, cancel plx!",
        closeOnConfirm: false,
        closeOnCancel: false
    },
        function (isConfirm) {
            if (isConfirm) {
                var RequestData = { "Id": Id };
                $.ajax({
                    type: "POST",
                    url: "/Ration/DeleteRation/",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify(RequestData),
                    dataType: "json",
                    success: function (data) {
                        if (data === 1) {
                            swal({
                                title: "Deleted!!",
                                text: "Your Record has been deleted",
                                type: "success",
                                showCancelButton: true,
                                confirmButtonClass: "btn-danger",
                                confirmButtonText: "Ok",
                                cancelButtonText: "Close",
                                closeOnConfirm: false,
                                closeOnCancel: false
                            },
                                function (isConfirm) {
                                    if (isConfirm) {
                                        window.location.href = "/Ration/Dashboard";
                                    } else {
                                        window.location.href = "/Ration/Dashboard";
                                    }
                                });
                        }
                    },

                    failure: function (data) {
                        console.log(data.responseText);
                    },
                    error: function (data) {
                        console.log(data.responseText);
                    }

                });
            } else {
                window.location.href = "/Ration/Dashboard";
            }
        });

}
