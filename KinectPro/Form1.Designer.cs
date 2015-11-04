namespace KinectPro
{
    partial class Main
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
            this.pb = new System.Windows.Forms.PictureBox();
            this.btnStream = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statlbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConID = new System.Windows.Forms.ToolStripStatusLabel();
            this.sliderAngle = new System.Windows.Forms.TrackBar();
            this.sliderValue = new System.Windows.Forms.Label();
            this.btnAdjust = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(12, 12);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(568, 420);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // btnStream
            // 
            this.btnStream.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStream.Location = new System.Drawing.Point(268, 493);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(169, 44);
            this.btnStream.TabIndex = 12;
            this.btnStream.Text = "Stream";
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statlbl,
            this.toolStripStatusLabel2,
            this.lblConID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(715, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // statlbl
            // 
            this.statlbl.Name = "statlbl";
            this.statlbl.Size = new System.Drawing.Size(22, 17);
            this.statlbl.Text = "---";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel2.Text = "              Connection ID:";
            // 
            // lblConID
            // 
            this.lblConID.Name = "lblConID";
            this.lblConID.Size = new System.Drawing.Size(22, 17);
            this.lblConID.Text = "---";
            // 
            // sliderAngle
            // 
            this.sliderAngle.Location = new System.Drawing.Point(625, 12);
            this.sliderAngle.Maximum = 27;
            this.sliderAngle.Minimum = -27;
            this.sliderAngle.Name = "sliderAngle";
            this.sliderAngle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sliderAngle.Size = new System.Drawing.Size(45, 420);
            this.sliderAngle.TabIndex = 14;
            this.sliderAngle.Scroll += new System.EventHandler(this.sliderAngle_Scroll);
            this.sliderAngle.ValueChanged += new System.EventHandler(this.sliderAngle_ValueChanged);
            // 
            // sliderValue
            // 
            this.sliderValue.AutoSize = true;
            this.sliderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderValue.Location = new System.Drawing.Point(631, 435);
            this.sliderValue.Name = "sliderValue";
            this.sliderValue.Size = new System.Drawing.Size(18, 20);
            this.sliderValue.TabIndex = 15;
            this.sliderValue.Text = "0";
            this.sliderValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdjust
            // 
            this.btnAdjust.Location = new System.Drawing.Point(604, 475);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(75, 23);
            this.btnAdjust.TabIndex = 16;
            this.btnAdjust.Text = "Adjust";
            this.btnAdjust.UseVisualStyleBackColor = true;
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(604, 505);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 561);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdjust);
            this.Controls.Add(this.sliderValue);
            this.Controls.Add(this.sliderAngle);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnStream);
            this.Controls.Add(this.pb);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statlbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblConID;
        private System.Windows.Forms.TrackBar sliderAngle;
        private System.Windows.Forms.Label sliderValue;
        private System.Windows.Forms.Button btnAdjust;
        private System.Windows.Forms.Button btnReset;
    }
}

