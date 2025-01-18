
namespace WindowsFormsApp2
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
            this.btnplay = new System.Windows.Forms.Button();
            this.btninstruction = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnhighestscore = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlaysound = new System.Windows.Forms.Button();
            this.btnmute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnplay
            // 
            this.btnplay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnplay.Location = new System.Drawing.Point(429, 366);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 34);
            this.btnplay.TabIndex = 2;
            this.btnplay.Text = "PLAY";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btninstruction
            // 
            this.btninstruction.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninstruction.Location = new System.Drawing.Point(378, 427);
            this.btninstruction.Name = "btninstruction";
            this.btninstruction.Size = new System.Drawing.Size(176, 28);
            this.btninstruction.TabIndex = 3;
            this.btninstruction.Text = "INSTRUCTION";
            this.btninstruction.UseVisualStyleBackColor = true;
            this.btninstruction.Click += new System.EventHandler(this.btninstruction_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(429, 521);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnhighestscore
            // 
            this.btnhighestscore.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhighestscore.Location = new System.Drawing.Point(378, 477);
            this.btnhighestscore.Name = "btnhighestscore";
            this.btnhighestscore.Size = new System.Drawing.Size(176, 28);
            this.btnhighestscore.TabIndex = 5;
            this.btnhighestscore.Text = "SCORE";
            this.btnhighestscore.UseVisualStyleBackColor = true;
            this.btnhighestscore.Click += new System.EventHandler(this.btnhighestscore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 667);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlaysound
            // 
            this.btnPlaysound.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaysound.Image")));
            this.btnPlaysound.Location = new System.Drawing.Point(495, 12);
            this.btnPlaysound.Name = "btnPlaysound";
            this.btnPlaysound.Size = new System.Drawing.Size(77, 79);
            this.btnPlaysound.TabIndex = 6;
            this.btnPlaysound.UseVisualStyleBackColor = true;
            this.btnPlaysound.Click += new System.EventHandler(this.btnPlaysound_Click);
            // 
            // btnmute
            // 
            this.btnmute.Image = ((System.Drawing.Image)(resources.GetObject("btnmute.Image")));
            this.btnmute.Location = new System.Drawing.Point(495, 12);
            this.btnmute.Name = "btnmute";
            this.btnmute.Size = new System.Drawing.Size(77, 79);
            this.btnmute.TabIndex = 7;
            this.btnmute.UseVisualStyleBackColor = true;
            this.btnmute.Click += new System.EventHandler(this.btnmute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.btnmute);
            this.Controls.Add(this.btnPlaysound);
            this.Controls.Add(this.btnhighestscore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btninstruction);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Car Racing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btninstruction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnhighestscore;
        private System.Windows.Forms.Button btnSoundplay;
        private System.Windows.Forms.Button btnSoundmute;
        private System.Windows.Forms.Button btnPlaysound;
        private System.Windows.Forms.Button btnmute;
    }
}

