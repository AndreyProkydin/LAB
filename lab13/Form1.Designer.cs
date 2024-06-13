namespace lab13
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFullPath = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCreationTime = new System.Windows.Forms.Label();
            this.lblLastAccessTime = new System.Windows.Forms.Label();
            this.lblLastWriteTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(27, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(430, 400);
            this.treeView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLastWriteTime);
            this.panel1.Controls.Add(this.lblLastAccessTime);
            this.panel1.Controls.Add(this.lblCreationTime);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblFullPath);
            this.panel1.Location = new System.Drawing.Point(535, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 214);
            this.panel1.TabIndex = 1;
            // 
            // lblFullPath
            // 
            this.lblFullPath.AutoSize = true;
            this.lblFullPath.Location = new System.Drawing.Point(26, 24);
            this.lblFullPath.Name = "lblFullPath";
            this.lblFullPath.Size = new System.Drawing.Size(0, 13);
            this.lblFullPath.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 1;
            // 
            // lblCreationTime
            // 
            this.lblCreationTime.AutoSize = true;
            this.lblCreationTime.Location = new System.Drawing.Point(26, 82);
            this.lblCreationTime.Name = "lblCreationTime";
            this.lblCreationTime.Size = new System.Drawing.Size(0, 13);
            this.lblCreationTime.TabIndex = 2;
            // 
            // lblLastAccessTime
            // 
            this.lblLastAccessTime.AutoSize = true;
            this.lblLastAccessTime.Location = new System.Drawing.Point(26, 110);
            this.lblLastAccessTime.Name = "lblLastAccessTime";
            this.lblLastAccessTime.Size = new System.Drawing.Size(0, 13);
            this.lblLastAccessTime.TabIndex = 3;
            // 
            // lblLastWriteTime
            // 
            this.lblLastWriteTime.AutoSize = true;
            this.lblLastWriteTime.Location = new System.Drawing.Point(26, 139);
            this.lblLastWriteTime.Name = "lblLastWriteTime";
            this.lblLastWriteTime.Size = new System.Drawing.Size(0, 13);
            this.lblLastWriteTime.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFullPath;
        private System.Windows.Forms.Label lblLastWriteTime;
        private System.Windows.Forms.Label lblLastAccessTime;
        private System.Windows.Forms.Label lblCreationTime;
        private System.Windows.Forms.Label lblName;
    }
}

