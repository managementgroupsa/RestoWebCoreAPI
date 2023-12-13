using Layer.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.AccessData
{
    public class VTD_RESTO_APERTURA_Data
    {
        private static string ConnectionString()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();
            var cadenaConexion = config["ConnectionStrings:ConnectionString"];


            return cadenaConexion;
        }

        public async Task<MENSAJE_Entity> CambiarMeseroPedido(VTD_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EditarRegistro("spVTD_RESTO_APERTURA", "CAMBIARMESEROPEDIDO", "Layer.Entity", "VTD_RESTO_APERTURA_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> CambiarEstadoPedido(VTD_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EditarRegistro("spVTD_RESTO_APERTURA", "CAMBIARESTADOPEDIDO", "Layer.Entity", "VTD_RESTO_APERTURA_Entity", entidad);
        }

        public async Task<List<object>> SeleccionarTodos(VTD_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.SeleccionarTodos("spVTD_RESTO_APERTURA", "BUSCARTODOS", "Layer.Entity", "VTD_RESTO_APERTURA_Entity", entidad);
        }

        public async Task<object> SeleccionarRegistro(VTD_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.SeleccionarRegistro("spVTD_RESTO_APERTURA", "BUSCARREGISTRO", "Layer.Entity", "VTD_RESTO_APERTURA_Entity", entidad);
        }
        
        public async Task<MENSAJE_Entity> AnularRegistro(VTD_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EliminarRegistro("spVTD_RESTO_APERTURA", "ANULAR", "Layer.Entity", "VTD_RESTO_APERTURA_Entity", entidad);
        }


        public async Task<MENSAJE_Entity> EliminarRegistro(VTD_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EliminarRegistro("spVTD_RESTO_APERTURA", "ELIMINAR", "Layer.Entity", "VTD_RESTO_APERTURA_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> InsertarRegistro(VTD_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.InsertarRegistro("spVTD_RESTO_APERTURA", "INSERTAR", "Layer.Entity", "VTD_RESTO_APERTURA_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> EditarRegistro(VTD_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EditarRegistro("spVTD_RESTO_APERTURA", "EDITAR", "Layer.Entity", "VTD_RESTO_APERTURA_Entity", entidad);
        }

    }
}
