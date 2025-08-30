namespace NumerosAleatorios
{
    partial class frmEmpleado
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
            btnPrueba = new Button();
            textnum = new TextBox();
            textname = new TextBox();
            datefec = new DateTimePicker();
            texsueld = new TextBox();
            lblNombre = new Label();
            lblNumero = new Label();
            chkMasculino = new RadioButton();
            chkFemenino = new RadioButton();
            checkmedi = new CheckBox();
            comgrup = new ComboBox();
            lblFechaNacimiento = new Label();
            labegrup = new Label();
            labsuel = new Label();
            SuspendLayout();
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(343, 409);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(270, 29);
            btnPrueba.TabIndex = 0;
            btnPrueba.Text = "Generar Datos Aleatorios";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // textnum
            // 
            textnum.Location = new Point(81, 31);
            textnum.Name = "textnum";
            textnum.Size = new Size(125, 27);
            textnum.TabIndex = 1;
            // 
            // textname
            // 
            textname.Location = new Point(81, 92);
            textname.Name = "textname";
            textname.Size = new Size(428, 27);
            textname.TabIndex = 2;
            // 
            // datefec
            // 
            datefec.Location = new Point(187, 154);
            datefec.Name = "datefec";
            datefec.Size = new Size(348, 27);
            datefec.TabIndex = 3;
            // 
            // texsueld
            // 
            texsueld.Location = new Point(81, 356);
            texsueld.Name = "texsueld";
            texsueld.Size = new Size(125, 27);
            texsueld.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 92);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(12, 31);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(66, 20);
            lblNumero.TabIndex = 6;
            lblNumero.Text = "Numero:";
            // 
            // chkMasculino
            // 
            chkMasculino.AutoSize = true;
            chkMasculino.Location = new Point(213, 206);
            chkMasculino.Name = "chkMasculino";
            chkMasculino.Size = new Size(97, 24);
            chkMasculino.TabIndex = 7;
            chkMasculino.TabStop = true;
            chkMasculino.Text = "Masculino";
            chkMasculino.UseVisualStyleBackColor = true;
            // 
            // chkFemenino
            // 
            chkFemenino.AutoSize = true;
            chkFemenino.Location = new Point(213, 246);
            chkFemenino.Name = "chkFemenino";
            chkFemenino.Size = new Size(95, 24);
            chkFemenino.TabIndex = 8;
            chkFemenino.TabStop = true;
            chkFemenino.Text = "Femenino";
            chkFemenino.UseVisualStyleBackColor = true;
            // 
            // checkmedi
            // 
            checkmedi.AutoSize = true;
            checkmedi.Location = new Point(364, 369);
            checkmedi.Name = "checkmedi";
            checkmedi.Size = new Size(132, 24);
            checkmedi.TabIndex = 9;
            checkmedi.Text = "Seguro Medico";
            checkmedi.UseVisualStyleBackColor = true;
            // 
            // comgrup
            // 
            comgrup.FormattingEnabled = true;
            comgrup.Location = new Point(68, 293);
            comgrup.Name = "comgrup";
            comgrup.Size = new Size(151, 28);
            comgrup.TabIndex = 10;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(21, 154);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(152, 20);
            lblFechaNacimiento.TabIndex = 11;
            lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // labegrup
            // 
            labegrup.AutoSize = true;
            labegrup.Location = new Point(12, 296);
            labegrup.Name = "labegrup";
            labegrup.Size = new Size(53, 20);
            labegrup.TabIndex = 12;
            labegrup.Text = "Grupo:";
            // 
            // labsuel
            // 
            labsuel.AutoSize = true;
            labsuel.Location = new Point(20, 356);
            labsuel.Name = "labsuel";
            labsuel.Size = new Size(58, 20);
            labsuel.TabIndex = 13;
            labsuel.Text = "Sueldo:";
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labsuel);
            Controls.Add(labegrup);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(comgrup);
            Controls.Add(checkmedi);
            Controls.Add(chkFemenino);
            Controls.Add(chkMasculino);
            Controls.Add(lblNumero);
            Controls.Add(lblNombre);
            Controls.Add(texsueld);
            Controls.Add(datefec);
            Controls.Add(textname);
            Controls.Add(textnum);
            Controls.Add(btnPrueba);
            Name = "frmEmpleado";
            Text = "Empleado con datos aleatorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrueba;
        private TextBox textnum;
        private TextBox textname;
        private DateTimePicker datefec;
        private TextBox texsueld;
        private Label lblNombre;
        private Label lblNumero;
        private RadioButton chkMasculino;
        private RadioButton chkFemenino;
        private CheckBox checkmedi;
        private ComboBox comgrup;
        private Label lblFechaNacimiento;
        private Label labegrup;
        private Label labsuel;
    }
}
