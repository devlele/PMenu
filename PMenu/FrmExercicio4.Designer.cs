namespace PMenu
{
    partial class FrmExercicio4
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
            richTxtTexto = new RichTextBox();
            btnContNum = new Button();
            btnBranco = new Button();
            btnContLetra = new Button();
            SuspendLayout();
            // 
            // richTxtTexto
            // 
            richTxtTexto.Location = new Point(77, 71);
            richTxtTexto.Name = "richTxtTexto";
            richTxtTexto.Size = new Size(739, 120);
            richTxtTexto.TabIndex = 0;
            richTxtTexto.Text = "";
            // 
            // btnContNum
            // 
            btnContNum.Location = new Point(77, 283);
            btnContNum.Name = "btnContNum";
            btnContNum.Size = new Size(157, 66);
            btnContNum.TabIndex = 1;
            btnContNum.Text = "Contagem de números";
            btnContNum.UseVisualStyleBackColor = true;
            btnContNum.Click += btnContNum_Click;
            // 
            // btnBranco
            // 
            btnBranco.Location = new Point(356, 283);
            btnBranco.Name = "btnBranco";
            btnBranco.Size = new Size(157, 66);
            btnBranco.TabIndex = 2;
            btnBranco.Text = "Posição caracter em branco";
            btnBranco.UseVisualStyleBackColor = true;
            btnBranco.Click += btnBranco_Click;
            // 
            // btnContLetra
            // 
            btnContLetra.Location = new Point(659, 283);
            btnContLetra.Name = "btnContLetra";
            btnContLetra.Size = new Size(157, 66);
            btnContLetra.TabIndex = 3;
            btnContLetra.Text = "Contagem de letras";
            btnContLetra.UseVisualStyleBackColor = true;
            btnContLetra.Click += btnContLetra_Click;
            // 
            // FrmExercicio4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 555);
            Controls.Add(btnContLetra);
            Controls.Add(btnBranco);
            Controls.Add(btnContNum);
            Controls.Add(richTxtTexto);
            Name = "FrmExercicio4";
            Text = "FrmExercicio4";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTxtTexto;
        private Button btnContNum;
        private Button btnBranco;
        private Button btnContLetra;
    }
}