namespace PMenu
{
    partial class FrmExercicio3
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
            btnRemover = new Button();
            btnReverter = new Button();
            SuspendLayout();
            // 
            // lblPalavra1
            // 
            lblPalavra1.AutoSize = true;
            lblPalavra1.Location = new Point(139, 80);
            lblPalavra1.Name = "lblPalavra1";
            lblPalavra1.Size = new Size(162, 20);
            lblPalavra1.TabIndex = 0;
            lblPalavra1.Text = "Digite o primeiro texto";
            // 
            // lblPalavra2
            // 
            lblPalavra2.AutoSize = true;
            lblPalavra2.Location = new Point(533, 80);
            lblPalavra2.Name = "lblPalavra2";
            lblPalavra2.Size = new Size(162, 20);
            lblPalavra2.TabIndex = 1;
            lblPalavra2.Text = "Digite o segundo texto";
            // 
            // txtPalavra1
            // 
            txtPalavra1.Location = new Point(139, 122);
            txtPalavra1.Name = "txtPalavra1";
            txtPalavra1.Size = new Size(255, 27);
            txtPalavra1.TabIndex = 2;
            // 
            // txtPalavra2
            // 
            txtPalavra2.Location = new Point(533, 122);
            txtPalavra2.Name = "txtPalavra2";
            txtPalavra2.Size = new Size(255, 27);
            txtPalavra2.TabIndex = 3;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(139, 315);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(151, 50);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover ocorrências";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnReverter
            // 
            btnReverter.Location = new Point(533, 315);
            btnReverter.Name = "btnReverter";
            btnReverter.Size = new Size(151, 50);
            btnReverter.TabIndex = 5;
            btnReverter.Text = "Reverter texto";
            btnReverter.UseVisualStyleBackColor = true;
            btnReverter.Click += btnReverter_Click;
            // 
            // FrmExercicio3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 537);
            Controls.Add(btnReverter);
            Controls.Add(btnRemover);
            Controls.Add(txtPalavra2);
            Controls.Add(txtPalavra1);
            Controls.Add(lblPalavra2);
            Controls.Add(lblPalavra1);
            Name = "FrmExercicio3";
            Text = "FrmExercicio3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPalavra1;
        private Label lblPalavra2;
        private TextBox txtPalavra1;
        private TextBox txtPalavra2;
        private Button btnRemover;
        private Button btnReverter;
    }
}