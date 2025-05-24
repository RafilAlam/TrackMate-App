using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TrackMate.ToDoTabs
{
    partial class ToDoPageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Label();
            this.ExpandButton = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.CreatedOnLabel = new System.Windows.Forms.Label();
            this.DeadlineLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.CreatedOnDate = new System.Windows.Forms.Label();
            this.DeadlineDate = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.MainPanel.Controls.Add(this.DeleteButton);
            this.MainPanel.Controls.Add(this.ExpandButton);
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(366, 57);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.ParentChanged += new System.EventHandler(this.MainPanel_ParentChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.DeleteButton.Location = new System.Drawing.Point(330, 16);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(34, 25);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "✖️";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExpandButton
            // 
            this.ExpandButton.AutoSize = true;
            this.ExpandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpandButton.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.ExpandButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.ExpandButton.Location = new System.Drawing.Point(3, 16);
            this.ExpandButton.Name = "ExpandButton";
            this.ExpandButton.Size = new System.Drawing.Size(24, 20);
            this.ExpandButton.TabIndex = 1;
            this.ExpandButton.Text = "▼";
            this.ExpandButton.Click += new System.EventHandler(this.ExpandButton_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.Title.Location = new System.Drawing.Point(31, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(292, 28);
            this.Title.TabIndex = 0;
            this.Title.Text = "PlaceHolder";
            // 
            // CreatedOnLabel
            // 
            this.CreatedOnLabel.AutoSize = true;
            this.CreatedOnLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreatedOnLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedOnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.CreatedOnLabel.Location = new System.Drawing.Point(17, 70);
            this.CreatedOnLabel.Name = "CreatedOnLabel";
            this.CreatedOnLabel.Size = new System.Drawing.Size(88, 20);
            this.CreatedOnLabel.TabIndex = 3;
            this.CreatedOnLabel.Text = "Created on:";
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.AutoSize = true;
            this.DeadlineLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeadlineLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.DeadlineLabel.Location = new System.Drawing.Point(17, 100);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(74, 20);
            this.DeadlineLabel.TabIndex = 4;
            this.DeadlineLabel.Text = "Deadline:";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.DescriptionBox.Location = new System.Drawing.Point(21, 137);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(329, 98);
            this.DescriptionBox.TabIndex = 5;
            this.DescriptionBox.Text = "PlaceHolder Description Box";
            // 
            // CreatedOnDate
            // 
            this.CreatedOnDate.AutoSize = true;
            this.CreatedOnDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreatedOnDate.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedOnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.CreatedOnDate.Location = new System.Drawing.Point(111, 70);
            this.CreatedOnDate.Name = "CreatedOnDate";
            this.CreatedOnDate.Size = new System.Drawing.Size(82, 20);
            this.CreatedOnDate.TabIndex = 6;
            this.CreatedOnDate.Text = "Date, Time";
            // 
            // DeadlineDate
            // 
            this.DeadlineDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.DeadlineDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeadlineDate.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.DeadlineDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.DeadlineDate.Location = new System.Drawing.Point(115, 99);
            this.DeadlineDate.Name = "DeadlineDate";
            this.DeadlineDate.Size = new System.Drawing.Size(100, 20);
            this.DeadlineDate.TabIndex = 7;
            this.DeadlineDate.Text = "Date, Time";
            // 
            // ToDoPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.DeadlineDate);
            this.Controls.Add(this.CreatedOnDate);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.DeadlineLabel);
            this.Controls.Add(this.CreatedOnLabel);
            this.Controls.Add(this.MainPanel);
            this.Name = "ToDoPageControl";
            this.Size = new System.Drawing.Size(366, 248);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label ExpandButton;
        private System.Windows.Forms.Label DeleteButton;
        private System.Windows.Forms.Label CreatedOnLabel;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.Label CreatedOnDate;
        private System.Windows.Forms.TextBox DeadlineDate;
    }
}
