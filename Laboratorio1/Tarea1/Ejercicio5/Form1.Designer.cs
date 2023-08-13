namespace Lab_ContadorDePalabras__
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oraciontxt = new System.Windows.Forms.TextBox();
            this.palabratxtb = new System.Windows.Forms.TextBox();
            this.resultadotxt = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palabra a buscar";
            // 
            // oraciontxt
            // 
            this.oraciontxt.Location = new System.Drawing.Point(306, 79);
            this.oraciontxt.Name = "oraciontxt";
            this.oraciontxt.Size = new System.Drawing.Size(163, 23);
            this.oraciontxt.TabIndex = 2;
            // 
            // palabratxtb
            // 
            this.palabratxtb.Location = new System.Drawing.Point(305, 175);
            this.palabratxtb.Name = "palabratxtb";
            this.palabratxtb.Size = new System.Drawing.Size(164, 23);
            this.palabratxtb.TabIndex = 3;
            // 
            // resultadotxt
            // 
            this.resultadotxt.AutoSize = true;
            this.resultadotxt.Location = new System.Drawing.Point(634, 162);
            this.resultadotxt.Name = "resultadotxt";
            this.resultadotxt.Size = new System.Drawing.Size(62, 15);
            this.resultadotxt.TabIndex = 4;
            this.resultadotxt.Text = "Resultado:";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(337, 261);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(118, 53);
            this.Buscar.TabIndex = 5;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.resultadotxt);
            this.Controls.Add(this.palabratxtb);
            this.Controls.Add(this.oraciontxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox oraciontxt;
        private TextBox palabratxtb;
        private Label resultadotxt;
        private Button Buscar;
    }
}