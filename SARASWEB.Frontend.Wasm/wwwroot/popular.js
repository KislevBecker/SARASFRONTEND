(function () {
    window.popular = {
        alertaError: function (e) {
            $.NotificationApp.send("Error", e, "bottom-right", "rgba(0,0,0,0.2)", "error")
        },
        alertaExito: function (e) {
            $.NotificationApp.send("Éxito", e, "bottom-right", "rgba(0,0,0,0.2)", "success")
        },
        mostrarLoader: function () {
            $("#loaderModal").modal("show")
        },
        cerrarLoader: function () {
            $("#loaderModal").modal("hide")
        },
        limpiarIdentidad: function (id) {
            document.getElementById(id).value = '';
        }
    };
})();

var loader = null;