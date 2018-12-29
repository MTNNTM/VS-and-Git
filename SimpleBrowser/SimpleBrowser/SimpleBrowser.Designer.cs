﻿namespace SimpleBrowser
{
    partial class SimpleBrowser
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
            this.tbSiteAddress = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // tbSiteAddress
            // 
            this.tbSiteAddress.Location = new System.Drawing.Point(12, 12);
            this.tbSiteAddress.Name = "tbSiteAddress";
            this.tbSiteAddress.Size = new System.Drawing.Size(902, 38);
            this.tbSiteAddress.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.LightGreen;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnGo.Location = new System.Drawing.Point(944, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(180, 50);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 70);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(180, 50);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(183, 70);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(180, 50);
            this.btnBackward.TabIndex = 7;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(354, 70);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(180, 50);
            this.btnForward.TabIndex = 8;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(525, 70);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(180, 50);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // wb
            // 
            this.wb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wb.Location = new System.Drawing.Point(6, 124);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(1249, 669);
            this.wb.TabIndex = 10;
            // 
            // SimpleBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 805);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbSiteAddress);
            this.Name = "SimpleBrowser";
            this.ShowIcon = false;
            this.Text = "SimpleBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSiteAddress;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.WebBrowser wb;
    }
}