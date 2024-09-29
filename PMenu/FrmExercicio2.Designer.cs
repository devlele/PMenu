namespace PMenu
{
    partial class FrmExercicio2
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
            lblPalavra1 = new Label();
            lblPalavra2 = new Label();
            txtPalavra1 = new TextBox();
            txtPalavra2 = new TextBox();
            btnCompara = new Button();
            btnInserir1 = new Button();
            btnInserir2 = new Button();
            SuspendLayout();
            // 
            // lblPalavra1
            // 
            lblPalavra1.AutoSize = true;
            lblPalavra1.Location = new Point(240, 49);
            lblPalavra1.Name = "lblPalavra1";
            lblPalavra1.Size = new Size(68, 20);
            lblPalavra1.TabIndex = 0;
            lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            lblPalavra2.AutoSize = true;
            lblPalavra2.Location = new Point(240, 196);
            lblPalavra2.Name = "lblPalavra2";
            lblPalavra2.Size = new Size(68, 20);
            lblPalavra2.TabIndex = 1;
            lblPalavra2.Text = "Palavra 2";
            // 
            // txtPalavra1
            // 
            txtPalavra1.Location = new Point(354, 39);
            txtPalavra1.Margin = new Padding(3, 4, 3, 4);
            txtPalavra1.Name = "txtPalavra1";
            txtPalavra1.Size = new Size(114, 27);
            txtPalavra1.TabIndex = 2;
            // 
            // txtPalavra2
            // 
            txtPalavra2.Location = new Point(354, 185);
            txtPalavra2.Margin = new Padding(3, 4, 3, 4);
            txtPalavra2.Name = "txtPalavra2";
            txtPalavra2.Size = new Size(114, 27);
            txtPalavra2.TabIndex = 3;
            // 
            // btnCompara
            // 
            btnCompara.Location = new Point(161, 279);
            btnCompara.Margin = new Padding(3, 4, 3, 4);
            btnCompara.Name = "btnCompara";
            btnCompara.Size = new Size(122, 53);
            btnCompara.TabIndex = 4;
            btnCompara.Text = "Comparar";
            btnCompara.UseVisualStyleBackColor = true;
            btnCompara.Click += btnCompara_Click;
            // 
            // btnInserir1
            // 
            btnInserir1.Location = new Point(313, 279);
            btnInserir1.Margin = new Padding(3, 4, 3, 4);
            btnInserir1.Name = "btnInserir1";
            btnInserir1.Size = new Size(137, 53);
            btnInserir1.TabIndex = 5;
            btnInserir1.Text = "Inserir 1º no meio do 2º";
            btnInserir1.UseVisualStyleBackColor = true;
            btnInserir1.Click += btnInserir1_Click;
            // 
            // btnInserir2
            // 
            btnInserir2.Location = new Point(482, 279);
            btnInserir2.Margin = new Padding(3, 4, 3, 4);
            btnInserir2.Name = "btnInserir2";
            btnInserir2.Size = new Size(129, 53);
            btnInserir2.TabIndex = 6;
            btnInserir2.Text = "Inserir 2 asteriscos";
            btnInserir2.UseVisualStyleBackColor = true;
            btnInserir2.Click += btnInserir2_Click;
            // 
            // FrmExercicio2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnInserir2);
            Controls.Add(btnInserir1);
            Controls.Add(btnCompara);
            Controls.Add(txtPalavra2);
            Controls.Add(txtPalavra1);
            Controls.Add(lblPalavra2);
            Controls.Add(lblPalavra1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmExercicio2";
            Text = "FrmExercicio2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPalavra1;
        private Label lblPalavra2;
        private TextBox txtPalavra1;
        private TextBox txtPalavra2;
        private Button btnCompara;
        private Button btnInserir1;
        private Button btnInserir2;
    }
}