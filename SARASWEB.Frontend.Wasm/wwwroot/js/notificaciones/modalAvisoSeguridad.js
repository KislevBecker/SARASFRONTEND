(function () {
    window.mostrarAvisoSeguridad = {

        mostrarModal: function (id) {
            $(`#${id}`).modal('show');
        },
        cerrarModal: function (id) {
            $(`#${id}`).modal('hide');
        }
    };
})();