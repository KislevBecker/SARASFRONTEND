using System.Threading.Tasks;

namespace SARASWEB.Frontend.Controlador.TransferenciaPropiaControlador
{
    public interface ITransferenciaPropiaControlador
    {
        public string[] Wizard { get; set; }
        public bool MostrarLoader { get; set; }
        public string BarraPorcentaje { get; set; }
        public bool MostrarBotonesWizard { get; set; }
        
        void AtrasStep();
        Task Siguiente();
       
    }
}
