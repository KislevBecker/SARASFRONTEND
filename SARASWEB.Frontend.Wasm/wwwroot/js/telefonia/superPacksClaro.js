(function () {
    window.superpacks = {
        obtenerDetalleSuperPacks: function () {
            let texto = $('#ddlSuperPacks option:selected').text();
            return texto;
        }
    };
})();