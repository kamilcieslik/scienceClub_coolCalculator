namespace KamilCieslikLab1
{
    partial class MathematicalDefinitions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathematicalDefinitions));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxCategoryFirst = new System.Windows.Forms.ComboBox();
            this.webBrowserMathematicalDefinitions = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gray;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBack);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxCategoryFirst);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowserMathematicalDefinitions);
            this.splitContainer1.Size = new System.Drawing.Size(1546, 590);
            this.splitContainer1.SplitterDistance = 511;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Yellow;
            this.buttonBack.Location = new System.Drawing.Point(78, 515);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(363, 54);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Powrót do kalkulatora";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Yellow;
            this.buttonSearch.Location = new System.Drawing.Point(78, 455);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(363, 54);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxCategoryFirst
            // 
            this.comboBoxCategoryFirst.FormattingEnabled = true;
            this.comboBoxCategoryFirst.Items.AddRange(new object[] {
            "Systemy liczbowe",
            "Twierdzenia matematyczne",
            "Układy współrzędnych",
            "Algebra",
            "Algorytmika",
            "Analiza matematyczna",
            "Arytmetyka",
            "Czasopisma matematyczne",
            "Geometria",
            "Konkursy matematyczne",
            "Logika matematyczna",
            "Matematycy",
            "Matematyka dyskretna",
            "Matematyka stosowana",
            "Metody numeryczne",
            "Nagrody i wyróżniena matematyczne",
            "Niezmienniki",
            "Oprogramowanie matematyczne",
            "Stałe matematyczne",
            "Teoria decyzji",
            "Teoria kategorii",
            "Teoria miary",
            "Teoria mnogości",
            "Terminologia matematyczna",
            "Wydziały matematyki"});
            this.comboBoxCategoryFirst.Location = new System.Drawing.Point(78, 98);
            this.comboBoxCategoryFirst.Name = "comboBoxCategoryFirst";
            this.comboBoxCategoryFirst.Size = new System.Drawing.Size(363, 21);
            this.comboBoxCategoryFirst.TabIndex = 2;
            // 
            // webBrowserMathematicalDefinitions
            // 
            this.webBrowserMathematicalDefinitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMathematicalDefinitions.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMathematicalDefinitions.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMathematicalDefinitions.Name = "webBrowserMathematicalDefinitions";
            this.webBrowserMathematicalDefinitions.Size = new System.Drawing.Size(1031, 590);
            this.webBrowserMathematicalDefinitions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rozwiń listę:";
            // 
            // MathematicalDefinitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 590);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MathematicalDefinitions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathematicalDefinitions";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowserMathematicalDefinitions;
        private System.Windows.Forms.ComboBox comboBoxCategoryFirst;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
    }
}