namespace TrackMate.CounterPages
{
    partial class CounterRow
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
            this.EqualLbl = new System.Windows.Forms.Label();
            this.ValueNameTxt = new System.Windows.Forms.TextBox();
            this.ValueTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EqualLbl
            // 
            this.EqualLbl.AutoSize = true;
            this.EqualLbl.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.EqualLbl.Location = new System.Drawing.Point(75, 5);
            this.EqualLbl.Name = "EqualLbl";
            this.EqualLbl.Size = new System.Drawing.Size(17, 17);
            this.EqualLbl.TabIndex = 1;
            this.EqualLbl.Text = "=";
            // 
            // ValueNameTxt
            // 
            this.ValueNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.ValueNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ValueNameTxt.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.ValueNameTxt.Location = new System.Drawing.Point(18, 5);
            this.ValueNameTxt.Name = "ValueNameTxt";
            this.ValueNameTxt.Size = new System.Drawing.Size(51, 18);
            this.ValueNameTxt.TabIndex = 2;
            this.ValueNameTxt.Text = "Value";
            this.ValueNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValueNameTxt.TextChanged += new System.EventHandler(this.ValueNameTxt_TextChanged);
            // 
            // ValueTxt
            // 
            this.ValueTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.ValueTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ValueTxt.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.ValueTxt.Location = new System.Drawing.Point(98, 5);
            this.ValueTxt.Name = "ValueTxt";
            this.ValueTxt.Size = new System.Drawing.Size(51, 18);
            this.ValueTxt.TabIndex = 3;
            this.ValueTxt.Text = "Value";
            this.ValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValueTxt.TextChanged += new System.EventHandler(this.ValueTxt_TextChanged);
            // 
            // CounterRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.ValueTxt);
            this.Controls.Add(this.ValueNameTxt);
            this.Controls.Add(this.EqualLbl);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CounterRow";
            this.Size = new System.Drawing.Size(168, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EqualLbl;
        private System.Windows.Forms.TextBox ValueNameTxt;
        private System.Windows.Forms.TextBox ValueTxt;
    }
}
