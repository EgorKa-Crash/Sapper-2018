namespace Laba_8_WinForm_Kaleev_Egor
{
    partial class SolFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolFunction));
            this.aMathTextBox = new System.Windows.Forms.TextBox();
            this.ansTextBox = new System.Windows.Forms.TextBox();
            this.functionOnDisp = new System.Windows.Forms.TextBox();
            this.chance = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.komentDec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aMathTextBox
            // 
            this.aMathTextBox.Location = new System.Drawing.Point(12, 112);
            this.aMathTextBox.Name = "aMathTextBox";
            this.aMathTextBox.Size = new System.Drawing.Size(121, 20);
            this.aMathTextBox.TabIndex = 0;
            this.aMathTextBox.Text = "Значение А :";
            this.aMathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aMathTextBox.Click += new System.EventHandler(this.aMathTextBox_Click);
            this.aMathTextBox.TextChanged += new System.EventHandler(this.aMathTextBox_TextChanged);
            // 
            // ansTextBox
            // 
            this.ansTextBox.Location = new System.Drawing.Point(12, 146);
            this.ansTextBox.Name = "ansTextBox";
            this.ansTextBox.Size = new System.Drawing.Size(121, 20);
            this.ansTextBox.TabIndex = 1;
            this.ansTextBox.Text = "Ответ :";
            this.ansTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ansTextBox.Click += new System.EventHandler(this.ansTextBox_Click);
            this.ansTextBox.TextChanged += new System.EventHandler(this.ansTextBox_TextChanged);
            // 
            // functionOnDisp
            // 
            this.functionOnDisp.Location = new System.Drawing.Point(253, 146);
            this.functionOnDisp.Name = "functionOnDisp";
            this.functionOnDisp.Size = new System.Drawing.Size(372, 20);
            this.functionOnDisp.TabIndex = 2;
            this.functionOnDisp.TextChanged += new System.EventHandler(this.functionOnDisp_TextChanged);
            // 
            // chance
            // 
            this.chance.Location = new System.Drawing.Point(12, 239);
            this.chance.Name = "chance";
            this.chance.Size = new System.Drawing.Size(121, 20);
            this.chance.TabIndex = 3;
            this.chance.TextChanged += new System.EventHandler(this.chance_TextChanged);
            // 
            // next
            // 
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(12, 179);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(129, 54);
            this.next.TabIndex = 4;
            this.next.Text = "Ответить";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(12, 410);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(129, 54);
            this.exit.TabIndex = 5;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // komentDec
            // 
            this.komentDec.Location = new System.Drawing.Point(253, 197);
            this.komentDec.Name = "komentDec";
            this.komentDec.Size = new System.Drawing.Size(372, 20);
            this.komentDec.TabIndex = 6;
            this.komentDec.TextChanged += new System.EventHandler(this.komentDec_TextChanged);
            // 
            // SolFunction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 476);
            this.Controls.Add(this.komentDec);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.next);
            this.Controls.Add(this.chance);
            this.Controls.Add(this.functionOnDisp);
            this.Controls.Add(this.ansTextBox);
            this.Controls.Add(this.aMathTextBox);
            this.MaximumSize = new System.Drawing.Size(730, 515);
            this.MinimumSize = new System.Drawing.Size(730, 515);
            this.Name = "SolFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SolFunction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aMathTextBox;
        private System.Windows.Forms.TextBox ansTextBox;
        private System.Windows.Forms.TextBox functionOnDisp;
        private System.Windows.Forms.TextBox chance;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox komentDec;
    }
}