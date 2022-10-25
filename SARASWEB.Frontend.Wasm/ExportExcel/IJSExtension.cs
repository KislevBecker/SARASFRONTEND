using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.Wasm.ExportExcel
{
    public static class IJSExtension
    {
        public static ValueTask<object> GuardarComo(this IJSRuntime js, string nombreArchivo, byte[] archivo)
        {
            return js.InvokeAsync<object>("saveAsFile",
                nombreArchivo,
                Convert.ToBase64String(archivo));
        }
        public static ValueTask<object> MostrarSweetAlert(this IJSRuntime js, string titulo, string mensaje, string tipo, string colorBoton)
        {
            return js.InvokeAsync<object>("Swal.fire", titulo, mensaje, tipo, colorBoton);
        }
        public async static ValueTask<object> ConfirmWarning(this IJSRuntime js, string titulo, string mensaje, string tipo)
        {
            return await js.InvokeAsync<object>("CustomConfirmWarning", titulo, mensaje, tipo);
        }
        public async static ValueTask<object> ConfirmError(this IJSRuntime js, string titulo, string mensaje, string tipo)
        {
            return await js.InvokeAsync<object>("CustomConfirmError", titulo, mensaje, tipo);
        }
    }
}
