namespace Laba_8_WinForm_Kaleev_Egor
{
    partial class SaperG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaperG));
            this.exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flag = new System.Windows.Forms.RadioButton();
            this.step = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(12, 410);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(129, 54);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flag
            // 
            this.flag.AutoSize = true;
            this.flag.Location = new System.Drawing.Point(12, 119);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(53, 17);
            this.flag.TabIndex = 5;
            this.flag.TabStop = true;
            this.flag.Text = "Флаг";
            this.flag.UseVisualStyleBackColor = true;
            this.flag.CheckedChanged += new System.EventHandler(this.flag_CheckedChanged);
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.Location = new System.Drawing.Point(12, 96);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(45, 17);
            this.step.TabIndex = 6;
            this.step.TabStop = true;
            this.step.Text = "Шаг";
            this.step.UseVisualStyleBackColor = true;
            this.step.CheckedChanged += new System.EventHandler(this.step_CheckedChanged);
            // 
            // SaperG
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(713, 474);
            this.Controls.Add(this.step);
            this.Controls.Add(this.flag);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit);
            this.MaximumSize = new System.Drawing.Size(729, 513);
            this.MinimumSize = new System.Drawing.Size(729, 513);
            this.Name = "SaperG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaperG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton flag;
        private System.Windows.Forms.RadioButton step;
    }
}