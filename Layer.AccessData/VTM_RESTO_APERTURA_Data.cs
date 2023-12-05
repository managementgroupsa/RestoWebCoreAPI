using Layer.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.AccessData
{
    public class VTM_RESTO_APERTURA_Data
    {
        private static string ConnectionString()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();
            var cadenaConexion = config["ConnectionStrings:ConnectionString"];


            return cadenaConexion;
        }


        public async Task<List<object>> SeleccionarTodos(VTM_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.SeleccionarTodos("spVTM_RESTO_APERTURA", "BUSCARTODOS", "Layer.Entity", "VTM_RESTO_APERTURA_Entity", entidad);
        }

        public async Task<object> SeleccionarRegistro(VTM_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.SeleccionarRegistro("spVTM_RESTO_APERTURA", "BUSCARREGISTRO", "Layer.Entity", "VTM_RESTO_APERTURA_Entity", entidad);
        }


        public async Task<MENSAJE_Entity> EliminarRegistro(VTM_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EliminarRegistro("spVTM_RESTO_APERTURA", "ELIMINAR", "Layer.Entity", "VTM_RESTO_APERTURA_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> InsertarRegistro(VTM_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.InsertarRegistro("spVTM_RESTO_APERTURA", "INSERTAR", "Layer.Entity", "VTM_RESTO_APERTURA_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> EditarRegistro(VTM_RESTO_APERTURA_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EditarRegistro("spVTM_RESTO_APERTURA", "EDITAR", "Layer.Entity", "VTM_RESTO_APERTURA_Entity", entidad);
        }

    }
}
