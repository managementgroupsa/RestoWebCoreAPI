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
    public class VTM_RESTO_MESAS : ControllerBase
    {
        [HttpPost("SeleccionarTodos")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<List<object>> SeleccionarTodos(VTM_RESTO_MESAS_Entity entidad)
        {
            VTM_RESTO_MESAS_Domain oDominio = new VTM_RESTO_MESAS_Domain();
            return await oDominio.SeleccionarTodos(entidad);
        }

        [HttpPost("SeleccionarRegistro")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<object> SeleccionarRegistro(VTM_RESTO_MESAS_Entity entidad)
        {
            VTM_RESTO_MESAS_Domain oDominio = new VTM_RESTO_MESAS_Domain();
            return await oDominio.SeleccionarRegistro(entidad);
        }



    }
}
