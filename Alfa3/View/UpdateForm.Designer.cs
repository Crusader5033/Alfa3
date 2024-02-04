namespace Alfa3.View
{
    partial class UpdateForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SluzbaBtn = new System.Windows.Forms.Button();
            this.utvarBtn = new System.Windows.Forms.Button();
            this.newPlaceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.utvarView = new System.Windows.Forms.DataGridView();
            this.sluzbaView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.newroleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utvarView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluzbaView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.newroleBox);
            this.tabPage1.Controls.Add(this.sluzbaView);
            this.tabPage1.Controls.Add(this.SluzbaBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sluzba";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.utvarView);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.newPlaceBox);
            this.tabPage2.Controls.Add(this.utvarBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Utvar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SluzbaBtn
            // 
            this.SluzbaBtn.Location = new System.Drawing.Point(321, 300);
            this.SluzbaBtn.Name = "SluzbaBtn";
            this.SluzbaBtn.Size = new System.Drawing.Size(152, 71);
            this.SluzbaBtn.TabIndex = 0;
            this.SluzbaBtn.Text = "Upravit";
            this.SluzbaBtn.UseVisualStyleBackColor = true;
            this.SluzbaBtn.Click += new System.EventHandler(this.SluzbaBtn_Click);
            // 
            // utvarBtn
            // 
            this.utvarBtn.Location = new System.Drawing.Point(285, 327);
            this.utvarBtn.Name = "utvarBtn";
            this.utvarBtn.Size = new System.Drawing.Size(169, 71);
            this.utvarBtn.TabIndex = 1;
            this.utvarBtn.Text = "Upravit";
            this.utvarBtn.UseVisualStyleBackColor = true;
            this.utvarBtn.Click += new System.EventHandler(this.utvarBtn_Click);
            // 
            // newPlaceBox
            // 
            this.newPlaceBox.Location = new System.Drawing.Point(22, 349);
            this.newPlaceBox.Name = "newPlaceBox";
            this.newPlaceBox.Size = new System.Drawing.Size(169, 26);
            this.newPlaceBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nové působiště:";
            // 
            // utvarView
            // 
            this.utvarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utvarView.Location = new System.Drawing.Point(0, 0);
            this.utvarView.Name = "utvarView";
            this.utvarView.RowTemplate.Height = 28;
            this.utvarView.Size = new System.Drawing.Size(788, 210);
            this.utvarView.TabIndex = 4;
            // 
            // sluzbaView
            // 
            this.sluzbaView.AllowUserToAddRows = false;
            this.sluzbaView.AllowUserToDeleteRows = false;
            this.sluzbaView.AllowUserToOrderColumns = true;
            this.sluzbaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sluzbaView.Location = new System.Drawing.Point(0, 3);
            this.sluzbaView.Name = "sluzbaView";
            this.sluzbaView.ReadOnly = true;
            this.sluzbaView.RowTemplate.Height = 28;
            this.sluzbaView.Size = new System.Drawing.Size(788, 210);
            this.sluzbaView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "WORK IN PROGRESS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // newroleBox
            // 
            this.newroleBox.Location = new System.Drawing.Point(20, 322);
            this.newroleBox.Name = "newroleBox";
            this.newroleBox.Size = new System.Drawing.Size(169, 26);
            this.newroleBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "WORK IN PROGRESS";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "UpdateForm";
            this.Text = "Úprava dat";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utvarView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluzbaView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button SluzbaBtn;
        private System.Windows.Forms.Button utvarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPlaceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newroleBox;
        private System.Windows.Forms.DataGridView sluzbaView;
        private System.Windows.Forms.DataGridView utvarView;
        private System.Windows.Forms.Label label3;
    }
}