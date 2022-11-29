namespace FileDemo1
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWriteStream = new System.Windows.Forms.Button();
            this.btnReadStream = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(132, 166);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(285, 166);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(132, 207);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(78, 46);
            this.btnCreateDirectory.TabIndex = 2;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(285, 207);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(75, 46);
            this.btnCreateFile.TabIndex = 3;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(279, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(131, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(279, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(131, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(279, 121);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(131, 20);
            this.txtLocation.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Location";
            // 
            // btnWriteStream
            // 
            this.btnWriteStream.Location = new System.Drawing.Point(490, 140);
            this.btnWriteStream.Name = "btnWriteStream";
            this.btnWriteStream.Size = new System.Drawing.Size(105, 23);
            this.btnWriteStream.TabIndex = 10;
            this.btnWriteStream.Text = "write using Stream";
            this.btnWriteStream.UseVisualStyleBackColor = true;
            this.btnWriteStream.Click += new System.EventHandler(this.btnWriteStream_Click);
            // 
            // btnReadStream
            // 
            this.btnReadStream.Location = new System.Drawing.Point(490, 187);
            this.btnReadStream.Name = "btnReadStream";
            this.btnReadStream.Size = new System.Drawing.Size(105, 23);
            this.btnReadStream.TabIndex = 11;
            this.btnReadStream.Text = "Read usign Stream";
            this.btnReadStream.UseVisualStyleBackColor = true;
            this.btnReadStream.Click += new System.EventHandler(this.btnReadStream_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(490, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(151, 20);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 310);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnReadStream);
            this.Controls.Add(this.btnWriteStream);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Name = "Form1";
            this.Text = "Department Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWriteStream;
        private System.Windows.Forms.Button btnReadStream;
        private System.Windows.Forms.TextBox richTextBox1;
    }
}

