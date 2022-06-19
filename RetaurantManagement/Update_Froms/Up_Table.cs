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
    public partial class Up_Table : Form
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
        public Table tbl;
        public Up_Table(int id)
        {
            this.id = id;
            InitializeComponent();
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 30, 30));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            textBox8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox8.Width, textBox8.Height, 10, 10));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            tbl.nb_place= Int16.Parse(textBox8.Text.ToString());
            myDB.Tables.Attach(tbl);
            myDB.Entry(tbl).State = EntityState.Modified;
            myDB.SaveChanges();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Up_Table_Load(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            tbl = myDB.Tables.Where(x => x.num_tab == id).First();
            textBox8.Text = tbl.nb_place.ToString();
        }
    }
}
