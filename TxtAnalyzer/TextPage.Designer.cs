namespace TxtAnalyzer
{
    partial class TextPage
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextFile = new System.Windows.Forms.OpenFileDialog();
            this.saveTextFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.AcceptsReturn = true;
            this.textBox.AcceptsTab = true;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 28);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(886, 422);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.wordsNotInDictionary_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.dictionaryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.openToolStripMenuItem.Text = "Abrir";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.saveToolStripMenuItem.Text = "Salvar";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dictionaryToolStripMenuItem
            // 
            this.dictionaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewDictionaryToolStripMenuItem,
            this.checkWordsToolStripMenuItem});
            this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
            this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.dictionaryToolStripMenuItem.Text = "Dicionário";
            // 
            // openNewDictionaryToolStripMenuItem
            // 
            this.openNewDictionaryToolStripMenuItem.Name = "openNewDictionaryToolStripMenuItem";
            this.openNewDictionaryToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.openNewDictionaryToolStripMenuItem.Text = "Open new dictionary";
            this.openNewDictionaryToolStripMenuItem.Click += new System.EventHandler(this.openNewDictionaryToolStripMenuItem_Click);
            // 
            // checkWordsToolStripMenuItem
            // 
            this.checkWordsToolStripMenuItem.Name = "checkWordsToolStripMenuItem";
            this.checkWordsToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.checkWordsToolStripMenuItem.Text = "Check words";
            this.checkWordsToolStripMenuItem.Click += new System.EventHandler(this.checkWordsToolStripMenuItem_Click);
            // 
            // openTextFile
            // 
            this.openTextFile.FileName = "*.txt";
            this.openTextFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveTextFile
            // 
            this.saveTextFile.FileName = "*.txt";
            this.saveTextFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // TextPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TextPage";
            this.Text = "TxtAnalyzer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openTextFile;
        private System.Windows.Forms.ToolStripMenuItem openNewDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkWordsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveTextFile;
    }
}

