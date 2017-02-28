namespace CP220___A1___MDORFMAN
{
    partial class Form1
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
            this.btnLaser1 = new System.Windows.Forms.Button();
            this.btnTorp1 = new System.Windows.Forms.Button();
            this.btnIon1 = new System.Windows.Forms.Button();
            this.p1HealthBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.p1ShieldBar = new System.Windows.Forms.ProgressBar();
            this.btnReload1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.p2ShieldBar = new System.Windows.Forms.ProgressBar();
            this.btnReload2 = new System.Windows.Forms.Button();
            this.p2HealthBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLaser2 = new System.Windows.Forms.Button();
            this.btnTorp2 = new System.Windows.Forms.Button();
            this.btnIon2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.WarLog = new System.Windows.Forms.ListBox();
            this.btnCheckVar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLaser1
            // 
            this.btnLaser1.Location = new System.Drawing.Point(6, 19);
            this.btnLaser1.Name = "btnLaser1";
            this.btnLaser1.Size = new System.Drawing.Size(83, 23);
            this.btnLaser1.TabIndex = 0;
            this.btnLaser1.Text = "Fire Laser";
            this.btnLaser1.UseVisualStyleBackColor = true;
            this.btnLaser1.Click += new System.EventHandler(this.btnLaser1_Click);
            // 
            // btnTorp1
            // 
            this.btnTorp1.Location = new System.Drawing.Point(6, 48);
            this.btnTorp1.Name = "btnTorp1";
            this.btnTorp1.Size = new System.Drawing.Size(83, 23);
            this.btnTorp1.TabIndex = 1;
            this.btnTorp1.Text = "Fire Torpedo";
            this.btnTorp1.UseVisualStyleBackColor = true;
            this.btnTorp1.Click += new System.EventHandler(this.btnTorp1_Click);
            // 
            // btnIon1
            // 
            this.btnIon1.Location = new System.Drawing.Point(6, 77);
            this.btnIon1.Name = "btnIon1";
            this.btnIon1.Size = new System.Drawing.Size(83, 23);
            this.btnIon1.TabIndex = 2;
            this.btnIon1.Text = "Fire Ion Bomb";
            this.btnIon1.UseVisualStyleBackColor = true;
            this.btnIon1.Click += new System.EventHandler(this.btnIon1_Click);
            // 
            // p1HealthBar
            // 
            this.p1HealthBar.Location = new System.Drawing.Point(122, 106);
            this.p1HealthBar.Name = "p1HealthBar";
            this.p1HealthBar.Size = new System.Drawing.Size(150, 23);
            this.p1HealthBar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Health";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.p1ShieldBar);
            this.groupBox2.Controls.Add(this.btnReload1);
            this.groupBox2.Controls.Add(this.p1HealthBar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnLaser1);
            this.groupBox2.Controls.Add(this.btnTorp1);
            this.groupBox2.Controls.Add(this.btnIon1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 138);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 1 : Cruiser ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Shields";
            // 
            // p1ShieldBar
            // 
            this.p1ShieldBar.Location = new System.Drawing.Point(122, 48);
            this.p1ShieldBar.Name = "p1ShieldBar";
            this.p1ShieldBar.Size = new System.Drawing.Size(150, 23);
            this.p1ShieldBar.TabIndex = 7;
            // 
            // btnReload1
            // 
            this.btnReload1.Location = new System.Drawing.Point(6, 106);
            this.btnReload1.Name = "btnReload1";
            this.btnReload1.Size = new System.Drawing.Size(83, 23);
            this.btnReload1.TabIndex = 3;
            this.btnReload1.Text = "Reload";
            this.btnReload1.UseVisualStyleBackColor = true;
            this.btnReload1.Click += new System.EventHandler(this.btnReload1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.p2ShieldBar);
            this.groupBox1.Controls.Add(this.btnReload2);
            this.groupBox1.Controls.Add(this.p2HealthBar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLaser2);
            this.groupBox1.Controls.Add(this.btnTorp2);
            this.groupBox1.Controls.Add(this.btnIon2);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 2 : Destroyer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Shields";
            // 
            // p2ShieldBar
            // 
            this.p2ShieldBar.Location = new System.Drawing.Point(122, 48);
            this.p2ShieldBar.Name = "p2ShieldBar";
            this.p2ShieldBar.Size = new System.Drawing.Size(150, 23);
            this.p2ShieldBar.TabIndex = 8;
            // 
            // btnReload2
            // 
            this.btnReload2.Location = new System.Drawing.Point(6, 106);
            this.btnReload2.Name = "btnReload2";
            this.btnReload2.Size = new System.Drawing.Size(83, 23);
            this.btnReload2.TabIndex = 3;
            this.btnReload2.Text = "Reload";
            this.btnReload2.UseVisualStyleBackColor = true;
            this.btnReload2.Click += new System.EventHandler(this.btnReload2_Click);
            // 
            // p2HealthBar
            // 
            this.p2HealthBar.Location = new System.Drawing.Point(122, 106);
            this.p2HealthBar.Name = "p2HealthBar";
            this.p2HealthBar.Size = new System.Drawing.Size(150, 23);
            this.p2HealthBar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Health";
            // 
            // btnLaser2
            // 
            this.btnLaser2.Location = new System.Drawing.Point(6, 19);
            this.btnLaser2.Name = "btnLaser2";
            this.btnLaser2.Size = new System.Drawing.Size(83, 23);
            this.btnLaser2.TabIndex = 0;
            this.btnLaser2.Text = "Fire Laser";
            this.btnLaser2.UseVisualStyleBackColor = true;
            this.btnLaser2.Click += new System.EventHandler(this.btnLaser2_Click);
            // 
            // btnTorp2
            // 
            this.btnTorp2.Location = new System.Drawing.Point(6, 48);
            this.btnTorp2.Name = "btnTorp2";
            this.btnTorp2.Size = new System.Drawing.Size(83, 23);
            this.btnTorp2.TabIndex = 1;
            this.btnTorp2.Text = "Fire Torpedo";
            this.btnTorp2.UseVisualStyleBackColor = true;
            this.btnTorp2.Click += new System.EventHandler(this.btnTorp2_Click);
            // 
            // btnIon2
            // 
            this.btnIon2.Location = new System.Drawing.Point(6, 77);
            this.btnIon2.Name = "btnIon2";
            this.btnIon2.Size = new System.Drawing.Size(83, 23);
            this.btnIon2.TabIndex = 2;
            this.btnIon2.Text = "Fire Ion Bomb";
            this.btnIon2.UseVisualStyleBackColor = true;
            this.btnIon2.Click += new System.EventHandler(this.btnIon2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "The War Log";
            // 
            // WarLog
            // 
            this.WarLog.FormattingEnabled = true;
            this.WarLog.Location = new System.Drawing.Point(307, 28);
            this.WarLog.Name = "WarLog";
            this.WarLog.Size = new System.Drawing.Size(407, 264);
            this.WarLog.TabIndex = 10;
            // 
            // btnCheckVar
            // 
            this.btnCheckVar.Location = new System.Drawing.Point(12, 300);
            this.btnCheckVar.Name = "btnCheckVar";
            this.btnCheckVar.Size = new System.Drawing.Size(702, 23);
            this.btnCheckVar.TabIndex = 11;
            this.btnCheckVar.Text = "Check Values";
            this.btnCheckVar.UseVisualStyleBackColor = true;
            this.btnCheckVar.Click += new System.EventHandler(this.btnCheckVar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 330);
            this.Controls.Add(this.btnCheckVar);
            this.Controls.Add(this.WarLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "CP220 - A1 - MDORFMAN";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaser1;
        private System.Windows.Forms.Button btnTorp1;
        private System.Windows.Forms.Button btnIon1;
        private System.Windows.Forms.ProgressBar p1HealthBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReload1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReload2;
        private System.Windows.Forms.ProgressBar p2HealthBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLaser2;
        private System.Windows.Forms.Button btnTorp2;
        private System.Windows.Forms.Button btnIon2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar p1ShieldBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar p2ShieldBar;
        private System.Windows.Forms.Button btnCheckVar;
        public System.Windows.Forms.ListBox WarLog;
    }
}

