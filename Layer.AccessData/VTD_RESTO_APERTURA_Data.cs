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



    }
}
