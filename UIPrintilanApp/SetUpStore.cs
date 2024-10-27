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

namespace UIPrintilanApp
{
    public partial class SetUpStore : Form
    {
        public SetUpStore()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        private DataGridViewRow r;
        string connstring = "Host=172.177.227.63;Port=5432;Username=postgres;Password=dummyprodigy;Database=printilan;Include Error Detail=True;";
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

        private void btnQuit_Click(object sender, EventArgs e)
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

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ini nanti page Wishlist", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDM_Click(object sender, EventArgs e)
        {
            this.Hide();
            DM DMForm = new DM();
            DMForm.Show();
        }

        private void SetUpStore_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
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
                    if (rd.FieldCount != 9)
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

                sql = @"SELECT pr_update(:_productid, :_storeid, :_productname, :_price, :_category, 
                                      :_material, :_dimensions, :_availability, :_description)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_productid", Convert.ToInt32(r.Cells["productid"].Value)); // Ambil dari DataGridView
                cmd.Parameters.AddWithValue("_productname", tbPrName.Text);
                cmd.Parameters.AddWithValue("_price", Convert.ToDecimal(tbPrPrice.Text));
                cmd.Parameters.AddWithValue("_category", tbPrCategory.Text);
                cmd.Parameters.AddWithValue("_material", tbPrMaterial.Text);
                cmd.Parameters.AddWithValue("_dimensions", tbPrDimensions.Text);
                cmd.Parameters.AddWithValue("_availability", cbPrAvailability.Checked);
                cmd.Parameters.AddWithValue("_description", tbPrDescription.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data produk berhasil diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnLoadData.PerformClick();

                    tbPrName.Text = "";
                    tbPrPrice.Text = tbPrCategory.Text = tbPrMaterial.Text = "";
                    tbPrDimensions.Text = tbPrDescription.Text = "";
                    cbPrAvailability.Checked = false;

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

                sql = @"SELECT pr_insert(@_productname, @_price, @_category, 
                                  @_material, @_dimensions, @_availability, @_description)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@_productname", tbPrName.Text);
                cmd.Parameters.AddWithValue("@_price", Convert.ToDecimal(tbPrPrice.Text));
                cmd.Parameters.AddWithValue("@_category", tbPrCategory.Text);
                cmd.Parameters.AddWithValue("@_material", tbPrMaterial.Text);
                cmd.Parameters.AddWithValue("@_dimensions", tbPrDimensions.Text);
                cmd.Parameters.AddWithValue("@_availability", cbPrAvailability.Checked);
                cmd.Parameters.AddWithValue("@_description", tbPrDescription.Text);

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

    }
}
