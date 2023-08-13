namespace Ejercico1
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
            llblBaseMayor = new Label();
            lblBaseMenor = new Label();
            lblAltura = new Label();
            lblLado1 = new Label();
            lblResultadoArea = new Label();
            lblLado2 = new Label();
            lblResultadoPerimetro = new Label();
            txtBaseMayor = new TextBox();
            txtBaseMenor = new TextBox();
            txtAltura = new TextBox();
            txtLado1 = new TextBox();
            txtLado2 = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // llblBaseMayor
            // 
            llblBaseMayor.AutoSize = true;
            llblBaseMayor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            llblBaseMayor.Location = new Point(161, 9);
            llblBaseMayor.Name = "llblBaseMayor";
            llblBaseMayor.Size = new Size(195, 21);
            llblBaseMayor.TabIndex = 0;
            llblBaseMayor.Text = "Base mayor del Trapecio";
            // 
            // lblBaseMenor
            // 
            lblBaseMenor.AutoSize = true;
            lblBaseMenor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaseMenor.Location = new Point(156, 68);
            lblBaseMenor.Name = "lblBaseMenor";
            lblBaseMenor.Size = new Size(200, 21);
            lblBaseMenor.TabIndex = 1;
            lblBaseMenor.Text = "Base menor del Trapecio ";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAltura.Location = new Point(221, 131);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(57, 21);
            lblAltura.TabIndex = 2;
            lblAltura.Text = "Altura";
            // 
            // lblLado1
            // 
            lblLado1.AutoSize = true;
            lblLado1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLado1.Location = new Point(222, 191);
            lblLado1.Name = "lblLado1";
            lblLado1.Size = new Size(56, 21);
            lblLado1.TabIndex = 3;
            lblLado1.Text = "Lado1";
            // 
            // lblResultadoArea
            // 
            lblResultadoArea.AutoSize = true;
            lblResultadoArea.Location = new Point(195, 371);
            lblResultadoArea.Name = "lblResultadoArea";
            lblResultadoArea.Size = new Size(83, 15);
            lblResultadoArea.TabIndex = 4;
            lblResultadoArea.Text = "ResultadoArea";
            // 
            // lblLado2
            // 
            lblLado2.AutoSize = true;
            lblLado2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLado2.Location = new Point(222, 252);
            lblLado2.Name = "lblLado2";
            lblLado2.Size = new Size(56, 21);
            lblLado2.TabIndex = 5;
            lblLado2.Text = "Lado2";
            // 
            // lblResultadoPerimetro
            // 
            lblResultadoPerimetro.AutoSize = true;
            lblResultadoPerimetro.Location = new Point(195, 406);
            lblResultadoPerimetro.Name = "lblResultadoPerimetro";
            lblResultadoPerimetro.Size = new Size(111, 15);
            lblResultadoPerimetro.TabIndex = 6;
            lblResultadoPerimetro.Text = "ResultadoPerimetro";
            // 
            // txtBaseMayor
            // 
            txtBaseMayor.BackColor = SystemColors.ControlLight;
            txtBaseMayor.Location = new Point(174, 42);
            txtBaseMayor.Name = "txtBaseMayor";
            txtBaseMayor.Size = new Size(140, 23);
            txtBaseMayor.TabIndex = 7;
            // 
            // txtBaseMenor
            // 
            txtBaseMenor.BackColor = SystemColors.ScrollBar;
            txtBaseMenor.Location = new Point(174, 105);
            txtBaseMenor.Name = "txtBaseMenor";
            txtBaseMenor.Size = new Size(140, 23);
            txtBaseMenor.TabIndex = 8;
            // 
            // txtAltura
            // 
            txtAltura.BackColor = SystemColors.ScrollBar;
            txtAltura.Location = new Point(195, 161);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 9;
            // 
            // txtLado1
            // 
            txtLado1.BackColor = SystemColors.ScrollBar;
            txtLado1.Location = new Point(195, 215);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(100, 23);
            txtLado1.TabIndex = 10;
            // 
            // txtLado2
            // 
            txtLado2.BackColor = SystemColors.ScrollBar;
            txtLado2.Location = new Point(195, 286);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(100, 23);
            txtLado2.TabIndex = 11;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.AppWorkspace;
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(256, 315);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 30);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveBorder;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(139, 315);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 30);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 434);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtLado2);
            Controls.Add(txtLado1);
            Controls.Add(txtAltura);
            Controls.Add(txtBaseMenor);
            Controls.Add(txtBaseMayor);
            Controls.Add(lblResultadoPerimetro);
            Controls.Add(lblLado2);
            Controls.Add(lblResultadoArea);
            Controls.Add(lblLado1);
            Controls.Add(lblAltura);
            Controls.Add(lblBaseMenor);
            Controls.Add(llblBaseMayor);
            Name = "Form1";
            Text = "Form1";
            Click += btnCalcular_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label llblBaseMayor;
        private Label lblBaseMenor;
        private Label lblAltura;
        private Label lblLado1;
        private Label lblResultadoArea;
        private Label lblLado2;
        private Label lblResultadoPerimetro;
        private TextBox txtBaseMayor;
        private TextBox txtBaseMenor;
        private TextBox txtAltura;
        private TextBox txtLado1;
        private TextBox txtLado2;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}