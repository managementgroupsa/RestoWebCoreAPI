﻿using System;
using System.Collections.Generic;
using Layer.Entity;
using Layer.AccessData;
using System.Threading.Tasks;

namespace Layer.Domain
{
    public class VTM_RESTO_MESAS_Domain
    {

        public async Task<List<object>> SeleccionarTodos(VTM_RESTO_MESAS_Entity entidad)
        {
            VTM_RESTO_MESAS_Data oData = new VTM_RESTO_MESAS_Data();
            return await oData.SeleccionarTodos(entidad);
        }

        public async Task<object> SeleccionarRegistro(VTM_RESTO_MESAS_Entity entidad)
        {
            VTM_RESTO_MESAS_Data oData = new VTM_RESTO_MESAS_Data();
            return await oData.SeleccionarRegistro(entidad);
        }


    }
}