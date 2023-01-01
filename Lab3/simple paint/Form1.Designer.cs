namespace simple_paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.line = new System.Windows.Forms.Button();
            this.kvadr = new System.Windows.Forms.Button();
            this.lastic = new System.Windows.Forms.Button();
            this.krug = new System.Windows.Forms.Button();
            this.Other = new System.Windows.Forms.Button();
            this.octoflower = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.drawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1511, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.line);
            this.toolsPanel.Controls.Add(this.kvadr);
            this.toolsPanel.Controls.Add(this.lastic);
            this.toolsPanel.Controls.Add(this.krug);
            this.toolsPanel.Controls.Add(this.Other);
            this.toolsPanel.Controls.Add(this.octoflower);
            this.toolsPanel.Controls.Add(this.label2);
            this.toolsPanel.Controls.Add(this.label1);
            this.toolsPanel.Controls.Add(this.trackBar1);
            this.toolsPanel.Controls.Add(this.panel2);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolsPanel.Location = new System.Drawing.Point(1279, 0);
            this.toolsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(232, 779);
            this.toolsPanel.TabIndex = 1;
            this.toolsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toolsPanel_Paint);
            // 
            // line
            // 
            this.line.Dock = System.Windows.Forms.DockStyle.Top;
            this.line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line.Location = new System.Drawing.Point(0, 306);
            this.line.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(232, 55);
            this.line.TabIndex = 2;
            this.line.Text = "Линия";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // kvadr
            // 
            this.kvadr.Dock = System.Windows.Forms.DockStyle.Top;
            this.kvadr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kvadr.Location = new System.Drawing.Point(0, 251);
            this.kvadr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kvadr.Name = "kvadr";
            this.kvadr.Size = new System.Drawing.Size(232, 55);
            this.kvadr.TabIndex = 0;
            this.kvadr.Text = "Квадрат";
            this.kvadr.UseVisualStyleBackColor = true;
            this.kvadr.Click += new System.EventHandler(this.kvadr_Click);
            // 
            // lastic
            // 
            this.lastic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastic.Location = new System.Drawing.Point(0, 196);
            this.lastic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastic.Name = "lastic";
            this.lastic.Size = new System.Drawing.Size(232, 55);
            this.lastic.TabIndex = 1;
            this.lastic.Text = "Ластик";
            this.lastic.UseVisualStyleBackColor = true;
            this.lastic.Click += new System.EventHandler(this.lastic_Click);
            // 
            // krug
            // 
            this.krug.Dock = System.Windows.Forms.DockStyle.Top;
            this.krug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.krug.Location = new System.Drawing.Point(0, 141);
            this.krug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.krug.Name = "krug";
            this.krug.Size = new System.Drawing.Size(232, 55);
            this.krug.TabIndex = 1;
            this.krug.Text = "Круг";
            this.krug.UseVisualStyleBackColor = true;
            this.krug.Click += new System.EventHandler(this.krug_Click);
            // 
            // Other
            // 
            this.Other.Dock = System.Windows.Forms.DockStyle.Top;
            this.Other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Other.Location = new System.Drawing.Point(0, 86);
            this.Other.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(232, 55);
            this.Other.TabIndex = 1;
            this.Other.Text = "Спрей";
            this.Other.UseVisualStyleBackColor = true;
            this.Other.Click += new System.EventHandler(this.Other_Click);
            // 
            // octoflower
            // 
            this.octoflower.Dock = System.Windows.Forms.DockStyle.Top;
            this.octoflower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.octoflower.Location = new System.Drawing.Point(0, 31);
            this.octoflower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.octoflower.Name = "octoflower";
            this.octoflower.Size = new System.Drawing.Size(232, 55);
            this.octoflower.TabIndex = 8;
            this.octoflower.Text = "Листик";
            this.octoflower.UseVisualStyleBackColor = true;
            this.octoflower.Click += new System.EventHandler(this.octoflower_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выберите кисть:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выбор толщины:";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar1.Location = new System.Drawing.Point(0, 523);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(232, 60);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 45;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 583);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 196);
            this.panel2.TabIndex = 9;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button9.Location = new System.Drawing.Point(0, 143);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(232, 53);
            this.button9.TabIndex = 8;
            this.button9.Text = "Градиент";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(155, 69);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 53);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(106, 69);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 53);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Cyan;
            this.button6.Location = new System.Drawing.Point(56, 69);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 53);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(3, 69);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 53);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(155, 8);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 53);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(106, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 53);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(54, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 53);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 53);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.AutoScroll = true;
            this.drawPanel.Controls.Add(this.toolsPanel);
            this.drawPanel.Controls.Add(this.pictureBox1);
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPanel.Location = new System.Drawing.Point(0, 0);
            this.drawPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(1511, 779);
            this.drawPanel.TabIndex = 2;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1511, 779);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_Mouseup);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.drawPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1511, 779);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 809);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.drawPanel.ResumeLayout(false);
            this.drawPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private Panel toolsPanel;
        private Button Other;
        private Button krug;
        private Button lastic;
        private TrackBar trackBar1;
        private Button kvadr;
        private Button octoflower;
        private Button line;
        private Panel drawPanel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ColorDialog colorDialog1;
        private Panel panel2;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}