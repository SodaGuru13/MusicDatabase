
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
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.navApplyChanges = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSongDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSongDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.navCopySong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // navAdd
            // 
            this.navAdd.Location = new System.Drawing.Point(416, 602);
            this.navAdd.Margin = new System.Windows.Forms.Padding(1);
            this.navAdd.Name = "navAdd";
            this.navAdd.Size = new System.Drawing.Size(28, 28);
            this.navAdd.TabIndex = 0;
            this.navAdd.Text = "+";
            this.navAdd.UseVisualStyleBackColor = true;
            this.navAdd.Click += new System.EventHandler(this.NavAdd_Click);
            // 
            // navLeft
            // 
            this.navLeft.Location = new System.Drawing.Point(513, 602);
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
            this.navRight.Location = new System.Drawing.Point(609, 602);
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
            this.navDelete.Location = new System.Drawing.Point(705, 602);
            this.navDelete.Margin = new System.Windows.Forms.Padding(1);
            this.navDelete.Name = "navDelete";
            this.navDelete.Size = new System.Drawing.Size(28, 28);
            this.navDelete.TabIndex = 3;
            this.navDelete.Text = "-";
            this.navDelete.UseVisualStyleBackColor = true;
            this.navDelete.Click += new System.EventHandler(this.navDelete_Click);
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(131, 45);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(1);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(342, 27);
            this.txtAlbum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Title";
            // 
            // navApplyChanges
            // 
            this.navApplyChanges.Location = new System.Drawing.Point(1015, 584);
            this.navApplyChanges.Margin = new System.Windows.Forms.Padding(1);
            this.navApplyChanges.Name = "navApplyChanges";
            this.navApplyChanges.Size = new System.Drawing.Size(150, 28);
            this.navApplyChanges.TabIndex = 12;
            this.navApplyChanges.Text = "Apply Changes";
            this.navApplyChanges.UseVisualStyleBackColor = true;
            this.navApplyChanges.Click += new System.EventHandler(this.navApplyChanges_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtReleaseDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSongDuration);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSongDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSongTitle);
            this.groupBox1.Location = new System.Drawing.Point(44, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 278);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Song";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Release Date";
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Location = new System.Drawing.Point(145, 201);
            this.txtReleaseDate.Margin = new System.Windows.Forms.Padding(1);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(342, 27);
            this.txtReleaseDate.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Duration";
            // 
            // txtSongDuration
            // 
            this.txtSongDuration.Location = new System.Drawing.Point(145, 150);
            this.txtSongDuration.Margin = new System.Windows.Forms.Padding(1);
            this.txtSongDuration.Name = "txtSongDuration";
            this.txtSongDuration.Size = new System.Drawing.Size(342, 27);
            this.txtSongDuration.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Description";
            // 
            // txtSongDescription
            // 
            this.txtSongDescription.Location = new System.Drawing.Point(145, 99);
            this.txtSongDescription.Margin = new System.Windows.Forms.Padding(1);
            this.txtSongDescription.Name = "txtSongDescription";
            this.txtSongDescription.Size = new System.Drawing.Size(342, 27);
            this.txtSongDescription.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Title";
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Location = new System.Drawing.Point(145, 51);
            this.txtSongTitle.Margin = new System.Windows.Forms.Padding(1);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(342, 27);
            this.txtSongTitle.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtGenre);
            this.groupBox2.Location = new System.Drawing.Point(44, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 240);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(112, 38);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(1);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(342, 27);
            this.txtGenre.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtArtist);
            this.groupBox3.Location = new System.Drawing.Point(599, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 266);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(94, 38);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(1);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(342, 27);
            this.txtArtist.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAlbum);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(599, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(566, 240);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Album";
            // 
            // navCopySong
            // 
            this.navCopySong.Location = new System.Drawing.Point(44, 582);
            this.navCopySong.Name = "navCopySong";
            this.navCopySong.Size = new System.Drawing.Size(94, 29);
            this.navCopySong.TabIndex = 23;
            this.navCopySong.Text = "Copy Song";
            this.navCopySong.UseVisualStyleBackColor = true;
            this.navCopySong.Click += new System.EventHandler(this.navCopySong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 658);
            this.Controls.Add(this.navCopySong);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navApplyChanges);
            this.Controls.Add(this.navDelete);
            this.Controls.Add(this.navRight);
            this.Controls.Add(this.navLeft);
            this.Controls.Add(this.navAdd);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Music Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button navAdd;
        private System.Windows.Forms.Button navLeft;
        private System.Windows.Forms.Button navRight;
        private System.Windows.Forms.Button navDelete;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button navApplyChanges;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReleaseDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSongDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSongDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button navCopySong;
    }
}

