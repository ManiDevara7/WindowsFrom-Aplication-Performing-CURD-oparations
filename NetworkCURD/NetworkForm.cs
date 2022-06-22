using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NetworkCURD
{
    public partial class NetworkForm : Form
    {
        public NetworkForm()
        {
            InitializeComponent();
        }
        public int DataGridView;

        SqlConnection con = new SqlConnection();

        private void Form1_Load(object sender, EventArgs e)
        {
            GetNetworkRecord();
        }

        private void GetNetworkRecord()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DeafultConnection"].ToString();
            SqlCommand cmd = new SqlCommand("exec dbo.GetDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            NetworkdataGridView.DataSource = dt;
            con.Close();
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {



                    con.ConnectionString = ConfigurationManager.ConnectionStrings["DeafultConnection"].ToString();
                    SqlCommand cmd = new SqlCommand("exec dbo.Network_Create '" + NetCodeTxt.Text + "','" + AffiliactionTxt.Text + "','" + ConfigurationTxt.Text + "','" + radioButton1.Checked.ToString() + "','" + radioButton3.Checked.ToString() + "'", con);



                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New Record Is Created Successfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetNetworkRecord();
                    RestFormControls();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Record can't be created with same NetCode and Affiliaction", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                       
                }
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message);
                throw;
            }

            


        }

        private bool IsValid()
        {
            if (NetCodeTxt.Text == string.Empty)
            {

                MessageBox.Show("Netcode is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (AffiliactionTxt.Text == string.Empty)
            {
                MessageBox.Show("Affiliation is required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void UpDateBTN_Click(object sender, EventArgs e)
        {
            try
            {

                con.ConnectionString = ConfigurationManager.ConnectionStrings["DeafultConnection"].ToString();
                SqlCommand cmd = new SqlCommand("exec dbo.Network_Update '" + NetCodeTxt.Text + "','" + AffiliactionTxt.Text + "','" + ConfigurationTxt.Text + "','" + radioButton1.Checked.ToString() + "','" + radioButton3.Checked.ToString() + "'", con);
               


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Record Is Updated Sccessfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetNetworkRecord();
                RestFormControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                throw;
            }

        }


        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DeafultConnection"].ToString();
                SqlCommand cmd = new SqlCommand("exec dbo.Network_Delete '" + NetCodeTxt.Text + "','" + AffiliactionTxt.Text + "','" + ConfigurationTxt.Text + "','" + radioButton1.Checked.ToString() + "','" + radioButton3.Checked.ToString() + "'", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Is Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetNetworkRecord();
                RestFormControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        private void ResertBTN_Click(object sender, EventArgs e)
        {
            RestFormControls();
        }

        private void RestFormControls()
        {
            NetCodeTxt.Clear();
           
            AffiliactionTxt.Clear();
            ConfigurationTxt.Clear();
            NetCodeTxt.Focus();
            browseTXT.Clear();
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = true;
            }
            if (radioButton3.Checked == true)
            {
                radioButton4.Checked = true;
            }

        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
                OpenFileDialog1.Title = "Seclect file";
                OpenFileDialog1.InitialDirectory = @"C:\";
                OpenFileDialog1.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
                OpenFileDialog1.FilterIndex = 1;
                OpenFileDialog1.ShowDialog();
                if (OpenFileDialog1.FileName != "")
                { browseTXT.Text = OpenFileDialog1.FileName; }
                else { browseTXT.Text = ""; }
                OpenFileDialog1.RestoreDirectory = true;
                ConfigurationTxt.Text = System.IO.File.ReadAllText(OpenFileDialog1.FileName);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                 throw;
            }

        }



        private void NetworkdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = NetworkdataGridView.Rows[e.RowIndex];
                NetCodeTxt.Text = row.Cells[0].Value.ToString();
                AffiliactionTxt.Text = row.Cells[1].Value.ToString();
                ConfigurationTxt.Text = row.Cells[2].Value.ToString();

                if (Convert.ToBoolean(row.Cells[3].Value))
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                if (Convert.ToBoolean(row.Cells[4].Value))
                {
                    radioButton3.Checked = true;
                }
                else
                {
                    radioButton4.Checked = true;
                }

                radioButton3.Checked = Convert.ToBoolean(row.Cells[4].Value);
                NetCodeTxt.ReadOnly = true;
                AffiliactionTxt.ReadOnly = true;


            }

        }

        private void NetworkdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxDoDates_Enter(object sender, EventArgs e)
        {
        }

        private void groupBoxFullRoster_Enter(object sender, EventArgs e)
        {



        }
    }
}
