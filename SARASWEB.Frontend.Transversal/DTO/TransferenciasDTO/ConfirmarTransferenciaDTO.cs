namespace SARASWEB.Frontend.Transversal.DTO.TransferenciasDTO
{
    public class ConfirmarTransferenciaDTO
    {
        public string estado { get; set; }
        public string referencia { get; set; }
        public string cuentaDebitada { get; set; }
        public string cuentaAcreditada { get; set; }
        public decimal? monto { get; set; }
        public string moneda { get; set; }
        public string motivo { get; set; }
        public string CorreoDestinatario { get; set; }
        public string CorreoConfirmacion { get; set; }
        public string comision { get; set; }
        public string nombreDestinatario { get; set; }
    }
}
