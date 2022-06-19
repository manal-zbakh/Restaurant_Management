namespace RetaurantManagement.Forms
{
    partial class FormServeurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_srv = new System.Windows.Forms.Button();
            this.panel_add_srv = new System.Windows.Forms.Panel();
            this.add_prenom_srv = new System.Windows.Forms.TextBox();
            this.add_name_srv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_add_srv.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_srv
            // 
            this.add_srv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            this.add_srv.FlatAppearance.BorderSize = 0;
            this.add_srv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_srv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_srv.Location = new System.Drawing.Point(579, 306);
            this.add_srv.Name = "add_srv";
            this.add_srv.Size = new System.Drawing.Size(170, 29);
            this.add_srv.TabIndex = 4;
            this.add_srv.Text = "+ Ajouter";
            this.add_srv.UseVisualStyleBackColor = false;
            this.add_srv.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel_add_srv
            // 
            this.panel_add_srv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(217)))), ((int)(((byte)(209)))));
            this.panel_add_srv.Controls.Add(this.add_prenom_srv);
            this.panel_add_srv.Controls.Add(this.add_name_srv);
            this.panel_add_srv.Location = new System.Drawing.Point(541, 255);
            this.panel_add_srv.Name = "panel_add_srv";
            this.panel_add_srv.Size = new System.Drawing.Size(249, 34);
            this.panel_add_srv.TabIndex = 5;
            // 
            // add_prenom_srv
            // 
            this.add_prenom_srv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.add_prenom_srv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_prenom_srv.ForeColor = System.Drawing.Color.Silver;
            this.add_prenom_srv.Location = new System.Drawing.Point(158, 8);
            this.add_prenom_srv.Name = "add_prenom_srv";
            this.add_prenom_srv.Size = new System.Drawing.Size(82, 15);
            this.add_prenom_srv.TabIndex = 7;
            this.add_prenom_srv.Text = "Prénom";
            this.add_prenom_srv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.add_prenom_srv.Enter += new System.EventHandler(this.textBox2_Enter);
            this.add_prenom_srv.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // add_name_srv
            // 
            this.add_name_srv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.add_name_srv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_name_srv.ForeColor = System.Drawing.Color.Silver;
            this.add_name_srv.Location = new System.Drawing.Point(14, 8);
            this.add_name_srv.Name = "add_name_srv";
            this.add_name_srv.Size = new System.Drawing.Size(82, 15);
            this.add_name_srv.TabIndex = 6;
            this.add_name_srv.Text = "Nom";
            this.add_name_srv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.add_name_srv.Enter += new System.EventHandler(this.textBox1_Enter);
            this.add_name_srv.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Action";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(21, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 33);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(148, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 33);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(267, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(84, 33);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(156)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(432, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(89, 33);
            this.panel5.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RetaurantManagement.Properties.Resources.serveurs;
            this.pictureBox1.Location = new System.Drawing.Point(589, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormServeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 358);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_add_srv);
            this.Controls.Add(this.add_srv);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(876, 397);
            this.MinimumSize = new System.Drawing.Size(876, 397);
            this.Name = "FormServeurs";
            this.Text = "FormServeurs";
            this.Load += new System.EventHandler(this.FormServeurs_Load);
            this.panel_add_srv.ResumeLayout(false);
            this.panel_add_srv.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button add_srv;
        private System.Windows.Forms.Panel panel_add_srv;
        private System.Windows.Forms.TextBox add_prenom_srv;
        private System.Windows.Forms.TextBox add_name_srv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}