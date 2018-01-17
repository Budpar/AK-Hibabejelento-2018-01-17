namespace AK_Hibabejelento_14S
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
            this.butOK = new System.Windows.Forms.Button();
            this.hibabejelento_nevLB = new System.Windows.Forms.Label();
            this.hibabejelento_datumLB = new System.Windows.Forms.Label();
            this.hibabejelento_leirasLB = new System.Windows.Forms.Label();
            this.hibabejelento_nevTB = new System.Windows.Forms.TextBox();
            this.hibabejelento_leirasTB = new System.Windows.Forms.TextBox();
            this.hibabejelento_datumTB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(101, 226);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 0;
            this.butOK.Text = "OK";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // hibabejelento_nevLB
            // 
            this.hibabejelento_nevLB.AutoSize = true;
            this.hibabejelento_nevLB.Location = new System.Drawing.Point(12, 9);
            this.hibabejelento_nevLB.Name = "hibabejelento_nevLB";
            this.hibabejelento_nevLB.Size = new System.Drawing.Size(102, 13);
            this.hibabejelento_nevLB.TabIndex = 1;
            this.hibabejelento_nevLB.Text = "Hibabejelentő neve:";
            // 
            // hibabejelento_datumLB
            // 
            this.hibabejelento_datumLB.AutoSize = true;
            this.hibabejelento_datumLB.Location = new System.Drawing.Point(12, 51);
            this.hibabejelento_datumLB.Name = "hibabejelento_datumLB";
            this.hibabejelento_datumLB.Size = new System.Drawing.Size(97, 13);
            this.hibabejelento_datumLB.TabIndex = 2;
            this.hibabejelento_datumLB.Text = "Bejelentés dátuma:";
            // 
            // hibabejelento_leirasLB
            // 
            this.hibabejelento_leirasLB.AutoSize = true;
            this.hibabejelento_leirasLB.Location = new System.Drawing.Point(12, 92);
            this.hibabejelento_leirasLB.Name = "hibabejelento_leirasLB";
            this.hibabejelento_leirasLB.Size = new System.Drawing.Size(35, 13);
            this.hibabejelento_leirasLB.TabIndex = 3;
            this.hibabejelento_leirasLB.Text = "label3";
            // 
            // hibabejelento_nevTB
            // 
            this.hibabejelento_nevTB.Location = new System.Drawing.Point(12, 28);
            this.hibabejelento_nevTB.Name = "hibabejelento_nevTB";
            this.hibabejelento_nevTB.Size = new System.Drawing.Size(260, 20);
            this.hibabejelento_nevTB.TabIndex = 4;
            this.hibabejelento_nevTB.TextChanged += new System.EventHandler(this.hibabejelento_nevTB_TextChanged);
            // 
            // hibabejelento_leirasTB
            // 
            this.hibabejelento_leirasTB.Location = new System.Drawing.Point(12, 108);
            this.hibabejelento_leirasTB.Multiline = true;
            this.hibabejelento_leirasTB.Name = "hibabejelento_leirasTB";
            this.hibabejelento_leirasTB.Size = new System.Drawing.Size(260, 112);
            this.hibabejelento_leirasTB.TabIndex = 5;
            this.hibabejelento_leirasTB.TextChanged += new System.EventHandler(this.hibabejelento_leirasTB_TextChanged);
            // 
            // hibabejelento_datumTB
            // 
            this.hibabejelento_datumTB.Location = new System.Drawing.Point(12, 69);
            this.hibabejelento_datumTB.Name = "hibabejelento_datumTB";
            this.hibabejelento_datumTB.Size = new System.Drawing.Size(260, 20);
            this.hibabejelento_datumTB.TabIndex = 6;
            this.hibabejelento_datumTB.ValueChanged += new System.EventHandler(this.hibabejelento_datumTB_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.hibabejelento_datumTB);
            this.Controls.Add(this.hibabejelento_leirasTB);
            this.Controls.Add(this.hibabejelento_nevTB);
            this.Controls.Add(this.hibabejelento_leirasLB);
            this.Controls.Add(this.hibabejelento_datumLB);
            this.Controls.Add(this.hibabejelento_nevLB);
            this.Controls.Add(this.butOK);
            this.Name = "Form1";
            this.Text = "AK Hibabejelentő Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Label hibabejelento_nevLB;
        private System.Windows.Forms.Label hibabejelento_datumLB;
        private System.Windows.Forms.Label hibabejelento_leirasLB;
        private System.Windows.Forms.TextBox hibabejelento_nevTB;
        private System.Windows.Forms.TextBox hibabejelento_leirasTB;
        private System.Windows.Forms.DateTimePicker hibabejelento_datumTB;
    }
}

