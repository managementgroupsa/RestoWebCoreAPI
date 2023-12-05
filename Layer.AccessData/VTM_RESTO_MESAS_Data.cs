using Layer.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.AccessData
{
    public class VTM_RESTO_MESAS_Data
    {
        private static string ConnectionString()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();
            var cadenaConexion = config["ConnectionStrings:ConnectionString"];


            return cadenaConexion;
        }


        public async Task<List<object>> SeleccionarTodos(VTM_RESTO_MESAS_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.SeleccionarTodos("spVTM_RESTO_MESAS", "BUSCARTODOS", "Layer.Entity", "VTM_RESTO_MESAS_Entity", entidad);
        }

        public async Task<object> SeleccionarRegistro(VTM_RESTO_MESAS_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.SeleccionarRegistro("spVTM_RESTO_MESAS", "BUSCARREGISTRO", "Layer.Entity", "VTM_RESTO_MESAS_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> EliminarRegistro(VTM_RESTO_MESAS_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EliminarRegistro("spVTM_RESTO_MESAS", "ELIMINAR", "Layer.Entity", "VTM_RESTO_MESAS_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> InsertarRegistro(VTM_RESTO_MESAS_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.InsertarRegistro("spVTM_RESTO_MESAS", "INSERTAR", "Layer.Entity", "VTM_RESTO_MESAS_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> EditarRegistro(VTM_RESTO_MESAS_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EditarRegistro("spVTM_RESTO_MESAS", "EDITAR", "Layer.Entity", "VTM_RESTO_MESAS_Entity", entidad);
        }



    }
}
