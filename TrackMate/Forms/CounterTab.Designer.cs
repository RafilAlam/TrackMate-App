namespace TrackMate.Forms
{
    partial class CounterTab
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
            CounterDeskPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CounterDeskPanel
            // 
            CounterDeskPanel.AutoScroll = true;
            CounterDeskPanel.Location = new System.Drawing.Point(0, -1);
            CounterDeskPanel.Name = "CounterDeskPanel";
            CounterDeskPanel.Padding = new System.Windows.Forms.Padding(10);
            CounterDeskPanel.Size = new System.Drawing.Size(385, 308);
            CounterDeskPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.panel1.Location = new System.Drawing.Point(383, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 308);
            this.panel1.TabIndex = 1;
            // 
            // CounterTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(531, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(CounterDeskPanel);
            this.Name = "CounterTab";
            this.Text = "CounterTab";
            this.Shown += new System.EventHandler(this.CounterTab_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public static System.Windows.Forms.FlowLayoutPanel CounterDeskPanel;
    }
}