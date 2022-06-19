using RetaurantManagement.data;
using RetaurantManagement.Update_Froms;
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

namespace RetaurantManagement.Forms
{
    
    public partial class FormPlats : Form
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
        public FormPlats()
        {
            InitializeComponent();
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 30, 30));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 30, 30));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 30, 30));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 30, 30));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            libelle_inpt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, libelle_inpt.Width, libelle_inpt.Height, 10, 10));
            prix_inpt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, prix_inpt.Width, prix_inpt.Height, 10, 10));
            comboBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox1.Width, comboBox1.Height, 20, 20));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            Plat plats = new Plat();
            plats.libelle = libelle_inpt.Text;
            Type type = myDB.Types.Where(x => x.libelle.Equals(comboBox1.Text)).First();
            plats.Type = type;
            plats.prix = Int32.Parse(prix_inpt.Text.ToString());
            myDB.Plats.Add(plats);
            myDB.SaveChanges();

        }

        private void FormPlats_Load(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            List<Plat> plats = myDB.Plats.Include("Type").ToList();
            int y = 0;
            foreach (Plat plat in plats)
            {
                System.Windows.Forms.Panel panel_plt;
                panel_plt = new System.Windows.Forms.Panel();

                System.Windows.Forms.Label code_plt;
                code_plt = new System.Windows.Forms.Label();

                System.Windows.Forms.Label prix_plt;
                prix_plt = new System.Windows.Forms.Label();

                System.Windows.Forms.Label type_plt;
                type_plt = new System.Windows.Forms.Label();

                System.Windows.Forms.Label libelle_plt;
                libelle_plt = new System.Windows.Forms.Label();

                System.Windows.Forms.Button delete_plt;
                delete_plt = new System.Windows.Forms.Button();

                System.Windows.Forms.Button update_plt;
                update_plt = new System.Windows.Forms.Button();


                panel_plt.SuspendLayout();
                panel_plt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
                panel_plt.Location = new System.Drawing.Point(21, 75+y);
                panel_plt.Name = "panel_plt";
                panel_plt.Size = new System.Drawing.Size(411, 34);
                panel_plt.TabIndex = 18;

                //code
                code_plt.AutoSize = true;
                code_plt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                code_plt.Location = new System.Drawing.Point(12, 10);
                code_plt.Name = "code_plt";
                code_plt.Size = new System.Drawing.Size(35, 13);
                code_plt.TabIndex = 19;
                code_plt.Text = plat.code_plat.ToString();

                //libelle
                libelle_plt.AutoSize = true;
                libelle_plt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                libelle_plt.Location = new System.Drawing.Point(84, 12);
                libelle_plt.Name = "libelle_plt";
                libelle_plt.Size = new System.Drawing.Size(40, 13);
                libelle_plt.TabIndex = 23;
                libelle_plt.Text = plat.libelle;

                //type
                type_plt.AutoSize = true;
                type_plt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                type_plt.Location = new System.Drawing.Point(165, 12);
                type_plt.Name = "type_plt";
                type_plt.Size = new System.Drawing.Size(31, 13);
                type_plt.TabIndex = 22;
                type_plt.Text = plat.Type.libelle;

                //prix
                prix_plt.AutoSize = true;
                prix_plt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                prix_plt.Location = new System.Drawing.Point(234, 12);
                prix_plt.Name = "prix_plt";
                prix_plt.Size = new System.Drawing.Size(27, 13);
                prix_plt.TabIndex = 21;
                prix_plt.Text = plat.prix.ToString();

                //update_btn
                update_plt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
                update_plt.FlatAppearance.BorderSize = 0;
                update_plt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                update_plt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                update_plt.Image = global::RetaurantManagement.Properties.Resources.btn_edite;
                update_plt.Location = new System.Drawing.Point(308, 0);
                update_plt.Name = plat.code_plat.ToString();
                update_plt.Size = new System.Drawing.Size(36, 34);
                update_plt.TabIndex = 15;
                update_plt.UseVisualStyleBackColor = false;
                update_plt.Click += new System.EventHandler(this.button1_Click);


                //delete_btn
                delete_plt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
                delete_plt.FlatAppearance.BorderSize = 0;
                delete_plt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                delete_plt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                delete_plt.Image = global::RetaurantManagement.Properties.Resources.btn_delete;
                delete_plt.Location = new System.Drawing.Point(369, 1);
                delete_plt.Name = "delete_plt";
                delete_plt.Size = new System.Drawing.Size(36, 32);
                delete_plt.TabIndex = 16;
                delete_plt.UseVisualStyleBackColor = false;
                delete_plt.Click += (s, ev) => button2_Click(s, ev, plat);




                panel_plt.Controls.Add(prix_plt);
                panel_plt.Controls.Add(type_plt);
                panel_plt.Controls.Add(libelle_plt);
                panel_plt.Controls.Add(code_plt);
                panel_plt.Controls.Add(delete_plt);
                panel_plt.Controls.Add(update_plt);
                this.Controls.Add(panel_plt);
                y = y + 50;

            }

            comboBox1.DataSource = myDB.Types.ToArray();
            comboBox1.DisplayMember = "libelle";
            comboBox1.ValueMember = "libelle";
            comboBox1.Text = "choisir un type";

        }

        private void button2_Click(object sender, EventArgs e,Plat p)
        {
            MyDB myDB = new MyDB();
            myDB.Entry(p).State = EntityState.Deleted;
            myDB.SaveChanges();

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (libelle_inpt.Text == "libelle")
            {
                libelle_inpt.Text = "";
                libelle_inpt.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (libelle_inpt.Text == "")
            {
                libelle_inpt.Text = "libelle";
                libelle_inpt.ForeColor = Color.Silver;
            }
        }


        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (prix_inpt.Text == "prix")
            {
                prix_inpt.Text = "";
                prix_inpt.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (prix_inpt.Text == "")
            {
                prix_inpt.Text = "prix";
                prix_inpt.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            Button bt = (Button)sender;
            int id = Int16.Parse(bt.Name.ToString());
            Plat plat = myDB.Plats.Where(x => x.code_plat == id).First();

            Up_Plat p = new Up_Plat(id);
            p.Show();


        }

    }
}
