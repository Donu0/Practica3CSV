namespace Practica3CSV
{
    partial class AplicacionCURP
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaCalculo = new DateTimePicker();
            btnCalcEdad = new Button();
            txtCurp = new TextBox();
            label1 = new Label();
            btnCalcular = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpFechaNacimiento, 0, 1);
            tableLayoutPanel1.Controls.Add(dtpFechaCalculo, 0, 3);
            tableLayoutPanel1.Controls.Add(btnCalcEdad, 1, 4);
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.5060234F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.49397F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(354, 166);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 0;
            label2.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 78);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 1;
            label3.Text = "Fecha Calculo";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(3, 23);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(171, 23);
            dtpFechaNacimiento.TabIndex = 2;
            dtpFechaNacimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtpFechaCalculo
            // 
            dtpFechaCalculo.Location = new Point(3, 100);
            dtpFechaCalculo.Name = "dtpFechaCalculo";
            dtpFechaCalculo.Size = new Size(171, 23);
            dtpFechaCalculo.TabIndex = 3;
            dtpFechaCalculo.ValueChanged += dtpFechaCalculo_ValueChanged;
            // 
            // btnCalcEdad
            // 
            btnCalcEdad.Location = new Point(180, 138);
            btnCalcEdad.Name = "btnCalcEdad";
            btnCalcEdad.Size = new Size(171, 23);
            btnCalcEdad.TabIndex = 4;
            btnCalcEdad.Text = "Calcular";
            btnCalcEdad.UseVisualStyleBackColor = true;
            btnCalcEdad.Click += btnCalcEdad_Click;
            // 
            // txtCurp
            // 
            txtCurp.Location = new Point(3, 202);
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(100, 23);
            txtCurp.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 184);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "CURP";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(183, 201);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(174, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // AplicacionCURP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(392, 259);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Controls.Add(txtCurp);
            Controls.Add(tableLayoutPanel1);
            Name = "AplicacionCURP";
            Text = "AplicacionCURP";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtCurp;
        private Label label1;
        private Button btnCalcular;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaCalculo;
        private Button btnCalcEdad;
    }
}