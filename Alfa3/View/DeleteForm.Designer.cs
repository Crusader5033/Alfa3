namespace Alfa3.View
{
    partial class DeleteForm
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
            this.Sluzba = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewVojak = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewSluzba = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewUtvar = new System.Windows.Forms.DataGridView();
            this.VojakBtn = new System.Windows.Forms.Button();
            this.sluzbaBtn = new System.Windows.Forms.Button();
            this.utvarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sluzba.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVojak)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSluzba)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtvar)).BeginInit();
            this.SuspendLayout();
            // 
            // Sluzba
            // 
            this.Sluzba.Controls.Add(this.tabPage1);
            this.Sluzba.Controls.Add(this.tabPage2);
            this.Sluzba.Controls.Add(this.tabPage3);
            this.Sluzba.Location = new System.Drawing.Point(3, 12);
            this.Sluzba.Name = "Sluzba";
            this.Sluzba.SelectedIndex = 0;
            this.Sluzba.Size = new System.Drawing.Size(794, 252);
            this.Sluzba.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridViewVojak);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vojak";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVojak
            // 
            this.dataGridViewVojak.AllowUserToAddRows = false;
            this.dataGridViewVojak.AllowUserToDeleteRows = false;
            this.dataGridViewVojak.AllowUserToOrderColumns = true;
            this.dataGridViewVojak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVojak.Location = new System.Drawing.Point(7, 0);
            this.dataGridViewVojak.Name = "dataGridViewVojak";
            this.dataGridViewVojak.ReadOnly = true;
            this.dataGridViewVojak.RowTemplate.Height = 28;
            this.dataGridViewVojak.Size = new System.Drawing.Size(783, 216);
            this.dataGridViewVojak.TabIndex = 0;
            this.dataGridViewVojak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVojak_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridViewSluzba);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sluzba";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSluzba
            // 
            this.dataGridViewSluzba.AllowUserToAddRows = false;
            this.dataGridViewSluzba.AllowUserToDeleteRows = false;
            this.dataGridViewSluzba.AllowUserToOrderColumns = true;
            this.dataGridViewSluzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSluzba.Location = new System.Drawing.Point(6, 0);
            this.dataGridViewSluzba.Name = "dataGridViewSluzba";
            this.dataGridViewSluzba.ReadOnly = true;
            this.dataGridViewSluzba.RowTemplate.Height = 28;
            this.dataGridViewSluzba.Size = new System.Drawing.Size(783, 216);
            this.dataGridViewSluzba.TabIndex = 1;
            this.dataGridViewSluzba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSluzba_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.dataGridViewUtvar);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(786, 219);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Útvar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUtvar
            // 
            this.dataGridViewUtvar.AllowUserToAddRows = false;
            this.dataGridViewUtvar.AllowUserToDeleteRows = false;
            this.dataGridViewUtvar.AllowUserToOrderColumns = true;
            this.dataGridViewUtvar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtvar.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewUtvar.Name = "dataGridViewUtvar";
            this.dataGridViewUtvar.ReadOnly = true;
            this.dataGridViewUtvar.RowTemplate.Height = 28;
            this.dataGridViewUtvar.Size = new System.Drawing.Size(783, 216);
            this.dataGridViewUtvar.TabIndex = 1;
            this.dataGridViewUtvar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUtvar_CellContentClick);
            // 
            // VojakBtn
            // 
            this.VojakBtn.Location = new System.Drawing.Point(12, 311);
            this.VojakBtn.Name = "VojakBtn";
            this.VojakBtn.Size = new System.Drawing.Size(141, 56);
            this.VojakBtn.TabIndex = 0;
            this.VojakBtn.Text = "Odstraň Vojaka";
            this.VojakBtn.UseVisualStyleBackColor = true;
            this.VojakBtn.Click += new System.EventHandler(this.VojakBtn_Click);
            // 
            // sluzbaBtn
            // 
            this.sluzbaBtn.Location = new System.Drawing.Point(272, 311);
            this.sluzbaBtn.Name = "sluzbaBtn";
            this.sluzbaBtn.Size = new System.Drawing.Size(141, 56);
            this.sluzbaBtn.TabIndex = 1;
            this.sluzbaBtn.Text = "Odstraň Sluzbu";
            this.sluzbaBtn.UseVisualStyleBackColor = true;
            this.sluzbaBtn.Click += new System.EventHandler(this.sluzbaBtn_Click);
            // 
            // utvarBtn
            // 
            this.utvarBtn.Location = new System.Drawing.Point(535, 311);
            this.utvarBtn.Name = "utvarBtn";
            this.utvarBtn.Size = new System.Drawing.Size(141, 56);
            this.utvarBtn.TabIndex = 2;
            this.utvarBtn.Text = "Odstraň útvar";
            this.utvarBtn.UseVisualStyleBackColor = true;
            this.utvarBtn.Click += new System.EventHandler(this.utvarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kliknout zde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "->\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "->\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "->\r\n";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.utvarBtn);
            this.Controls.Add(this.sluzbaBtn);
            this.Controls.Add(this.VojakBtn);
            this.Controls.Add(this.Sluzba);
            this.Name = "DeleteForm";
            this.Text = "Smazani";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.Sluzba.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVojak)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSluzba)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Sluzba;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button VojakBtn;
        private System.Windows.Forms.DataGridView dataGridViewVojak;
        private System.Windows.Forms.DataGridView dataGridViewSluzba;
        private System.Windows.Forms.DataGridView dataGridViewUtvar;
        private System.Windows.Forms.Button sluzbaBtn;
        private System.Windows.Forms.Button utvarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}