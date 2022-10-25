(function () {
    window.mostrarModalConfirmaClave = {

        mostrarModal: function (id) {
            $(`#${id}`).modal('show');
        },
        cerrarModal: function (id) {
            $(`#${id}`).modal('hide');
        }
    };
})();