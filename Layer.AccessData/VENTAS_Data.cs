using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Layer.Entity;
using Microsoft.Extensions.Configuration;

using Newtonsoft.Json;

namespace Layer.AccessData
{
    public class VENTAS_Data
    {
        private SqlConnection conectar;
        private SqlTransaction tran;
        private SqlCommand comando;
        private SqlCommand comandoDet;
        private SqlCommand comandoCuo;

        private static string ConnectionString()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();
            var cadenaConexion = config["ConnectionStrings:ConnectionString"];

            return cadenaConexion;
        }

        private void Inicia()
        {
            try
            {
                conectar = new SqlConnection();
                conectar.ConnectionString = ConnectionString();
                conectar.Open();
            }
            catch
            {
            }
        }

        public void Finaliza()
        {
            // cerramos la conexion
            if (conectar.State != ConnectionState.Closed)
                conectar.Close();
            // destruimos la conexion
            conectar.Dispose();
        }


 
        public async Task<MENSAJE_Entity> ActualizaEstadoSunat(Estado_Documento oEntidad, string cEmpresa, string cAnio, string cNummov, string cValidaSunat, string cTipoDoc)
        {
            string jsonText = JsonConvert.SerializeObject(oEntidad);

            MENSAJE_Entity oResultado = new MENSAJE_Entity();
            Int32 recordsAffected = 0;

            Inicia();
            try
            {
                tran = conectar.BeginTransaction();

                comando = new SqlCommand("spVTM_DOC_VENTA", conectar);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Transaction = tran;

                string cAccion = "";

                if (cTipoDoc == "01" || cTipoDoc == "03")
                    cAccion = "ACTUALIZA_ESTADO";

                if (cTipoDoc == "07")
                    cAccion = "ACTUALIZA_ESTADO_NC";

                if (cTipoDoc == "08")
                    cAccion = "ACTUALIZA_ESTADO_ND";

                if (cTipoDoc == "09")
                    cAccion = "ACTUALIZA_ESTADO_GR";


                SqlParameter prm0 = new SqlParameter("@Accion", cAccion);

                SqlParameter prm1 = new SqlParameter("@Emp_cCodigo", cEmpresa);
                SqlParameter prm2 = new SqlParameter("@Pan_cAnio", cAnio);
                SqlParameter prm3 = new SqlParameter("@Dvm_cNumMov", cNummov);
                SqlParameter prm4 = new SqlParameter("@cOtrosAtri", jsonText);
                SqlParameter prm5 = new SqlParameter("@Dvm_cValidaSunat", cValidaSunat);


                comando.Parameters.Add(prm0);
                comando.Parameters.Add(prm1);
                comando.Parameters.Add(prm2);
                comando.Parameters.Add(prm3);
                comando.Parameters.Add(prm4);
                comando.Parameters.Add(prm5);

                recordsAffected = comando.ExecuteNonQuery();

                tran.Commit();

                Finaliza();

                oResultado.Codigo = "";
                oResultado.Mensaje = cNummov;
                oResultado.Resultado = "OK";
                oResultado.FilasAfectadas = recordsAffected;

            }
            catch (SqlException e)
            {
                oResultado.Codigo = e.ErrorCode.ToString();
                oResultado.Mensaje = e.Message;
                oResultado.Resultado = "ERROR";
                oResultado.FilasAfectadas = recordsAffected;

                tran.Rollback();
                Finaliza();
            }
            catch (Exception e)
            {
                oResultado.Codigo = e.Source;
                oResultado.Mensaje = e.Message;
                oResultado.Resultado = "ERROR";
                oResultado.FilasAfectadas = recordsAffected;

                tran.Rollback();
                Finaliza();
            }
            finally
            {
                Finaliza();
            }

            return oResultado;
        }
        public async Task<MENSAJE_Entity> ActualizaEstadoAnulacion(Estado_Documento oEntidad, string cEmpresa, string cAnio, string cNummov, string cValidaSunat, string cTipoDoc)
        {
            string jsonText = JsonConvert.SerializeObject(oEntidad);

            MENSAJE_Entity oResultado = new MENSAJE_Entity();
            Int32 recordsAffected = 0;

            Inicia();
            try
            {
                tran = conectar.BeginTransaction();

                comando = new SqlCommand("spVTM_DOC_VENTA", conectar);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Transaction = tran;

                string cAccion = "";

                if (cTipoDoc == "01" || cTipoDoc == "03")
                    cAccion = "ACTUALIZA_ESTADO_ANULACION";

                if (cTipoDoc == "07")
                    cAccion = "ACTUALIZA_ESTADO_ANULACION_NC";

                if (cTipoDoc == "08")
                    cAccion = "ACTUALIZA_ESTADO_ANULACION_ND";


                SqlParameter prm0 = new SqlParameter("@Accion", cAccion);

                SqlParameter prm1 = new SqlParameter("@Emp_cCodigo", cEmpresa);
                SqlParameter prm2 = new SqlParameter("@Pan_cAnio", cAnio);
                SqlParameter prm3 = new SqlParameter("@Dvm_cNumMov", cNummov);
                SqlParameter prm4 = new SqlParameter("@cOtrosAtri", jsonText);
                SqlParameter prm5 = new SqlParameter("@Dvm_cValidaSunat", cValidaSunat);


                comando.Parameters.Add(prm0);
                comando.Parameters.Add(prm1);
                comando.Parameters.Add(prm2);
                comando.Parameters.Add(prm3);
                comando.Parameters.Add(prm4);
                comando.Parameters.Add(prm5);

                recordsAffected = comando.ExecuteNonQuery();

                tran.Commit();

                Finaliza();

                oResultado.Codigo = "";
                oResultado.Mensaje = cNummov;
                oResultado.Resultado = "OK";
                oResultado.FilasAfectadas = recordsAffected;

            }
            catch (SqlException e)
            {
                oResultado.Codigo = e.ErrorCode.ToString();
                oResultado.Mensaje = e.Message;
                oResultado.Resultado = "ERROR";
                oResultado.FilasAfectadas = recordsAffected;

                tran.Rollback();
                Finaliza();
            }
            catch (Exception e)
            {
                oResultado.Codigo = e.Source;
                oResultado.Mensaje = e.Message;
                oResultado.Resultado = "ERROR";
                oResultado.FilasAfectadas = recordsAffected;

                tran.Rollback();
                Finaliza();
            }
            finally
            {
                Finaliza();
            }

            return oResultado;
        }
        public async Task<MENSAJE_Entity> GrabaVenta(VENTAS_Entity oEntidad)
        {
            MENSAJE_Entity oResultado = new MENSAJE_Entity();
            Int32 recordsAffected = 0;
            string query = "";
            string jsonText = JsonConvert.SerializeObject(oEntidad);

            string cEmpresa = oEntidad.Cabecera.Emp_cCodigo ;
            string cAnio = oEntidad.Cabecera.Pan_cAnio ;
            string cNummov = oEntidad.Cabecera.Res_cNummov;
            string cPuntoVenta = oEntidad.Cabecera.Pvt_cCodigo ;
            string cMesa = oEntidad.Detalles.Mes_cCodigo; 

            string cAccion = "INSERTAR";

            Inicia();
            try
            {


                tran = conectar.BeginTransaction();


                //---------------------------------------------------------------------------------------------
                if (!string.IsNullOrEmpty(cNummov))
                {
                    query = "exec VTD_RESTO_APERTURA_PEDIDO 'ELIMINARTODOS', '" + cEmpresa + "', '" + cAnio + "', '" + cNummov  + "', '" + cPuntoVenta + "','','','" + cMesa + "'  ";

                    SqlDataAdapter Da = new SqlDataAdapter(query, conectar);
                    DataTable dtResult = new DataTable();

                    Da.SelectCommand.Transaction = tran;
                    Da.Fill(dtResult);

                    cNummov = dtResult.Rows[0]["Valor"].ToString();
                }

                //---------------------------------------------------------------------------------------------




                //---------------------------------------------------------------------------------------------
                foreach (var pedido in oEntidad.Pedidos )
                {

                    comando = new SqlCommand("VTD_RESTO_APERTURA_PEDIDO", conectar);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Transaction = tran;

                    SqlParameter prm0 = new SqlParameter("@Accion", cAccion);
                    SqlParameter prm1 = new SqlParameter("@Emp_cCodigo", pedido.Emp_cCodigo);
                    SqlParameter prm2 = new SqlParameter("@Pan_cAnio", pedido.Pan_cAnio);
                    SqlParameter prm3 = new SqlParameter("@Res_cNummov", cNummov);
                    SqlParameter prm4 = new SqlParameter("@Pvt_cCodigo", pedido.Pvt_cCodigo);
                    SqlParameter prm5 = new SqlParameter("@Ped_cNummov", pedido.Ped_cNummov);
                    SqlParameter prm6 = new SqlParameter("@Mes_cCodigo", pedido.Mes_cCodigo );
                    SqlParameter prm7 = new SqlParameter("@Ped_nItem", pedido.Ped_nItem  );
                    SqlParameter prm8 = new SqlParameter("@Cab_cCatalogo", pedido.Cab_cCatalogo );
                    SqlParameter prm9 = new SqlParameter("@Ped_nCantidad", pedido.Ped_nCantidad );
                    SqlParameter prm10 = new SqlParameter("@Ped_cComentario", pedido.Ped_cComentario );
                    SqlParameter prm11 = new SqlParameter("@Ped_cEstado", pedido.Ped_cEstado );
                    SqlParameter prm12 = new SqlParameter("@Ped_cUser", pedido.Ped_cUser );

                    comando.Parameters.Add(prm0);
                    comando.Parameters.Add(prm1);
                    comando.Parameters.Add(prm2);
                    comando.Parameters.Add(prm3);
                    comando.Parameters.Add(prm4);
                    comando.Parameters.Add(prm5);
                    comando.Parameters.Add(prm6);
                    comando.Parameters.Add(prm7);
                    comando.Parameters.Add(prm8);
                    comando.Parameters.Add(prm9);
                    comando.Parameters.Add(prm10);
                    comando.Parameters.Add(prm11);
                    comando.Parameters.Add(prm12);

                    recordsAffected = comando.ExecuteNonQuery();

                }
                


                //---------------------------------------------------------------------------------------------

                tran.Commit();

                Finaliza();

                oResultado.Codigo = "";
                oResultado.Mensaje = cNummov;
                oResultado.Resultado = "OK";
                oResultado.FilasAfectadas = recordsAffected;

            }
            catch (SqlException e)
            {
                oResultado.Codigo = e.ErrorCode.ToString();
                oResultado.Mensaje = e.Message;
                oResultado.Resultado = "ERROR";
                oResultado.FilasAfectadas = recordsAffected;

                tran.Rollback();
                Finaliza();
            }
            catch (Exception e)
            {
                oResultado.Codigo = e.Source;
                oResultado.Mensaje = e.Message;
                oResultado.Resultado = "ERROR";
                oResultado.FilasAfectadas = recordsAffected;

                tran.Rollback();
                Finaliza();
            }
            finally
            {
                Finaliza();
            }

            return oResultado;

        }


    }
}

