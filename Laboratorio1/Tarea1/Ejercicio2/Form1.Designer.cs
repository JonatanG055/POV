namespace Ejecicio2
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
            components = new System.ComponentModel.Container();
            txtInput1 = new TextBox();
            txtInput2 = new TextBox();
            btnCheckAnagram = new Button();
            lblResult = new Label();
            errorProvider = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtInput1
            // 
            txtInput1.BackColor = SystemColors.InactiveCaption;
            txtInput1.Location = new Point(184, 40);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(100, 23);
            txtInput1.TabIndex = 0;
            txtInput1.TextChanged += btnCheckAnagram_Click;
            txtInput1.Validating += txtInput1_Validating;
            // 
            // txtInput2
            // 
            txtInput2.BackColor = SystemColors.InactiveCaption;
            txtInput2.Location = new Point(184, 109);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(100, 23);
            txtInput2.TabIndex = 1;
            // 
            // btnCheckAnagram
            // 
            btnCheckAnagram.BackColor = SystemColors.ButtonShadow;
            btnCheckAnagram.Location = new Point(255, 164);
            btnCheckAnagram.Name = "btnCheckAnagram";
            btnCheckAnagram.Size = new Size(75, 23);
            btnCheckAnagram.TabIndex = 2;
            btnCheckAnagram.Text = "Verificar";
            btnCheckAnagram.UseVisualStyleBackColor = false;
            btnCheckAnagram.Click += btnCheckAnagram_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(206, 201);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(61, 17);
            lblResult.TabIndex = 3;
            lblResult.Text = "Resultado";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 4;
            label1.Text = "Palabra1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(206, 80);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 5;
            label2.Text = "Palabra2";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.AppWorkspace;
            btnClear.Location = new Point(145, 164);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 299);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnCheckAnagram);
            Controls.Add(txtInput2);
            Controls.Add(txtInput1);
            Name = "Form1";
            Text = "Form1";
            Click += btnCheckAnagram_Click;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput1;
        private TextBox txtInput2;
        private Button btnCheckAnagram;
        private Label lblResult;
        private ErrorProvider errorProvider;
        private Label label2;
        private Label label1;
        private Button btnClear;
    }
}