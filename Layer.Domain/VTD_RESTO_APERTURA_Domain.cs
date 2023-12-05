﻿using System;
using System.Collections.Generic;
using Layer.Entity;
using Layer.AccessData;
using System.Threading.Tasks;

namespace Layer.Domain
{
    public class VTD_RESTO_APERTURA_Domain
    {

        public async Task<List<object>> SeleccionarTodos(VTD_RESTO_APERTURA_Entity entidad)
        {
            VTD_RESTO_APERTURA_Data oData = new VTD_RESTO_APERTURA_Data();
            return await oData.SeleccionarTodos(entidad);
        }

        public async Task<object> SeleccionarRegistro(VTD_RESTO_APERTURA_Entity entidad)
        {
            VTD_RESTO_APERTURA_Data oData = new VTD_RESTO_APERTURA_Data();
            return await oData.SeleccionarRegistro(entidad);
        }


    }
}