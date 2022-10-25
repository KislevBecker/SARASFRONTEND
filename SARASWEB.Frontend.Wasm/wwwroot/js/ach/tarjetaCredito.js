(function () {
    window.tarjetaCredito = {
        obtenerBancoTarjeta: function () {
            let texto = $('#ddlBancosTransferenciaTarjeta option:selected').text();
            return texto;
        }
    };
})();