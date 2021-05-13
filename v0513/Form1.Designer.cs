
namespace v0513
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.mybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mybutton
            // 
            this.mybutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.mybutton.Font = new System.Drawing.Font("HGP創英ﾌﾟﾚｾﾞﾝｽEB", 12F);
            this.mybutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.mybutton.Location = new System.Drawing.Point(227, 85);
            this.mybutton.Name = "mybutton";
            this.mybutton.Size = new System.Drawing.Size(126, 42);
            this.mybutton.TabIndex = 0;
            this.mybutton.Text = "ボタン";
            this.mybutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mybutton.UseVisualStyleBackColor = false;
            this.mybutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.mybutton);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mybutton;
    }
}

