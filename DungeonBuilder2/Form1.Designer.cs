namespace DungeonBuilder2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btWall = new System.Windows.Forms.Button();
            this.labelScaleUp = new System.Windows.Forms.Label();
            this.labelScaleDown = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMultiplierDown = new System.Windows.Forms.Label();
            this.labelMultiplierUp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wallWidthTrack = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGrid = new System.Windows.Forms.CheckBox();
            this.cbRuler = new System.Windows.Forms.CheckBox();
            this.cbPoints = new System.Windows.Forms.CheckBox();
            this.btMaximize = new System.Windows.Forms.Button();
            this.tbScale = new System.Windows.Forms.TextBox();
            this.labelWallWidth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbScaleMultiplier = new System.Windows.Forms.TextBox();
            this.btPolyWall = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.brBed = new System.Windows.Forms.Button();
            this.btLine = new System.Windows.Forms.Button();
            this.btMeasuringTape = new System.Windows.Forms.Button();
            this.btWindow = new System.Windows.Forms.Button();
            this.btDoor = new System.Windows.Forms.Button();
            this.btRuler = new System.Windows.Forms.Button();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.btLamp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.wallWidthTrack)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelPictureBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (40)))), ((int) (((byte) (40)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(901, 541);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btWall
            // 
            this.btWall.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (60)))), ((int) (((byte) (60)))));
            this.btWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btWall.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btWall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWall.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btWall.ForeColor = System.Drawing.Color.Silver;
            this.btWall.Image = ((System.Drawing.Image) (resources.GetObject("btWall.Image")));
            this.btWall.Location = new System.Drawing.Point(3, 3);
            this.btWall.Name = "btWall";
            this.btWall.Size = new System.Drawing.Size(68, 79);
            this.btWall.TabIndex = 2;
            this.btWall.Text = "Wall";
            this.btWall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btWall.UseVisualStyleBackColor = false;
            this.btWall.Click += new System.EventHandler(this.btWall_Click);
            // 
            // labelScaleUp
            // 
            this.labelScaleUp.ForeColor = System.Drawing.SystemColors.Control;
            this.labelScaleUp.Location = new System.Drawing.Point(64, 5);
            this.labelScaleUp.Name = "labelScaleUp";
            this.labelScaleUp.Size = new System.Drawing.Size(15, 13);
            this.labelScaleUp.TabIndex = 4;
            this.labelScaleUp.Text = "▲";
            this.labelScaleUp.Click += new System.EventHandler(this.labelScaleUp_Click);
            // 
            // labelScaleDown
            // 
            this.labelScaleDown.ForeColor = System.Drawing.SystemColors.Control;
            this.labelScaleDown.Location = new System.Drawing.Point(64, 18);
            this.labelScaleDown.Name = "labelScaleDown";
            this.labelScaleDown.Size = new System.Drawing.Size(15, 13);
            this.labelScaleDown.TabIndex = 5;
            this.labelScaleDown.Text = "▼";
            this.labelScaleDown.Click += new System.EventHandler(this.labelScaleDown_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Scale: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(92, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Multiplier:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMultiplierDown
            // 
            this.labelMultiplierDown.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMultiplierDown.Location = new System.Drawing.Point(174, 18);
            this.labelMultiplierDown.Name = "labelMultiplierDown";
            this.labelMultiplierDown.Size = new System.Drawing.Size(15, 13);
            this.labelMultiplierDown.TabIndex = 9;
            this.labelMultiplierDown.Text = "▼";
            this.labelMultiplierDown.Click += new System.EventHandler(this.labelMultiplierDown_Click);
            // 
            // labelMultiplierUp
            // 
            this.labelMultiplierUp.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMultiplierUp.Location = new System.Drawing.Point(174, 5);
            this.labelMultiplierUp.Name = "labelMultiplierUp";
            this.labelMultiplierUp.Size = new System.Drawing.Size(15, 13);
            this.labelMultiplierUp.TabIndex = 8;
            this.labelMultiplierUp.Text = "▲";
            this.labelMultiplierUp.Click += new System.EventHandler(this.labelMultiplierUp_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(84, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 36);
            this.label2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(192, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 36);
            this.label5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(200, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Width:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wallWidthTrack
            // 
            this.wallWidthTrack.AutoSize = false;
            this.wallWidthTrack.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.wallWidthTrack.Location = new System.Drawing.Point(240, 7);
            this.wallWidthTrack.Margin = new System.Windows.Forms.Padding(0);
            this.wallWidthTrack.Maximum = 50;
            this.wallWidthTrack.Minimum = 10;
            this.wallWidthTrack.Name = "wallWidthTrack";
            this.wallWidthTrack.Size = new System.Drawing.Size(100, 21);
            this.wallWidthTrack.SmallChange = 5;
            this.wallWidthTrack.TabIndex = 5;
            this.wallWidthTrack.TickFrequency = 5;
            this.wallWidthTrack.Value = 20;
            this.wallWidthTrack.Scroll += new System.EventHandler(this.wallWidthTrack_Scroll);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(373, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 36);
            this.label8.TabIndex = 17;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (230)))), ((int) (((byte) (85)))), ((int) (((byte) (85)))));
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btClose.Location = new System.Drawing.Point(1033, 4);
            this.btClose.Margin = new System.Windows.Forms.Padding(0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(16, 16);
            this.btClose.TabIndex = 20;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btMinimize.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMinimize.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btMinimize.Location = new System.Drawing.Point(991, 4);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(16, 16);
            this.btMinimize.TabIndex = 21;
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (55)))), ((int) (((byte) (55)))), ((int) (((byte) (55)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbGrid);
            this.panel1.Controls.Add(this.cbRuler);
            this.panel1.Controls.Add(this.cbPoints);
            this.panel1.Controls.Add(this.btMaximize);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btMinimize);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 25);
            this.panel1.TabIndex = 24;
            // 
            // cbGrid
            // 
            this.cbGrid.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cbGrid.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cbGrid.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbGrid.Location = new System.Drawing.Point(69, 2);
            this.cbGrid.Name = "cbGrid";
            this.cbGrid.Size = new System.Drawing.Size(53, 20);
            this.cbGrid.TabIndex = 25;
            this.cbGrid.Text = "Grid";
            this.cbGrid.UseVisualStyleBackColor = true;
            this.cbGrid.CheckedChanged += new System.EventHandler(this.cbGrid_CheckedChanged);
            // 
            // cbRuler
            // 
            this.cbRuler.Checked = true;
            this.cbRuler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRuler.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cbRuler.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cbRuler.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbRuler.Location = new System.Drawing.Point(3, 2);
            this.cbRuler.Name = "cbRuler";
            this.cbRuler.Size = new System.Drawing.Size(60, 20);
            this.cbRuler.TabIndex = 26;
            this.cbRuler.Text = "Ruler";
            this.cbRuler.UseVisualStyleBackColor = true;
            this.cbRuler.CheckedChanged += new System.EventHandler(this.cbRuler_CheckedChanged);
            // 
            // cbPoints
            // 
            this.cbPoints.Checked = true;
            this.cbPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPoints.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cbPoints.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cbPoints.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbPoints.Location = new System.Drawing.Point(128, 2);
            this.cbPoints.Name = "cbPoints";
            this.cbPoints.Size = new System.Drawing.Size(83, 20);
            this.cbPoints.TabIndex = 24;
            this.cbPoints.Text = "Points";
            this.cbPoints.UseVisualStyleBackColor = true;
            this.cbPoints.CheckedChanged += new System.EventHandler(this.cbPoints_CheckedChanged);
            // 
            // btMaximize
            // 
            this.btMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btMaximize.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMaximize.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btMaximize.Location = new System.Drawing.Point(1012, 4);
            this.btMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btMaximize.Name = "btMaximize";
            this.btMaximize.Size = new System.Drawing.Size(16, 16);
            this.btMaximize.TabIndex = 22;
            this.btMaximize.UseVisualStyleBackColor = false;
            this.btMaximize.Click += new System.EventHandler(this.btMaximize_Click);
            // 
            // tbScale
            // 
            this.tbScale.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbScale.ForeColor = System.Drawing.SystemColors.Control;
            this.tbScale.Location = new System.Drawing.Point(45, 9);
            this.tbScale.MaximumSize = new System.Drawing.Size(20, 18);
            this.tbScale.Name = "tbScale";
            this.tbScale.Size = new System.Drawing.Size(18, 18);
            this.tbScale.TabIndex = 22;
            this.tbScale.Text = "0";
            this.tbScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelWallWidth
            // 
            this.labelWallWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWallWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelWallWidth.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.labelWallWidth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWallWidth.Location = new System.Drawing.Point(343, 6);
            this.labelWallWidth.Name = "labelWallWidth";
            this.labelWallWidth.Size = new System.Drawing.Size(23, 21);
            this.labelWallWidth.TabIndex = 16;
            this.labelWallWidth.Text = "20";
            this.labelWallWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbScaleMultiplier);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelScaleUp);
            this.panel2.Controls.Add(this.tbScale);
            this.panel2.Controls.Add(this.labelScaleDown);
            this.panel2.Controls.Add(this.labelMultiplierUp);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.labelMultiplierDown);
            this.panel2.Controls.Add(this.labelWallWidth);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.wallWidthTrack);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 38);
            this.panel2.TabIndex = 25;
            // 
            // tbScaleMultiplier
            // 
            this.tbScaleMultiplier.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbScaleMultiplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbScaleMultiplier.ForeColor = System.Drawing.SystemColors.Control;
            this.tbScaleMultiplier.Location = new System.Drawing.Point(155, 9);
            this.tbScaleMultiplier.MaximumSize = new System.Drawing.Size(20, 18);
            this.tbScaleMultiplier.Name = "tbScaleMultiplier";
            this.tbScaleMultiplier.Size = new System.Drawing.Size(18, 18);
            this.tbScaleMultiplier.TabIndex = 23;
            this.tbScaleMultiplier.Text = "0";
            this.tbScaleMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btPolyWall
            // 
            this.btPolyWall.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (60)))), ((int) (((byte) (60)))));
            this.btPolyWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btPolyWall.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btPolyWall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPolyWall.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btPolyWall.ForeColor = System.Drawing.Color.Silver;
            this.btPolyWall.Image = ((System.Drawing.Image) (resources.GetObject("btPolyWall.Image")));
            this.btPolyWall.Location = new System.Drawing.Point(78, 3);
            this.btPolyWall.Name = "btPolyWall";
            this.btPolyWall.Size = new System.Drawing.Size(68, 79);
            this.btPolyWall.TabIndex = 26;
            this.btPolyWall.Text = "Poly Wall";
            this.btPolyWall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPolyWall.UseVisualStyleBackColor = false;
            this.btPolyWall.Click += new System.EventHandler(this.btPolyWall_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btLamp);
            this.panel3.Controls.Add(this.brBed);
            this.panel3.Controls.Add(this.btLine);
            this.panel3.Controls.Add(this.btMeasuringTape);
            this.panel3.Controls.Add(this.btWindow);
            this.panel3.Controls.Add(this.btDoor);
            this.panel3.Controls.Add(this.btRuler);
            this.panel3.Controls.Add(this.btWall);
            this.panel3.Controls.Add(this.btPolyWall);
            this.panel3.Location = new System.Drawing.Point(906, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 543);
            this.panel3.TabIndex = 27;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // brBed
            // 
            this.brBed.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (60)))), ((int) (((byte) (60)))));
            this.brBed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.brBed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.brBed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brBed.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.brBed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.brBed.Image = ((System.Drawing.Image) (resources.GetObject("brBed.Image")));
            this.brBed.Location = new System.Drawing.Point(77, 258);
            this.brBed.Name = "brBed";
            this.brBed.Size = new System.Drawing.Size(68, 79);
            this.brBed.TabIndex = 32;
            this.brBed.Text = "Bed";
            this.brBed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brBed.UseVisualStyleBackColor = false;
            this.brBed.Click += new System.EventHandler(this.brBed_Click);
            // 
            // btLine
            // 
            this.btLine.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (60)))), ((int) (((byte) (60)))));
            this.btLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btLine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLine.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btLine.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btLine.Image = ((System.Drawing.Image) (resources.GetObject("btLine.Image")));
            this.btLine.Location = new System.Drawing.Point(3, 258);
            this.btLine.Name = "btLine";
            this.btLine.Size = new System.Drawing.Size(68, 79);
            this.btLine.TabIndex = 31;
            this.btLine.Text = "Line";
            this.btLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLine.UseVisualStyleBackColor = false;
            this.btLine.Click += new System.EventHandler(this.btLine_Click);
            // 
            // btMeasuringTape
            // 
            this.btMeasuringTape.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (60)))), ((int) (((byte) (60)))));
            this.btMeasuringTape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMeasuringTape.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btMeasuringTape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMeasuringTape.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btMeasuringTape.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btMeasuringTape.Image = ((System.Drawing.Image) (resources.GetObject("btMeasuringTape.Image")));
            this.btMeasuringTape.Location = new System.Drawing.Point(3, 173);
            this.btMeasuringTape.Name = "btMeasuringTape";
            this.btMeasuringTape.Size = new System.Drawing.Size(68, 79);
            this.btMeasuringTape.TabIndex = 30;
            this.btMeasuringTape.Text = "M-Tape";
            this.btMeasuringTape.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMeasuringTape.UseVisualStyleBackColor = false;
            this.btMeasuringTape.Click += new System.EventHandler(this.btMeasuringTape_Click);
            // 
            // btWindow
            // 
            this.btWindow.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (60)))), ((int) (((byte) (60)))));
            this.btWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWindow.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btWindow.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btWindow.Image = ((System.Drawing.Image) (resources.GetObject("btWindow.Image")));
            this.btWindow.Location = new System.Drawing.Point(3, 88);
            this.btWindow.Name = "btWindow";
            this.btWindow.Size = new System.Drawing.Size(68, 79);
            this.btWindow.TabIndex = 29;
            this.btWindow.Text = "Window";
            this.btWindow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btWindow.UseVisualStyleBackColor = false;
            this.btWindow.Click += new System.EventHandler(this.btWindow_Click);
            // 
            // btDoor
            // 
            this.btDoor.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (60)))), ((int) (((byte) (60)))));
            this.btDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btDoor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btDoor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDoor.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btDoor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btDoor.Image = ((System.Drawing.Image) (resources.GetObject("btDoor.Image")));
            this.btDoor.Location = new System.Drawing.Point(77, 88);
            this.btDoor.Name = "btDoor";
            this.btDoor.Size = new System.Drawing.Size(68, 79);
            this.btDoor.TabIndex = 28;
            this.btDoor.Text = "Door";
            this.btDoor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDoor.UseVisualStyleBackColor = false;
            this.btDoor.Click += new System.EventHandler(this.btDoor_Click);
            // 
            // btRuler
            // 
            this.btRuler.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (60)))), ((int) (((byte) (60)))));
            this.btRuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRuler.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btRuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRuler.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btRuler.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btRuler.Image = ((System.Drawing.Image) (resources.GetObject("btRuler.Image")));
            this.btRuler.Location = new System.Drawing.Point(77, 173);
            this.btRuler.Name = "btRuler";
            this.btRuler.Size = new System.Drawing.Size(68, 79);
            this.btRuler.TabIndex = 27;
            this.btRuler.Text = "Ruler";
            this.btRuler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRuler.UseVisualStyleBackColor = false;
            this.btRuler.Click += new System.EventHandler(this.btRuler_Click);
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPictureBox.AutoScroll = true;
            this.panelPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPictureBox.Controls.Add(this.pictureBox1);
            this.panelPictureBox.Location = new System.Drawing.Point(1, 65);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(903, 543);
            this.panelPictureBox.TabIndex = 28;
            // 
            // btLamp
            // 
            this.btLamp.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (60)))), ((int) (((byte) (60)))));
            this.btLamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btLamp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLamp.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btLamp.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btLamp.Image = ((System.Drawing.Image) (resources.GetObject("btLamp.Image")));
            this.btLamp.Location = new System.Drawing.Point(3, 343);
            this.btLamp.Name = "btLamp";
            this.btLamp.Size = new System.Drawing.Size(68, 79);
            this.btLamp.TabIndex = 33;
            this.btLamp.Text = "Lamp";
            this.btLamp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLamp.UseVisualStyleBackColor = false;
            this.btLamp.Click += new System.EventHandler(this.btLamp_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.ClientSize = new System.Drawing.Size(1059, 610);
            this.ControlBox = false;
            this.Controls.Add(this.panelPictureBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.wallWidthTrack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelPictureBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btLamp;

        private System.Windows.Forms.Button brBed;

        private System.Windows.Forms.Button btLine;

        private System.Windows.Forms.Button btMeasuringTape;

        private System.Windows.Forms.Button btWindow;

        private System.Windows.Forms.Button btDoor;

        private System.Windows.Forms.Button btRuler;

        private System.Windows.Forms.CheckBox cbGrid;
        private System.Windows.Forms.CheckBox cbPoints;
        private System.Windows.Forms.CheckBox cbRuler;

        private System.Windows.Forms.Button btMaximize;

        private System.Windows.Forms.Panel panelPictureBox;

        private System.Windows.Forms.Button btPolyWall;
        private System.Windows.Forms.Button btWall;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.TextBox tbScaleMultiplier;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox tbScale;

        private JDragControl.JDragControl jDragControl1;

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMinimize;

        private System.Windows.Forms.Label labelWallWidth;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar wallWidthTrack;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMultiplierDown;
        private System.Windows.Forms.Label labelMultiplierUp;

        private System.Windows.Forms.Label labelScaleDown;
        private System.Windows.Forms.Label labelScaleUp;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}