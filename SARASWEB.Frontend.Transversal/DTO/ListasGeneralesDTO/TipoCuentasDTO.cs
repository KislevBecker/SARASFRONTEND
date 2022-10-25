namespace SARASWEB.Frontend.Transversal.DTO.ListasGeneralesDTO
{
    public class TipoCuentasDTO
    {
        public int Id { get; set; }
        public string CodigoTipoCuenta { get; set; }
        public string Descripcion { get; set; }
        public bool Prestamo { get; set; }
        public bool Tarjeta { get; set; }
    }
}
