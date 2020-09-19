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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 95);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(148, 110);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "255 0 0\n0 128 0\n0 0 255\n0 100 0\n0 0 139\n255 255 0\n255 165 0\n128 0 128";
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(193, 26);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(50, 20);
            this.textY.TabIndex = 3;
            this.textY.Text = "30";
            this.textY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(272, 26);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(50, 20);
            this.textX.TabIndex = 4;
            this.textX.Text = "30";
            this.textX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(93, 29);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(83, 13);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "Размер карты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(414, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(28, 322);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(357, 130);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Информация:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(264, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обучитьToolStripMenuItem
            // 
            this.обучитьToolStripMenuItem.Name = "обучитьToolStripMenuItem";
            this.обучитьToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.обучитьToolStripMenuItem.Text = "Обучить";
            this.обучитьToolStripMenuItem.Click += new System.EventHandler(this.обучитьToolStripMenuItem_Click);
            // 
            // перерисоватьToolStripMenuItem
            // 
            this.перерисоватьToolStripMenuItem.Name = "перерисоватьToolStripMenuItem";
            this.перерисоватьToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.перерисоватьToolStripMenuItem.Text = "Перерисовать";
            this.перерисоватьToolStripMenuItem.Click += new System.EventHandler(this.перерисоватьToolStripMenuItem_Click);
            // 
            // распознатьToolStripMenuItem
            // 
            this.распознатьToolStripMenuItem.Name = "распознатьToolStripMenuItem";
            this.распознатьToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.распознатьToolStripMenuItem.Text = "Распознать";
            this.распознатьToolStripMenuItem.Click += new System.EventHandler(this.распознатьToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Обучающая выборка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Тестовая выборка";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 464);
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
            this.Name = "MainForm";
            this.Text = "SOM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

