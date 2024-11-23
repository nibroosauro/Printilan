using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using RestSharp;

namespace UIPrintilanApp
{
    public partial class SetUpStore : Form
    {
        public static List<string> GetKotaList()
        {
            List<string> returnList = new List<string>();
            var client = new RestClient("https://api.rajaongkir.com/starter/city");
            var request = new RestRequest(Method.GET);
            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");
            IRestResponse response = client.Execute(request);
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            JsonObject rajaObj = (JsonObject)obj["rajaongkir"];
            JsonArray cityListArray = (JsonArray)rajaObj["results"];
            foreach (JsonObject city in cityListArray)
            {
                returnList.Add((string)city["city_name"]);
            }
            return returnList;
        }

        List<string> listKota = new List<string>();
        public SetUpStore()
        {
            InitializeComponent();
            listKota = GetKotaList();
            foreach (string kota in listKota)
            {
                tbLocation.AutoCompleteCustomSource.Add(kota);
                tbLocation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbLocation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private NpgsqlConnection conn;
        private DataGridViewRow r;
        string connstring = AppSettings.ConnectionString;
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Profile_Page profileForm = new Profile_Page();
            profileForm.Show();
        }

        private void btnSetUpStore_Click(object sender, EventArgs e)
        {
            //logic to set up store
        }

        //private void SetUpStore_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        conn = new NpgsqlConnection(connstring);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error initializing connection: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        if (conn != null && conn.State == ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        private void SetUpStore_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                // Fetch the storeid corresponding to the logged-in user
                int userId = UserSession.UserId;
                sql = "SELECT sellerid FROM seller WHERE userid = @userId";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userid", userId);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    int storeId = Convert.ToInt32(result);
                    // You can now use this storeId for filtering queries
                }
                else
                {
                    MessageBox.Show("Store not found for this user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing connection: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new NpgsqlConnection(connstring);
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                dgvData.DataSource = null;

                sql = "select * from pr_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();

                using (var rd = cmd.ExecuteReader())
                {
                    if (rd.FieldCount != 10)
                    {
                        MessageBox.Show("Jumlah kolom tidak sesuai dengan yang diharapkan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dt.Load(rd);
                }

                dgvData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                r = dgvData.Rows[e.RowIndex];

                tbPrName.Text = r.Cells["productname"].Value.ToString();
                tbPrPrice.Text = r.Cells["price"].Value.ToString();
                tbPrCategory.Text = r.Cells["category"].Value.ToString();
                tbPrMaterial.Text = r.Cells["material"].Value.ToString();
                tbPrDimensions.Text = r.Cells["dimensions"].Value.ToString();
                cbPrAvailability.Checked = Convert.ToBoolean(r.Cells["availability"].Value);
                tbPrDescription.Text = r.Cells["description"].Value.ToString();
                tbLocation.Text = r.Cells["product_location"].Value.ToString();

                MessageBox.Show("Baris dipilih: " + tbPrName.Text);
            }
        }
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];

                if (r != null)
                {
                    MessageBox.Show("Product Name: " + r.Cells["productname"].Value.ToString());

                    tbPrName.Text = r.Cells["productname"].Value.ToString();
                    tbPrPrice.Text = r.Cells["price"].Value.ToString();
                    tbPrCategory.Text = r.Cells["category"].Value.ToString();
                    tbPrMaterial.Text = r.Cells["material"].Value.ToString();
                    tbPrDimensions.Text = r.Cells["dimensions"].Value.ToString();
                    cbPrAvailability.Checked = Convert.ToBoolean(r.Cells["availability"].Value);
                    tbPrDescription.Text = r.Cells["description"].Value.ToString();
                    tbLocation.Text = r.Cells["product_location"].Value.ToString();
                }
            }
        }


