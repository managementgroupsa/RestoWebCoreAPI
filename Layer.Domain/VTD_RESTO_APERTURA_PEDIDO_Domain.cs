using System;
using System.Collections.Generic;
using Layer.Entity;
using Layer.AccessData;
using System.Threading.Tasks;

namespace Layer.Domain
{
    public class VTD_RESTO_APERTURA_PEDIDO_Domain
    {



        public async Task<MENSAJE_Entity> GrabarPedidoPorUsuario(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            VTD_RESTO_APERTURA_PEDIDO_Data oData = new VTD_RESTO_APERTURA_PEDIDO_Data();
            return await oData.GrabarPedidoPorUsuario(entidad);
        }

        public async Task<List<object>> BuscarPedidosPorUsuario(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            VTD_RESTO_APERTURA_PEDIDO_Data oData = new VTD_RESTO_APERTURA_PEDIDO_Data();
            return await oData.BuscarPedidosPorUsuario(entidad);
        }

        public async Task<List<object>> SeleccionarTodos(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            VTD_RESTO_APERTURA_PEDIDO_Data oData = new VTD_RESTO_APERTURA_PEDIDO_Data();
            return await oData.SeleccionarTodos(entidad);
        }

        public async Task<object> SeleccionarRegistro(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            VTD_RESTO_APERTURA_PEDIDO_Data oData = new VTD_RESTO_APERTURA_PEDIDO_Data();
            return await oData.SeleccionarRegistro(entidad);
        }

        public async Task<MENSAJE_Entity> EliminarRegistro(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            VTD_RESTO_APERTURA_PEDIDO_Data oData = new VTD_RESTO_APERTURA_PEDIDO_Data();
            return await oData.EliminarRegistro(entidad);
        }

        public async Task<MENSAJE_Entity> InsertarRegistro(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            VTD_RESTO_APERTURA_PEDIDO_Data oData = new VTD_RESTO_APERTURA_PEDIDO_Data();
            return await oData.InsertarRegistro(entidad);
        }

        public async Task<MENSAJE_Entity> EditarRegistro(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            VTD_RESTO_APERTURA_PEDIDO_Data oData = new VTD_RESTO_APERTURA_PEDIDO_Data();
            return await oData.EditarRegistro(entidad);
        }
    }
}
