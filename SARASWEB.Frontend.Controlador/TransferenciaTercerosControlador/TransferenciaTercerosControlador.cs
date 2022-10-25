using System.Threading.Tasks;

namespace SARASWEB.Frontend.Controlador.TransferenciaTercerosControlador
{
    public class TransferenciaTercerosControlador : ITransferenciaTercerosControlador
    {
        private int porcentajeIndividual = 0;
        private int posicion = 0;
        public string[] Wizard { get; set; }
        public bool MostrarLoader { get; set; }
        public string BarraPorcentaje { get; set; }
        public bool MostrarBotonesWizard { get; set; }
        public TransferenciaTercerosControlador()
        {
            IniciarWizard();
        }
        private void IniciarWizard()
        {
            Wizard = new string[] { "active", "", "", "" };
            porcentajeIndividual = 100 / 3;
            BarraPorcentaje = $"{porcentajeIndividual}%";
        }

        private void LimpiarWizard()
        {
            int i = 0;
            while (i < 3)
            {
                Wizard[i] = "";
                i++;
            }
        }

        public void SiguienteStep()
        {
            if (posicion != 2)
            {
                LimpiarWizard();
                posicion = posicion + 1;
                BarraPorcentaje = $"{porcentajeIndividual * (posicion + 1)}%";

                Wizard[posicion] = "active";
            }
            if (posicion is 2)
            {
                MostrarBotonesWizard = false;
            }
        }

        public void AtrasStep()
        {
            if (posicion != 0)
            {
                LimpiarWizard();
                posicion = posicion - 1;
                BarraPorcentaje = $"{porcentajeIndividual * (posicion is 0 ? 1 : posicion + 1)}%";

                Wizard[posicion] = "active";
            }

            if (posicion is 0)
                MostrarBotonesWizard = false;
        }

        public async Task Siguiente()
        {
            if (posicion is 0)
            {
                MostrarBotonesWizard = true;
                SiguienteStep();
                return;
            }
            if (posicion is 1)
            {
                MostrarBotonesWizard = true;
                SiguienteStep();
                return;
            }
        }
 
    }
}
