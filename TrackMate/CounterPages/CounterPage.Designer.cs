namespace TrackMate.CounterPages
{
    partial class CounterPage
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
            this.PageTitle = new System.Windows.Forms.TextBox();
            this.AddRowBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EqualLbl
            // 
            this.EqualLbl.AutoSize = true;
            this.EqualLbl.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.EqualLbl.Location = new System.Drawing.Point(75, 70);
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
            this.ValueNameTxt.Location = new System.Drawing.Point(18, 70);
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
            this.ValueTxt.Location = new System.Drawing.Point(98, 70);
            this.ValueTxt.Name = "ValueTxt";
            this.ValueTxt.Size = new System.Drawing.Size(51, 18);
            this.ValueTxt.TabIndex = 3;
            this.ValueTxt.Text = "Value";
            this.ValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValueTxt.TextChanged += new System.EventHandler(this.ValueTxt_TextChanged);
            // 
            // PageTitle
            // 
            this.PageTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.PageTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PageTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.PageTitle.Location = new System.Drawing.Point(28, 14);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(111, 22);
            this.PageTitle.TabIndex = 0;
            this.PageTitle.Text = "Money Saved";
            this.PageTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PageTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.AddRowBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddRowBtn.FlatAppearance.BorderSize = 0;
            this.AddRowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.AddRowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.AddRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRowBtn.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddRowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.AddRowBtn.Location = new System.Drawing.Point(58, 94);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(51, 24);
            this.AddRowBtn.TabIndex = 4;
            this.AddRowBtn.Text = "+";
            this.AddRowBtn.UseVisualStyleBackColor = false;
            this.AddRowBtn.Click += new System.EventHandler(this.AddPg_Click);
            // 
            // CounterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.AddRowBtn);
            this.Controls.Add(this.ValueTxt);
            this.Controls.Add(this.ValueNameTxt);
            this.Controls.Add(this.EqualLbl);
            this.Controls.Add(this.PageTitle);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CounterPage";
            this.Size = new System.Drawing.Size(168, 133);
            this.Tag = "None";
            this.Click += new System.EventHandler(this.CounterPage_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EqualLbl;
        private System.Windows.Forms.TextBox ValueNameTxt;
        private System.Windows.Forms.TextBox ValueTxt;
        private System.Windows.Forms.TextBox PageTitle;
        private System.Windows.Forms.Button AddRowBtn;
    }
}
