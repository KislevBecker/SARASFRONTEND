(function () {
    window.prestamo = {
        obtenerBancoPrestamo: function () {
            let texto = $('#ddlBancosTransferenciaPrestamo option:selected').text();
            return texto;
        }
    };
})();