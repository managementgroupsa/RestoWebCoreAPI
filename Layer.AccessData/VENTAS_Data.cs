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


 
    public async Task<MENSAJE_Entity> GrabaPedido(VENTAS_Entity oEntidad)
        {
            MENSAJE_Entity oResultado = new MENSAJE_Entity();
            Int32 recordsAffected = 0;
            string query = "";
            string jsonText = JsonConvert.SerializeObject(oEntidad);

            string Emp_cCodigo = oEntidad.Cabecera.Emp_cCodigo ;
            string Pan_cAnio = oEntidad.Cabecera.Pan_cAnio ;
            string Res_cNummov = oEntidad.Cabecera.Res_cNummov;
            string Pvt_cCodigo = oEntidad.Cabecera.Pvt_cCodigo ;
            string Ped_cNummov = oEntidad.Detalle.Ped_cNummov; 
            string Mes_cCodigo = oEntidad.Detalle.Mes_cCodigo; 

            string cAccion = "INSERTAR";

            Inicia();
            try
            {


                tran = conectar.BeginTransaction();


                //---------------------------------------------------------------------------------------------
                if (!string.IsNullOrEmpty(Ped_cNummov))
                {
                    cAccion = "EDITAR";

                    query = "exec spVTD_RESTO_APERTURA_PEDIDO 'ELIMINARTODOS', '" + Emp_cCodigo + "', '" + Pan_cAnio + "' , '" + Res_cNummov + "' , '" + Pvt_cCodigo + "' , '" + Ped_cNummov + "' ";

                    SqlDataAdapter DaeElimina = new SqlDataAdapter(query, conectar);
                    DataTable dtResultElimina = new DataTable();

                    DaeElimina.SelectCommand.Transaction = tran;
                    DaeElimina.Fill(dtResultElimina);

                }
                else
                {
                    query = "exec spVTD_RESTO_APERTURA 'SIGUIENTECODIGO', '" + Emp_cCodigo + "', '" + Pan_cAnio + "' , '" + Res_cNummov + "' , '" + Pvt_cCodigo + "' ";

                    SqlDataAdapter Da = new SqlDataAdapter(query, conectar);
                    DataTable dtResult = new DataTable();

                    Da.SelectCommand.Transaction = tran;
                    Da.Fill(dtResult);

                    Ped_cNummov = dtResult.Rows[0]["Valor"].ToString();

                }


                //---------------------------------------------------------------------------------------------
                foreach (var pedido in oEntidad.Pedidos )
                {

                    comando = new SqlCommand("spVTD_RESTO_APERTURA_PEDIDO", conectar);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Transaction = tran;

                    SqlParameter prm0 = new SqlParameter("@Accion", "INSERTAR");
                    SqlParameter prm1 = new SqlParameter("@Emp_cCodigo", Emp_cCodigo);
                    SqlParameter prm2 = new SqlParameter("@Pan_cAnio", Pan_cAnio);
                    SqlParameter prm3 = new SqlParameter("@Res_cNummov", Res_cNummov);
                    SqlParameter prm4 = new SqlParameter("@Pvt_cCodigo", Pvt_cCodigo);
                    SqlParameter prm5 = new SqlParameter("@Ped_cNummov", Ped_cNummov);

                    
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
                oResultado.Mensaje = Ped_cNummov;
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

