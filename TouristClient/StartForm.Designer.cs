﻿namespace TouristClient
{
    partial class StartForm
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
            this.button_sight = new System.Windows.Forms.Button();
            this.button_tour_type = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_sight
            // 
            this.button_sight.Location = new System.Drawing.Point(12, 12);
            this.button_sight.Name = "button_sight";
            this.button_sight.Size = new System.Drawing.Size(155, 37);
            this.button_sight.TabIndex = 0;
            this.button_sight.Text = "Достопримечательности";
            this.button_sight.UseVisualStyleBackColor = true;
            this.button_sight.Click += new System.EventHandler(this.button_sight_Click);
            // 
            // button_tour_type
            // 
            this.button_tour_type.Location = new System.Drawing.Point(265, 12);
            this.button_tour_type.Name = "button_tour_type";
            this.button_tour_type.Size = new System.Drawing.Size(110, 37);
            this.button_tour_type.TabIndex = 1;
            this.button_tour_type.Text = "Типы туров";
            this.button_tour_type.UseVisualStyleBackColor = true;
            this.button_tour_type.Click += new System.EventHandler(this.button_tour_type_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.Controls.Add(this.button_tour_type);
            this.Controls.Add(this.button_sight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_sight;
        private System.Windows.Forms.Button button_tour_type;
    }
}