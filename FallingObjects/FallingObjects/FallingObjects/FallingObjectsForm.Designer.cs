namespace FallingObjects
{
    partial class frmFallingObjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFallingObjects));
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.mnuExit = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.radEarthGravity = new System.Windows.Forms.RadioButton();
            this.radMoonGravity = new System.Windows.Forms.RadioButton();
            this.radHeight100 = new System.Windows.Forms.RadioButton();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.grbHeight = new System.Windows.Forms.GroupBox();
            this.radHeight200 = new System.Windows.Forms.RadioButton();
            this.grbGravity = new System.Windows.Forms.GroupBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.mnuExit.SuspendLayout();
            this.grbHeight.SuspendLayout();
            this.grbGravity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(35, 107);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 0;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(113, 91);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(13, 13);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "0";
            this.lblHeight.Click += new System.EventHandler(this.lblHeight_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.mnuExit.Location = new System.Drawing.Point(0, 0);
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(449, 24);
            this.mnuExit.TabIndex = 2;
            this.mnuExit.Text = "menuStrip1";
            // 
            // mniProgram
            // 
            this.mniProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniProgram.Name = "mniProgram";
            this.mniProgram.Size = new System.Drawing.Size(65, 20);
            this.mniProgram.Text = "Program";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(32, 91);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(80, 13);
            this.lblGreeting.TabIndex = 3;
            this.lblGreeting.Text = "The ball will be ";
            this.lblGreeting.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(141, 110);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(47, 13);
            this.lblSeconds.TabIndex = 4;
            this.lblSeconds.Text = "seconds";
            // 
            // radEarthGravity
            // 
            this.radEarthGravity.AutoSize = true;
            this.radEarthGravity.Location = new System.Drawing.Point(6, 19);
            this.radEarthGravity.Name = "radEarthGravity";
            this.radEarthGravity.Size = new System.Drawing.Size(91, 17);
            this.radEarthGravity.TabIndex = 5;
            this.radEarthGravity.TabStop = true;
            this.radEarthGravity.Text = "Earth\'s gravity";
            this.radEarthGravity.UseVisualStyleBackColor = true;
            this.radEarthGravity.CheckedChanged += new System.EventHandler(this.radEarthGravity_CheckedChanged);
            // 
            // radMoonGravity
            // 
            this.radMoonGravity.AutoSize = true;
            this.radMoonGravity.Location = new System.Drawing.Point(6, 63);
            this.radMoonGravity.Name = "radMoonGravity";
            this.radMoonGravity.Size = new System.Drawing.Size(93, 17);
            this.radMoonGravity.TabIndex = 6;
            this.radMoonGravity.TabStop = true;
            this.radMoonGravity.Text = "Moon\'s gravity";
            this.radMoonGravity.UseVisualStyleBackColor = true;
            this.radMoonGravity.CheckedChanged += new System.EventHandler(this.radMoonGravity_CheckedChanged);
            // 
            // radHeight100
            // 
            this.radHeight100.AutoSize = true;
            this.radHeight100.Location = new System.Drawing.Point(15, 19);
            this.radHeight100.Name = "radHeight100";
            this.radHeight100.Size = new System.Drawing.Size(77, 17);
            this.radHeight100.TabIndex = 7;
            this.radHeight100.TabStop = true;
            this.radHeight100.Text = "100 meters";
            this.radHeight100.UseVisualStyleBackColor = true;
            this.radHeight100.CheckedChanged += new System.EventHandler(this.radHeight100_CheckedChanged);
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.Location = new System.Drawing.Point(210, 91);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(85, 13);
            this.lblQuestion2.TabIndex = 8;
            this.lblQuestion2.Text = "meters high after";
            this.lblQuestion2.Click += new System.EventHandler(this.lblQuestion2_Click);
            // 
            // grbHeight
            // 
            this.grbHeight.Controls.Add(this.radHeight200);
            this.grbHeight.Controls.Add(this.radHeight100);
            this.grbHeight.Location = new System.Drawing.Point(26, 154);
            this.grbHeight.Name = "grbHeight";
            this.grbHeight.Size = new System.Drawing.Size(112, 95);
            this.grbHeight.TabIndex = 9;
            this.grbHeight.TabStop = false;
            this.grbHeight.Text = "Height";
            // 
            // radHeight200
            // 
            this.radHeight200.AutoSize = true;
            this.radHeight200.Location = new System.Drawing.Point(15, 63);
            this.radHeight200.Name = "radHeight200";
            this.radHeight200.Size = new System.Drawing.Size(77, 17);
            this.radHeight200.TabIndex = 8;
            this.radHeight200.TabStop = true;
            this.radHeight200.Text = "200 meters";
            this.radHeight200.UseVisualStyleBackColor = true;
            this.radHeight200.CheckedChanged += new System.EventHandler(this.radHeight200_CheckedChanged);
            // 
            // grbGravity
            // 
            this.grbGravity.Controls.Add(this.radMoonGravity);
            this.grbGravity.Controls.Add(this.radEarthGravity);
            this.grbGravity.Location = new System.Drawing.Point(162, 154);
            this.grbGravity.Name = "grbGravity";
            this.grbGravity.Size = new System.Drawing.Size(112, 95);
            this.grbGravity.TabIndex = 10;
            this.grbGravity.TabStop = false;
            this.grbGravity.Text = "Gravity";
            // 
            // picBall
            // 
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(311, 135);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(108, 114);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBall.TabIndex = 11;
            this.picBall.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(199, 110);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 332);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.grbGravity);
            this.Controls.Add(this.grbHeight);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.mnuExit);
            this.MainMenuStrip = this.mnuExit;
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects Zach k";
            this.Load += new System.EventHandler(this.frmFallingObjects_Load);
            this.mnuExit.ResumeLayout(false);
            this.mnuExit.PerformLayout();
            this.grbHeight.ResumeLayout(false);
            this.grbHeight.PerformLayout();
            this.grbGravity.ResumeLayout(false);
            this.grbGravity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.MenuStrip mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.RadioButton radEarthGravity;
        private System.Windows.Forms.RadioButton radMoonGravity;
        private System.Windows.Forms.RadioButton radHeight100;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.GroupBox grbHeight;
        private System.Windows.Forms.GroupBox grbGravity;
        private System.Windows.Forms.RadioButton radHeight200;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Button btnCalculate;
    }
}

