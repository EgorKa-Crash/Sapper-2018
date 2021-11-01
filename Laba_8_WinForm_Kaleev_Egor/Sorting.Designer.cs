namespace Laba_8_WinForm_Kaleev_Egor
{
    partial class Sorting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorting));
            this.next = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuOfSort = new System.Windows.Forms.TabControl();
            this.randMass = new System.Windows.Forms.TabPage();
            this.gnomMass = new System.Windows.Forms.TabPage();
            this.mixMass = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewStart = new System.Windows.Forms.DataGridView();
            this.dataGridViewGnom = new System.Windows.Forms.DataGridView();
            this.dataGridViewMix = new System.Windows.Forms.DataGridView();
            this.menuOfSort.SuspendLayout();
            this.randMass.SuspendLayout();
            this.gnomMass.SuspendLayout();
            this.mixMass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGnom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMix)).BeginInit();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.Location = new System.Drawing.Point(12, 167);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(129, 54);
            this.next.TabIndex = 0;
            this.next.Text = "Продолжить";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(15, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 15);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // home
            // 
            this.home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home.BackgroundImage")));
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.home.Location = new System.Drawing.Point(12, 376);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(129, 53);
            this.home.TabIndex = 4;
            this.home.Text = "Вернуться в меню";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите количество  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = " переменных";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuOfSort
            // 
            this.menuOfSort.Controls.Add(this.randMass);
            this.menuOfSort.Controls.Add(this.gnomMass);
            this.menuOfSort.Controls.Add(this.mixMass);
            this.menuOfSort.Location = new System.Drawing.Point(226, 119);
            this.menuOfSort.Name = "menuOfSort";
            this.menuOfSort.SelectedIndex = 0;
            this.menuOfSort.Size = new System.Drawing.Size(428, 298);
            this.menuOfSort.TabIndex = 7;
            // 
            // randMass
            // 
            this.randMass.Controls.Add(this.dataGridViewStart);
            this.randMass.Location = new System.Drawing.Point(4, 22);
            this.randMass.Name = "randMass";
            this.randMass.Padding = new System.Windows.Forms.Padding(3);
            this.randMass.Size = new System.Drawing.Size(420, 272);
            this.randMass.TabIndex = 0;
            this.randMass.Text = "Рандомный массив";
            this.randMass.UseVisualStyleBackColor = true;
            this.randMass.Click += new System.EventHandler(this.randMass_Click);
            // 
            // gnomMass
            // 
            this.gnomMass.Controls.Add(this.dataGridViewGnom);
            this.gnomMass.Location = new System.Drawing.Point(4, 22);
            this.gnomMass.Name = "gnomMass";
            this.gnomMass.Padding = new System.Windows.Forms.Padding(3);
            this.gnomMass.Size = new System.Drawing.Size(420, 272);
            this.gnomMass.TabIndex = 1;
            this.gnomMass.Text = "Сортировка Гномом";
            this.gnomMass.UseVisualStyleBackColor = true;
            this.gnomMass.Click += new System.EventHandler(this.gnomMass_Click);
            // 
            // mixMass
            // 
            this.mixMass.Controls.Add(this.dataGridViewMix);
            this.mixMass.Location = new System.Drawing.Point(4, 22);
            this.mixMass.Name = "mixMass";
            this.mixMass.Padding = new System.Windows.Forms.Padding(3);
            this.mixMass.Size = new System.Drawing.Size(420, 272);
            this.mixMass.TabIndex = 2;
            this.mixMass.Text = "Сортировка перемешиванием";
            this.mixMass.UseVisualStyleBackColor = true;
            this.mixMass.Click += new System.EventHandler(this.mixMass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "О проведенной  ";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Gray;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Location = new System.Drawing.Point(12, 274);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(129, 57);
            this.result.TabIndex = 9;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(9, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = " сортировке :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridViewStart
            // 
            this.dataGridViewStart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStart.ColumnHeadersVisible = false;
            this.dataGridViewStart.Enabled = false;
            this.dataGridViewStart.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewStart.Name = "dataGridViewStart";
            this.dataGridViewStart.Size = new System.Drawing.Size(414, 56);
            this.dataGridViewStart.TabIndex = 0;
            this.dataGridViewStart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStart_CellContentClick);
            // 
            // dataGridViewGnom
            // 
            this.dataGridViewGnom.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGnom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGnom.ColumnHeadersVisible = false;
            this.dataGridViewGnom.Enabled = false;
            this.dataGridViewGnom.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewGnom.Name = "dataGridViewGnom";
            this.dataGridViewGnom.Size = new System.Drawing.Size(414, 56);
            this.dataGridViewGnom.TabIndex = 1;
            // 
            // dataGridViewMix
            // 
            this.dataGridViewMix.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMix.ColumnHeadersVisible = false;
            this.dataGridViewMix.Enabled = false;
            this.dataGridViewMix.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewMix.Name = "dataGridViewMix";
            this.dataGridViewMix.Size = new System.Drawing.Size(414, 56);
            this.dataGridViewMix.TabIndex = 1;
            // 
            // Sorting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 476);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuOfSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.next);
            this.Location = new System.Drawing.Point(300, 300);
            this.MaximumSize = new System.Drawing.Size(730, 515);
            this.MinimumSize = new System.Drawing.Size(730, 515);
            this.Name = "Sorting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting";
            this.menuOfSort.ResumeLayout(false);
            this.randMass.ResumeLayout(false);
            this.gnomMass.ResumeLayout(false);
            this.mixMass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGnom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl menuOfSort;
        private System.Windows.Forms.TabPage randMass;
        private System.Windows.Forms.TabPage gnomMass;
        private System.Windows.Forms.TabPage mixMass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewStart;
        private System.Windows.Forms.DataGridView dataGridViewGnom;
        private System.Windows.Forms.DataGridView dataGridViewMix;
    }
}