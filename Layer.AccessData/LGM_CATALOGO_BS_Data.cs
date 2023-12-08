using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Layer.Entity;
using Microsoft.Extensions.Configuration;

namespace Layer.AccessData
{
    public class LGM_CATALOGO_BS_Data
    {
        private static string ConnectionString()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();
            var cadenaConexion = config["ConnectionStrings:ConnectionString"];

            return cadenaConexion;
        }

        public async Task<List<object>> SeleccionarTodos(LGM_CATALOGO_BS_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.SeleccionarTodos("spLGM_CATALOGO_BS", "BUSCARTODOS", "Layer.Entity", "LGM_CATALOGO_BS_Entity", entidad);
        }

        public async Task<object> SeleccionarRegistro(LGM_CATALOGO_BS_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.SeleccionarRegistro("spLGM_CATALOGO_BS", "BUSCARREGISTRO", "Layer.Entity", "LGM_CATALOGO_BS_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> EliminarRegistro(LGM_CATALOGO_BS_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EliminarRegistro("spLGM_CATALOGO_BS", "ELIMINAR", "Layer.Entity", "LGM_CATALOGO_BS_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> InsertarRegistro(LGM_CATALOGO_BS_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.InsertarRegistro("spLGM_CATALOGO_BS", "INSERTAR", "Layer.Entity", "LGM_CATALOGO_BS_Entity", entidad);
        }

        public async Task<MENSAJE_Entity> EditarRegistro(LGM_CATALOGO_BS_Entity entidad)
        {
            GENERAL_Data oData = new GENERAL_Data();
            return await oData.EditarRegistro("spLGM_CATALOGO_BS", "EDITAR", "Layer.Entity", "LGM_CATALOGO_BS_Entity", entidad);
        }
    }
}