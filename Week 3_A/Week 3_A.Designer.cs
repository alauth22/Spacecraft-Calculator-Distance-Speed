
namespace Week_3_A
{
    partial class frmExploreTheGalaxy
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
            this.lblDays = new System.Windows.Forms.Label();
            this.txtActualDays = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblActualSpeed = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblActualDistance = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(141, 45);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(114, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Enter Number of Days:";
            // 
            // txtActualDays
            // 
            this.txtActualDays.Location = new System.Drawing.Point(267, 45);
            this.txtActualDays.Name = "txtActualDays";
            this.txtActualDays.Size = new System.Drawing.Size(100, 20);
            this.txtActualDays.TabIndex = 1;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(33, 81);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(222, 13);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Spacecraft Speed (MPD) by End of Last Day:";
            // 
            // lblActualSpeed
            // 
            this.lblActualSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActualSpeed.Location = new System.Drawing.Point(267, 80);
            this.lblActualSpeed.Name = "lblActualSpeed";
            this.lblActualSpeed.Size = new System.Drawing.Size(100, 23);
            this.lblActualSpeed.TabIndex = 3;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(38, 119);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(217, 13);
            this.lblDistance.TabIndex = 4;
            this.lblDistance.Text = "Total Distance Traveled by End of Last Day:";
            // 
            // lblActualDistance
            // 
            this.lblActualDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActualDistance.Location = new System.Drawing.Point(267, 119);
            this.lblActualDistance.Name = "lblActualDistance";
            this.lblActualDistance.Size = new System.Drawing.Size(100, 23);
            this.lblActualDistance.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(52, 181);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 34);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(178, 181);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(306, 181);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmExploreTheGalaxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 249);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblActualDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblActualSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.txtActualDays);
            this.Controls.Add(this.lblDays);
            this.Name = "frmExploreTheGalaxy";
            this.Text = "Explore The Galaxy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtActualDays;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblActualSpeed;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblActualDistance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
    }
}

