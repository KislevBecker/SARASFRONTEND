namespace SARASWEB.Frontend.Transversal.DTO.ListasGeneralesDTO
{
    public class BancosDTO
    {
        public int Id { get; set; }
        public string Banco { get; set; }
        public string RutaLempiras { get; set; }
        public string RutaDolares { get; set; }
        public bool Tarjeta { get; set; }
        public bool Prestamo { get; set; }
    }
}
