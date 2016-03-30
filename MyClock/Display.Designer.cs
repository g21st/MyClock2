namespace MyClock
{
    partial class Display
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeNow = new System.Windows.Forms.Label();
            this.secTimer = new System.Windows.Forms.Timer(this.components);
            this.clockMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.clockMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeNow
            // 
            this.timeNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeNow.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeNow.Location = new System.Drawing.Point(0, 0);
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(345, 83);
            this.timeNow.TabIndex = 0;
            this.timeNow.Text = "12時34分 56秒";
            this.timeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secTimer
            // 
            this.secTimer.Enabled = true;
            this.secTimer.Interval = 1000;
            this.secTimer.Tick += new System.EventHandler(this.secTimer_Tick);
            // 
            // clockMenu
            // 
            this.clockMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemClose});
            this.clockMenu.Name = "clockMenu";
            this.clockMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.Size = new System.Drawing.Size(152, 22);
            this.menuItemClose.Text = "終了(&X)";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 83);
            this.ContextMenuStrip = this.clockMenu;
            this.Controls.Add(this.timeNow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Display";
            this.Opacity = 0.5D;
            this.Text = "MyClock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Display_Load);
            this.clockMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeNow;
        private System.Windows.Forms.Timer secTimer;
        private System.Windows.Forms.ContextMenuStrip clockMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemClose;
    }
}

