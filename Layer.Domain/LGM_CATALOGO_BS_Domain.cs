using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.AccessData;
using Layer.Entity;


namespace Layer.Domain
{
    public class LGM_CATALOGO_BS_Domain
    {

        public async Task<List<object>> SeleccionarTodos(LGM_CATALOGO_BS_Entity entidad)
        {
            LGM_CATALOGO_BS_Data oData = new LGM_CATALOGO_BS_Data();
            return await oData.SeleccionarTodos(entidad);
        }

        public async Task<object> SeleccionarRegistro(LGM_CATALOGO_BS_Entity entidad)
        {
            LGM_CATALOGO_BS_Data oData = new LGM_CATALOGO_BS_Data();
            return await oData.SeleccionarRegistro(entidad);
        }

        public async Task<MENSAJE_Entity> EliminarRegistro(LGM_CATALOGO_BS_Entity entidad)
        {
            LGM_CATALOGO_BS_Data oData = new LGM_CATALOGO_BS_Data();
            return await oData.EliminarRegistro(entidad);
        }

        public async Task<MENSAJE_Entity> InsertarRegistro(LGM_CATALOGO_BS_Entity entidad)
        {
            LGM_CATALOGO_BS_Data oData = new LGM_CATALOGO_BS_Data();
            return await oData.InsertarRegistro(entidad);
        }

        public async Task<MENSAJE_Entity> EditarRegistro(LGM_CATALOGO_BS_Entity entidad)
        {
            LGM_CATALOGO_BS_Data oData = new LGM_CATALOGO_BS_Data();
            return await oData.EditarRegistro(entidad);
        }
    }
}
