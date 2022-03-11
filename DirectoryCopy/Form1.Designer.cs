
namespace DirectoryCopy
{
    partial class DirectoryCopy
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PathFrom = new System.Windows.Forms.TextBox();
            this.PathDest = new System.Windows.Forms.TextBox();
            this.ShowInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathFrom
            // 
            this.PathFrom.AllowDrop = true;
            this.PathFrom.Location = new System.Drawing.Point(104, 23);
            this.PathFrom.Name = "PathFrom";
            this.PathFrom.Size = new System.Drawing.Size(615, 21);
            this.PathFrom.TabIndex = 0;
            this.PathFrom.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathFrom_DragDrop);
            this.PathFrom.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathFrom_DragEnter);
            // 
            // PathDest
            // 
            this.PathDest.AllowDrop = true;
            this.PathDest.Location = new System.Drawing.Point(104, 59);
            this.PathDest.Name = "PathDest";
            this.PathDest.Size = new System.Drawing.Size(615, 21);
            this.PathDest.TabIndex = 1;
            this.PathDest.DragDrop += new System.Windows.Forms.DragEventHandler(this.PathDest_DragDrop);
            this.PathDest.DragEnter += new System.Windows.Forms.DragEventHandler(this.PathDest_DragEnter);
            // 
            // ShowInfo
            // 
            this.ShowInfo.Location = new System.Drawing.Point(12, 99);
            this.ShowInfo.Multiline = true;
            this.ShowInfo.Name = "ShowInfo";
            this.ShowInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowInfo.Size = new System.Drawing.Size(776, 67);
            this.ShowInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination";
            // 
            // StartCopy
            // 
            this.StartCopy.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartCopy.Location = new System.Drawing.Point(735, 30);
            this.StartCopy.Name = "StartCopy";
            this.StartCopy.Size = new System.Drawing.Size(50, 42);
            this.StartCopy.TabIndex = 5;
            this.StartCopy.Text = "Go";
            this.StartCopy.UseVisualStyleBackColor = true;
            this.StartCopy.Click += new System.EventHandler(this.StartCopy_Click);
            // 
            // DirectoryCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 181);
            this.Controls.Add(this.StartCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowInfo);
            this.Controls.Add(this.PathDest);
            this.Controls.Add(this.PathFrom);
            this.Name = "DirectoryCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirectoryCopy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathFrom;
        private System.Windows.Forms.TextBox PathDest;
        private System.Windows.Forms.TextBox ShowInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartCopy;
    }
}

