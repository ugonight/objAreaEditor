namespace objAreaEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listImage = new System.Windows.Forms.ListBox();
            this.listArea = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabImage = new System.Windows.Forms.TabPage();
            this.labelImageCenter = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudImageY = new System.Windows.Forms.NumericUpDown();
            this.nudImageX = new System.Windows.Forms.NumericUpDown();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbImageName = new System.Windows.Forms.TextBox();
            this.tabArea = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudAreaH = new System.Windows.Forms.NumericUpDown();
            this.nudAreaW = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAreaY = new System.Windows.Forms.NumericUpDown();
            this.nudAreaX = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveArea = new System.Windows.Forms.Button();
            this.btnAddArea = new System.Windows.Forms.Button();
            this.btnDownImage = new System.Windows.Forms.Button();
            this.btnUpImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageX)).BeginInit();
            this.tabArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaX)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(854, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // listImage
            // 
            this.listImage.AllowDrop = true;
            this.listImage.FormattingEnabled = true;
            this.listImage.ItemHeight = 12;
            this.listImage.Location = new System.Drawing.Point(12, 577);
            this.listImage.Name = "listImage";
            this.listImage.Size = new System.Drawing.Size(380, 88);
            this.listImage.TabIndex = 1;
            this.listImage.SelectedIndexChanged += new System.EventHandler(this.listImage_SelectedIndexChanged);
            this.listImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.listImage_DragDrop);
            this.listImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.listImage_DragEnter);
            // 
            // listArea
            // 
            this.listArea.FormattingEnabled = true;
            this.listArea.ItemHeight = 12;
            this.listArea.Location = new System.Drawing.Point(447, 577);
            this.listArea.Name = "listArea";
            this.listArea.Size = new System.Drawing.Size(380, 88);
            this.listArea.TabIndex = 2;
            this.listArea.SelectedIndexChanged += new System.EventHandler(this.listArea_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "画像リスト";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "エリアリスト";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(398, 577);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(20, 20);
            this.btnAddImage.TabIndex = 5;
            this.btnAddImage.Text = "+";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 672);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = ",";
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Location = new System.Drawing.Point(398, 603);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(20, 20);
            this.btnRemoveImage.TabIndex = 8;
            this.btnRemoveImage.Text = "-";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabImage);
            this.tabControl1.Controls.Add(this.tabArea);
            this.tabControl1.Location = new System.Drawing.Point(9, 498);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 60);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabImage
            // 
            this.tabImage.Controls.Add(this.labelImageCenter);
            this.tabImage.Controls.Add(this.label10);
            this.tabImage.Controls.Add(this.label5);
            this.tabImage.Controls.Add(this.label4);
            this.tabImage.Controls.Add(this.nudImageY);
            this.tabImage.Controls.Add(this.nudImageX);
            this.tabImage.Controls.Add(this.btnChangeImage);
            this.tabImage.Controls.Add(this.label3);
            this.tabImage.Controls.Add(this.tbImageName);
            this.tabImage.Location = new System.Drawing.Point(4, 25);
            this.tabImage.Name = "tabImage";
            this.tabImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabImage.Size = new System.Drawing.Size(846, 31);
            this.tabImage.TabIndex = 0;
            this.tabImage.Text = "画像移動";
            this.tabImage.UseVisualStyleBackColor = true;
            // 
            // labelImageCenter
            // 
            this.labelImageCenter.AutoSize = true;
            this.labelImageCenter.Location = new System.Drawing.Point(719, 10);
            this.labelImageCenter.Name = "labelImageCenter";
            this.labelImageCenter.Size = new System.Drawing.Size(19, 12);
            this.labelImageCenter.TabIndex = 8;
            this.labelImageCenter.Text = "0,0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(648, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "中央の座標:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "x:";
            // 
            // nudImageY
            // 
            this.nudImageY.Location = new System.Drawing.Point(558, 8);
            this.nudImageY.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.nudImageY.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            -2147483648});
            this.nudImageY.Name = "nudImageY";
            this.nudImageY.Size = new System.Drawing.Size(65, 19);
            this.nudImageY.TabIndex = 4;
            this.nudImageY.ValueChanged += new System.EventHandler(this.nudImageY_ValueChanged);
            // 
            // nudImageX
            // 
            this.nudImageX.Location = new System.Drawing.Point(451, 8);
            this.nudImageX.Maximum = new decimal(new int[] {
            854,
            0,
            0,
            0});
            this.nudImageX.Minimum = new decimal(new int[] {
            854,
            0,
            0,
            -2147483648});
            this.nudImageX.Name = "nudImageX";
            this.nudImageX.Size = new System.Drawing.Size(65, 19);
            this.nudImageX.TabIndex = 3;
            this.nudImageX.ValueChanged += new System.EventHandler(this.nudImageX_ValueChanged);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(385, 6);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(20, 20);
            this.btnChangeImage.TabIndex = 2;
            this.btnChangeImage.Text = "…";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "画像ファイル:";
            // 
            // tbImageName
            // 
            this.tbImageName.Enabled = false;
            this.tbImageName.Location = new System.Drawing.Point(77, 7);
            this.tbImageName.Name = "tbImageName";
            this.tbImageName.Size = new System.Drawing.Size(302, 19);
            this.tbImageName.TabIndex = 0;
            // 
            // tabArea
            // 
            this.tabArea.Controls.Add(this.label8);
            this.tabArea.Controls.Add(this.label9);
            this.tabArea.Controls.Add(this.nudAreaH);
            this.tabArea.Controls.Add(this.nudAreaW);
            this.tabArea.Controls.Add(this.label6);
            this.tabArea.Controls.Add(this.label7);
            this.tabArea.Controls.Add(this.nudAreaY);
            this.tabArea.Controls.Add(this.nudAreaX);
            this.tabArea.Location = new System.Drawing.Point(4, 25);
            this.tabArea.Name = "tabArea";
            this.tabArea.Padding = new System.Windows.Forms.Padding(3);
            this.tabArea.Size = new System.Drawing.Size(846, 31);
            this.tabArea.TabIndex = 1;
            this.tabArea.Text = "エリア編集";
            this.tabArea.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "h:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "w:";
            // 
            // nudAreaH
            // 
            this.nudAreaH.Location = new System.Drawing.Point(351, 9);
            this.nudAreaH.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.nudAreaH.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            -2147483648});
            this.nudAreaH.Name = "nudAreaH";
            this.nudAreaH.Size = new System.Drawing.Size(65, 19);
            this.nudAreaH.TabIndex = 12;
            this.nudAreaH.ValueChanged += new System.EventHandler(this.nudAreaH_ValueChanged);
            // 
            // nudAreaW
            // 
            this.nudAreaW.Location = new System.Drawing.Point(244, 9);
            this.nudAreaW.Maximum = new decimal(new int[] {
            854,
            0,
            0,
            0});
            this.nudAreaW.Minimum = new decimal(new int[] {
            854,
            0,
            0,
            -2147483648});
            this.nudAreaW.Name = "nudAreaW";
            this.nudAreaW.Size = new System.Drawing.Size(65, 19);
            this.nudAreaW.TabIndex = 11;
            this.nudAreaW.ValueChanged += new System.EventHandler(this.nudAreaW_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "x:";
            // 
            // nudAreaY
            // 
            this.nudAreaY.Location = new System.Drawing.Point(136, 9);
            this.nudAreaY.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.nudAreaY.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            -2147483648});
            this.nudAreaY.Name = "nudAreaY";
            this.nudAreaY.Size = new System.Drawing.Size(65, 19);
            this.nudAreaY.TabIndex = 8;
            this.nudAreaY.ValueChanged += new System.EventHandler(this.nudAreaY_ValueChanged);
            // 
            // nudAreaX
            // 
            this.nudAreaX.Location = new System.Drawing.Point(29, 9);
            this.nudAreaX.Maximum = new decimal(new int[] {
            854,
            0,
            0,
            0});
            this.nudAreaX.Minimum = new decimal(new int[] {
            854,
            0,
            0,
            -2147483648});
            this.nudAreaX.Name = "nudAreaX";
            this.nudAreaX.Size = new System.Drawing.Size(65, 19);
            this.nudAreaX.TabIndex = 7;
            this.nudAreaX.ValueChanged += new System.EventHandler(this.nudAreaX_ValueChanged);
            // 
            // btnRemoveArea
            // 
            this.btnRemoveArea.Location = new System.Drawing.Point(833, 603);
            this.btnRemoveArea.Name = "btnRemoveArea";
            this.btnRemoveArea.Size = new System.Drawing.Size(20, 20);
            this.btnRemoveArea.TabIndex = 12;
            this.btnRemoveArea.Text = "-";
            this.btnRemoveArea.UseVisualStyleBackColor = true;
            this.btnRemoveArea.Click += new System.EventHandler(this.btnRemoveArea_Click);
            // 
            // btnAddArea
            // 
            this.btnAddArea.Location = new System.Drawing.Point(833, 577);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.Size = new System.Drawing.Size(20, 20);
            this.btnAddArea.TabIndex = 11;
            this.btnAddArea.Text = "+";
            this.btnAddArea.UseVisualStyleBackColor = true;
            this.btnAddArea.Click += new System.EventHandler(this.btnAddArea_Click);
            // 
            // btnDownImage
            // 
            this.btnDownImage.Font = new System.Drawing.Font("MS UI Gothic", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDownImage.Location = new System.Drawing.Point(398, 650);
            this.btnDownImage.Name = "btnDownImage";
            this.btnDownImage.Size = new System.Drawing.Size(20, 15);
            this.btnDownImage.TabIndex = 14;
            this.btnDownImage.Text = "▼";
            this.btnDownImage.UseVisualStyleBackColor = true;
            this.btnDownImage.Click += new System.EventHandler(this.btnDownImage_Click);
            // 
            // btnUpImage
            // 
            this.btnUpImage.Font = new System.Drawing.Font("MS UI Gothic", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpImage.Location = new System.Drawing.Point(398, 629);
            this.btnUpImage.Name = "btnUpImage";
            this.btnUpImage.Size = new System.Drawing.Size(20, 15);
            this.btnUpImage.TabIndex = 13;
            this.btnUpImage.Text = "▲";
            this.btnUpImage.UseVisualStyleBackColor = true;
            this.btnUpImage.Click += new System.EventHandler(this.btnUpImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 694);
            this.Controls.Add(this.btnDownImage);
            this.Controls.Add(this.btnUpImage);
            this.Controls.Add(this.btnRemoveArea);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAddArea);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listArea);
            this.Controls.Add(this.listImage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "objAreaEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabImage.ResumeLayout(false);
            this.tabImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImageX)).EndInit();
            this.tabArea.ResumeLayout(false);
            this.tabArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAreaX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listImage;
        private System.Windows.Forms.ListBox listArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabImage;
        private System.Windows.Forms.TabPage tabArea;
        private System.Windows.Forms.Button btnRemoveArea;
        private System.Windows.Forms.Button btnAddArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudImageY;
        private System.Windows.Forms.NumericUpDown nudImageX;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbImageName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudAreaH;
        private System.Windows.Forms.NumericUpDown nudAreaW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAreaY;
        private System.Windows.Forms.NumericUpDown nudAreaX;
        private System.Windows.Forms.Button btnDownImage;
        private System.Windows.Forms.Button btnUpImage;
        private System.Windows.Forms.Label labelImageCenter;
        private System.Windows.Forms.Label label10;
    }
}

