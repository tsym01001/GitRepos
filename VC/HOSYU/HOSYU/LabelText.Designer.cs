namespace HOSYU
{
    partial class LabelTextControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.propLabelcontrol = new System.Windows.Forms.Label();
            this.propTextcontrol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // propLabelcontrol
            // 
            this.propLabelcontrol.AutoSize = true;
            this.propLabelcontrol.BackColor = System.Drawing.Color.Transparent;
            this.propLabelcontrol.Dock = System.Windows.Forms.DockStyle.Left;
            this.propLabelcontrol.Location = new System.Drawing.Point(0, 0);
            this.propLabelcontrol.Name = "propLabelcontrol";
            this.propLabelcontrol.Size = new System.Drawing.Size(0, 12);
            this.propLabelcontrol.TabIndex = 0;
            this.propLabelcontrol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // propTextcontrol
            // 
            this.propTextcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propTextcontrol.Location = new System.Drawing.Point(0, 0);
            this.propTextcontrol.Name = "propTextcontrol";
            this.propTextcontrol.Size = new System.Drawing.Size(361, 19);
            this.propTextcontrol.TabIndex = 1;
            // 
            // LabelTextControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.propTextcontrol);
            this.Controls.Add(this.propLabelcontrol);
            this.Name = "LabelTextControl";
            this.Size = new System.Drawing.Size(361, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label propLabelcontrol;
        private System.Windows.Forms.TextBox propTextcontrol;
    }
}
