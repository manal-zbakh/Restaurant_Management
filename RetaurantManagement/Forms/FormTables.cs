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

namespace RetaurantManagement.Forms
{
    public partial class FormTables : Form
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
        public FormTables()
        {
            InitializeComponent();
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 30, 30));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 30, 30));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            nbr_plc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, nbr_plc.Width, nbr_plc.Height, 10, 10));
           }

        private void button3_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            Table tables = new Table();
            tables.nb_place = Int32.Parse(nbr_plc.Text);
            myDB.Tables.Add(tables);
            myDB.SaveChanges();
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (nbr_plc.Text == "Nbr palce")
            {
                nbr_plc.Text = "";
                nbr_plc.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (nbr_plc.Text == "")
            {
                nbr_plc.Text = "date cmd";
                nbr_plc.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            Button bt = (Button)sender;
            int id = Int16.Parse(bt.Name.ToString());
            Table table = myDB.Tables.Where(x => x.num_tab == id).First();
            Up_Table t = new Up_Table(id);
            t.Show();
        }

        private void FormTables_Load(object sender, EventArgs e)
        {
            MyDB myDB = new MyDB();
            List<Table> tables = myDB.Tables.ToList();  
            int y = 0;

            foreach (Table table in tables)
            {
                System.Windows.Forms.Panel panel_tbl;
                panel_tbl = new System.Windows.Forms.Panel();

                System.Windows.Forms.Label Id_tbl;
                Id_tbl = new System.Windows.Forms.Label();

                System.Windows.Forms.Label Nbr_place;
                Nbr_place = new System.Windows.Forms.Label();

                System.Windows.Forms.Button delete_tbl;
                delete_tbl = new System.Windows.Forms.Button();

                System.Windows.Forms.Button update_tbl;
                update_tbl = new System.Windows.Forms.Button();

                panel_tbl.SuspendLayout();
                panel_tbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
                panel_tbl.Location = new System.Drawing.Point(21, 75+y);
                panel_tbl.Name = "panel_tbl";
                panel_tbl.Size = new System.Drawing.Size(433, 34);
                panel_tbl.TabIndex = 15;

                //id
                Id_tbl.AutoSize = true;
                Id_tbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Id_tbl.Location = new System.Drawing.Point(28, 11);
                Id_tbl.Name = "Id_tbl";
                Id_tbl.Size = new System.Drawing.Size(18, 13);
                Id_tbl.TabIndex = 16;
                Id_tbl.Text = table.num_tab.ToString();
                //Id_tbl.Click += new System.EventHandler(this.Id_tbl_Click);

                //Nbr_place
                Nbr_place.AutoSize = true;
                Nbr_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Nbr_place.Location = new System.Drawing.Point(172, 11);
                Nbr_place.Name = "Nbr_place";
                Nbr_place.Size = new System.Drawing.Size(50, 13);
                Nbr_place.TabIndex = 17;
                //  Nbr_place.Text = table.nb_place.ToString();
                Nbr_place.Text = table.nb_place.ToString();

                //button update
                update_tbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
                update_tbl.FlatAppearance.BorderSize = 0;
                update_tbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                update_tbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                update_tbl.Image = global::RetaurantManagement.Properties.Resources.btn_edite;
                update_tbl.Location = new System.Drawing.Point(325, 0);
                update_tbl.Name = table.num_tab.ToString();
                update_tbl.Size = new System.Drawing.Size(36, 34);
                update_tbl.TabIndex = 15;
                update_tbl.UseVisualStyleBackColor = false;
                update_tbl.Click += new System.EventHandler(this.button1_Click);

                //button delete
                delete_tbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
                delete_tbl.FlatAppearance.BorderSize = 0;
                delete_tbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                delete_tbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                delete_tbl.Image = global::RetaurantManagement.Properties.Resources.btn_delete;
                delete_tbl.Location = new System.Drawing.Point(391, 2);
                delete_tbl.Name = "delete_tbl";
                delete_tbl.Size = new System.Drawing.Size(36, 32);
                delete_tbl.TabIndex = 16;
                delete_tbl.UseVisualStyleBackColor = false;
                delete_tbl.Click += (s,ev) => delete_tbl_Click(s,ev, table);



                panel_tbl.Controls.Add(delete_tbl);
                panel_tbl.Controls.Add(update_tbl);
                panel_tbl.Controls.Add(Id_tbl);
                panel_tbl.Controls.Add(Nbr_place);
                this.Controls.Add(panel_tbl);

                y = y + 50;
            }

            
        }

        private void delete_tbl_Click(object sender, EventArgs e,Table t)
        {
            
            MyDB myDB = new MyDB();
            myDB.Entry(t).State = EntityState.Deleted;
            myDB.SaveChanges();
        }
    }
}
