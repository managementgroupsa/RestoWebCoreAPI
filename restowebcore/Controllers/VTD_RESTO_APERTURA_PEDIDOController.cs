using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Layer.Entity;
using Layer.Domain;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace restowebcore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VTD_RESTO_APERTURA_PEDIDOController : ControllerBase
    {


        [HttpPost("GrabarPedidoPorUsuario")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<MENSAJE_Entity> GrabarPedidoPorUsuario(VTD_RESTO_APERTURA_PEDIDO_Entity entidades)
        {
            VTD_RESTO_APERTURA_PEDIDO_Domain oDominio = new VTD_RESTO_APERTURA_PEDIDO_Domain();

            return await oDominio.GrabarPedidoPorUsuario(entidades);

        }


        [HttpPost("BuscarPedidosPorUsuario")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<List<object>> BuscarPedidosPorUsuario(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            VTD_RESTO_APERTURA_PEDIDO_Domain oDominio = new VTD_RESTO_APERTURA_PEDIDO_Domain();
            return await oDominio.BuscarPedidosPorUsuario(entidad);
        }

        [HttpPost("SeleccionarTodos")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<List<object>> SeleccionarTodos(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            VTD_RESTO_APERTURA_PEDIDO_Domain oDominio = new VTD_RESTO_APERTURA_PEDIDO_Domain();
            return await oDominio.SeleccionarTodos(entidad);
        }

        [HttpPost("SeleccionarRegistro")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<object> SeleccionarRegistro(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            VTD_RESTO_APERTURA_PEDIDO_Domain oDominio = new VTD_RESTO_APERTURA_PEDIDO_Domain();
            return await oDominio.SeleccionarRegistro(entidad);
        }

        [HttpPost("EliminarRegistro")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<MENSAJE_Entity> EliminarRegistro(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            VTD_RESTO_APERTURA_PEDIDO_Domain oDominio = new VTD_RESTO_APERTURA_PEDIDO_Domain();

            return await oDominio.EliminarRegistro(entidad);
        }

        [HttpPost("InsertarRegistro")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<MENSAJE_Entity> InsertarRegistro(VTD_RESTO_APERTURA_PEDIDO_Entity entidades)
        {
            VTD_RESTO_APERTURA_PEDIDO_Domain oDominio = new VTD_RESTO_APERTURA_PEDIDO_Domain();

            return await oDominio.InsertarRegistro(entidades);

        }

        [HttpPost("EditarRegistro")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<MENSAJE_Entity> EditarRegistro(VTD_RESTO_APERTURA_PEDIDO_Entity entidades)
        {
            VTD_RESTO_APERTURA_PEDIDO_Domain oDominio = new VTD_RESTO_APERTURA_PEDIDO_Domain();

            return await oDominio.EditarRegistro(entidades);

        }

    }
}
