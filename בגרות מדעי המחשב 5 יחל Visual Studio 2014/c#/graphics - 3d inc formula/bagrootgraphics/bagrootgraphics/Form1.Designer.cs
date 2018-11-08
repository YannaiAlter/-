namespace WindowsFormsApplication1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Resolution = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.widthBar = new System.Windows.Forms.TrackBar();
            this.widthvalue = new System.Windows.Forms.Label();
            this.ArrayBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.ResolutionValue = new System.Windows.Forms.Label();
            this.heightBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.ArrayTrack = new System.Windows.Forms.Label();
            this.heightValue = new System.Windows.Forms.Label();
            this.DepthDegreesValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DepthDegreesBar = new System.Windows.Forms.TrackBar();
            this.WatchingDegreesValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WatchingDegreesBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.HeightAdd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.WidthAdd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.function = new System.Windows.Forms.ComboBox();
            this.PaintWithOutLines = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.checkedBitmap = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.colorOption = new System.Windows.Forms.NumericUpDown();
            this.LinesWithPaint = new System.Windows.Forms.RadioButton();
            this.OnlyLines = new System.Windows.Forms.RadioButton();
            this.PaintWithLines = new System.Windows.Forms.RadioButton();
            this.E_res = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Resolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthDegreesBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatchingDegreesBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorOption)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 764);
            this.panel1.TabIndex = 0;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Miriam", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(741, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Z =";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(828, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "שרטט גרף";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resolution
            // 
            this.Resolution.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Resolution.LargeChange = 1;
            this.Resolution.Location = new System.Drawing.Point(734, 40);
            this.Resolution.Maximum = 20;
            this.Resolution.Minimum = 1;
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(177, 45);
            this.Resolution.TabIndex = 7;
            this.Resolution.Value = 5;
            this.Resolution.Scroll += new System.EventHandler(this.Resolution_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(917, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = ":רזולוצייה";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(926, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = ":הגדלה אופקית";
            // 
            // widthBar
            // 
            this.widthBar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.widthBar.Location = new System.Drawing.Point(737, 142);
            this.widthBar.Maximum = 100;
            this.widthBar.Minimum = 1;
            this.widthBar.Name = "widthBar";
            this.widthBar.Size = new System.Drawing.Size(180, 45);
            this.widthBar.SmallChange = 2;
            this.widthBar.TabIndex = 14;
            this.widthBar.TickFrequency = 10;
            this.widthBar.Value = 50;
            this.widthBar.Scroll += new System.EventHandler(this.widthBar_Scroll);
            // 
            // widthvalue
            // 
            this.widthvalue.AutoSize = true;
            this.widthvalue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.widthvalue.ForeColor = System.Drawing.Color.Cornsilk;
            this.widthvalue.Location = new System.Drawing.Point(816, 174);
            this.widthvalue.Name = "widthvalue";
            this.widthvalue.Size = new System.Drawing.Size(19, 13);
            this.widthvalue.TabIndex = 15;
            this.widthvalue.Text = "50";
            // 
            // ArrayBar
            // 
            this.ArrayBar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ArrayBar.LargeChange = 2;
            this.ArrayBar.Location = new System.Drawing.Point(734, 87);
            this.ArrayBar.Maximum = 50;
            this.ArrayBar.Minimum = 2;
            this.ArrayBar.Name = "ArrayBar";
            this.ArrayBar.Size = new System.Drawing.Size(179, 45);
            this.ArrayBar.TabIndex = 17;
            this.ArrayBar.TickFrequency = 2;
            this.ArrayBar.Value = 5;
            this.ArrayBar.Scroll += new System.EventHandler(this.ArrayBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(918, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = ":גודל מערך";
            // 
            // ResolutionValue
            // 
            this.ResolutionValue.AutoSize = true;
            this.ResolutionValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ResolutionValue.ForeColor = System.Drawing.Color.Cornsilk;
            this.ResolutionValue.Location = new System.Drawing.Point(806, 72);
            this.ResolutionValue.Name = "ResolutionValue";
            this.ResolutionValue.Size = new System.Drawing.Size(13, 13);
            this.ResolutionValue.TabIndex = 19;
            this.ResolutionValue.Text = "5";
            // 
            // heightBar
            // 
            this.heightBar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.heightBar.Location = new System.Drawing.Point(746, 210);
            this.heightBar.Maximum = 100;
            this.heightBar.Minimum = 1;
            this.heightBar.Name = "heightBar";
            this.heightBar.Size = new System.Drawing.Size(180, 45);
            this.heightBar.SmallChange = 2;
            this.heightBar.TabIndex = 20;
            this.heightBar.TickFrequency = 10;
            this.heightBar.Value = 50;
            this.heightBar.Scroll += new System.EventHandler(this.heightBar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(939, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = ":הגדלה אנכית";
            // 
            // ArrayTrack
            // 
            this.ArrayTrack.AutoSize = true;
            this.ArrayTrack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ArrayTrack.ForeColor = System.Drawing.Color.Cornsilk;
            this.ArrayTrack.Location = new System.Drawing.Point(806, 116);
            this.ArrayTrack.Name = "ArrayTrack";
            this.ArrayTrack.Size = new System.Drawing.Size(13, 13);
            this.ArrayTrack.TabIndex = 23;
            this.ArrayTrack.Text = "5";
            // 
            // heightValue
            // 
            this.heightValue.AutoSize = true;
            this.heightValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.heightValue.ForeColor = System.Drawing.Color.Cornsilk;
            this.heightValue.Location = new System.Drawing.Point(825, 242);
            this.heightValue.Name = "heightValue";
            this.heightValue.Size = new System.Drawing.Size(19, 13);
            this.heightValue.TabIndex = 24;
            this.heightValue.Text = "50";
            // 
            // DepthDegreesValue
            // 
            this.DepthDegreesValue.AutoSize = true;
            this.DepthDegreesValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DepthDegreesValue.ForeColor = System.Drawing.Color.Cornsilk;
            this.DepthDegreesValue.Location = new System.Drawing.Point(828, 314);
            this.DepthDegreesValue.Name = "DepthDegreesValue";
            this.DepthDegreesValue.Size = new System.Drawing.Size(19, 13);
            this.DepthDegreesValue.TabIndex = 27;
            this.DepthDegreesValue.Text = "20";
            this.DepthDegreesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(939, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = ":זווית ציר אורך";
            // 
            // DepthDegreesBar
            // 
            this.DepthDegreesBar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DepthDegreesBar.Location = new System.Drawing.Point(746, 282);
            this.DepthDegreesBar.Maximum = 90;
            this.DepthDegreesBar.Minimum = -90;
            this.DepthDegreesBar.Name = "DepthDegreesBar";
            this.DepthDegreesBar.Size = new System.Drawing.Size(180, 45);
            this.DepthDegreesBar.TabIndex = 25;
            this.DepthDegreesBar.TickFrequency = 10;
            this.DepthDegreesBar.Value = 20;
            this.DepthDegreesBar.Scroll += new System.EventHandler(this.DepthDegreesBar_Scroll);
            // 
            // WatchingDegreesValue
            // 
            this.WatchingDegreesValue.AutoSize = true;
            this.WatchingDegreesValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.WatchingDegreesValue.ForeColor = System.Drawing.Color.Cornsilk;
            this.WatchingDegreesValue.Location = new System.Drawing.Point(828, 385);
            this.WatchingDegreesValue.Name = "WatchingDegreesValue";
            this.WatchingDegreesValue.Size = new System.Drawing.Size(19, 13);
            this.WatchingDegreesValue.TabIndex = 30;
            this.WatchingDegreesValue.Text = "40";
            this.WatchingDegreesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(933, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = ":זווית ציר רוחב";
            // 
            // WatchingDegreesBar
            // 
            this.WatchingDegreesBar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.WatchingDegreesBar.Location = new System.Drawing.Point(749, 354);
            this.WatchingDegreesBar.Maximum = 90;
            this.WatchingDegreesBar.Minimum = -90;
            this.WatchingDegreesBar.Name = "WatchingDegreesBar";
            this.WatchingDegreesBar.Size = new System.Drawing.Size(180, 45);
            this.WatchingDegreesBar.TabIndex = 28;
            this.WatchingDegreesBar.TickFrequency = 10;
            this.WatchingDegreesBar.Value = 40;
            this.WatchingDegreesBar.Scroll += new System.EventHandler(this.WatchingDegreesBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(899, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = ":הזזה בציר האנכי";
            // 
            // HeightAdd
            // 
            this.HeightAdd.Location = new System.Drawing.Point(814, 465);
            this.HeightAdd.Name = "HeightAdd";
            this.HeightAdd.Size = new System.Drawing.Size(79, 20);
            this.HeightAdd.TabIndex = 32;
            this.HeightAdd.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.Cornsilk;
            this.label9.Location = new System.Drawing.Point(743, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "יחידות";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.Cornsilk;
            this.label10.Location = new System.Drawing.Point(740, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "יחידות";
            // 
            // WidthAdd
            // 
            this.WidthAdd.Location = new System.Drawing.Point(811, 426);
            this.WidthAdd.Name = "WidthAdd";
            this.WidthAdd.Size = new System.Drawing.Size(79, 20);
            this.WidthAdd.TabIndex = 35;
            this.WidthAdd.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Font = new System.Drawing.Font("Miriam Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Cornsilk;
            this.label11.Location = new System.Drawing.Point(896, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = ":הזזה בציר האפקי";
            // 
            // function
            // 
            this.function.FormattingEnabled = true;
            this.function.Items.AddRange(new object[] {
            "sin(x^2+y^2)",
            "x^2+2x",
            "3x^2-2xy+y^2",
            "(x-y)^2+yx",
            "cos(abs(x)+abs(y))",
            "1-abs(x+y)-abs(y-x)",
            "1-abs(y)",
            "sin(10(x^2+y^2))/10",
            "tan(xy)*sin(x)"});
            this.function.Location = new System.Drawing.Point(802, 12);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(209, 21);
            this.function.TabIndex = 38;
            // 
            // PaintWithOutLines
            // 
            this.PaintWithOutLines.AutoSize = true;
            this.PaintWithOutLines.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PaintWithOutLines.Checked = true;
            this.PaintWithOutLines.Location = new System.Drawing.Point(185, 49);
            this.PaintWithOutLines.Name = "PaintWithOutLines";
            this.PaintWithOutLines.Size = new System.Drawing.Size(105, 17);
            this.PaintWithOutLines.TabIndex = 39;
            this.PaintWithOutLines.TabStop = true;
            this.PaintWithOutLines.Text = "ציור ללא קווים";
            this.PaintWithOutLines.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.PaintWithOutLines.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.checkedBitmap);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.colorOption);
            this.groupBox1.Controls.Add(this.LinesWithPaint);
            this.groupBox1.Controls.Add(this.OnlyLines);
            this.groupBox1.Controls.Add(this.PaintWithLines);
            this.groupBox1.Controls.Add(this.PaintWithOutLines);
            this.groupBox1.Location = new System.Drawing.Point(762, 537);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 136);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "סגנון ציור הפונקצייה";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 20);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            this.progressBar1.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(106, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = ":תהליך";
            // 
            // checkedBitmap
            // 
            this.checkedBitmap.AutoSize = true;
            this.checkedBitmap.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkedBitmap.Location = new System.Drawing.Point(159, 19);
            this.checkedBitmap.Name = "checkedBitmap";
            this.checkedBitmap.Size = new System.Drawing.Size(144, 17);
            this.checkedBitmap.TabIndex = 47;
            this.checkedBitmap.Text = "ציור מהיר (ללא הדרגה)";
            this.checkedBitmap.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label14.Location = new System.Drawing.Point(57, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 15);
            this.label14.TabIndex = 46;
            this.label14.Text = "לחץ כאן";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(114, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "לרשימת הצבעים";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = ":צבע";
            // 
            // colorOption
            // 
            this.colorOption.Location = new System.Drawing.Point(211, 110);
            this.colorOption.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorOption.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorOption.Name = "colorOption";
            this.colorOption.Size = new System.Drawing.Size(31, 20);
            this.colorOption.TabIndex = 43;
            this.colorOption.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LinesWithPaint
            // 
            this.LinesWithPaint.AutoSize = true;
            this.LinesWithPaint.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LinesWithPaint.Location = new System.Drawing.Point(36, 83);
            this.LinesWithPaint.Name = "LinesWithPaint";
            this.LinesWithPaint.Size = new System.Drawing.Size(101, 17);
            this.LinesWithPaint.TabIndex = 42;
            this.LinesWithPaint.Text = "קווים ואז ציור";
            this.LinesWithPaint.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LinesWithPaint.UseVisualStyleBackColor = true;
            // 
            // OnlyLines
            // 
            this.OnlyLines.AutoSize = true;
            this.OnlyLines.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OnlyLines.Location = new System.Drawing.Point(32, 49);
            this.OnlyLines.Name = "OnlyLines";
            this.OnlyLines.Size = new System.Drawing.Size(105, 17);
            this.OnlyLines.TabIndex = 41;
            this.OnlyLines.Text = "קווים ללא ציור";
            this.OnlyLines.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.OnlyLines.UseVisualStyleBackColor = true;
            // 
            // PaintWithLines
            // 
            this.PaintWithLines.AutoSize = true;
            this.PaintWithLines.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PaintWithLines.Location = new System.Drawing.Point(185, 83);
            this.PaintWithLines.Name = "PaintWithLines";
            this.PaintWithLines.Size = new System.Drawing.Size(101, 17);
            this.PaintWithLines.TabIndex = 40;
            this.PaintWithLines.Text = "ציור ואז קווים";
            this.PaintWithLines.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.PaintWithLines.UseVisualStyleBackColor = true;
            // 
            // E_res
            // 
            this.E_res.Location = new System.Drawing.Point(1027, 57);
            this.E_res.Name = "E_res";
            this.E_res.Size = new System.Drawing.Size(19, 22);
            this.E_res.TabIndex = 41;
            this.E_res.Text = "?";
            this.E_res.UseVisualStyleBackColor = true;
            this.E_res.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1027, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 22);
            this.button2.TabIndex = 42;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1104, 733);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.E_res);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.function);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.WidthAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HeightAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WatchingDegreesValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.WatchingDegreesBar);
            this.Controls.Add(this.DepthDegreesValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DepthDegreesBar);
            this.Controls.Add(this.heightValue);
            this.Controls.Add(this.ArrayTrack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.heightBar);
            this.Controls.Add(this.widthvalue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResolutionValue);
            this.Controls.Add(this.ArrayBar);
            this.Controls.Add(this.Resolution);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Graphics Project\'s 5 Units";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form1_Scroll);
            ((System.ComponentModel.ISupportInitialize)(this.Resolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthDegreesBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatchingDegreesBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar Resolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar widthBar;
        private System.Windows.Forms.Label widthvalue;
        private System.Windows.Forms.TrackBar ArrayBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ResolutionValue;
        private System.Windows.Forms.TrackBar heightBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ArrayTrack;
        private System.Windows.Forms.Label heightValue;
        private System.Windows.Forms.Label DepthDegreesValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar DepthDegreesBar;
        private System.Windows.Forms.Label WatchingDegreesValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar WatchingDegreesBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HeightAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox WidthAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox function;
        private System.Windows.Forms.RadioButton PaintWithOutLines;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OnlyLines;
        private System.Windows.Forms.RadioButton PaintWithLines;
        private System.Windows.Forms.RadioButton LinesWithPaint;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown colorOption;
        private System.Windows.Forms.Button E_res;
        private System.Windows.Forms.CheckBox checkedBitmap;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
    }
}

