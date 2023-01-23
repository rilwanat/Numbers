namespace Numbers
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txt_q = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.btn_s = new System.Windows.Forms.Button();
            this.txt_inf = new System.Windows.Forms.TextBox();
            this.btn_gen = new System.Windows.Forms.Button();
            this.txt_command = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_ca = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_q
            // 
            this.txt_q.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_q.Font = new System.Drawing.Font("NewsGoth Cn BT", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_q.Location = new System.Drawing.Point(12, 202);
            this.txt_q.Name = "txt_q";
            this.txt_q.ReadOnly = true;
            this.txt_q.Size = new System.Drawing.Size(560, 112);
            this.txt_q.TabIndex = 0;
            this.txt_q.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_a
            // 
            this.txt_a.Font = new System.Drawing.Font("NewsGoth Cn BT", 69.75F);
            this.txt_a.Location = new System.Drawing.Point(396, 320);
            this.txt_a.MaxLength = 4;
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(176, 119);
            this.txt_a.TabIndex = 1;
            this.txt_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_s
            // 
            this.btn_s.Location = new System.Drawing.Point(464, 12);
            this.btn_s.Name = "btn_s";
            this.btn_s.Size = new System.Drawing.Size(1, 1);
            this.btn_s.TabIndex = 2;
            this.btn_s.UseVisualStyleBackColor = true;
            this.btn_s.Click += new System.EventHandler(this.btn_s_Click);
            // 
            // txt_inf
            // 
            this.txt_inf.BackColor = System.Drawing.SystemColors.Control;
            this.txt_inf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inf.Location = new System.Drawing.Point(212, 131);
            this.txt_inf.Multiline = true;
            this.txt_inf.Name = "txt_inf";
            this.txt_inf.ReadOnly = true;
            this.txt_inf.Size = new System.Drawing.Size(360, 26);
            this.txt_inf.TabIndex = 3;
            this.txt_inf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_gen
            // 
            this.btn_gen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gen.Location = new System.Drawing.Point(464, 65);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(108, 26);
            this.btn_gen.TabIndex = 4;
            this.btn_gen.Text = "Begin";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // txt_command
            // 
            this.txt_command.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_command.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_command.Location = new System.Drawing.Point(212, 163);
            this.txt_command.Multiline = true;
            this.txt_command.Name = "txt_command";
            this.txt_command.ReadOnly = true;
            this.txt_command.Size = new System.Drawing.Size(360, 26);
            this.txt_command.TabIndex = 5;
            this.txt_command.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 526);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(560, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_ca
            // 
            this.txt_ca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ca.Location = new System.Drawing.Point(212, 445);
            this.txt_ca.Multiline = true;
            this.txt_ca.Name = "txt_ca";
            this.txt_ca.ReadOnly = true;
            this.txt_ca.Size = new System.Drawing.Size(360, 75);
            this.txt_ca.TabIndex = 7;
            this.txt_ca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Location = new System.Drawing.Point(12, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(25, 25);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "?";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.White;
            this.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculator.Location = new System.Drawing.Point(43, 12);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(25, 25);
            this.btnCalculator.TabIndex = 14;
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(74, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(105, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(136, 12);
            this.trackBar1.Maximum = 7;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(322, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.txt_ca);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txt_command);
            this.Controls.Add(this.btn_gen);
            this.Controls.Add(this.txt_inf);
            this.Controls.Add(this.btn_s);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.txt_q);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Button btn_s;
        private System.Windows.Forms.TextBox txt_inf;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.TextBox txt_command;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_ca;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}