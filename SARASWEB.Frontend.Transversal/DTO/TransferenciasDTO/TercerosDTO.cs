namespace SARASWEB.Frontend.Transversal.DTO.TransferenciasDTO
{
    public class TercerosDTO
    {
        public string NumeroDocumento { get; set; }
        public string Usuario { get; set; }
        public string CuentaOrigen { get; set; }
        public string CuentaDestino { get; set; }
        public decimal Monto { get; set; }
        public string Motivo { get; set; }
        public string CorreoDestinatario { get; set; }
        public string CorreoConfirmacion { get; set; }
        public double Tasa { get; set; }
        public string popularToken { get; set; }
    }
}
