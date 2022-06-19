using RetaurantManagement.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetaurantManagement
{
    public partial class Commander : Form
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
/*        var[] array1;
        var[] array2;

        List<float[]> arrays = new List<array1, array2>();

        arrays.ToArray();*/
        public Commander()
        {
            InitializeComponent();
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));
            button7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button7.Width, button7.Height, 30, 30));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 30, 30));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 30, 30));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 30, 30));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 30, 30));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 5, 5));
            nbrprs_cmd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, nbrprs_cmd.Width, nbrprs_cmd.Height, 10, 10));
            nbrplt_cmd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, nbrplt_cmd.Width, nbrplt_cmd.Height, 10, 10));
            comboBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox1.Width, comboBox1.Height, 20, 20));
            comboBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox2.Width, comboBox2.Height, 20, 20));
            comboBox3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox3.Width, comboBox2.Height, 20, 20));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Accueil a = new Accueil();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestion g = new Gestion();
            g.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            Commande commandes = new Commande();

            commandes.nb_personnes = Int16.Parse(nbrprs_cmd.Text);

            int num_tbl = Int16.Parse(comboBox2.Text.ToString());
            Table table = myDB.Tables.Where(x=>x.num_tab == num_tbl).First();

            commandes.Table=table;

            commandes.mode_paiment = comboBox3.Text;

            commandes.date_com=DateTime.Now;
            commandes.heure_paiment= DateTime.Now.TimeOfDay;

            myDB.Commandes.Add(commandes);
            myDB.SaveChanges();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            int id = Int16.Parse(bt.Name.ToString());
            Facture f = new Facture(id);
            f.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
            MyDB myDB = new MyDB();
            Contient contients = new Contient();
            Commande commandes = myDB.Commandes.OrderByDescending(x => x.num_cmd).First();
            contients.Commande = commandes;
            int code_plt = Int16.Parse(comboBox1.Text.ToString());
            Plat plat = myDB.Plats.Where(x => x.code_plat == code_plt).First();
            contients.Plat = plat;
            contients.quantite = Int16.Parse(nbrplt_cmd.Text);
            myDB.Contients.Add(contients);
            myDB.SaveChanges();
        }

        private void Commander_Load(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            List<Commande> commandes = myDB.Commandes.ToList();
            int y = 0;
            foreach (Commande commande in commandes)
            {
                System.Windows.Forms.Button cmd_btn;
                cmd_btn = new System.Windows.Forms.Button();

                cmd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
                cmd_btn.FlatAppearance.BorderSize = 0;
                cmd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                cmd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cmd_btn.Location = new System.Drawing.Point(538, 130 + y);
                cmd_btn.Name = commande.num_cmd.ToString();
                cmd_btn.Size = new System.Drawing.Size(253, 29);
                cmd_btn.TabIndex = 16;
                cmd_btn.Text = "Commande " + commande.num_cmd.ToString();
                cmd_btn.UseVisualStyleBackColor = false;
                cmd_btn.Click += new System.EventHandler(this.button5_Click);

                this.Controls.Add(cmd_btn);
                y = y + 40;
            }

            comboBox1.DataSource = myDB.Plats.ToArray();
            comboBox1.DisplayMember = "code_plat";
            comboBox1.ValueMember = "code_plat";
            comboBox1.Text = "choisir un plat";

            comboBox2.DataSource = myDB.Tables.ToArray();
            comboBox2.DisplayMember = "num_tab";
            comboBox2.ValueMember = "num_tab";
            comboBox2.Text= "choisir une table";

            comboBox3.Items.Add("par carte");
            comboBox3.Items.Add("cache");

        }
        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (nbrplt_cmd.Text == "nbr plats")
            {
                nbrplt_cmd.Text = "";
                nbrplt_cmd.ForeColor = Color.Black;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (nbrplt_cmd.Text == "")
            {
                nbrplt_cmd.Text = "nbr plats";
                nbrplt_cmd.ForeColor = Color.Silver;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (nbrprs_cmd.Text == "nbr prs")
            {
                nbrprs_cmd.Text = "";
                nbrprs_cmd.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (nbrprs_cmd.Text == "")
            {
                nbrprs_cmd.Text = "nbr prs";
                nbrprs_cmd.ForeColor = Color.Silver;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
