namespace PracticaCrud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inicioControlPersonalizado1 = new PracticaCrud.InicioControlPersonalizado();
            this.estudianteControlPersonalizado1 = new PracticaCrud.estudianteControlPersonalizado();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 517);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(22, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "Estudiante";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(22, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(217, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 58);
            this.panel2.TabIndex = 1;
            // 
            // inicioControlPersonalizado1
            // 
            this.inicioControlPersonalizado1.Location = new System.Drawing.Point(265, 96);
            this.inicioControlPersonalizado1.Name = "inicioControlPersonalizado1";
            this.inicioControlPersonalizado1.Size = new System.Drawing.Size(555, 398);
            this.inicioControlPersonalizado1.TabIndex = 2;
            // 
            // estudianteControlPersonalizado1
            // 
            this.estudianteControlPersonalizado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.estudianteControlPersonalizado1.Location = new System.Drawing.Point(223, 64);
            this.estudianteControlPersonalizado1.Name = "estudianteControlPersonalizado1";
            this.estudianteControlPersonalizado1.Size = new System.Drawing.Size(666, 441);
            this.estudianteControlPersonalizado1.TabIndex = 3;
            this.estudianteControlPersonalizado1.Load += new System.EventHandler(this.estudianteControlPersonalizado1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 517);
            this.Controls.Add(this.estudianteControlPersonalizado1);
            this.Controls.Add(this.inicioControlPersonalizado1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private InicioControlPersonalizado inicioControlPersonalizado1;
        private estudianteControlPersonalizado estudianteControlPersonalizado1;
    }
}