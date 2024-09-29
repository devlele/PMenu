namespace PMenu
{
    partial class FrmExercicio5
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
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            txtPrimeiroNum = new TextBox();
            txtSegundoNum = new TextBox();
            btnSorteio = new Button();
            SuspendLayout();
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(94, 154);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(226, 20);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "Digite o primeiro número inteiro";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(94, 373);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(212, 20);
            lblNumero2.TabIndex = 1;
            lblNumero2.Text = "Digite o último número inteiro";
            // 
            // txtPrimeiroNum
            // 
            txtPrimeiroNum.Location = new Point(362, 154);
            txtPrimeiroNum.Name = "txtPrimeiroNum";
            txtPrimeiroNum.Size = new Size(125, 27);
            txtPrimeiroNum.TabIndex = 2;
            txtPrimeiroNum.Validating += txtPrimeiroNum_Validating;
            // 
            // txtSegundoNum
            // 
            txtSegundoNum.Location = new Point(362, 373);
            txtSegundoNum.Name = "txtSegundoNum";
            txtSegundoNum.Size = new Size(125, 27);
            txtSegundoNum.TabIndex = 3;
            txtSegundoNum.Validating += txtSegundoNum_Validating;
            // 
            // btnSorteio
            // 
            btnSorteio.Location = new Point(682, 222);
            btnSorteio.Name = "btnSorteio";
            btnSorteio.Size = new Size(137, 129);
            btnSorteio.TabIndex = 4;
            btnSorteio.Text = "Sortear";
            btnSorteio.UseVisualStyleBackColor = true;
            btnSorteio.Click += btnSorteio_Click;
            // 
            // FrmExercicio5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 554);
            Controls.Add(btnSorteio);
            Controls.Add(txtSegundoNum);
            Controls.Add(txtPrimeiroNum);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Name = "FrmExercicio5";
            Text = "FrmExercicio5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero1;
        private Label lblNumero2;
        private TextBox txtPrimeiroNum;
        private TextBox txtSegundoNum;
        private Button btnSorteio;
    }
}