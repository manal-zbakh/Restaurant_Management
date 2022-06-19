using RetaurantManagement.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetaurantManagement
{
    public partial class Facture : Form
    {
        int id;
        public Facture(int id)
        {
            this.id = id;

            InitializeComponent();
        }

        private void Facture_Load(object sender, EventArgs e)
        {
            CrystalReport1 report1 = new CrystalReport1();
            DataSet ds1 = new DataSet();
            DataTable dt1 = new DataSet1.FactureDataTable();
            MyDB db = new MyDB();
            Commande cmd = db.Commandes.Include("Table").Include("contients").Include("contients.Plat").Where(x => x.num_cmd == id).First();
            // List<Contient> contients = db.Contients.Include("Commande").Include("Plat").Where(x => x.id_contient == id).ToList();
            foreach (Contient dr in cmd.contients)
            {
                DataRow dataRow = dt1.NewRow();
                dataRow[0] = dr.quantite;
                dataRow[1] = dr.Plat.libelle;
                dataRow[2] = dr.Plat.prix;
                dataRow[3] = dr.quantite * dr.Plat.prix;
                dataRow[4] = dr.Commande.date_com;
                dataRow[5] = dr.Commande.heure_paiment;
                dataRow[6] = dr.Commande.Table.num_tab;
                dt1.Rows.Add(dataRow);

            }
            ds1.Tables.Add(dt1);
            report1.SetDataSource(ds1);
            crystalReportViewer1.ReportSource = report1;
        }
    }
}