        // RE SORRY BGT INI BLM SELESAI DAN AKU UDAH GA KUAT -Bar
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn == null)
                {
                    conn = new NpgsqlConnection(connstring);
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                sql = @"SELECT pr_update(:_productid, 1, :_productname, :_price, :_category, 
                                  :_material, :_dimensions, :_availability, :_description, :_product_location)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_productid", Convert.ToInt32(r.Cells["productid"].Value)); // Ambil dari DataGridView
                cmd.Parameters.AddWithValue("_productname", tbPrName.Text);
                cmd.Parameters.AddWithValue("_price", Convert.ToDecimal(tbPrPrice.Text));
                cmd.Parameters.AddWithValue("_category", tbPrCategory.Text);
                cmd.Parameters.AddWithValue("_material", tbPrMaterial.Text);
                cmd.Parameters.AddWithValue("_dimensions", tbPrDimensions.Text);
                cmd.Parameters.AddWithValue("_availability", cbPrAvailability.Checked);
                cmd.Parameters.AddWithValue("_description", tbPrDescription.Text);
                cmd.Parameters.AddWithValue(":_product_location", tbLocation.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data produk berhasil diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnLoadData.PerformClick();

                    tbPrName.Text = "";
                    tbPrPrice.Text = tbPrCategory.Text = tbPrMaterial.Text = "";
                    tbPrDimensions.Text = tbPrDescription.Text = "";
                    cbPrAvailability.Checked = false;
                    tbLocation.Text = "";

                    r = null;
                }
                else
                {
                    MessageBox.Show("Tidak ada data yang diupdate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //yg buat rore masih ada error
        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    if (r == null)
        //    {
        //        MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        if (conn == null)
        //        {
        //            conn = new NpgsqlConnection(connstring);
        //        }

        //        if (conn.State != ConnectionState.Open)
        //        {
        //            conn.Open();
        //        }

        //        sql = @"UPDATE product 
        //        SET productname = @productname, price = @price, category = @category, 
        //            material = @material, dimensions = @dimensions, availability = @availability, 
        //            description = @description, product_location = @product_location
        //        WHERE productid = @productid AND storeid = @storeid";  // Check storeid for authorization
        //        cmd = new NpgsqlCommand(sql, conn);

        //        cmd.Parameters.AddWithValue("@productid", Convert.ToInt32(r.Cells["productid"].Value)); // Get from DataGridView
        //        cmd.Parameters.AddWithValue("@storeid", UserSession.StoreId);  // Ensure update is authorized for the store
        //        cmd.Parameters.AddWithValue("@productname", tbPrName.Text);
        //        cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(tbPrPrice.Text));
        //        cmd.Parameters.AddWithValue("@category", tbPrCategory.Text);
        //        cmd.Parameters.AddWithValue("@material", tbPrMaterial.Text);
        //        cmd.Parameters.AddWithValue("@dimensions", tbPrDimensions.Text);
        //        cmd.Parameters.AddWithValue("@availability", cbPrAvailability.Checked);
        //        cmd.Parameters.AddWithValue("@description", tbPrDescription.Text);
        //        cmd.Parameters.AddWithValue("@product_location", tbLocation.Text);

        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        if (rowsAffected > 0)
        //        {
        //            MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            btnLoadData.PerformClick();  // Reload data after update
        //        }
        //        else
        //        {
        //            MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Update Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        // Bagianku udah aman yaa -Bar
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Apakah benar anda ingin menghapus data " + r.Cells["productname"].Value.ToString() + "?",
                                "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                == DialogResult.Yes)
            {
                try
                {
                    if (conn == null)
                    {
                        conn = new NpgsqlConnection(connstring);
                    }

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    sql = @"SELECT pr_delete(:_productid)";
                    cmd = new NpgsqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("_productid", Convert.ToInt32(r.Cells["productid"].Value));

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data produk berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        conn.Close();

                        btnLoadData.PerformClick();

                        tbPrName.Text = "";
                        tbPrPrice.Text = tbPrCategory.Text = tbPrMaterial.Text = "";
                        tbPrDimensions.Text = tbPrDescription.Text = "";
                        cbPrAvailability.Checked = false;

                        r = null;
                    }
                    else
                    {
                        MessageBox.Show("Tidak ada data yang dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        //yang buat RORE masih error
        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (r == null)
        //    {
        //        MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        if (conn == null)
        //        {
        //            conn = new NpgsqlConnection(connstring);
        //        }

        //        if (conn.State != ConnectionState.Open)
        //        {
        //            conn.Open();
        //        }

        //        sql = @"DELETE FROM product 
        //        WHERE productid = @productid AND storeid = @storeid";  // Ensure it belongs to the authorized store
        //        cmd = new NpgsqlCommand(sql, conn);

        //        cmd.Parameters.AddWithValue("@productid", Convert.ToInt32(r.Cells["productid"].Value));  // Get from DataGridView
        //        cmd.Parameters.AddWithValue("@storeid", UserSession.StoreId);  // Check storeid for authorization

        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        if (rowsAffected > 0)
        //        {
        //            MessageBox.Show("Product deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            btnLoadData.PerformClick();  // Reload data after delete
        //        }
        //        else
        //        {
        //            MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Delete Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        // LIN SORRY BGT INI BLM SELESAI DAN AKU UDAH GA KUAT -Bar
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new NpgsqlConnection(connstring);
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                sql = @"SELECT pr_insert(1, :_productname, :_price, :_category, 
                                  :_material, :_dimensions, :_availability, :_description, :_product_location)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue(":_productname", tbPrName.Text);
                cmd.Parameters.AddWithValue(":_price", Convert.ToDecimal(tbPrPrice.Text));
                cmd.Parameters.AddWithValue(":_category", tbPrCategory.Text);
                cmd.Parameters.AddWithValue(":_material", tbPrMaterial.Text);
                cmd.Parameters.AddWithValue(":_dimensions", tbPrDimensions.Text);
                cmd.Parameters.AddWithValue(":_availability", cbPrAvailability.Checked);
                cmd.Parameters.AddWithValue(":_description", tbPrDescription.Text);
                cmd.Parameters.AddWithValue(":_product_location", tbLocation.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data produk berhasil ditambahkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnLoadData.PerformClick();

                    tbPrName.Text = tbPrCategory.Text = tbPrMaterial.Text = "";
                    tbPrPrice.Text = tbPrDimensions.Text = tbPrDescription.Text = "";
                    cbPrAvailability.Checked = false;
                }
                else
                {
                    MessageBox.Show("Data produk gagal ditambahkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnWhsh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ini nanti page Wishlist", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDM_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ListDM ListDMForm = new ListDM();
            ListDMForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to quit Printilan App?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //yang buat RORE masih error
        //private void btnInsert_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (conn == null)
        //        {
        //            conn = new NpgsqlConnection(connstring);
        //        }

        //        if (conn.State != ConnectionState.Open)
        //        {
        //            conn.Open();
        //        }

        //        sql = @"INSERT INTO product (storeid, productname, price, category, material, dimensions, availability, description, product_location)
        //        VALUES (@storeid, @productname, @price, @category, @material, @dimensions, @availability, @description, @product_location)";
        //        cmd = new NpgsqlCommand(sql, conn);

        //        cmd.Parameters.AddWithValue("@storeid", UserSession.StoreId);  // Ensure it is inserted with the authorized storeid
        //        cmd.Parameters.AddWithValue("@productname", tbPrName.Text);
        //        cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(tbPrPrice.Text));
        //        cmd.Parameters.AddWithValue("@category", tbPrCategory.Text);
        //        cmd.Parameters.AddWithValue("@material", tbPrMaterial.Text);
        //        cmd.Parameters.AddWithValue("@dimensions", tbPrDimensions.Text);
        //        cmd.Parameters.AddWithValue("@availability", cbPrAvailability.Checked);
        //        cmd.Parameters.AddWithValue("@description", tbPrDescription.Text);
        //        cmd.Parameters.AddWithValue("@product_location", tbLocation.Text);

        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        if (rowsAffected > 0)
        //        {
        //            MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            btnLoadData.PerformClick();  // Reload data after insert
        //        }
        //        else
        //        {
        //            MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Insert Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


    }
}
