namespace Clase_4___Consultorio_con_cola
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
            groupBox1 = new GroupBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmdIngreso = new Button();
            button1 = new Button();
            lstEspera = new ListBox();
            lstSobreturno = new ListBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingreso";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(153, 34);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(153, 74);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(153, 34);
            txtApellido.TabIndex = 4;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(153, 30);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(153, 34);
            txtDNI.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 117);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 2;
            label3.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 1;
            label2.Text = "APELLIDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // cmdIngreso
            // 
            cmdIngreso.BackColor = Color.FromArgb(255, 128, 0);
            cmdIngreso.Location = new Point(176, 194);
            cmdIngreso.Name = "cmdIngreso";
            cmdIngreso.Size = new Size(178, 48);
            cmdIngreso.TabIndex = 1;
            cmdIngreso.Text = "Ingresar";
            cmdIngreso.UseVisualStyleBackColor = false;
            cmdIngreso.Click += cmdIngreso_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(18, 364);
            button1.Name = "button1";
            button1.Size = new Size(336, 48);
            button1.TabIndex = 2;
            button1.Text = "LLAMAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lstEspera
            // 
            lstEspera.FormattingEnabled = true;
            lstEspera.ItemHeight = 28;
            lstEspera.Location = new Point(371, 39);
            lstEspera.Name = "lstEspera";
            lstEspera.Size = new Size(207, 228);
            lstEspera.TabIndex = 3;
            // 
            // lstSobreturno
            // 
            lstSobreturno.FormattingEnabled = true;
            lstSobreturno.ItemHeight = 28;
            lstSobreturno.Location = new Point(371, 296);
            lstSobreturno.Name = "lstSobreturno";
            lstSobreturno.Size = new Size(207, 116);
            lstSobreturno.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 265);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 5;
            label4.Text = "SOBRETURNO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 8);
            label5.Name = "label5";
            label5.Size = new Size(79, 28);
            label5.TabIndex = 6;
            label5.Text = "ESPERA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(601, 424);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lstSobreturno);
            Controls.Add(lstEspera);
            Controls.Add(button1);
            Controls.Add(cmdIngreso);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button cmdIngreso;
        private Button button1;
        private ListBox lstEspera;
        private ListBox lstSobreturno;
        private Label label4;
        private Label label5;
    }
}