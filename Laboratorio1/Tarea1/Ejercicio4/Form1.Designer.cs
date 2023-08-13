namespace labUno.ejer4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.contarpalabrasbtn = new System.Windows.Forms.Button();
            this.textobox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba las palabras que desea contar";
            // 
            // contarpalabrasbtn
            // 
            this.contarpalabrasbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contarpalabrasbtn.Location = new System.Drawing.Point(315, 160);
            this.contarpalabrasbtn.Name = "contarpalabrasbtn";
            this.contarpalabrasbtn.Size = new System.Drawing.Size(90, 37);
            this.contarpalabrasbtn.TabIndex = 1;
            this.contarpalabrasbtn.Text = "Contar";
            this.contarpalabrasbtn.UseVisualStyleBackColor = true;
            this.contarpalabrasbtn.Click += new System.EventHandler(this.contarpalabrasbtn_Click);
            // 
            // textobox
            // 
            this.textobox.Location = new System.Drawing.Point(219, 116);
            this.textobox.Name = "textobox";
            this.textobox.Size = new System.Drawing.Size(316, 22);
            this.textobox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textobox);
            this.Controls.Add(this.contarpalabrasbtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button contarpalabrasbtn;
        private System.Windows.Forms.TextBox textobox;
    }
}

