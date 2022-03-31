using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlYazma
{
    public partial class DbToXmlForm : Form
    {
        public DbToXmlForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=LAPTOP-AVI5AKH9\SQLEXPRESS07 ; Database=Northwind ; Integrated Security=true");
        private void btnUrunXml_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("prc_Urunler_Select", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds, "Urunler");
            ds.WriteXml("Urunler.xml");
        }

        private void btnTedarikciXml_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Select * from Tedarikciler", baglanti);
            adp.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adp.Fill(ds, "Tedarikciler");
            ds.WriteXml("Tedarikciler.xml");
        }

        private void btnUrunlerListele_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Urunler.xml");
            dataGridView1.DataSource = ds.Tables["Urunler"];
        }

        private void btnTedarikcilerListele_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Tedarikciler.xml");
            dataGridView1.DataSource = ds.Tables["Tedarikciler"];
        }
    }
}
