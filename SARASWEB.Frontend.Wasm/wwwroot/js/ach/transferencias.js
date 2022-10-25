(function () {
    window.transferencias = {
        obtenerBanco: function () {
            let texto = $('#ddlBancosTransferencia option:selected').text();
            return texto;
        }
    };
})();