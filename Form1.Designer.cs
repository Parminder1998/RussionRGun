
namespace RUSSIONRGun
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
            this.buttonPress = new System.Windows.Forms.Button();
            this.buttonSpin = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pictureProcess = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPress
            // 
            this.buttonPress.BackColor = System.Drawing.Color.Transparent;
            this.buttonPress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPress.ForeColor = System.Drawing.Color.Black;
            this.buttonPress.Location = new System.Drawing.Point(518, 345);
            this.buttonPress.Name = "buttonPress";
            this.buttonPress.Size = new System.Drawing.Size(353, 85);
            this.buttonPress.TabIndex = 15;
            this.buttonPress.Text = " Trigger";
            this.buttonPress.UseVisualStyleBackColor = false;
            this.buttonPress.Click += new System.EventHandler(this.buttonPress_Click);
            // 
            // buttonSpin
            // 
            this.buttonSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpin.Location = new System.Drawing.Point(518, 174);
            this.buttonSpin.Name = "buttonSpin";
            this.buttonSpin.Size = new System.Drawing.Size(353, 86);
            this.buttonSpin.TabIndex = 14;
            this.buttonSpin.Text = "Spin Chamber";
            this.buttonSpin.UseVisualStyleBackColor = true;
            this.buttonSpin.Click += new System.EventHandler(this.buttonSpin_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(518, 25);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(353, 89);
            this.buttonLoad.TabIndex = 13;
            this.buttonLoad.Text = "Load Gun";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStart.Location = new System.Drawing.Point(49, 140);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(269, 78);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "Start ";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Tw Cen MT Condensed", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(42, 221);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(282, 41);
            this.lblMsg.TabIndex = 11;
            this.lblMsg.Text = "Click To Start The Game...";
            // 
            // pictureProcess
            // 
            this.pictureProcess.Location = new System.Drawing.Point(361, 149);
            this.pictureProcess.Name = "pictureProcess";
            this.pictureProcess.Size = new System.Drawing.Size(118, 111);
            this.pictureProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProcess.TabIndex = 10;
            this.pictureProcess.TabStop = false;
            this.pictureProcess.Click += new System.EventHandler(this.pictureProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.buttonPress);
            this.Controls.Add(this.buttonSpin);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.pictureProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPress;
        private System.Windows.Forms.Button buttonSpin;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox pictureProcess;
    }
}

