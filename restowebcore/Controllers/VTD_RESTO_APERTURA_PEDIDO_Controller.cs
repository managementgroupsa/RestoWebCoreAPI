using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Layer.Entity;
using Layer.Domain;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace CodesicorpCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VTD_RESTO_APERTURA_PEDIDO_Controller : ControllerBase
    {
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



    }
}
