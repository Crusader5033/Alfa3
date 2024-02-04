namespace Alfa3.View
{
    partial class SelectForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectVojaci = new System.Windows.Forms.Button();
            this.SluzbyBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.UtvaryBtn = new System.Windows.Forms.Button();
            this.VojaciSpecializaceBtn = new System.Windows.Forms.Button();
            this.SpecializaceBtn = new System.Windows.Forms.Button();
            this.ZkouskaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(984, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SelectVojaci
            // 
            this.SelectVojaci.Location = new System.Drawing.Point(12, 322);
            this.SelectVojaci.Name = "SelectVojaci";
            this.SelectVojaci.Size = new System.Drawing.Size(132, 41);
            this.SelectVojaci.TabIndex = 1;
            this.SelectVojaci.Text = "Vojáci";
            this.SelectVojaci.UseVisualStyleBackColor = true;
            this.SelectVojaci.Click += new System.EventHandler(this.SelectVojaci_Click);
            // 
            // SluzbyBtn
            // 
            this.SluzbyBtn.Location = new System.Drawing.Point(366, 389);
            this.SluzbyBtn.Name = "SluzbyBtn";
            this.SluzbyBtn.Size = new System.Drawing.Size(132, 41);
            this.SluzbyBtn.TabIndex = 2;
            this.SluzbyBtn.Text = "Vypis Sluzeb";
            this.SluzbyBtn.UseVisualStyleBackColor = true;
            this.SluzbyBtn.Click += new System.EventHandler(this.SluzbyBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Role";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UtvaryBtn
            // 
            this.UtvaryBtn.Location = new System.Drawing.Point(181, 322);
            this.UtvaryBtn.Name = "UtvaryBtn";
            this.UtvaryBtn.Size = new System.Drawing.Size(132, 41);
            this.UtvaryBtn.TabIndex = 4;
            this.UtvaryBtn.Text = "Útvary";
            this.UtvaryBtn.UseVisualStyleBackColor = true;
            this.UtvaryBtn.Click += new System.EventHandler(this.UtvaryBtn_Click);
            // 
            // VojaciSpecializaceBtn
            // 
            this.VojaciSpecializaceBtn.Location = new System.Drawing.Point(807, 348);
            this.VojaciSpecializaceBtn.Name = "VojaciSpecializaceBtn";
            this.VojaciSpecializaceBtn.Size = new System.Drawing.Size(189, 68);
            this.VojaciSpecializaceBtn.TabIndex = 5;
            this.VojaciSpecializaceBtn.Text = "Vojaci a jejich specializace";
            this.VojaciSpecializaceBtn.UseVisualStyleBackColor = true;
            this.VojaciSpecializaceBtn.Click += new System.EventHandler(this.VojaciSpecializaceBtn_Click);
            // 
            // SpecializaceBtn
            // 
            this.SpecializaceBtn.Location = new System.Drawing.Point(181, 389);
            this.SpecializaceBtn.Name = "SpecializaceBtn";
            this.SpecializaceBtn.Size = new System.Drawing.Size(132, 41);
            this.SpecializaceBtn.TabIndex = 6;
            this.SpecializaceBtn.Text = "Specializace";
            this.SpecializaceBtn.UseVisualStyleBackColor = true;
            this.SpecializaceBtn.Click += new System.EventHandler(this.SpecializaceBtn_Click);
            // 
            // ZkouskaBtn
            // 
            this.ZkouskaBtn.Location = new System.Drawing.Point(366, 322);
            this.ZkouskaBtn.Name = "ZkouskaBtn";
            this.ZkouskaBtn.Size = new System.Drawing.Size(132, 41);
            this.ZkouskaBtn.TabIndex = 7;
            this.ZkouskaBtn.Text = "Zkousky";
            this.ZkouskaBtn.UseVisualStyleBackColor = true;
            this.ZkouskaBtn.Click += new System.EventHandler(this.ZkouskaBtn_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.ZkouskaBtn);
            this.Controls.Add(this.SpecializaceBtn);
            this.Controls.Add(this.VojaciSpecializaceBtn);
            this.Controls.Add(this.UtvaryBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SluzbyBtn);
            this.Controls.Add(this.SelectVojaci);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SelectForm";
            this.Text = "Výpis dat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SelectVojaci;
        private System.Windows.Forms.Button SluzbyBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button UtvaryBtn;
        private System.Windows.Forms.Button VojaciSpecializaceBtn;
        private System.Windows.Forms.Button SpecializaceBtn;
        private System.Windows.Forms.Button ZkouskaBtn;
    }
}