using System.Windows.Forms;

namespace Hydrate
{
    partial class ReminderWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderWindow));
            this.lblHydrateMeText = new System.Windows.Forms.Label();
            this.btnIDrankWater = new System.Windows.Forms.Button();
            this.btnIAmBusy = new System.Windows.Forms.Button();
            this.pictureBoxHydrateMe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHydrateMe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHydrateMeText
            // 
            resources.ApplyResources(this.lblHydrateMeText, "lblHydrateMeText");
            this.lblHydrateMeText.Name = "lblHydrateMeText";
            // 
            // btnIDrankWater
            // 
            resources.ApplyResources(this.btnIDrankWater, "btnIDrankWater");
            this.btnIDrankWater.Name = "btnIDrankWater";
            this.btnIDrankWater.UseVisualStyleBackColor = true;
            this.btnIDrankWater.Click += new System.EventHandler(this.btnIDrankWater_Click);
            // 
            // btnIAmBusy
            // 
            resources.ApplyResources(this.btnIAmBusy, "btnIAmBusy");
            this.btnIAmBusy.Name = "btnIAmBusy";
            this.btnIAmBusy.UseVisualStyleBackColor = true;
            this.btnIAmBusy.Click += new System.EventHandler(this.btnIAmBusy_Click);
            // 
            // pictureBoxHydrateMe
            // 
            this.pictureBoxHydrateMe.Image = global::Hydrate.Properties.Resources.giphy;
            resources.ApplyResources(this.pictureBoxHydrateMe, "pictureBoxHydrateMe");
            this.pictureBoxHydrateMe.Name = "pictureBoxHydrateMe";
            this.pictureBoxHydrateMe.TabStop = false;
            // 
            // ReminderWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.pictureBoxHydrateMe);
            this.Controls.Add(this.btnIAmBusy);
            this.Controls.Add(this.btnIDrankWater);
            this.Controls.Add(this.lblHydrateMeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReminderWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHydrateMe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHydrateMeText;
        private System.Windows.Forms.Button btnIDrankWater;
        private System.Windows.Forms.Button btnIAmBusy;
        private PictureBox pictureBoxHydrateMe;
    }
}