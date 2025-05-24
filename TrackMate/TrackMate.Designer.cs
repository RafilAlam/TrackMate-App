namespace TrackMate
{
    partial class TrackMate
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Maxbtn = new System.Windows.Forms.Button();
            this.Minbtn = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.ToDobtn = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Button();
            this.TabContainer = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.TabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.Maxbtn);
            this.panel2.Controls.Add(this.Minbtn);
            this.panel2.Controls.Add(this.X);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 64);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(139, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 343);
            this.panel4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 50F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(210, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 89);
            this.label4.TabIndex = 5;
            this.label4.Text = "😄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.label5.Location = new System.Drawing.Point(80, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 71);
            this.label5.TabIndex = 4;
            this.label5.Text = "Welcome Back!";
            // 
            // Maxbtn
            // 
            this.Maxbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maxbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.Maxbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Maxbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.Maxbtn.FlatAppearance.BorderSize = 2;
            this.Maxbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maxbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maxbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(100)))), ((int)(((byte)(113)))));
            this.Maxbtn.Location = new System.Drawing.Point(581, 26);
            this.Maxbtn.Name = "Maxbtn";
            this.Maxbtn.Size = new System.Drawing.Size(40, 30);
            this.Maxbtn.TabIndex = 3;
            this.Maxbtn.Text = "⧠";
            this.Maxbtn.UseVisualStyleBackColor = false;
            this.Maxbtn.Click += new System.EventHandler(this.Maxbtn_Click);
            // 
            // Minbtn
            // 
            this.Minbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.Minbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Minbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.Minbtn.FlatAppearance.BorderSize = 2;
            this.Minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minbtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Minbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(100)))), ((int)(((byte)(113)))));
            this.Minbtn.Location = new System.Drawing.Point(535, 26);
            this.Minbtn.Name = "Minbtn";
            this.Minbtn.Size = new System.Drawing.Size(40, 30);
            this.Minbtn.TabIndex = 2;
            this.Minbtn.Text = "=";
            this.Minbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minbtn.UseVisualStyleBackColor = false;
            this.Minbtn.Click += new System.EventHandler(this.Minbtn_Click);
            // 
            // X
            // 
            this.X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.X.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.X.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.X.FlatAppearance.BorderSize = 2;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(100)))), ((int)(((byte)(113)))));
            this.X.Location = new System.Drawing.Point(624, 26);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(40, 30);
            this.X.TabIndex = 1;
            this.X.Text = "✖";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "TrackMate ◮";
            // 
            // TabPanel
            // 
            this.TabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.TabPanel.Controls.Add(this.button4);
            this.TabPanel.Controls.Add(this.ToDobtn);
            this.TabPanel.Controls.Add(this.Counter);
            this.TabPanel.Location = new System.Drawing.Point(0, 65);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.Size = new System.Drawing.Size(139, 340);
            this.TabPanel.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.button4.Location = new System.Drawing.Point(20, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 58);
            this.button4.TabIndex = 2;
            this.button4.Text = "🛠";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ToDobtn
            // 
            this.ToDobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.ToDobtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ToDobtn.FlatAppearance.BorderSize = 0;
            this.ToDobtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.ToDobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.ToDobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDobtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ToDobtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.ToDobtn.Location = new System.Drawing.Point(0, 64);
            this.ToDobtn.Name = "ToDobtn";
            this.ToDobtn.Size = new System.Drawing.Size(139, 58);
            this.ToDobtn.TabIndex = 1;
            this.ToDobtn.Text = "📝 To-Do List";
            this.ToDobtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToDobtn.UseVisualStyleBackColor = false;
            this.ToDobtn.Click += new System.EventHandler(this.ToDobtn_Click);
            // 
            // Counter
            // 
            this.Counter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.Counter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Counter.FlatAppearance.BorderSize = 0;
            this.Counter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.Counter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(40)))), ((int)(((byte)(53)))));
            this.Counter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Counter.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Counter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.Counter.Location = new System.Drawing.Point(0, 0);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(139, 58);
            this.Counter.TabIndex = 0;
            this.Counter.Text = "📠 Counter";
            this.Counter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Counter.UseVisualStyleBackColor = false;
            this.Counter.Click += new System.EventHandler(this.Counter_Click);
            // 
            // TabContainer
            // 
            this.TabContainer.Location = new System.Drawing.Point(139, 62);
            this.TabContainer.Margin = new System.Windows.Forms.Padding(0);
            this.TabContainer.Name = "TabContainer";
            this.TabContainer.Size = new System.Drawing.Size(547, 343);
            this.TabContainer.TabIndex = 4;
            // 
            // TrackMate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(41)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(686, 405);
            this.Controls.Add(this.TabPanel);
            this.Controls.Add(this.TabContainer);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrackMate";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.TabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Maxbtn;
        private System.Windows.Forms.Button Minbtn;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TabPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ToDobtn;
        private System.Windows.Forms.Button Counter;
        private System.Windows.Forms.Panel TabContainer;
    }
}

