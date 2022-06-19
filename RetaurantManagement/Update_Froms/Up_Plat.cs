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
using Type = RetaurantManagement.data.Type;

namespace RetaurantManagement.Update_Froms
{
    public partial class Up_Plat : Form
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
        public int id;
        public Plat plt;
        public Up_Plat(int id)
        {
            this.id= id;
            InitializeComponent();
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 30, 30));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            textBox5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox5.Width, textBox5.Height, 10, 10));
            textBox8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox8.Width, textBox8.Height, 10, 10));
            comboBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox1.Width, comboBox1.Height, 20, 20));
        }

        private void Plat_Load(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            plt = myDB.Plats.Where(x => x.code_plat == id).First();
            textBox8.Text = plt.libelle;
            textBox5.Text = plt.prix.ToString();

            comboBox1.DataSource = myDB.Types.ToArray();
            comboBox1.DisplayMember = "libelle";
            comboBox1.ValueMember = "libelle";
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            plt.libelle = textBox8.Text;
            plt.prix = Int32.Parse(textBox5.Text.ToString());
            Type type = myDB.Types.Where(x => x.libelle.Equals(comboBox1.Text)).First();
            plt.Type = type;
            myDB.Plats.Attach(plt);
            myDB.Entry(plt).State = EntityState.Modified;
            myDB.SaveChanges();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
