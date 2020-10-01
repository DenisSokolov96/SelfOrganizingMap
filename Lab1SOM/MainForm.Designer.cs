namespace Lab1SOM
{
    partial class MainForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textY = new System.Windows.Forms.TextBox();
            this.textX = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обучитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перерисоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распознатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(37, 117);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 134);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "255 0 0\n0 128 0\n0 0 255\n0 100 0\n0 0 139\n255 255 0\n255 165 0\n128 0 128";
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(257, 32);
            this.textY.Margin = new System.Windows.Forms.Padding(4);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(65, 22);
            this.textY.TabIndex = 3;
            this.textY.Text = "30";
            this.textY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(363, 32);
            this.textX.Margin = new System.Windows.Forms.Padding(4);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(65, 22);
            this.textX.TabIndex = 4;
            this.textX.Text = "30";
            this.textX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(124, 36);
            this.labelSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(105, 17);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "Размер карты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(552, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 713);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(37, 396);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(475, 159);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 352);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Информация:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 258);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(352, 128);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 123);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обучитьToolStripMenuItem,
            this.перерисоватьToolStripMenuItem,
            this.распознатьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1160, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обучитьToolStripMenuItem
            // 
            this.обучитьToolStripMenuItem.Name = "обучитьToolStripMenuItem";
            this.обучитьToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.обучитьToolStripMenuItem.Text = "Обучить";
            this.обучитьToolStripMenuItem.Click += new System.EventHandler(this.обучитьToolStripMenuItem_Click);
            // 
            // перерисоватьToolStripMenuItem
            // 
            this.перерисоватьToolStripMenuItem.Name = "перерисоватьToolStripMenuItem";
            this.перерисоватьToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.перерисоватьToolStripMenuItem.Text = "Перерисовать";
            this.перерисоватьToolStripMenuItem.Click += new System.EventHandler(this.перерисоватьToolStripMenuItem_Click);
            // 
            // распознатьToolStripMenuItem
            // 
            this.распознатьToolStripMenuItem.Name = "распознатьToolStripMenuItem";
            this.распознатьToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.распознатьToolStripMenuItem.Text = "Распознать";
            this.распознатьToolStripMenuItem.Click += new System.EventHandler(this.распознатьToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Обучающая выборка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Тестовая выборка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Скорость обучения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 674);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Количество итераций";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 674);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Радиус";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(37, 604);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(216, 56);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.Value = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 699);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 22);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "7000";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(257, 699);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 22);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "15";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 733);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "SOM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem перерисоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обучитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem распознатьToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

