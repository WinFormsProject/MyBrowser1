﻿
namespace MyBrowser1
{
    partial class SitesEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SitesEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.categSelector = new System.Windows.Forms.ComboBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.siteName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.urlBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category name";
            // 
            // categSelector
            // 
            this.categSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categSelector.FormattingEnabled = true;
            this.categSelector.Location = new System.Drawing.Point(48, 79);
            this.categSelector.Name = "categSelector";
            this.categSelector.Size = new System.Drawing.Size(487, 26);
            this.categSelector.Sorted = true;
            this.categSelector.TabIndex = 1;
            //this.categSelector.SelectedIndexChanged += new System.EventHandler(this.categSelector_SelectedIndexChanged);
            // 
            // actionButton
            // 
            this.actionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionButton.Location = new System.Drawing.Point(136, 376);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(334, 63);
            this.actionButton.TabIndex = 2;
            this.actionButton.Text = "Action";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.action_Click);
            // 
            // siteName
            // 
            this.siteName.Location = new System.Drawing.Point(48, 189);
            this.siteName.Name = "siteName";
            this.siteName.Size = new System.Drawing.Size(487, 24);
            this.siteName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Site name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Url Address";
            // 
            // urlBox1
            // 
            this.urlBox1.Location = new System.Drawing.Point(48, 307);
            this.urlBox1.Name = "urlBox1";
            this.urlBox1.Size = new System.Drawing.Size(487, 24);
            this.urlBox1.TabIndex = 6;
            // 
            // SitesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 452);
            this.Controls.Add(this.urlBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siteName);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.categSelector);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SitesEditor";
            this.Text = "SitesEditor";
            this.Load += new System.EventHandler(this.SitesEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categSelector;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.TextBox siteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urlBox1;
    }
}