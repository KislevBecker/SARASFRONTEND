using SARASWEB.Frontend.Transversal.DTO.ProductosDTO;
using SARASWEB.Frontend.Transversal.DTO.RespuestaDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.Aplicacion.ProductosAplicacion
{
    public interface IProductoAplicacion
    {
        Task<RespuestaDTO<IEnumerable<ProductosDTO>>> ObtenerProductos(RequestProductosDTO requestProductosDTO);
        Task<RespuestaDTO<IEnumerable<CuentasDTO>>> ObtenerCuentas(RequestCuentaDTO requestCuentaDTO);
        Task<RespuestaDTO<CuentaDatosDTO>> ObtenerInformacionCuenta(CuentaObtenerInformacionDTO cuentaObtenerInformacionDTO);
        Task<RespuestaDTO<CuentaDatosPropiaDTO>> ObtenerInformacionCuentaPropia(CuentaObtenerInformacionDTO cuentaObtenerInformacionDTO);
        Task<RespuestaDTO<IEnumerable<MovimientosCuentaDTO>>> ObtenerMovimientos(CuentaMovimientosDTO cuentaMovimientosDTO);
        Task<RespuestaDTO<IEnumerable<PrestamosDTO>>> ObtenerPrestamos(RequestPrestamosDTO requestPrestamosDTO);
        Task<RespuestaDTO<DatosPrestamoDTO>> ValidaPrestamo(RequestValidaPrestamoDTO requestValidaPrestamoDTO);
        Task<RespuestaDTO<RespuestaTasaAS400DTO>> ObtenerTasa();
        Task<RespuestaDTO<DetalleCDTDTO>> ObtenerInformacionCuentaCDT(CuentaObtenerInformacionDTO cuentaObtenerInformacionDTO);
    }
}
