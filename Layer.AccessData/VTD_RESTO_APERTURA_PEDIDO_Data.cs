using Layer.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.AccessData
{
    public class VTD_RESTO_APERTURA_PEDIDO_Data
    {
        private static string ConnectionString()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();
            var cadenaConexion = config["ConnectionStrings:ConnectionString"];


            return cadenaConexion;
        }



        public async Task<MENSAJE_Entity> GrabarPedidoPorUsuario(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.InsertarRegistro("spVTD_RESTO_APERTURA_PEDIDO", "INSERTAR", "Layer.Entity", "VTD_RESTO_APERTURA_PEDIDO_Entity", entidad);
        }

        public async Task<List<object>> BuscarPedidosPorUsuario(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.SeleccionarTodos("spVTD_RESTO_APERTURA_PEDIDO", "BUSCAPEDIDOSXUSER", "Layer.Entity", "VTD_RESTO_APERTURA_PEDIDO_Entity", entidad);
        }

        public async Task<List<object>> SeleccionarTodos(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.SeleccionarTodos("spVTD_RESTO_APERTURA_PEDIDO", "BUSCARTODOS", "Layer.Entity", "VTD_RESTO_APERTURA_PEDIDO_Entity", entidad);
        }

        public async Task<object> SeleccionarRegistro(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.SeleccionarRegistro("spVTD_RESTO_APERTURA_PEDIDO", "BUSCARREGISTRO", "Layer.Entity", "VTD_RESTO_APERTURA_PEDIDO_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> EliminarRegistro(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EliminarRegistro("spVTD_RESTO_APERTURA_PEDIDO", "ELIMINAR", "Layer.Entity", "VTD_RESTO_APERTURA_PEDIDO_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> InsertarRegistro(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.InsertarRegistro("spVTD_RESTO_APERTURA_PEDIDO", "INSERTAR", "Layer.Entity", "VTD_RESTO_APERTURA_PEDIDO_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> EditarRegistro(VTD_RESTO_APERTURA_PEDIDO_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EditarRegistro("spVTD_RESTO_APERTURA_PEDIDO", "EDITAR", "Layer.Entity", "VTD_RESTO_APERTURA_PEDIDO_Entity", entidad);
        }

    }
}
