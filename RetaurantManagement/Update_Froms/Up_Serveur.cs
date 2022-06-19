using RetaurantManagement.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetaurantManagement.Update_Froms
{
    public partial class Up_Serveur : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nleft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse


            );
        public int id ;
        public Serveur srv;
        public Up_Serveur(int id)
        {
            this.id = id;
            InitializeComponent();
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 30, 30));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            textBox8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox8.Width, textBox8.Height, 10, 10));
            textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 10, 10));
        }

        private void Serveur_Load(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            srv = myDB.Serveurs.Where(x=>x.num_srv==id).First();
            textBox8.Text = srv.nom;
            textBox1.Text = srv.prenom ;
            /*Button bt = (Button)sender;
            int id = Int16.Parse(bt.Name.ToString());
            Serveur serveur = myDB.Serveurs.Where(x => x.num_srv == id).First();
            textBox8.Text = serveur.nom;
            textBox1.Text = serveur.prenom;*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            srv.nom = textBox8.Text;
            srv.prenom = textBox1.Text;
           // myDB.Serveurs.Add(srv);
            myDB.Serveurs.Attach(srv);
            myDB.Entry(srv).State = EntityState.Modified;
            myDB.SaveChanges();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
