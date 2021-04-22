
namespace HomeWork7
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxDepth = new System.Windows.Forms.ListBox();
            this.listBox2Length = new System.Windows.Forms.ListBox();
            this.listBoxPer1 = new System.Windows.Forms.ListBox();
            this.listBoxPer2 = new System.Windows.Forms.ListBox();
            this.listBoxTh1 = new System.Windows.Forms.ListBox();
            this.listBoxTh2 = new System.Windows.Forms.ListBox();
            this.listBoxColor = new System.Windows.Forms.ListBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 60);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonDraw);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(790, 60);
            this.splitContainer1.SplitterDistance = 653;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(653, 60);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(653, 25);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "递归深度";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(86, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "主干长度";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(169, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "右分支长度比";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(275, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "左分支长度比";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(381, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = " 右分支角度";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(477, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "左分支角度";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(573, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "画笔颜色";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.listBoxDepth);
            this.flowLayoutPanel2.Controls.Add(this.listBox2Length);
            this.flowLayoutPanel2.Controls.Add(this.listBoxPer1);
            this.flowLayoutPanel2.Controls.Add(this.listBoxPer2);
            this.flowLayoutPanel2.Controls.Add(this.listBoxTh1);
            this.flowLayoutPanel2.Controls.Add(this.listBoxTh2);
            this.flowLayoutPanel2.Controls.Add(this.listBoxColor);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(653, 31);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // listBoxDepth
            // 
            this.listBoxDepth.FormattingEnabled = true;
            this.listBoxDepth.ItemHeight = 20;
            this.listBoxDepth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.listBoxDepth.Location = new System.Drawing.Point(3, 3);
            this.listBoxDepth.Name = "listBoxDepth";
            this.listBoxDepth.Size = new System.Drawing.Size(77, 24);
            this.listBoxDepth.TabIndex = 0;
            // 
            // listBox2Length
            // 
            this.listBox2Length.FormattingEnabled = true;
            this.listBox2Length.ItemHeight = 20;
            this.listBox2Length.Items.AddRange(new object[] {
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            ""});
            this.listBox2Length.Location = new System.Drawing.Point(86, 3);
            this.listBox2Length.Name = "listBox2Length";
            this.listBox2Length.Size = new System.Drawing.Size(77, 24);
            this.listBox2Length.TabIndex = 1;
            // 
            // listBoxPer1
            // 
            this.listBoxPer1.FormattingEnabled = true;
            this.listBoxPer1.ItemHeight = 20;
            this.listBoxPer1.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9"});
            this.listBoxPer1.Location = new System.Drawing.Point(169, 3);
            this.listBoxPer1.Name = "listBoxPer1";
            this.listBoxPer1.Size = new System.Drawing.Size(100, 24);
            this.listBoxPer1.TabIndex = 2;
            // 
            // listBoxPer2
            // 
            this.listBoxPer2.FormattingEnabled = true;
            this.listBoxPer2.ItemHeight = 20;
            this.listBoxPer2.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9"});
            this.listBoxPer2.Location = new System.Drawing.Point(275, 3);
            this.listBoxPer2.Name = "listBoxPer2";
            this.listBoxPer2.Size = new System.Drawing.Size(100, 24);
            this.listBoxPer2.TabIndex = 3;
            // 
            // listBoxTh1
            // 
            this.listBoxTh1.FormattingEnabled = true;
            this.listBoxTh1.ItemHeight = 20;
            this.listBoxTh1.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.listBoxTh1.Location = new System.Drawing.Point(381, 3);
            this.listBoxTh1.Name = "listBoxTh1";
            this.listBoxTh1.Size = new System.Drawing.Size(90, 24);
            this.listBoxTh1.TabIndex = 4;
            // 
            // listBoxTh2
            // 
            this.listBoxTh2.FormattingEnabled = true;
            this.listBoxTh2.ItemHeight = 20;
            this.listBoxTh2.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.listBoxTh2.Location = new System.Drawing.Point(477, 3);
            this.listBoxTh2.Name = "listBoxTh2";
            this.listBoxTh2.Size = new System.Drawing.Size(90, 24);
            this.listBoxTh2.TabIndex = 5;
            // 
            // listBoxColor
            // 
            this.listBoxColor.FormattingEnabled = true;
            this.listBoxColor.ItemHeight = 20;
            this.listBoxColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow"});
            this.listBoxColor.Location = new System.Drawing.Point(573, 3);
            this.listBoxColor.Name = "listBoxColor";
            this.listBoxColor.Size = new System.Drawing.Size(77, 24);
            this.listBoxColor.TabIndex = 6;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(22, 16);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(94, 40);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 380);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxDepth;
        private System.Windows.Forms.ListBox listBox2Length;
        private System.Windows.Forms.ListBox listBoxPer1;
        private System.Windows.Forms.ListBox listBoxPer2;
        private System.Windows.Forms.ListBox listBoxTh1;
        private System.Windows.Forms.ListBox listBoxTh2;
        private System.Windows.Forms.ListBox listBoxColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDraw;
    }
}

