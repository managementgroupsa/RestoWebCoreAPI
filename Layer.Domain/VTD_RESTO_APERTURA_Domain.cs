using System;
using System.Collections.Generic;
using Layer.Entity;
using Layer.AccessData;
using System.Threading.Tasks;

namespace Layer.Domain
{
    public class VTD_RESTO_APERTURA_Domain
    {
        public async Task<MENSAJE_Entity> CambiarEstadoPedido(VTD_RESTO_APERTURA_Entity entidad)
        {
            VTD_RESTO_APERTURA_Data oData = new VTD_RESTO_APERTURA_Data();
            return await oData.CambiarEstadoPedido(entidad);
        }

        public async Task<MENSAJE_Entity> CambiarMeseroPedido(VTD_RESTO_APERTURA_Entity entidad)
        {
            VTD_RESTO_APERTURA_Data oData = new VTD_RESTO_APERTURA_Data();
            return await oData.CambiarMeseroPedido(entidad);
        }

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

        public async Task<MENSAJE_Entity> EliminarRegistro(VTD_RESTO_APERTURA_Entity entidad)
        {
            VTD_RESTO_APERTURA_Data oData = new VTD_RESTO_APERTURA_Data();
            return await oData.EliminarRegistro(entidad);
        }

        public async Task<MENSAJE_Entity> AnularRegistro(VTD_RESTO_APERTURA_Entity entidad)
        {
            VTD_RESTO_APERTURA_Data oData = new VTD_RESTO_APERTURA_Data();
            return await oData.AnularRegistro(entidad);
        }
        
        public async Task<MENSAJE_Entity> InsertarRegistro(VTD_RESTO_APERTURA_Entity entidad)
        {
            VTD_RESTO_APERTURA_Data oData = new VTD_RESTO_APERTURA_Data();
            return await oData.InsertarRegistro(entidad);
        }

        public async Task<MENSAJE_Entity> EditarRegistro(VTD_RESTO_APERTURA_Entity entidad)
        {
            VTD_RESTO_APERTURA_Data oData = new VTD_RESTO_APERTURA_Data();
            return await oData.EditarRegistro(entidad);
        }
    }
}
