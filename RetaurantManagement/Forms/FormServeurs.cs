using RetaurantManagement.data;
using RetaurantManagement.Update_Froms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetaurantManagement.Forms
{
    public partial class FormServeurs : Form
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
        public FormServeurs()
        {
            InitializeComponent();
            add_srv.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, add_srv.Width, add_srv.Height, 30, 30));
            panel_add_srv.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_add_srv.Width, panel_add_srv.Height, 30, 30));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 30, 30));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 30, 30));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 30, 30));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 30, 30));
            add_name_srv.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, add_name_srv.Width, add_name_srv.Height, 10, 10));
            add_prenom_srv.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, add_prenom_srv.Width, add_prenom_srv.Height, 10, 10));


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            Serveur serveurs = new Serveur();
            serveurs.nom = add_name_srv.Text;
            serveurs.prenom = add_prenom_srv.Text;
            myDB.Serveurs.Add(serveurs);
            myDB.SaveChanges();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (add_name_srv.Text == "Nom")
            {
                add_name_srv.Text = "";
                add_name_srv.ForeColor = Color.Black;
            }
        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (add_name_srv.Text == "")
            {
                add_name_srv.Text = "Nom";
                add_name_srv.ForeColor = Color.Silver;
                    }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (add_prenom_srv.Text == "Prénom")
            {
                add_prenom_srv.Text = "";
                add_prenom_srv.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (add_prenom_srv.Text == "")
            {
                add_prenom_srv.Text = "Prénom";
                add_prenom_srv.ForeColor = Color.Silver;
            }
        }

        private void FormServeurs_Load(object sender, EventArgs e)

        {
            affiche();
           
        }
        void affiche()
        {
            MyDB myDB = new MyDB();
            List<Serveur> serveurs = myDB.Serveurs.ToList();
            int y = 0;
            foreach (Serveur serveur in serveurs)
            {
                System.Windows.Forms.Panel panel_srv;
                panel_srv = new System.Windows.Forms.Panel();

                System.Windows.Forms.Label Id_srv;
                Id_srv = new System.Windows.Forms.Label();

                System.Windows.Forms.Label Nom_srv;
                Nom_srv = new System.Windows.Forms.Label();

                System.Windows.Forms.Label Prenom_srv;
                Prenom_srv = new System.Windows.Forms.Label();

                System.Windows.Forms.Button update_srv;
                update_srv = new System.Windows.Forms.Button();

                System.Windows.Forms.Button delete_srv;
                delete_srv = new System.Windows.Forms.Button();

                //panel
                panel_srv.SuspendLayout();
                panel_srv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
                panel_srv.Location = new System.Drawing.Point(21, 72 + y);
                panel_srv.Name = "panel_srv";
                panel_srv.Size = new System.Drawing.Size(503, 34);
                panel_srv.TabIndex = 14;



                //id
                Id_srv.AutoSize = true;
                Id_srv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Id_srv.Location = new System.Drawing.Point(30, 12);
                Id_srv.Name = "Id_srv";
                Id_srv.Size = new System.Drawing.Size(18, 13);
                Id_srv.Text = serveur.num_srv.ToString();
                //Id_srv.Click += new System.EventHandler(Id_srv_Click);

                //nom
                Nom_srv.AutoSize = true;
                Nom_srv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Nom_srv.Location = new System.Drawing.Point(143, 12);
                Nom_srv.Name = "Nom_srv";
                Nom_srv.Size = new System.Drawing.Size(32, 13);
                Nom_srv.Text = serveur.nom;
                //Nom_srv.Click += new System.EventHandler(this.Nom_srv_Click);

                //prenom
                Prenom_srv.AutoSize = true;
                Prenom_srv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Prenom_srv.Location = new System.Drawing.Point(259, 11);
                Prenom_srv.Name = "Prenom_srv";
                Prenom_srv.Size = new System.Drawing.Size(49, 13);
                Prenom_srv.Text = serveur.prenom;
                //Prenom_srv.Click += new System.EventHandler(this.Prenom_srv_Click);

                //btn-update
                update_srv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
                update_srv.FlatAppearance.BorderSize = 0;
                update_srv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                update_srv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                update_srv.Image = global::RetaurantManagement.Properties.Resources.btn_edite;
                update_srv.Location = new System.Drawing.Point(411, 0);
                update_srv.Name = serveur.num_srv.ToString();
                update_srv.Size = new System.Drawing.Size(36, 34);
                update_srv.UseVisualStyleBackColor = false;
                update_srv.Click += new System.EventHandler(this.button1_Click_3);

                //btn-delete
                delete_srv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
                delete_srv.FlatAppearance.BorderSize = 0;
                delete_srv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                delete_srv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                delete_srv.Image = global::RetaurantManagement.Properties.Resources.btn_delete;
                delete_srv.Location = new System.Drawing.Point(464, 1);
                // delete_srv.Name = serveur.num_srv.ToString();
                delete_srv.Name = "btn";
                delete_srv.Size = new System.Drawing.Size(36, 32);
                delete_srv.UseVisualStyleBackColor = false;
                delete_srv.Click += (s,e) => delete_srv_Click(s,e,serveur);



                panel_srv.Controls.Add(Id_srv);
                panel_srv.Controls.Add(Nom_srv);
                panel_srv.Controls.Add(Prenom_srv);
                panel_srv.Controls.Add(update_srv);
                panel_srv.Controls.Add(delete_srv);
                this.Controls.Add(panel_srv);
                y = y + 50;
            }
        }
        private void button1_Click_3(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            Button bt = (Button)sender;
            int id = Int16.Parse(bt.Name.ToString());
            Serveur serveur = myDB.Serveurs.Where(x => x.num_srv == id).First();
            Up_Serveur s = new Up_Serveur(id);
            s.Show();


        }

        private void delete_srv_Click(object sender, EventArgs e,Serveur s)
        {
            MyDB myDB = new MyDB();
            myDB.Entry(s).State = EntityState.Deleted;
            myDB.SaveChanges();
        }
    }
}
