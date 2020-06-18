namespace FCFS_ex
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJlhproses = new System.Windows.Forms.TextBox();
            this.LV = new System.Windows.Forms.ListView();
            this.btnfcfs = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtrata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(282, 33);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Processes";
            // 
            // txtJlhproses
            // 
            this.txtJlhproses.Location = new System.Drawing.Point(212, 35);
            this.txtJlhproses.Name = "txtJlhproses";
            this.txtJlhproses.Size = new System.Drawing.Size(64, 20);
            this.txtJlhproses.TabIndex = 2;
            // 
            // LV
            // 
            this.LV.Location = new System.Drawing.Point(12, 66);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(533, 204);
            this.LV.TabIndex = 3;
            this.LV.UseCompatibleStateImageBehavior = false;
            // 
            // btnfcfs
            // 
            this.btnfcfs.Location = new System.Drawing.Point(373, 33);
            this.btnfcfs.Name = "btnfcfs";
            this.btnfcfs.Size = new System.Drawing.Size(75, 23);
            this.btnfcfs.TabIndex = 4;
            this.btnfcfs.Text = "FCFS";
            this.btnfcfs.UseVisualStyleBackColor = true;
            this.btnfcfs.Click += new System.EventHandler(this.btnfcfs_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(470, 276);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 5;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total TA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ratio TA";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(445, 315);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 8;
            // 
            // txtrata
            // 
            this.txtrata.Location = new System.Drawing.Point(85, 315);
            this.txtrata.Name = "txtrata";
            this.txtrata.Size = new System.Drawing.Size(100, 20);
            this.txtrata.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 340);
            this.Controls.Add(this.txtrata);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnfcfs);
            this.Controls.Add(this.LV);
            this.Controls.Add(this.txtJlhproses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJlhproses;
        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.Button btnfcfs;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtrata;
    }
}

