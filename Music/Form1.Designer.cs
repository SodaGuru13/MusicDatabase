
namespace Music
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navAdd = new System.Windows.Forms.Button();
            this.navLeft = new System.Windows.Forms.Button();
            this.navRight = new System.Windows.Forms.Button();
            this.navDelete = new System.Windows.Forms.Button();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.navApplyChanges = new System.Windows.Forms.Button();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // navAdd
            // 
            this.navAdd.Location = new System.Drawing.Point(68, 390);
            this.navAdd.Margin = new System.Windows.Forms.Padding(1);
            this.navAdd.Name = "navAdd";
            this.navAdd.Size = new System.Drawing.Size(28, 28);
            this.navAdd.TabIndex = 0;
            this.navAdd.Text = "+";
            this.navAdd.UseVisualStyleBackColor = true;
            this.navAdd.Click += new System.EventHandler(this.navAdd_Click);
            // 
            // navLeft
            // 
            this.navLeft.Location = new System.Drawing.Point(165, 390);
            this.navLeft.Margin = new System.Windows.Forms.Padding(1);
            this.navLeft.Name = "navLeft";
            this.navLeft.Size = new System.Drawing.Size(28, 28);
            this.navLeft.TabIndex = 1;
            this.navLeft.Text = "<";
            this.navLeft.UseVisualStyleBackColor = true;
            this.navLeft.Click += new System.EventHandler(this.navLeft_Click);
            // 
            // navRight
            // 
            this.navRight.Location = new System.Drawing.Point(261, 390);
            this.navRight.Margin = new System.Windows.Forms.Padding(1);
            this.navRight.Name = "navRight";
            this.navRight.Size = new System.Drawing.Size(28, 28);
            this.navRight.TabIndex = 2;
            this.navRight.Text = ">";
            this.navRight.UseVisualStyleBackColor = true;
            this.navRight.Click += new System.EventHandler(this.navRight_Click);
            // 
            // navDelete
            // 
            this.navDelete.Location = new System.Drawing.Point(357, 390);
            this.navDelete.Margin = new System.Windows.Forms.Padding(1);
            this.navDelete.Name = "navDelete";
            this.navDelete.Size = new System.Drawing.Size(28, 28);
            this.navDelete.TabIndex = 3;
            this.navDelete.Text = "-";
            this.navDelete.UseVisualStyleBackColor = true;
            this.navDelete.Click += new System.EventHandler(this.navDelete_Click);
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Location = new System.Drawing.Point(133, 43);
            this.txtSongTitle.Margin = new System.Windows.Forms.Padding(1);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(342, 27);
            this.txtSongTitle.TabIndex = 4;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(132, 167);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(1);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(342, 27);
            this.txtArtist.TabIndex = 5;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(133, 214);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(1);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(342, 27);
            this.txtAlbum.TabIndex = 6;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(133, 265);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(1);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(342, 27);
            this.txtGenre.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Song Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Genre";
            // 
            // navApplyChanges
            // 
            this.navApplyChanges.Location = new System.Drawing.Point(332, 338);
            this.navApplyChanges.Margin = new System.Windows.Forms.Padding(1);
            this.navApplyChanges.Name = "navApplyChanges";
            this.navApplyChanges.Size = new System.Drawing.Size(150, 28);
            this.navApplyChanges.TabIndex = 12;
            this.navApplyChanges.Text = "Apply Changes";
            this.navApplyChanges.UseVisualStyleBackColor = true;
            this.navApplyChanges.Click += new System.EventHandler(this.navApplyChanges_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(133, 91);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(1);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(342, 27);
            this.txtDuration.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Song Duration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.navApplyChanges);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtSongTitle);
            this.Controls.Add(this.navDelete);
            this.Controls.Add(this.navRight);
            this.Controls.Add(this.navLeft);
            this.Controls.Add(this.navAdd);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Music Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button navAdd;
        private System.Windows.Forms.Button navLeft;
        private System.Windows.Forms.Button navRight;
        private System.Windows.Forms.Button navDelete;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button navApplyChanges;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label5;
    }
}

