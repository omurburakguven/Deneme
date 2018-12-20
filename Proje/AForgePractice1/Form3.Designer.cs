namespace AForgePractice1
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledYakmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canlıNesneTakibiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projelerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projelerToolStripMenuItem
            // 
            this.projelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ledYakmaToolStripMenuItem,
            this.canlıNesneTakibiToolStripMenuItem});
            this.projelerToolStripMenuItem.Name = "projelerToolStripMenuItem";
            this.projelerToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.projelerToolStripMenuItem.Text = "Projeler";
            // 
            // ledYakmaToolStripMenuItem
            // 
            this.ledYakmaToolStripMenuItem.Name = "ledYakmaToolStripMenuItem";
            this.ledYakmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ledYakmaToolStripMenuItem.Text = "3 * 3 Led yakma";
            this.ledYakmaToolStripMenuItem.Click += new System.EventHandler(this.ledYakmaToolStripMenuItem_Click);
            // 
            // canlıNesneTakibiToolStripMenuItem
            // 
            this.canlıNesneTakibiToolStripMenuItem.Name = "canlıNesneTakibiToolStripMenuItem";
            this.canlıNesneTakibiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.canlıNesneTakibiToolStripMenuItem.Text = "Canlı nesne takibi";
            this.canlıNesneTakibiToolStripMenuItem.Click += new System.EventHandler(this.canlıNesneTakibiToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledYakmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canlıNesneTakibiToolStripMenuItem;
    }
}