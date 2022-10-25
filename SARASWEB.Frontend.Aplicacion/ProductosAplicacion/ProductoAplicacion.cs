using SARASWEB.Frontend.PD;
using SARASWEB.Frontend.Transversal.DTO.ProductosDTO;
using SARASWEB.Frontend.Transversal.DTO.RespuestaDTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SARASWEB.Frontend.Aplicacion.ProductosAplicacion
{
    public class ProductoAplicacion : IProductoAplicacion
    {
        private readonly IGenericaPersistenciaDatos genericaPersistenciaDatos;

        public ProductoAplicacion(IGenericaPersistenciaDatos genericaPersistenciaDatos)
        {
            this.genericaPersistenciaDatos = genericaPersistenciaDatos;
        }
        public async Task<RespuestaDTO<IEnumerable<CuentasDTO>>> ObtenerCuentas(RequestCuentaDTO requestCuentasDTO)
        {
            try
            {
                return await genericaPersistenciaDatos
                    .Post<CuentasDTO, RequestCuentaDTO>($"/api/Productos/obtener-cuentas", requestCuentasDTO);
            }
            catch (Exception ex)
            {

                return new RespuestaDTO<IEnumerable<CuentasDTO>>
                {
                    Mensaje = "Ocurrio un error interno:" + ex.ToString(),
                    Codigo = 500
                };
            }
        }

        public async Task<RespuestaDTO<CuentaDatosDTO>> ObtenerInformacionCuenta(CuentaObtenerInformacionDTO cuentaObtenerInformacionDTO)
        {
            try
            {
                return await genericaPersistenciaDatos
                    .Post<CuentaDatosDTO, CuentaObtenerInformacionDTO>(cuentaObtenerInformacionDTO, $"/api/Productos/validar-cuenta-tercero");
            }
            catch (Exception)
            {

                return new RespuestaDTO<CuentaDatosDTO>
                {
                    Mensaje = "Ocurrio un error interno",
                    Codigo = 500
                };
            }
        }

        public async Task<RespuestaDTO<DetalleCDTDTO>> ObtenerInformacionCuentaCDT(CuentaObtenerInformacionDTO cuentaObtenerInformacionDTO)
        {
            try
            {
                return await genericaPersistenciaDatos
                    .Post<DetalleCDTDTO, CuentaObtenerInformacionDTO>(cuentaObtenerInformacionDTO, $"/api/Productos/obtener-informacion-CDT");
            }
            catch (Exception)
            {

                return new RespuestaDTO<DetalleCDTDTO>
                {
                    Mensaje = "Ocurrio un error interno",
                    Codigo = 500
                };
            }
        }

        public async Task<RespuestaDTO<CuentaDatosPropiaDTO>> ObtenerInformacionCuentaPropia(CuentaObtenerInformacionDTO cuentaObtenerInformacionDTO)
        {
            try
            {
                return await genericaPersistenciaDatos
                    .Post<CuentaDatosPropiaDTO, CuentaObtenerInformacionDTO>(cuentaObtenerInformacionDTO, $"/api/Productos/obtener-informacion-cuenta-propia");
            }
            catch (Exception)
            {

                return new RespuestaDTO<CuentaDatosPropiaDTO>
                {
                    Mensaje = "Ocurrio un error interno",
                    Codigo = 500
                };
            }
        }

        public async Task<RespuestaDTO<IEnumerable<MovimientosCuentaDTO>>> ObtenerMovimientos(CuentaMovimientosDTO cuentaMovimientosDTO)
        {
            try
            {
                return await genericaPersistenciaDatos
                    .Post<MovimientosCuentaDTO, CuentaMovimientosDTO>($"/api/Productos/obtener-movimientos-cuenta", cuentaMovimientosDTO);
            }
            catch (Exception)
            {
                return new RespuestaDTO<IEnumerable<MovimientosCuentaDTO>>
                {
                    Mensaje = "Ocurrio un error interno",
                    Codigo = 500
                };
            }
        }

        public async Task<RespuestaDTO<IEnumerable<PrestamosDTO>>> ObtenerPrestamos(RequestPrestamosDTO requestPrestamosDTO)
        {
            try
            {
                return await genericaPersistenciaDatos
                    .Post<PrestamosDTO, RequestPrestamosDTO>($"/api/Productos/obtener-prestamos", requestPrestamosDTO);
            }
            catch (Exception)
            {
                return new RespuestaDTO<IEnumerable<PrestamosDTO>>
                {
                    Mensaje = "Ocurrio un error interno",
                    Codigo = 500
                };
            }
        }

        public async Task<RespuestaDTO<IEnumerable<ProductosDTO>>> ObtenerProductos(RequestProductosDTO requestProductosDTO)
        {
            try
            {
                return await genericaPersistenciaDatos
                    .Post<ProductosDTO, RequestProductosDTO>($"/api/Productos/obtener-productos", requestProductosDTO);
            }
            catch (Exception)
            {
                return new RespuestaDTO<IEnumerable<ProductosDTO>>
                {
                    Mensaje = "Ocurrio un error interno",
                    Codigo = 500
                };
            }
        }

        public async Task<RespuestaDTO<RespuestaTasaAS400DTO>> ObtenerTasa()
        {
            try
            {
                return await genericaPersistenciaDatos.Get<RespuestaTasaAS400DTO>($"/api/Productos/obtener-tasa-cambio");
            }
            catch (Exception e)
            {
                return new RespuestaDTO<RespuestaTasaAS400DTO>
                {
                    Mensaje = "Ocurrio un error interno: " + e.Message,
                    Codigo = 500
                };
            }
        }

        public async Task<RespuestaDTO<DatosPrestamoDTO>> ValidaPrestamo(RequestValidaPrestamoDTO requestValidaPrestamoDTO)
        {
            try
            {
                return await genericaPersistenciaDatos
                    .Post<DatosPrestamoDTO, RequestValidaPrestamoDTO>(requestValidaPrestamoDTO, $"/api/Productos/validar-prestamo");
            }
            catch (Exception)
            {

                return new RespuestaDTO<DatosPrestamoDTO>
                {
                    Mensaje = "Ocurrio un error interno",
                    Codigo = 500
                };
            }
        }
    }
}
