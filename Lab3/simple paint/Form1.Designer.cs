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
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsPanel = new System.Windows.Forms.Panel();
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
            this.groupBrush = new System.Windows.Forms.GroupBox();
            this.Other = new System.Windows.Forms.Button();
            this.krug = new System.Windows.Forms.Button();
            this.octoflower = new System.Windows.Forms.Button();
            this.pryamo = new System.Windows.Forms.Button();
            this.Crocodile = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.kvadr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBrush.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.drawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.panel2);
            this.toolsPanel.Controls.Add(this.groupBrush);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolsPanel.Location = new System.Drawing.Point(1084, 0);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(180, 583);
            this.toolsPanel.TabIndex = 1;
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 147);
            this.panel2.TabIndex = 9;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button9.Location = new System.Drawing.Point(0, 107);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(180, 40);
            this.button9.TabIndex = 8;
            this.button9.Text = "Градиент";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(136, 52);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(93, 52);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Cyan;
            this.button6.Location = new System.Drawing.Point(49, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(3, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(136, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(93, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(47, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBrush
            // 
            this.groupBrush.Controls.Add(this.Other);
            this.groupBrush.Controls.Add(this.krug);
            this.groupBrush.Controls.Add(this.octoflower);
            this.groupBrush.Controls.Add(this.pryamo);
            this.groupBrush.Controls.Add(this.Crocodile);
            this.groupBrush.Controls.Add(this.trackBar1);
            this.groupBrush.Controls.Add(this.kvadr);
            this.groupBrush.Controls.Add(this.label1);
            this.groupBrush.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBrush.Location = new System.Drawing.Point(0, 0);
            this.groupBrush.Name = "groupBrush";
            this.groupBrush.Size = new System.Drawing.Size(180, 285);
            this.groupBrush.TabIndex = 0;
            this.groupBrush.TabStop = false;
            // 
            // Other
            // 
            this.Other.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Other.Location = new System.Drawing.Point(3, 96);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(174, 31);
            this.Other.TabIndex = 1;
            this.Other.Text = "Спрей";
            this.Other.UseVisualStyleBackColor = true;
            this.Other.Click += new System.EventHandler(this.Other_Click);
            // 
            // krug
            // 
            this.krug.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.krug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.krug.Location = new System.Drawing.Point(3, 127);
            this.krug.Name = "krug";
            this.krug.Size = new System.Drawing.Size(174, 31);
            this.krug.TabIndex = 1;
            this.krug.Text = "Круг";
            this.krug.UseVisualStyleBackColor = true;
            this.krug.Click += new System.EventHandler(this.krug_Click);
            // 
            // octoflower
            // 
            this.octoflower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.octoflower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.octoflower.Location = new System.Drawing.Point(3, 158);
            this.octoflower.Name = "octoflower";
            this.octoflower.Size = new System.Drawing.Size(174, 31);
            this.octoflower.TabIndex = 8;
            this.octoflower.Text = "Листик";
            this.octoflower.UseVisualStyleBackColor = true;
            this.octoflower.Click += new System.EventHandler(this.octoflower_Click_1);
            // 
            // pryamo
            // 
            this.pryamo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pryamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pryamo.Location = new System.Drawing.Point(3, 189);
            this.pryamo.Name = "pryamo";
            this.pryamo.Size = new System.Drawing.Size(174, 31);
            this.pryamo.TabIndex = 1;
            this.pryamo.Text = "Ластик";
            this.pryamo.UseVisualStyleBackColor = true;
            this.pryamo.Click += new System.EventHandler(this.pryamo_Click);
            // 
            // Crocodile
            // 
            this.Crocodile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Crocodile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Crocodile.Location = new System.Drawing.Point(3, 220);
            this.Crocodile.Name = "Crocodile";
            this.Crocodile.Size = new System.Drawing.Size(174, 31);
            this.Crocodile.TabIndex = 2;
            this.Crocodile.Text = "Линия";
            this.Crocodile.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.Location = new System.Drawing.Point(3, 43);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(174, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 45;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // kvadr
            // 
            this.kvadr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kvadr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kvadr.Location = new System.Drawing.Point(3, 251);
            this.kvadr.Name = "kvadr";
            this.kvadr.Size = new System.Drawing.Size(174, 31);
            this.kvadr.TabIndex = 0;
            this.kvadr.Text = "Квадрат";
            this.kvadr.UseVisualStyleBackColor = true;
            this.kvadr.Click += new System.EventHandler(this.kvadr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выбор толщины:";
            // 
            // drawPanel
            // 
            this.drawPanel.AutoScroll = true;
            this.drawPanel.Controls.Add(this.pictureBox1);
            this.drawPanel.Controls.Add(this.toolsPanel);
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPanel.Location = new System.Drawing.Point(0, 0);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(1264, 583);
            this.drawPanel.TabIndex = 2;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1084, 583);
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
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 583);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBrush.ResumeLayout(false);
            this.groupBrush.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private Panel toolsPanel;
        private GroupBox groupBrush;
        private Button Other;
        private Button krug;
        private Button pryamo;
        private TrackBar trackBar1;
        private Button kvadr;
        private Button octoflower;
        private Button Crocodile;
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
    }
}