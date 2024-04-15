using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace SarkiListe
{
    public partial class FrmMain1 : Form
    {
        public FrmMain1()
        {
            InitializeComponent();
        }
        string baglanti = "Server=localhost;Database=muzik;Uid=root;Pwd=''";

        private void FrmMain1_Load(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(baglanti))
            {
                string sql = "SELECT * FROM sarkilar";
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvListe.DataSource = dt;
            }
            
        }
    }
}
