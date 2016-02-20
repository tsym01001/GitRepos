namespace HOSYU
{
    partial class ConInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConTest = new System.Windows.Forms.Button();
            this.lblerr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "[ 接続文字列 ]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(12, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(667, 27);
            this.textBox1.TabIndex = 3;
            // 
            // btnConTest
            // 
            this.btnConTest.BackColor = System.Drawing.Color.GreenYellow;
            this.btnConTest.Location = new System.Drawing.Point(12, 63);
            this.btnConTest.Name = "btnConTest";
            this.btnConTest.Size = new System.Drawing.Size(112, 39);
            this.btnConTest.TabIndex = 4;
            this.btnConTest.Text = "接続テスト";
            this.btnConTest.UseVisualStyleBackColor = false;
            this.btnConTest.Click += new System.EventHandler(this.btnConTest_Click);
            // 
            // lblerr
            // 
            this.lblerr.AutoSize = true;
            this.lblerr.Location = new System.Drawing.Point(139, 73);
            this.lblerr.Name = "lblerr";
            this.lblerr.Size = new System.Drawing.Size(18, 18);
            this.lblerr.TabIndex = 5;
            this.lblerr.Text = "[]";
            this.lblerr.DoubleClick += new System.EventHandler(this.lblerr_DoubleClick);
            // 
            // ConInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(650, 0);
            this.ClientSize = new System.Drawing.Size(691, 123);
            this.Controls.Add(this.lblerr);
            this.Controls.Add(this.btnConTest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ConInfoForm";
            this.Text = "接続情報";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConTest;
        private System.Windows.Forms.Label lblerr;
    }
}