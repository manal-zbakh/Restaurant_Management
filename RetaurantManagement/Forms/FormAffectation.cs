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

namespace RetaurantManagement.Forms
{
    public partial class FormAffectation : Form
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
        public FormAffectation()
        {
            InitializeComponent();
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 30, 30));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 30, 30));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            comboBox1.Region= Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 20, 20));
            comboBox2.Region= Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 20, 20));

        }

        private void FormAffectation_Load(object sender, EventArgs e)
        {
           

            MyDB myDB = new MyDB();
            List<Affecter> affecters = myDB.Affecters.Include("Serveur").Include("Table").ToList();    
            int y = 0;
            foreach (Affecter affecter in affecters)
            {
                System.Windows.Forms.Panel panel_aff;
                panel_aff = new System.Windows.Forms.Panel();

                System.Windows.Forms.Label Seveur;
                Seveur = new System.Windows.Forms.Label();

                System.Windows.Forms.Label Id_tbl;
                Id_tbl = new System.Windows.Forms.Label();

                System.Windows.Forms.Button delete_tbl;
                delete_tbl = new System.Windows.Forms.Button();


                panel_aff.SuspendLayout();
                panel_aff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
                panel_aff.Location = new System.Drawing.Point(26, 108+y);
                panel_aff.Name = "panel_aff";
                panel_aff.Size = new System.Drawing.Size(369, 34);
                panel_aff.TabIndex = 16;
                //panel_aff.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_tbl_Paint);

                //num_tbl
                Id_tbl.AutoSize = true;
                Id_tbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Id_tbl.Location = new System.Drawing.Point(43, 11);
                Id_tbl.Name = "Id_tbl";
                Id_tbl.Size = new System.Drawing.Size(18, 13);
                Id_tbl.TabIndex = 16;
                Id_tbl.Text = affecter.Table.num_tab.ToString();

                //serveur
                Seveur.AutoSize = true;
                Seveur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Seveur.Location = new System.Drawing.Point(155, 11);
                Seveur.Name = "Seveur";
                Seveur.Size = new System.Drawing.Size(51, 13);
                Seveur.TabIndex = 18;
                Seveur.Text = affecter.Serveur.nom;

                //btn_delete
                delete_tbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
                delete_tbl.FlatAppearance.BorderSize = 0;
                delete_tbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                delete_tbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                delete_tbl.Image = global::RetaurantManagement.Properties.Resources.btn_delete;
                delete_tbl.Location = new System.Drawing.Point(291, 1);
                delete_tbl.Name = "delete_tbl";
                delete_tbl.Size = new System.Drawing.Size(36, 32);
                delete_tbl.TabIndex = 16;
                delete_tbl.UseVisualStyleBackColor = false;
                delete_tbl.Click += (s, ev) => delete_tbl_Click(s,ev,affecter);




                panel_aff.Controls.Add(Seveur);
                panel_aff.Controls.Add(Id_tbl);
                panel_aff.Controls.Add(delete_tbl);
                this.Controls.Add(panel_aff);

                y = y + 50;
            }
            comboBox1.DataSource = myDB.Serveurs.ToArray();
            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "nom";
            comboBox1.Text = "ajouter un serveur";

            comboBox2.DataSource = myDB.Tables.ToArray();
            comboBox2.DisplayMember = "num_tab";
            comboBox2.ValueMember = "num_tab";
            comboBox2.Text = "ajouter une table";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            Affecter affecters = new Affecter();

            int id = Int16.Parse(comboBox2.Text.ToString());
            Table table = myDB.Tables.Where(x=>x.num_tab == id).First();
            affecters.Table= table;

            Serveur serveur = myDB.Serveurs.Where(x => x.nom.Equals(comboBox1.Text)).First();
            affecters.Serveur = serveur;

            affecters.date = DateTime.Now;

            myDB.Affecters.Add(affecters);
            myDB.SaveChanges();
        }



        private void delete_tbl_Click(object sender, EventArgs e,Affecter a)
        {
            MyDB myDB = new MyDB();
            myDB.Entry(a).State = EntityState.Deleted;
            myDB.SaveChanges();
        }

    }
}
