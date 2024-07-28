namespace Interfaz_Proyecto
{
    partial class LoginStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginStaff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIST = new System.Windows.Forms.Button();
            this.PDatos = new System.Windows.Forms.Panel();
            this.txtPasss = new System.Windows.Forms.TextBox();
            this.btnISA = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnVend = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnIST);
            this.panel1.Controls.Add(this.PDatos);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnVend);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 425);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnIST
            // 
            this.btnIST.Location = new System.Drawing.Point(105, 219);
            this.btnIST.Name = "btnIST";
            this.btnIST.Size = new System.Drawing.Size(212, 23);
            this.btnIST.TabIndex = 3;
            this.btnIST.Text = "Iniciar Sesion";
            this.btnIST.UseVisualStyleBackColor = true;
            this.btnIST.Click += new System.EventHandler(this.btnIST_Click);
            // 
            // PDatos
            // 
            this.PDatos.Controls.Add(this.txtPasss);
            this.PDatos.Controls.Add(this.btnISA);
            this.PDatos.Controls.Add(this.txtCorreo);
            this.PDatos.Controls.Add(this.label2);
            this.PDatos.Controls.Add(this.label1);
            this.PDatos.Location = new System.Drawing.Point(82, 101);
            this.PDatos.Name = "PDatos";
            this.PDatos.Size = new System.Drawing.Size(265, 153);
            this.PDatos.TabIndex = 2;
            // 
            // txtPasss
            // 
            this.txtPasss.Location = new System.Drawing.Point(23, 79);
            this.txtPasss.Name = "txtPasss";
            this.txtPasss.Size = new System.Drawing.Size(212, 20);
            this.txtPasss.TabIndex = 3;
            // 
            // btnISA
            // 
            this.btnISA.Location = new System.Drawing.Point(23, 118);
            this.btnISA.Name = "btnISA";
            this.btnISA.Size = new System.Drawing.Size(212, 23);
            this.btnISA.TabIndex = 4;
            this.btnISA.Text = "Iniciar Sesion";
            this.btnISA.UseVisualStyleBackColor = true;
            this.btnISA.Click += new System.EventHandler(this.btnISA_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(23, 33);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(212, 20);
            this.txtCorreo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(82, 101);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(259, 60);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnVend
            // 
            this.btnVend.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.btnVend.Location = new System.Drawing.Point(82, 182);
            this.btnVend.Name = "btnVend";
            this.btnVend.Size = new System.Drawing.Size(259, 60);
            this.btnVend.TabIndex = 0;
            this.btnVend.Text = "Vendedor";
            this.btnVend.UseVisualStyleBackColor = true;
            this.btnVend.Click += new System.EventHandler(this.btnVend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(447, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 356);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "LoginStaff";
            this.Text = "LoginStaff";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PDatos.ResumeLayout(false);
            this.PDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnVend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnISA;
        private System.Windows.Forms.Button btnIST;
        private System.Windows.Forms.Panel PDatos;
        private System.Windows.Forms.TextBox txtPasss;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}