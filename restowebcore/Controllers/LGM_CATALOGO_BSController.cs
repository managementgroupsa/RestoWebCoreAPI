using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Layer.Entity;
using Layer.Domain;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace restowebcore.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class LGM_CATALOGO_BSController : ControllerBase
    {        
        [HttpPost("SeleccionarTodos")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<List<object>> SeleccionarTodos(LGM_CATALOGO_BS_Entity entidad)
        {
            LGM_CATALOGO_BS_Domain oDominio = new LGM_CATALOGO_BS_Domain();
            return await oDominio.SeleccionarTodos(entidad);
        }

        [HttpPost("SeleccionarRegistro")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<object> SeleccionarRegistro(LGM_CATALOGO_BS_Entity entidad)
        {
            LGM_CATALOGO_BS_Domain oDominio = new LGM_CATALOGO_BS_Domain();
            return await oDominio.SeleccionarRegistro(entidad);
        }


        [HttpPost("EliminarRegistro")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<MENSAJE_Entity> EliminarRegistro(LGM_CATALOGO_BS_Entity entidad)
        {
            LGM_CATALOGO_BS_Domain oDominio = new LGM_CATALOGO_BS_Domain();

            return await oDominio.EliminarRegistro(entidad);
        }

        [HttpPost("InsertarRegistro")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<MENSAJE_Entity> InsertarRegistro(LGM_CATALOGO_BS_Entity entidades)
        {
            LGM_CATALOGO_BS_Domain oDominio = new LGM_CATALOGO_BS_Domain();

            return await oDominio.InsertarRegistro(entidades);

        }

        [HttpPost("EditarRegistro")]
        [Authorize(Roles = "Administrator,User")]
        public async Task<MENSAJE_Entity> EditarRegistro(LGM_CATALOGO_BS_Entity entidades)
        {
            LGM_CATALOGO_BS_Domain oDominio = new LGM_CATALOGO_BS_Domain();

            return await oDominio.EditarRegistro(entidades);

        }
    }
}