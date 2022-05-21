namespace Лабораторная_работа_8__АТПО_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыОбъектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстурированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиКамерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьМодельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.параметрыОбъектаToolStripMenuItem,
            this.текстурированиеToolStripMenuItem,
            this.настройкиКамерыToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 25);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьМодельToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // параметрыОбъектаToolStripMenuItem
            // 
            this.параметрыОбъектаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.параметрыОбъектаToolStripMenuItem.Name = "параметрыОбъектаToolStripMenuItem";
            this.параметрыОбъектаToolStripMenuItem.Size = new System.Drawing.Size(151, 21);
            this.параметрыОбъектаToolStripMenuItem.Text = "Параметры объекта...";
            this.параметрыОбъектаToolStripMenuItem.Click += new System.EventHandler(this.параметрыОбъектаToolStripMenuItem_Click);
            // 
            // текстурированиеToolStripMenuItem
            // 
            this.текстурированиеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.текстурированиеToolStripMenuItem.Name = "текстурированиеToolStripMenuItem";
            this.текстурированиеToolStripMenuItem.Size = new System.Drawing.Size(132, 21);
            this.текстурированиеToolStripMenuItem.Text = "Текстурирование...";
            this.текстурированиеToolStripMenuItem.Click += new System.EventHandler(this.текстурированиеToolStripMenuItem_Click);
            // 
            // настройкиКамерыToolStripMenuItem
            // 
            this.настройкиКамерыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.настройкиКамерыToolStripMenuItem.Name = "настройкиКамерыToolStripMenuItem";
            this.настройкиКамерыToolStripMenuItem.Size = new System.Drawing.Size(142, 21);
            this.настройкиКамерыToolStripMenuItem.Text = "Настройки камеры...";
            this.настройкиКамерыToolStripMenuItem.Click += new System.EventHandler(this.настройкиКамерыToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 21);
            this.toolStripMenuItem1.Text = "Справка";
            // 
            // сохранитьМодельToolStripMenuItem
            // 
            this.сохранитьМодельToolStripMenuItem.Name = "сохранитьМодельToolStripMenuItem";
            this.сохранитьМодельToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.сохранитьМодельToolStripMenuItem.Text = "Сохранить модель";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Модель здания";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыОбъектаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстурированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиКамерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьМодельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}