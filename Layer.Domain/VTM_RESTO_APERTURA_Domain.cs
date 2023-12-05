using System;
using System.Collections.Generic;
using Layer.Entity;
using Layer.AccessData;
using System.Threading.Tasks;

namespace Layer.Domain
{
    public class VTM_RESTO_APERTURA_Domain
    {

        public async Task<List<object>> SeleccionarTodos(VTM_RESTO_APERTURA_Entity entidad)
        {
            VTM_RESTO_APERTURA_Data oData = new VTM_RESTO_APERTURA_Data();
            return await oData.SeleccionarTodos(entidad);
        }

        public async Task<object> SeleccionarRegistro(VTM_RESTO_APERTURA_Entity entidad)
        {
            VTM_RESTO_APERTURA_Data oData = new VTM_RESTO_APERTURA_Data();
            return await oData.SeleccionarRegistro(entidad);
        }


    }
}
