namespace PMenu
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            exercicio2ToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            exercicio3ToolStripMenuItem = new ToolStripMenuItem();
            exercicio4ToolStripMenuItem = new ToolStripMenuItem();
            exercicio5ToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editorDeTextoToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exercicio2ToolStripMenuItem, exercicio3ToolStripMenuItem, exercicio4ToolStripMenuItem, exercicio5ToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // exercicio2ToolStripMenuItem
            // 
            exercicio2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, colarToolStripMenuItem });
            exercicio2ToolStripMenuItem.Name = "exercicio2ToolStripMenuItem";
            exercicio2ToolStripMenuItem.Size = new Size(90, 24);
            exercicio2ToolStripMenuItem.Text = "Exercicio&2";
            exercicio2ToolStripMenuItem.Click += exercicio2ToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem.Size = new Size(187, 26);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            colarToolStripMenuItem.Size = new Size(187, 26);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += colarToolStripMenuItem_Click;
            // 
            // exercicio3ToolStripMenuItem
            // 
            exercicio3ToolStripMenuItem.Name = "exercicio3ToolStripMenuItem";
            exercicio3ToolStripMenuItem.Size = new Size(90, 24);
            exercicio3ToolStripMenuItem.Text = "Exercicio&3";
            exercicio3ToolStripMenuItem.Click += exercicio3ToolStripMenuItem_Click;
            // 
            // exercicio4ToolStripMenuItem
            // 
            exercicio4ToolStripMenuItem.Name = "exercicio4ToolStripMenuItem";
            exercicio4ToolStripMenuItem.Size = new Size(90, 24);
            exercicio4ToolStripMenuItem.Text = "Exercicio&4";
            exercicio4ToolStripMenuItem.Click += exercicio4ToolStripMenuItem_Click;
            // 
            // exercicio5ToolStripMenuItem
            // 
            exercicio5ToolStripMenuItem.Name = "exercicio5ToolStripMenuItem";
            exercicio5ToolStripMenuItem.Size = new Size(90, 24);
            exercicio5ToolStripMenuItem.Text = "Exercicio&5";
            exercicio5ToolStripMenuItem.Click += exercicio5ToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editorDeTextoToolStripMenuItem, calculadoraToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(178, 52);
            // 
            // editorDeTextoToolStripMenuItem
            // 
            editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            editorDeTextoToolStripMenuItem.Size = new Size(177, 24);
            editorDeTextoToolStripMenuItem.Text = "Editor de texto";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(177, 24);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem exercicio2ToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem exercicio3ToolStripMenuItem;
        private ToolStripMenuItem exercicio4ToolStripMenuItem;
        private ToolStripMenuItem exercicio5ToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editorDeTextoToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
    }
}
