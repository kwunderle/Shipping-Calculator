
namespace ShippingCalculator_Katharine_Wunderle
{
    partial class shipCalc
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
            this.entrInfoLbl = new System.Windows.Forms.Label();
            this.pkgWgtLbl = new System.Windows.Forms.Label();
            this.zipCdLbl = new System.Windows.Forms.Label();
            this.pkgWgtIpt = new System.Windows.Forms.TextBox();
            this.zipCdIpt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.wgtCstLbl = new System.Windows.Forms.Label();
            this.znCstLbl = new System.Windows.Forms.Label();
            this.ttlCstLbl = new System.Windows.Forms.Label();
            this.wgtCstOtpt = new System.Windows.Forms.Label();
            this.znCstOtpt = new System.Windows.Forms.Label();
            this.ttlCstOtpt = new System.Windows.Forms.Label();
            this.cpdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entrInfoLbl
            // 
            this.entrInfoLbl.AutoSize = true;
            this.entrInfoLbl.Location = new System.Drawing.Point(53, 21);
            this.entrInfoLbl.Name = "entrInfoLbl";
            this.entrInfoLbl.Size = new System.Drawing.Size(134, 13);
            this.entrInfoLbl.TabIndex = 0;
            this.entrInfoLbl.Text = "Enter Shipping Information:";
            // 
            // pkgWgtLbl
            // 
            this.pkgWgtLbl.AutoSize = true;
            this.pkgWgtLbl.Location = new System.Drawing.Point(29, 51);
            this.pkgWgtLbl.Name = "pkgWgtLbl";
            this.pkgWgtLbl.Size = new System.Drawing.Size(90, 13);
            this.pkgWgtLbl.TabIndex = 1;
            this.pkgWgtLbl.Text = "Package Weight:";
            this.pkgWgtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zipCdLbl
            // 
            this.zipCdLbl.AutoSize = true;
            this.zipCdLbl.Location = new System.Drawing.Point(12, 78);
            this.zipCdLbl.Name = "zipCdLbl";
            this.zipCdLbl.Size = new System.Drawing.Size(107, 26);
            this.zipCdLbl.TabIndex = 2;
            this.zipCdLbl.Text = "Shipping Zone Code:\r\nN, S, E, or W      ";
            this.zipCdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pkgWgtIpt
            // 
            this.pkgWgtIpt.Location = new System.Drawing.Point(125, 48);
            this.pkgWgtIpt.Name = "pkgWgtIpt";
            this.pkgWgtIpt.Size = new System.Drawing.Size(62, 20);
            this.pkgWgtIpt.TabIndex = 3;
            // 
            // zipCdIpt
            // 
            this.zipCdIpt.Location = new System.Drawing.Point(125, 75);
            this.zipCdIpt.Name = "zipCdIpt";
            this.zipCdIpt.Size = new System.Drawing.Size(62, 20);
            this.zipCdIpt.TabIndex = 4;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(85, 117);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 5;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // wgtCstLbl
            // 
            this.wgtCstLbl.AutoSize = true;
            this.wgtCstLbl.Location = new System.Drawing.Point(280, 51);
            this.wgtCstLbl.Name = "wgtCstLbl";
            this.wgtCstLbl.Size = new System.Drawing.Size(68, 13);
            this.wgtCstLbl.TabIndex = 6;
            this.wgtCstLbl.Text = "Weight Cost:";
            this.wgtCstLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // znCstLbl
            // 
            this.znCstLbl.AutoSize = true;
            this.znCstLbl.Location = new System.Drawing.Point(245, 82);
            this.znCstLbl.Name = "znCstLbl";
            this.znCstLbl.Size = new System.Drawing.Size(103, 13);
            this.znCstLbl.TabIndex = 7;
            this.znCstLbl.Text = "Shipping Zone Cost:";
            this.znCstLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ttlCstLbl
            // 
            this.ttlCstLbl.AutoSize = true;
            this.ttlCstLbl.Location = new System.Drawing.Point(290, 113);
            this.ttlCstLbl.Name = "ttlCstLbl";
            this.ttlCstLbl.Size = new System.Drawing.Size(58, 13);
            this.ttlCstLbl.TabIndex = 8;
            this.ttlCstLbl.Text = "Total Cost:";
            this.ttlCstLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wgtCstOtpt
            // 
            this.wgtCstOtpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wgtCstOtpt.Location = new System.Drawing.Point(354, 46);
            this.wgtCstOtpt.Name = "wgtCstOtpt";
            this.wgtCstOtpt.Size = new System.Drawing.Size(65, 23);
            this.wgtCstOtpt.TabIndex = 9;
            this.wgtCstOtpt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // znCstOtpt
            // 
            this.znCstOtpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.znCstOtpt.Location = new System.Drawing.Point(354, 77);
            this.znCstOtpt.Name = "znCstOtpt";
            this.znCstOtpt.Size = new System.Drawing.Size(65, 23);
            this.znCstOtpt.TabIndex = 10;
            this.znCstOtpt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ttlCstOtpt
            // 
            this.ttlCstOtpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttlCstOtpt.Location = new System.Drawing.Point(354, 108);
            this.ttlCstOtpt.Name = "ttlCstOtpt";
            this.ttlCstOtpt.Size = new System.Drawing.Size(65, 23);
            this.ttlCstOtpt.TabIndex = 11;
            this.ttlCstOtpt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpdLbl
            // 
            this.cpdLbl.AutoSize = true;
            this.cpdLbl.Location = new System.Drawing.Point(242, 113);
            this.cpdLbl.Name = "cpdLbl";
            this.cpdLbl.Size = new System.Drawing.Size(0, 13);
            this.cpdLbl.TabIndex = 12;
            // 
            // shipCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 177);
            this.Controls.Add(this.cpdLbl);
            this.Controls.Add(this.ttlCstOtpt);
            this.Controls.Add(this.znCstOtpt);
            this.Controls.Add(this.wgtCstOtpt);
            this.Controls.Add(this.ttlCstLbl);
            this.Controls.Add(this.znCstLbl);
            this.Controls.Add(this.wgtCstLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.zipCdIpt);
            this.Controls.Add(this.pkgWgtIpt);
            this.Controls.Add(this.zipCdLbl);
            this.Controls.Add(this.pkgWgtLbl);
            this.Controls.Add(this.entrInfoLbl);
            this.Name = "shipCalc";
            this.Text = "Shipping Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label entrInfoLbl;
        private System.Windows.Forms.Label pkgWgtLbl;
        private System.Windows.Forms.Label zipCdLbl;
        private System.Windows.Forms.TextBox pkgWgtIpt;
        private System.Windows.Forms.TextBox zipCdIpt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label wgtCstLbl;
        private System.Windows.Forms.Label znCstLbl;
        private System.Windows.Forms.Label ttlCstLbl;
        private System.Windows.Forms.Label wgtCstOtpt;
        private System.Windows.Forms.Label znCstOtpt;
        private System.Windows.Forms.Label ttlCstOtpt;
        private System.Windows.Forms.Label cpdLbl;
    }
}

