namespace Laba_8_WinForm_Kaleev_Egor
{
    partial class Stringsss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stringsss));
            this.next = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextForReorg = new System.Windows.Forms.RichTextBox();
            this.Prob = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(12, 90);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(129, 54);
            this.next.TabIndex = 0;
            this.next.Text = "Выполнить";
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
            this.exit.TabIndex = 1;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите текст , он перейдет в нижний регистр и из него будут удалены пробелы";
            // 
            // TextForReorg
            // 
            this.TextForReorg.Location = new System.Drawing.Point(237, 156);
            this.TextForReorg.Name = "TextForReorg";
            this.TextForReorg.Size = new System.Drawing.Size(405, 254);
            this.TextForReorg.TabIndex = 3;
            this.TextForReorg.Text = "";
            this.TextForReorg.TextChanged += new System.EventHandler(this.TextForReorg_TextChanged);
            // 
            // Prob
            // 
            this.Prob.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Prob.BackgroundImage")));
            this.Prob.FlatAppearance.BorderSize = 0;
            this.Prob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prob.Location = new System.Drawing.Point(12, 150);
            this.Prob.Name = "Prob";
            this.Prob.Size = new System.Drawing.Size(129, 54);
            this.Prob.TabIndex = 4;
            this.Prob.Text = "Пробный текст";
            this.Prob.UseVisualStyleBackColor = true;
            this.Prob.Click += new System.EventHandler(this.Prob_Click);
            // 
            // clean
            // 
            this.clean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clean.BackgroundImage")));
            this.clean.FlatAppearance.BorderSize = 0;
            this.clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clean.Location = new System.Drawing.Point(12, 210);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(129, 54);
            this.clean.TabIndex = 5;
            this.clean.Text = "Отчистить поле записи";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // Stringsss
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 476);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.Prob);
            this.Controls.Add(this.TextForReorg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.next);
            this.MaximumSize = new System.Drawing.Size(730, 515);
            this.MinimumSize = new System.Drawing.Size(730, 515);
            this.Name = "Stringsss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stringsss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TextForReorg;
        private System.Windows.Forms.Button Prob;
        private System.Windows.Forms.Button clean;
    }
}