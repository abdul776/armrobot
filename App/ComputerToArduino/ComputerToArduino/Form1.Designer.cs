namespace ComputerToArduino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonResetServos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelS1 = new System.Windows.Forms.Panel();
            this.labelServoPos_0 = new System.Windows.Forms.Label();
            this.sub1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarServo_0 = new System.Windows.Forms.TrackBar();
            this.panelS2 = new System.Windows.Forms.Panel();
            this.labelServoPos_1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarServo_1 = new System.Windows.Forms.TrackBar();
            this.panelS3 = new System.Windows.Forms.Panel();
            this.labelServoPos_2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarServo_2 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.panelS4 = new System.Windows.Forms.Panel();
            this.labelServoPos_3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarServo_3 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_0)).BeginInit();
            this.panelS2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_1)).BeginInit();
            this.panelS3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_2)).BeginInit();
            this.panelS4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(68, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arduino Not Connected";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 683);
            this.panel1.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Location = new System.Drawing.Point(123, 368);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Controller";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label15.Location = new System.Drawing.Point(37, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "NIM   : 41419110063";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 10F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(38, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Nama : Jody Maulana Anggi";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonResetServos);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 304);
            this.panel3.TabIndex = 5;
            // 
            // buttonResetServos
            // 
            this.buttonResetServos.Location = new System.Drawing.Point(89, 172);
            this.buttonResetServos.Name = "buttonResetServos";
            this.buttonResetServos.Size = new System.Drawing.Size(136, 40);
            this.buttonResetServos.TabIndex = 0;
            this.buttonResetServos.Text = "Reset";
            this.buttonResetServos.UseVisualStyleBackColor = true;
            this.buttonResetServos.Click += new System.EventHandler(this.buttoResetServos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(116, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serial Port";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ComputerToArduino.Properties.Resources.pas_foto;
            this.pictureBox1.Location = new System.Drawing.Point(84, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.buttonMinimize);
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.Header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(326, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 71);
            this.panel2.TabIndex = 11;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderForm_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borderForm_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borderForm_MouseUp);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Image = global::ComputerToArduino.Properties.Resources.minimize1;
            this.buttonMinimize.Location = new System.Drawing.Point(667, 22);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(25, 25);
            this.buttonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonMinimize.TabIndex = 7;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimized_Click);
            this.buttonMinimize.MouseEnter += new System.EventHandler(this.buttonMinimize_MouseEnter);
            this.buttonMinimize.MouseLeave += new System.EventHandler(this.buttonMinimize_MouseLeave);
            // 
            // buttonClose
            // 
            this.buttonClose.Image = global::ComputerToArduino.Properties.Resources.icons8_cancel_50;
            this.buttonClose.Location = new System.Drawing.Point(698, 22);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonClose.TabIndex = 6;
            this.buttonClose.TabStop = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.Navy;
            this.Header.Location = new System.Drawing.Point(215, 20);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(290, 37);
            this.Header.TabIndex = 0;
            this.Header.Text = "Robotic ARM 4-DOF";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Controls.Add(this.panelS1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelS2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelS3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelS4, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(326, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.606557F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.39344F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 612);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panelS1
            // 
            this.panelS1.BackColor = System.Drawing.Color.Snow;
            this.panelS1.Controls.Add(this.labelServoPos_0);
            this.panelS1.Controls.Add(this.sub1);
            this.panelS1.Controls.Add(this.label4);
            this.panelS1.Controls.Add(this.label3);
            this.panelS1.Controls.Add(this.trackBarServo_0);
            this.panelS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelS1.Location = new System.Drawing.Point(9, 11);
            this.panelS1.Margin = new System.Windows.Forms.Padding(0);
            this.panelS1.Name = "panelS1";
            this.panelS1.Size = new System.Drawing.Size(353, 299);
            this.panelS1.TabIndex = 0;
            // 
            // labelServoPos_0
            // 
            this.labelServoPos_0.AutoSize = true;
            this.labelServoPos_0.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServoPos_0.Location = new System.Drawing.Point(99, 166);
            this.labelServoPos_0.Name = "labelServoPos_0";
            this.labelServoPos_0.Size = new System.Drawing.Size(90, 20);
            this.labelServoPos_0.TabIndex = 5;
            this.labelServoPos_0.Text = "Degree : ";
            // 
            // sub1
            // 
            this.sub1.AutoSize = true;
            this.sub1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub1.Location = new System.Drawing.Point(116, 44);
            this.sub1.Name = "sub1";
            this.sub1.Size = new System.Drawing.Size(76, 23);
            this.sub1.TabIndex = 4;
            this.sub1.Text = "Axis 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "180";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // trackBarServo_0
            // 
            this.trackBarServo_0.Location = new System.Drawing.Point(34, 107);
            this.trackBarServo_0.Maximum = 180;
            this.trackBarServo_0.Name = "trackBarServo_0";
            this.trackBarServo_0.Size = new System.Drawing.Size(255, 56);
            this.trackBarServo_0.TabIndex = 1;
            this.trackBarServo_0.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarServo_0.Scroll += new System.EventHandler(this.trackBarServo_0_Scroll);
            // 
            // panelS2
            // 
            this.panelS2.BackColor = System.Drawing.Color.Snow;
            this.panelS2.Controls.Add(this.labelServoPos_1);
            this.panelS2.Controls.Add(this.label11);
            this.panelS2.Controls.Add(this.label5);
            this.panelS2.Controls.Add(this.label6);
            this.panelS2.Controls.Add(this.trackBarServo_1);
            this.panelS2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelS2.Location = new System.Drawing.Point(377, 11);
            this.panelS2.Margin = new System.Windows.Forms.Padding(0);
            this.panelS2.Name = "panelS2";
            this.panelS2.Size = new System.Drawing.Size(350, 299);
            this.panelS2.TabIndex = 1;
            // 
            // labelServoPos_1
            // 
            this.labelServoPos_1.AutoSize = true;
            this.labelServoPos_1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServoPos_1.Location = new System.Drawing.Point(123, 166);
            this.labelServoPos_1.Name = "labelServoPos_1";
            this.labelServoPos_1.Size = new System.Drawing.Size(90, 20);
            this.labelServoPos_1.TabIndex = 6;
            this.labelServoPos_1.Text = "Degree : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(137, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Axis 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "180";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "0";
            // 
            // trackBarServo_1
            // 
            this.trackBarServo_1.Location = new System.Drawing.Point(41, 107);
            this.trackBarServo_1.Maximum = 180;
            this.trackBarServo_1.Name = "trackBarServo_1";
            this.trackBarServo_1.Size = new System.Drawing.Size(255, 56);
            this.trackBarServo_1.TabIndex = 1;
            this.trackBarServo_1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarServo_1.Value = 50;
            this.trackBarServo_1.Scroll += new System.EventHandler(this.trackBarServo_1_Scroll);
            // 
            // panelS3
            // 
            this.panelS3.BackColor = System.Drawing.Color.Snow;
            this.panelS3.Controls.Add(this.labelServoPos_2);
            this.panelS3.Controls.Add(this.label13);
            this.panelS3.Controls.Add(this.label7);
            this.panelS3.Controls.Add(this.trackBarServo_2);
            this.panelS3.Controls.Add(this.label8);
            this.panelS3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelS3.Location = new System.Drawing.Point(9, 318);
            this.panelS3.Margin = new System.Windows.Forms.Padding(0);
            this.panelS3.Name = "panelS3";
            this.panelS3.Size = new System.Drawing.Size(353, 285);
            this.panelS3.TabIndex = 2;
            // 
            // labelServoPos_2
            // 
            this.labelServoPos_2.AutoSize = true;
            this.labelServoPos_2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServoPos_2.Location = new System.Drawing.Point(99, 182);
            this.labelServoPos_2.Name = "labelServoPos_2";
            this.labelServoPos_2.Size = new System.Drawing.Size(90, 20);
            this.labelServoPos_2.TabIndex = 6;
            this.labelServoPos_2.Text = "Degree : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(116, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 23);
            this.label13.TabIndex = 5;
            this.label13.Text = "Axis 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "180";
            // 
            // trackBarServo_2
            // 
            this.trackBarServo_2.Location = new System.Drawing.Point(34, 123);
            this.trackBarServo_2.Maximum = 180;
            this.trackBarServo_2.Name = "trackBarServo_2";
            this.trackBarServo_2.Size = new System.Drawing.Size(255, 56);
            this.trackBarServo_2.TabIndex = 1;
            this.trackBarServo_2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarServo_2.Value = 50;
            this.trackBarServo_2.Scroll += new System.EventHandler(this.trackBarServo_2_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "0";
            // 
            // panelS4
            // 
            this.panelS4.BackColor = System.Drawing.Color.Snow;
            this.panelS4.Controls.Add(this.labelServoPos_3);
            this.panelS4.Controls.Add(this.label12);
            this.panelS4.Controls.Add(this.label9);
            this.panelS4.Controls.Add(this.trackBarServo_3);
            this.panelS4.Controls.Add(this.label10);
            this.panelS4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelS4.Location = new System.Drawing.Point(377, 318);
            this.panelS4.Margin = new System.Windows.Forms.Padding(0);
            this.panelS4.Name = "panelS4";
            this.panelS4.Size = new System.Drawing.Size(350, 285);
            this.panelS4.TabIndex = 3;
            // 
            // labelServoPos_3
            // 
            this.labelServoPos_3.AutoSize = true;
            this.labelServoPos_3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServoPos_3.Location = new System.Drawing.Point(123, 182);
            this.labelServoPos_3.Name = "labelServoPos_3";
            this.labelServoPos_3.Size = new System.Drawing.Size(90, 20);
            this.labelServoPos_3.TabIndex = 7;
            this.labelServoPos_3.Text = "Degree : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(137, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "Axis 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "80";
            // 
            // trackBarServo_3
            // 
            this.trackBarServo_3.Location = new System.Drawing.Point(41, 123);
            this.trackBarServo_3.Maximum = 80;
            this.trackBarServo_3.Minimum = 41;
            this.trackBarServo_3.Name = "trackBarServo_3";
            this.trackBarServo_3.Size = new System.Drawing.Size(255, 56);
            this.trackBarServo_3.TabIndex = 1;
            this.trackBarServo_3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarServo_3.Value = 41;
            this.trackBarServo_3.Scroll += new System.EventHandler(this.trackBarServo_3_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1062, 683);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Computer to Arduino";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelS1.ResumeLayout(false);
            this.panelS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_0)).EndInit();
            this.panelS2.ResumeLayout(false);
            this.panelS2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_1)).EndInit();
            this.panelS3.ResumeLayout(false);
            this.panelS3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_2)).EndInit();
            this.panelS4.ResumeLayout(false);
            this.panelS4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelS1;
        private System.Windows.Forms.Panel panelS2;
        private System.Windows.Forms.Panel panelS3;
        private System.Windows.Forms.Panel panelS4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarServo_0;
        private System.Windows.Forms.TrackBar trackBarServo_1;
        private System.Windows.Forms.TrackBar trackBarServo_2;
        private System.Windows.Forms.Label sub1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelServoPos_0;
        private System.Windows.Forms.Label labelServoPos_1;
        private System.Windows.Forms.Label labelServoPos_2;
        private System.Windows.Forms.Label labelServoPos_3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonResetServos;
        private System.Windows.Forms.TrackBar trackBarServo_3;
        private System.Windows.Forms.PictureBox buttonClose;
        private System.Windows.Forms.PictureBox buttonMinimize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

