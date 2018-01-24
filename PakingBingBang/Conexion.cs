using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using CrypterPass;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PakingBingBang
{
    public class Conexion
    {
        public string SERVER = "";
        public string BD = "";
        public string US = "";
        public string PASS = "";

        public string SERV
        {
            get { return SERVER = Crypt.Desencriptar(ConfigurationManager.AppSettings["server"]); }
        }
        public string BASE
        {
            get { return BD = Crypt.Desencriptar(ConfigurationManager.AppSettings["database"]); }
        }

        public string USER
        {
            get { return US = Crypt.Desencriptar(ConfigurationManager.AppSettings["username"]); }
        }

        public string PASSWORD
        {
            get { return PASS = Crypt.Desencriptar(ConfigurationManager.AppSettings["password"]); }
        }

        SqlConnection con ;


        public string cadena()
        {
            string cad = "", server = "", db = "", user = "", pass = "";
            server = Crypt.Desencriptar(ConfigurationManager.AppSettings["server"]);
            db = Crypt.Desencriptar(ConfigurationManager.AppSettings["database"]);
            user = Crypt.Desencriptar(ConfigurationManager.AppSettings["username"]);
            pass = Crypt.Desencriptar(ConfigurationManager.AppSettings["password"]);
            cad = "Server= " + server + "; database= " + db + "; user id=" + user + "; Password= " + pass + "; Connection TimeOut=7";

            return cad;
        }

        public void Ordenes(FRMBuscaOrd f, string orden)
        {
            string consulta = "select v.ID, v.MovID AS Orden, c.Cliente + '  '+ c.Nombre AS Nombre, c.Direccion + ' '+ c.Poblacion as Direccion,ISNULL(a.nombre,'N/A') as Agente from Venta v with(nolock) LEFT JOIN Cte c WITH(NOLOCK) ON c.Cliente = v.Cliente LEFT JOIN Agente a WITH(NOLOCK) ON a.Agente = v.Agente where Mov = 'Orden Surtido'  and v.MovID = '" + orden + "'";
            con = new SqlConnection(cadena());
            SqlCommand com = new SqlCommand(consulta, con);
            con.Open();
            com.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr;
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (!f.dgvXOrdenes.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["OrdSurt"].Value) == orden))
                {
                    f.dgvXOrdenes.Rows.Add(dr["ID"].ToString(), dr["Orden"].ToString(), dr["Nombre"].ToString(), dr["Direccion"].ToString(), dr["Agente"].ToString(), true);
                }
            }
            con.Close();
        }

        public List<string> listaCat(int id)
        {
            string sp = "SP_Detalle_Packing";
            List<string> result = new List<string>();
            con = new SqlConnection(cadena());
            SqlCommand com = new SqlCommand(sp, con);
            con.Open();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "CAT";
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                result.Add(dr[0].ToString());
            }
            con.Close();
            dr.Close();
            return result;

        }

        public void dgvT(ctrlGridDetalleTop top, int id)
        {
            string sp = "SP_Detalle_Packing";
            con = new SqlConnection(cadena());
            SqlCommand com = new SqlCommand(sp, con);
            con.Open();
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "TODO";
            com.Parameters.Add("@Filtro", SqlDbType.VarChar).Value = "TOPS";
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                top.dgvXT2.Rows.Add(dr["ID"], dr["Articulo"], dr["descripcion1"], dr["Color"], dr["Cant1"], dr["Cant2"], dr["Cant3"], dr["Cant4"], dr["Cant5"], dr["Cant6"], dr["Cant7"], dr["Cant8"], dr["Cant9"], dr["Cant10"], dr["Cant11"], dr["Cant12"], dr["Cant13"], dr["Cant14"], dr["Cant15"], 0, dr["Cantidad"],dr["nColor"]);
            }
            con.Close();
            dr.Close();
            NotSortable(top.dgvXT2);
        }

        public void dgvBC(ctrlGridDetalleBC top, int id)
        {
            string sp = "SP_Detalle_Packing";
            con = new SqlConnection(cadena());
            SqlCommand com = new SqlCommand(sp, con);
            con.Open();
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "TODO";
            com.Parameters.Add("@Filtro", SqlDbType.VarChar).Value = "BC";
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                top.dataGridViewX1.Rows.Add(dr["ID"], dr["Articulo"], dr["descripcion1"], dr["Color"], dr["Cant1"], dr["Cant2"], dr["Cant3"], dr["Cant4"], dr["Cant5"], dr["Cant6"], dr["Cant7"], dr["Cant8"], dr["Cant9"], dr["Cant10"], dr["Cant11"], dr["Cant12"], dr["Cant13"], dr["Cant14"], dr["Cant15"], 0, dr["Cantidad"], dr["nColor"]);
            }
            con.Close();
            dr.Close();
            NotSortable(top.dataGridViewX1);
        }

        public void dgvBD(ctrlGridDetalleBD top, int id)
        {
            string sp = "SP_Detalle_Packing";
            con = new SqlConnection(cadena());
            SqlCommand com = new SqlCommand(sp, con);
            con.Open();
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "TODO";
            com.Parameters.Add("@Filtro", SqlDbType.VarChar).Value = "BD";
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                top.dgvXT1.Rows.Add(dr["ID"], dr["Articulo"], dr["descripcion1"], dr["Color"], dr["Cant1"], dr["Cant2"], dr["Cant3"], dr["Cant4"], dr["Cant5"], dr["Cant6"], dr["Cant7"], dr["Cant8"], dr["Cant9"], dr["Cant10"], dr["Cant11"], dr["Cant12"], dr["Cant13"], dr["Cant14"], dr["Cant15"], 0, dr["Cantidad"], dr["nColor"]);
            }
            con.Close();
            dr.Close();
            NotSortable(top.dgvXT1);
        }

        public void dgvUN(ctrlGridDetalle top, int id)
        {
            string sp = "SP_Detalle_Packing";
            con = new SqlConnection(cadena());
            SqlCommand com = new SqlCommand(sp, con);
            con.Open();
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "TODO";
            com.Parameters.Add("@Filtro", SqlDbType.VarChar).Value = "UN";
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                top.dgvXdetalle.Rows.Add(dr["ID"], dr["Articulo"], dr["descripcion1"], dr["Color"], dr["Cant1"], dr["Cant2"], dr["Cant3"], dr["Cant4"], dr["Cant5"], dr["Cant6"], dr["Cant7"], dr["Cant8"], dr["Cant9"], dr["Cant10"], dr["Cant11"], dr["Cant12"], dr["Cant13"], dr["Cant14"], dr["Cant15"], 0, dr["Cantidad"], dr["nColor"]);
            }

            con.Close();
            dr.Close();

            NotSortable(top.dgvXdetalle);
        }

        void NotSortable(DataGridView dgv)
        {
            for (int x = 0; x < dgv.Columns.Count; x++)
            {
                dgv.Columns[x].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public int GeneraIDpacking()
        {
            int new_id = 0;
            string sp = "SP_Packing_Insert";

            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "G_IDPACKING";
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                new_id = dr.GetInt32(0);
                dr.Close();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error al generar id packing" + e.Message);
            }
            return new_id;

        }

        public void GeneraDetallePack(int idP, int Orden)
        {
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "G_DETALLE_PACK";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idP;
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = Orden;
                com.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("error al generar detalle packing" + e.Message);
            }

        }

        public void InfoArticulosLineal(FRM_agregarArticulos f, int id_v, int orden, int id_pack)
        {
            string sp = "SP_Detalle_Packing";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = id_v;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "DET_LINEAL";
                com.Parameters.Add("@IdPacking", SqlDbType.Int).Value = id_pack;
                com.Parameters.Add("@orden", SqlDbType.Int).Value = orden;                
                
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    f.dgvArticulos.Rows.Add(dr["ID"], dr["Subcuenta"], dr["Articulo"], dr["Familia"], dr["nombre"], dr["Cantidad"], dr["Nombre"], dr["EnCaja"], dr["CODIGO"], dr["MovID"]);
                }
                dr.Close();
                con.Close();
                NotSortable(f.dgvArticulos);

            }
            catch (Exception e)
            {
                MessageBox.Show("error al desplegar informacion de artriculos" + e.Message);
            }
        }

        public void DetalleDeCaja( FRM_DET_CAJAS frm , int idpack, int idcaja)
        {
            string sp = "SP_Detalle_Packing";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "DET_CAJA";
                com.Parameters.Add("@orden", SqlDbType.Int).Value = idcaja;
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    frm.dgvDetalle.Rows.Add(dr["ORDEN"], dr["ARTICULO"], dr["TALLA"], dr["COLOR"], dr["CANTIDAD"], dr["EN_CAJA"]);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error al DetalleDeCaja" + ex.Message);
            }
        }

        public bool UpdateCaja(int idpack, int idcaja, string dimenciones, decimal pesoB, decimal pesoN, decimal Tara)
        {
            string update = "SP_update_caja";
            bool res = false;
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(update, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@IDdimenciones", SqlDbType.Int).Value = Convert.ToInt32(dimenciones);
                com.Parameters.Add("@Tara", SqlDbType.VarChar).Value = Tara;
                com.Parameters.Add("@PesoN", SqlDbType.Decimal).Value = pesoN;
                com.Parameters.Add("@PesoB", SqlDbType.Decimal).Value = pesoB;
                com.Parameters.Add("@idcaja", SqlDbType.Int).Value = idcaja;
                com.Parameters.Add("@idpack", SqlDbType.Int).Value = idpack;
                com.ExecuteNonQuery();
                con.Close();
                res = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error UpdateCaja" + ex.Message);
                res = false;
            }
            return res;
        }

        public int GeneraIDCAJA(int id_packing)
        {
            int new_id = 0;
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = id_packing;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "G_IDBOX";
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                new_id = dr.GetInt32(0);
                dr.Close();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error al generar id caja" + e.Message);
            }
            return new_id;

        }

        public void Modas ( FRM_agregarArticulos frm)
        {
            string sp = "SP_Detalle_Packing";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = 0;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "MODAS";
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if(ds.Tables.Count > 0)
                {
                    frm.cmbXModa.DataSource = ds.Tables[0];
                    frm.cmbXModa.ValueMember = "ID";
                    frm.cmbXModa.DisplayMember = "MODA";                    
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error al generar Modas" + e.Message);
            }
        }

        public void Modas(FRM_DET_CAJAS frm)
        {
            string sp = "SP_Detalle_Packing";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = 0;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "MODAS";
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    frm.cmbXModa.DataSource = ds.Tables[0];
                    frm.cmbXModa.ValueMember = "ID";
                    frm.cmbXModa.DisplayMember = "MODA";
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error al generar Modas" + e.Message);
            }
        }

        public void Detalle_Caja(int idcaja, int idpacking, int idorden, string art, string subcuenta, int cantidad, int escaneos, string codigo)
        {
            string sp = "SP_Packing_DetCaja";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@Id_Caja", SqlDbType.Int).Value = idcaja;
                com.Parameters.Add("@Id_Packing", SqlDbType.Int).Value = idpacking;
                com.Parameters.Add("@Id_Orden", SqlDbType.Int).Value = idorden;
                com.Parameters.Add("@Art", SqlDbType.VarChar).Value = art;
                com.Parameters.Add("@SubCuenta", SqlDbType.VarChar).Value = subcuenta;
                com.Parameters.Add("@Cantidad", SqlDbType.Int).Value = cantidad;
                com.Parameters.Add("@Escaneados", SqlDbType.Int).Value = escaneos;
                com.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = codigo;
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error en detalle caja" + e.Message);
            }
        }

        public int CerrarCAJA(int id_packing, int idcaja)
        {
            int new_id = 0;
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = id_packing;
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = idcaja;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "C_CERRARCAJA";
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error al cerrar caja" + e.Message);
            }
            return new_id;

        }

        public void Inserta_precinto(int packing, int caja, string precinto)
        {
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "ADD_PRECINTO";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = packing;
                com.Parameters.Add("@PRE_CINTO", SqlDbType.VarChar).Value = precinto;
                com.Parameters.Add("@CAJA", SqlDbType.Int).Value = caja;
                com.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception er)
            {
                MessageBox.Show("error al cerrar caja" + er.Message);
            }
            
        }

        public int UpdateMODA(int id_packing, int idcaja, int idmoda)
        {
            int new_id = 0;
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = id_packing;
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = idcaja;
                com.Parameters.Add("@CAJA", SqlDbType.Int).Value = idmoda;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "UPDATE_MODA";
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error UpdateMODA." + e.Message);
            }
            return new_id;

        }

        public void BorrarCAJA(int id_packing, int idcaja)
        {

            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = id_packing;
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = idcaja;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "G_DELETE";
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error al generar nueva caja" + e.Message);
            }

        }

        public void Cancela ( FRM_agregarArticulos frm , int id_packing, int id_caja, int id_orden)
        {
            string sp = "Sp_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;              
                com.Parameters.Add("@ID", SqlDbType.Int).Value = id_packing;
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = id_orden;
                com.Parameters.Add("@CAJA", SqlDbType.Int).Value = id_caja;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "G_CANCELA";
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    foreach (DataGridViewRow row in frm.dgvArticulos.Rows)
                    {
                        if (row.Cells["Articulo"].Value.ToString() == dr.GetString(0) && row.Cells["SUBCUENTA"].Value.ToString() == dr.GetString(1))
                        {
                            frm.lblNUmero.Text = Convert.ToString(Convert.ToInt32(frm.lblNUmero.Text) - Convert.ToInt32(row.Cells["EnCaja"].Value));
                            row.Cells["EnCaja"].Value = 0;
                        }
                    }
                }
                dr.Close();
                con.Close();

            }
            catch(Exception e)
            {
                MessageBox.Show("error al generar nueva caja" + e.Message);
            }
        }

        public bool ExisteArt(int id_packing, int id_caja, int id_orden)
        {
            string sp = "Sp_Packing_Insert";
            bool res = false;
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = id_packing;
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = id_orden;
                com.Parameters.Add("@CAJA", SqlDbType.Int).Value = id_caja;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "EXISTEN_ART";
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                if (dr.GetInt32(0) == 1)
                    res = true;

                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("error al generar nueva caja" + e.Message);
            }

            return res;
        }

        public int GET_MOVID(int ID_VENTA)
        {
            int new_id = 0;
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection (cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = ID_VENTA;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "G_IDoRDEN";
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                new_id = dr.GetInt32(0);
                dr.Close();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("error get movid" + e.Message);
            }
            return new_id;

        }

        public bool Orden_Completa( int id_pack, int id_orde)
        {
            string sp = "SP_Packing_Insert";
            bool res = false;
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "G_ordCompl";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = id_pack;
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = id_orde;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                if (dr.GetInt32(0) == 1)
                    res = true;
                con.Close();
                dr.Close();
            }
            catch(Exception er)
            {
                MessageBox.Show("error Orden_Completa" + er.Message);
            }

            return res;
        }

        public int N_cajas(int id_packing)
        {
            string query = "SELECT COUNT(*) FROM TBL_PACKING_BOX WITH(NOLOCK) WHERE Id_Packing = @idpack";
            int numero_C = 0;
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                com.CommandType = CommandType.Text;
                com.Parameters.Add("@idpack", SqlDbType.Int).Value = id_packing;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                numero_C = dr.GetInt32(0);
                dr.Close();
                con.Close();
            }
            catch(Exception er)
            {
                MessageBox.Show("error numero de cajas" + er.Message);
            }
            return numero_C;
        }

        public void get_datosCaja( FRM_DET_CAJAS frm, int idpack , int idcaja)
        {
            string consulta = "SP_Detalle_Packing";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(consulta, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "DAT_CAJA";
                com.Parameters.Add("@orden", SqlDbType.VarChar).Value = idcaja;
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    string mda = dr.GetString(0);
                    try
                    {
                        int index = frm.cmbXModa.FindString(mda.Substring(0, 5));
                        frm.cmbXModa.SelectedIndex = index;
                    }
                    catch (Exception e)
                    {

                    }                    
                    frm.txtXtara.Text = "0.9";
                    frm.txtXPesoN.Text = dr.GetString(2);
                    frm.txtXPesoB.Text = dr.GetString(3);
                    frm.lblPbruto.Visible = true;
                    frm.lblPneto.Visible = true;
                    frm.lblXnDim.Visible = true;
                    frm.lblXnDim.Visible = true;
                }
                con.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("error numero de cajas" + e.Message);
            }
        }

        public bool existe_precinto(int idpacking, int idcaja)
        {
            bool res = false;
            string query = "Select count(*) from TBL_PRECINTO_PACKING WITH(NOLOCK) WHERE Id_Packing = @pack and Id_Caja = @caja";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                com.CommandType = CommandType.Text;
                com.Parameters.Add("@pack", SqlDbType.Int).Value = idpacking;
                com.Parameters.Add("@caja", SqlDbType.Int).Value = idcaja;
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    if(dr.GetInt32(0) > 0)
                    {
                        res = true;
                    }
                }
                con.Close();                                          
            }
            catch(Exception ex)
            {
                MessageBox.Show("error existe_precinto" + ex.Message);
            }
            return res;
        }

        public void cancelar_todo(int idpack)
        {
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "ELIMINA_TODO";
                com.Parameters.Add("@ID", SqlDbType.VarChar).Value = idpack;
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error cancelar_todo" + ex.Message);
            }
        }

        public int total_artC (int idpack)
        {
            int res = 0;
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "TOTAL_ART";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                res = dr.GetInt32(0);
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error total_artC" + ex.Message);
            }

            return res;
        }

        public int total_orden (int idorden)
        {
            int res = 0;
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "TOTAL_ORDEN";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idorden;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                res = dr.GetInt32(0);
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error total_orden" + ex.Message);
            }

            return res;
        }

        public int Actualiza_grid(int idpack, int idorden, string art, int nColor)
        {
            int res = 0;
            
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "ACT_GRID";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = idorden;
                com.Parameters.Add("@CAJA", SqlDbType.Int).Value = nColor;
                com.Parameters.Add("@ART", SqlDbType.VarChar).Value = art;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                res = dr.GetInt32(0);                
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error Actualiza_grid" + ex.Message);
            }

            return res;
        }
        public bool ValidaCaja(int idpack)
        {
            bool res = true;
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "VALIDA_CAJA";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = 388;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                if ( Convert.ToInt32(dr[0]) == 1)
                    res = false;
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error ValidaCaja" + ex.Message);
                res = false;
            }
            return res;
        }

        public void Cancela_Caja (int idpack, int caja)
        {
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "CANCELA_CAJA";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = caja;
                com.ExecuteNonQuery();
                com.Clone();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error Cancela_Caja" + ex.Message);                
            }
        }

        public void DetalleDeCajaPrec(FRM_DET_CAJAS frm, int idpack, int idcaja)
        {
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "CONSUL_PREC";
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = idcaja;
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    frm.dgvXPrec.Rows.Add(dr["Id_PreCinto"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al DetalleDeCaja" + ex.Message);
            }
        }

        public void terminarPack (int idpack)
        {
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "TERMINAR_P";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                com.ExecuteNonQuery();
                con.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al terminarPack" + ex.Message);
            }
        }

        public void GeneraReporte(int idpack)
        {
            string sp = "SP_RepPacking";
           List<Datos> dat = new List<Datos>();
            try
            {
                FRMReporte frm = new FRMReporte();
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@IdPacking", SqlDbType.Int).Value = idpack;                
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Datos d = new Datos();
                    d.idcaja = dr.GetInt32(0);
                    d.Dimenciones = dr.GetString(1);
                    d.Tara = dr.GetDecimal(2);
                    d.PesoB = dr.GetDecimal(3);
                    d.PesoN = dr.GetDecimal(4);
                    d.Articulo = dr.GetString(5);
                    d.Descripcion = dr.GetString(6);
                    d.OrdenSurtido = dr.GetString(7);
                    d.IdPacking = dr.GetInt32(8);
                    d.Color = dr.GetString(9);
                    d.Cant1 = dr.GetInt32(10);
                    d.Cant2 = dr.GetInt32(11);
                    d.Cant3 = dr.GetInt32(12);
                    d.Cant4 = dr.GetInt32(13);
                    d.Cant5 = dr.GetInt32(14);
                    d.Cant6 = dr.GetInt32(15);
                    d.Cant7 = dr.GetInt32(16);
                    d.Cant8 = dr.GetInt32(17);
                    d.Cant9 = dr.GetInt32(18);
                    d.Cant10 = dr.GetInt32(19);
                    d.Cant11 = dr.GetInt32(20);
                    d.Cant12 = dr.GetInt32(21);
                    d.Cant13 = dr.GetInt32(22);
                    d.Cant14 = dr.GetInt32(23);
                    d.Cant15 = dr.GetInt32(24);
                    d.PreCint = dr.GetString(25);
                    d.maxCaja = dr.GetInt32(26);
                    d.sumPeso = dr.GetDecimal(27);
                    d.maxOrden = dr.GetInt32(28);
                    d.TotalEsc = dr.GetInt32(29);
                    d.sumPesoN = dr.GetDecimal(30);
                    dat.Add(d);
                    frm.Indatos.Add(d);
                }

                frm.ShowDialog();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al GeneraReporte" + ex.Message);
            }
        }
        public void CajaPendiente(int idpack, int idcaja)
        {
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "PENDIENTE";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = idcaja;
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al terminarPack" + ex.Message);
            }
        }

        public int verificaCajaP(int idpack)
        {
            int idcajaPend = 0;
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "VERIFICA";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;                
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                if(dr.GetInt32(0) > 0)
                {
                    idcajaPend = dr.GetInt32(0);
                }                

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al terminarPack" + ex.Message);
            }

            return idcajaPend;
        }

        public int Art_pendientes(int idpack, int idcaja)
        {
            int idcajaPend = 0;
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "ART_EN_CP";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = idcaja;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                if (dr.GetInt32(0) > 0)
                {
                    idcajaPend = dr.GetInt32(0);
                }                

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al terminarPack" + ex.Message);
            }

            return idcajaPend;
        }

        public void Historico(FRMGridHist h, int idpack, string opcion,string desde, string hasta)
        {
            string sp = "SP_Historico_Packing";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = opcion;
                com.Parameters.Add("@DESDE", SqlDbType.VarChar).Value = desde;
                com.Parameters.Add("@HASTA", SqlDbType.VarChar).Value = hasta ;
                com.Parameters.Add("@ID", SqlDbType.VarChar).Value = idpack;
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    h.dgvArticulos.Rows.Add(dr["Id_Packing"], dr["Fecha_Creacion"], dr["Fecha_Conclucion"]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al Historico" + ex.Message);
            }
        }

        public void Pendientes(FRMPendientes frm)
        {
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "PENDIENTES";               
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    frm.dgvArticulos.Rows.Add(dr["Id_Packing"], dr["Fecha_Creacion"],dr["Precin"]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error al Pendientes" + ex.Message);
            }
        }

        public Dictionary<int, string> ListaOrden (int idpack)
        {
            string sp = "SP_Packing_Insert";
            Dictionary<int, string> ordenes = new Dictionary<int, string>();
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "LISTA_ORDEN";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ordenes.Add(dr.GetInt32(0), dr["Id_Orden"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al Pendientes" + ex.Message);
            }
            return ordenes;
        }

        public string Verifica_estatus(int idpack)
        {
            string estatus = "";
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "VERIFICA_ESTATUS";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                estatus = dr[0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al Verifica_estatus" + ex.Message);
            }
            return estatus;
        }

        public void terminarSF(int idpack)
        {
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "TERMINAR_SF";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al terminarPack" + ex.Message);
            }
        }

        public List<int> ListaOrd(int idpack, int caja)
        {
            List<int> ret = new List<int>();
            string sp = "SP_Packing_Insert";
            try
            {
                con = new SqlConnection(cadena());
                SqlCommand com = new SqlCommand(sp, con);
                con.Open();
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@opcion", SqlDbType.VarChar).Value = "LISTA_ORD";
                com.Parameters.Add("@ID", SqlDbType.Int).Value = idpack;
                com.Parameters.Add("@ORDEN", SqlDbType.Int).Value = caja;
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ret.Add(dr.GetInt32(0));
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al terminarPack" + ex.Message);
            }

            return ret;
        }

    }
}
