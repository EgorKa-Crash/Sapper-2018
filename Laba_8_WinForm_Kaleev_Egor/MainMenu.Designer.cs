namespace Laba_8_WinForm_Kaleev_Egor
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AbautMe = new System.Windows.Forms.Button();
            this.Task = new System.Windows.Forms.Button();
            this.Functionn = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.Saper = new System.Windows.Forms.Button();
            this.Strings = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(233, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(412, 283);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // AbautMe
            // 
            this.AbautMe.BackColor = System.Drawing.Color.LightGray;
            this.AbautMe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AbautMe.BackgroundImage")));
            this.AbautMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AbautMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbautMe.FlatAppearance.BorderSize = 0;
            this.AbautMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbautMe.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AbautMe.ForeColor = System.Drawing.Color.Black;
            this.AbautMe.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AbautMe.Location = new System.Drawing.Point(12, 86);
            this.AbautMe.Name = "AbautMe";
            this.AbautMe.Size = new System.Drawing.Size(123, 51);
            this.AbautMe.TabIndex = 3;
            this.AbautMe.Text = "1 - Об авторе";
            this.AbautMe.UseVisualStyleBackColor = false;
            this.AbautMe.Click += new System.EventHandler(this.AbautMe_Click_1);
            // 
            // Task
            // 
            this.Task.BackColor = System.Drawing.Color.LightGray;
            this.Task.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Task.BackgroundImage")));
            this.Task.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Task.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Task.FlatAppearance.BorderSize = 0;
            this.Task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Task.ForeColor = System.Drawing.Color.Black;
            this.Task.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Task.Location = new System.Drawing.Point(12, 141);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(123, 51);
            this.Task.TabIndex = 4;
            this.Task.Text = "2 - Задание";
            this.Task.UseVisualStyleBackColor = false;
            this.Task.Click += new System.EventHandler(this.Task_Click);
            // 
            // Functionn
            // 
            this.Functionn.BackColor = System.Drawing.Color.LightGray;
            this.Functionn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Functionn.BackgroundImage")));
            this.Functionn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Functionn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Functionn.FlatAppearance.BorderSize = 0;
            this.Functionn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Functionn.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Functionn.ForeColor = System.Drawing.Color.Black;
            this.Functionn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Functionn.Location = new System.Drawing.Point(12, 196);
            this.Functionn.Name = "Functionn";
            this.Functionn.Size = new System.Drawing.Size(123, 51);
            this.Functionn.TabIndex = 5;
            this.Functionn.Text = "3 - Решить пример";
            this.Functionn.UseVisualStyleBackColor = false;
            this.Functionn.Click += new System.EventHandler(this.Functionn_Click);
            // 
            // Sort
            // 
            this.Sort.BackColor = System.Drawing.Color.LightGray;
            this.Sort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sort.BackgroundImage")));
            this.Sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sort.FlatAppearance.BorderSize = 0;
            this.Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort.ForeColor = System.Drawing.Color.Black;
            this.Sort.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Sort.Location = new System.Drawing.Point(12, 251);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(123, 51);
            this.Sort.TabIndex = 6;
            this.Sort.Text = "4- Сортировка";
            this.Sort.UseVisualStyleBackColor = false;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Saper
            // 
            this.Saper.BackColor = System.Drawing.Color.LightGray;
            this.Saper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Saper.BackgroundImage")));
            this.Saper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Saper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Saper.FlatAppearance.BorderSize = 0;
            this.Saper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Saper.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Saper.ForeColor = System.Drawing.Color.Black;
            this.Saper.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Saper.Location = new System.Drawing.Point(12, 306);
            this.Saper.Name = "Saper";
            this.Saper.Size = new System.Drawing.Size(123, 51);
            this.Saper.TabIndex = 7;
            this.Saper.Text = "5 - Сапер";
            this.Saper.UseVisualStyleBackColor = false;
            this.Saper.Click += new System.EventHandler(this.Saper_Click);
            // 
            // Strings
            // 
            this.Strings.BackColor = System.Drawing.Color.LightGray;
            this.Strings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Strings.BackgroundImage")));
            this.Strings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Strings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Strings.FlatAppearance.BorderSize = 0;
            this.Strings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Strings.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Strings.ForeColor = System.Drawing.Color.Black;
            this.Strings.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Strings.Location = new System.Drawing.Point(12, 361);
            this.Strings.Name = "Strings";
            this.Strings.Size = new System.Drawing.Size(123, 51);
            this.Strings.TabIndex = 8;
            this.Strings.Text = "6 - Работа со строками";
            this.Strings.UseVisualStyleBackColor = false;
            this.Strings.Click += new System.EventHandler(this.Strings_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightGray;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Exit.Location = new System.Drawing.Point(12, 416);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(123, 51);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "7 - Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 476);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Strings);
            this.Controls.Add(this.Saper);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Functionn);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.AbautMe);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(300, 300);
            this.MaximumSize = new System.Drawing.Size(730, 515);
            this.MinimumSize = new System.Drawing.Size(730, 515);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "K.Prog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AbautMe;
        private System.Windows.Forms.Button Task;
        private System.Windows.Forms.Button Functionn;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button Saper;
        private System.Windows.Forms.Button Strings;
        private System.Windows.Forms.Button Exit;
    }
}

