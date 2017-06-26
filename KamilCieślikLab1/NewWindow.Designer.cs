namespace KamilCieślikLab1
{
    partial class NewWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewWindow));
            this.labelChristmasTree = new System.Windows.Forms.Label();
            this.textBoxTree = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxTreeHeight = new System.Windows.Forms.TextBox();
            this.labelTreeHeight = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChristmasTree
            // 
            this.labelChristmasTree.AutoSize = true;
            this.labelChristmasTree.BackColor = System.Drawing.Color.White;
            this.labelChristmasTree.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChristmasTree.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelChristmasTree.Location = new System.Drawing.Point(94, 18);
            this.labelChristmasTree.Name = "labelChristmasTree";
            this.labelChristmasTree.Size = new System.Drawing.Size(421, 73);
            this.labelChristmasTree.TabIndex = 0;
            this.labelChristmasTree.Text = "Christmas Tree";
            // 
            // textBoxTree
            // 
            this.textBoxTree.Location = new System.Drawing.Point(28, 112);
            this.textBoxTree.Multiline = true;
            this.textBoxTree.Name = "textBoxTree";
            this.textBoxTree.ReadOnly = true;
            this.textBoxTree.Size = new System.Drawing.Size(550, 608);
            this.textBoxTree.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGenerate.Location = new System.Drawing.Point(503, 726);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Generuj";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxTreeHeight
            // 
            this.textBoxTreeHeight.Location = new System.Drawing.Point(325, 726);
            this.textBoxTreeHeight.Name = "textBoxTreeHeight";
            this.textBoxTreeHeight.Size = new System.Drawing.Size(61, 20);
            this.textBoxTreeHeight.TabIndex = 3;
            // 
            // labelTreeHeight
            // 
            this.labelTreeHeight.AutoSize = true;
            this.labelTreeHeight.BackColor = System.Drawing.Color.White;
            this.labelTreeHeight.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTreeHeight.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelTreeHeight.Location = new System.Drawing.Point(25, 728);
            this.labelTreeHeight.Name = "labelTreeHeight";
            this.labelTreeHeight.Size = new System.Drawing.Size(294, 15);
            this.labelTreeHeight.TabIndex = 4;
            this.labelTreeHeight.Text = "Z ilu warstw ma się składać drzewko? (łącznie z pniem)";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonClose.Location = new System.Drawing.Point(28, 765);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(550, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // NewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 797);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelTreeHeight);
            this.Controls.Add(this.textBoxTreeHeight);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxTree);
            this.Controls.Add(this.labelChristmasTree);
            this.ForeColor = System.Drawing.Color.DarkViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChristmasTree;
        private System.Windows.Forms.TextBox textBoxTree;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxTreeHeight;
        private System.Windows.Forms.Label labelTreeHeight;
        private System.Windows.Forms.Button buttonClose;
    }
}