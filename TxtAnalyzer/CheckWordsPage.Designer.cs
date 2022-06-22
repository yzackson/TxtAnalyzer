namespace TxtAnalyzer
{
    partial class CheckWordsPage
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
            this.wordsNotInDictionary = new System.Windows.Forms.TextBox();
            this.wordsInDictionary = new System.Windows.Forms.TextBox();
            this.insertInDictionary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordsNotInDictionary
            // 
            this.wordsNotInDictionary.Location = new System.Drawing.Point(42, 82);
            this.wordsNotInDictionary.Multiline = true;
            this.wordsNotInDictionary.Name = "wordsNotInDictionary";
            this.wordsNotInDictionary.Size = new System.Drawing.Size(241, 327);
            this.wordsNotInDictionary.TabIndex = 0;
            // 
            // wordsInDictionary
            // 
            this.wordsInDictionary.Location = new System.Drawing.Point(517, 82);
            this.wordsInDictionary.Multiline = true;
            this.wordsInDictionary.Name = "wordsInDictionary";
            this.wordsInDictionary.Size = new System.Drawing.Size(241, 327);
            this.wordsInDictionary.TabIndex = 1;
            // 
            // insertInDictionary
            // 
            this.insertInDictionary.Location = new System.Drawing.Point(359, 197);
            this.insertInDictionary.Name = "insertInDictionary";
            this.insertInDictionary.Size = new System.Drawing.Size(75, 65);
            this.insertInDictionary.TabIndex = 2;
            this.insertInDictionary.Text = "Inserir no dicionário\n->";
            this.insertInDictionary.UseVisualStyleBackColor = true;
            this.insertInDictionary.Click += new System.EventHandler(this.insertInDictionary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Não está no Dicionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dicionário";
            // 
            // CheckWordsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertInDictionary);
            this.Controls.Add(this.wordsInDictionary);
            this.Controls.Add(this.wordsNotInDictionary);
            this.Name = "CheckWordsPage";
            this.Text = "CheckWordsPage";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Closed += new System.EventHandler(CheckWord.CheckAllTextInDict());

        }

        #endregion

        private System.Windows.Forms.TextBox wordsNotInDictionary;
        private System.Windows.Forms.TextBox wordsInDictionary;
        private System.Windows.Forms.Button insertInDictionary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}