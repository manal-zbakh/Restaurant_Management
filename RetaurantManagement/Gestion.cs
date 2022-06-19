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
using RetaurantManagement.Forms;

namespace RetaurantManagement
{
    public partial class Gestion : Form
    {
        private Form activeForm;
        private Button currentButton;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
           int nleft,
           int nTop,
           int nRight,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse


           );
        public Gestion()
        {
            InitializeComponent();
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 5, 5));

        }

        private void Gestion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Commander c = new Commander();
            c.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Accueil a = new Accueil();
            a.Show();
            this.Hide();
        }

        void ActivateButton(Object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    disableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.Black;

                }
            }
        }

        void disableButton()
        {
            foreach (Control previousbtn in panelBtn.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {
                    Color color = Color.FromArgb(239, 217, 209);
                    previousbtn.BackColor = color;
                    previousbtn.ForeColor = Color.Black;

                }
            }
        }

        void OpenChildForm(Form childform, Object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            ActivateButton(btnsender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childform);
            this.panelForm.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormServeurs(), sender); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTables(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPlats(), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAffectation(), sender);
        }
    }
}
