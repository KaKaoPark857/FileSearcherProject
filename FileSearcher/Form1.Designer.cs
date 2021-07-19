
namespace FileSearcher
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameSearchBut = new System.Windows.Forms.Button();
            this.ListSearchBut = new System.Windows.Forms.Button();
            this.FilenameTB = new System.Windows.Forms.TextBox();
            this.FIlenameLabel = new System.Windows.Forms.Label();
            this.FilenameBT = new System.Windows.Forms.Button();
            this.FilenameListBox = new System.Windows.Forms.ListView();
            this.Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Filepath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Filedate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DirName = new System.Windows.Forms.DomainUpDown();
            this.OpenFolderBT = new System.Windows.Forms.Button();
            this.MakeCopyBT = new System.Windows.Forms.Button();
            this.ListSearchList = new System.Windows.Forms.ListView();
            this.ListName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListSearchTree = new System.Windows.Forms.TreeView();
            this.ListSearchBT = new System.Windows.Forms.Button();
            this.ListLabel = new System.Windows.Forms.Label();
            this.ListSearchBT2 = new System.Windows.Forms.Button();
            this.ListSearchTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameSearchBut
            // 
            this.nameSearchBut.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameSearchBut.Location = new System.Drawing.Point(29, 31);
            this.nameSearchBut.Name = "nameSearchBut";
            this.nameSearchBut.Size = new System.Drawing.Size(150, 50);
            this.nameSearchBut.TabIndex = 0;
            this.nameSearchBut.Text = "이름으로 찾기";
            this.nameSearchBut.UseVisualStyleBackColor = true;
            this.nameSearchBut.Click += new System.EventHandler(this.nameSearchBut_Click);
            // 
            // ListSearchBut
            // 
            this.ListSearchBut.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListSearchBut.Location = new System.Drawing.Point(214, 31);
            this.ListSearchBut.Name = "ListSearchBut";
            this.ListSearchBut.Size = new System.Drawing.Size(150, 50);
            this.ListSearchBut.TabIndex = 1;
            this.ListSearchBut.Text = "리스트로 찾기";
            this.ListSearchBut.UseVisualStyleBackColor = true;
            this.ListSearchBut.Click += new System.EventHandler(this.ListSearchBut_Click);
            // 
            // FilenameTB
            // 
            this.FilenameTB.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FilenameTB.Location = new System.Drawing.Point(194, 114);
            this.FilenameTB.Name = "FilenameTB";
            this.FilenameTB.Size = new System.Drawing.Size(253, 26);
            this.FilenameTB.TabIndex = 2;
            this.FilenameTB.Visible = false;
            // 
            // FIlenameLabel
            // 
            this.FIlenameLabel.AutoSize = true;
            this.FIlenameLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FIlenameLabel.Location = new System.Drawing.Point(26, 117);
            this.FIlenameLabel.Name = "FIlenameLabel";
            this.FIlenameLabel.Size = new System.Drawing.Size(82, 16);
            this.FIlenameLabel.TabIndex = 3;
            this.FIlenameLabel.Text = "파일 이름";
            this.FIlenameLabel.Visible = false;
            // 
            // FilenameBT
            // 
            this.FilenameBT.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FilenameBT.Location = new System.Drawing.Point(453, 113);
            this.FilenameBT.Name = "FilenameBT";
            this.FilenameBT.Size = new System.Drawing.Size(77, 27);
            this.FilenameBT.TabIndex = 4;
            this.FilenameBT.Text = "검색";
            this.FilenameBT.UseVisualStyleBackColor = true;
            this.FilenameBT.Visible = false;
            this.FilenameBT.Click += new System.EventHandler(this.FilenameBT_Click);
            // 
            // FilenameListBox
            // 
            this.FilenameListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Filename,
            this.Filepath,
            this.Filedate,
            this.FileLength});
            this.FilenameListBox.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FilenameListBox.HideSelection = false;
            this.FilenameListBox.Location = new System.Drawing.Point(10, 153);
            this.FilenameListBox.Name = "FilenameListBox";
            this.FilenameListBox.Size = new System.Drawing.Size(1488, 682);
            this.FilenameListBox.TabIndex = 3;
            this.FilenameListBox.UseCompatibleStateImageBehavior = false;
            this.FilenameListBox.View = System.Windows.Forms.View.Details;
            this.FilenameListBox.Visible = false;
            // 
            // Filename
            // 
            this.Filename.Text = "파일 이름";
            this.Filename.Width = 500;
            // 
            // Filepath
            // 
            this.Filepath.Text = "경로";
            this.Filepath.Width = 650;
            // 
            // Filedate
            // 
            this.Filedate.Text = "생성일";
            this.Filedate.Width = 200;
            // 
            // FileLength
            // 
            this.FileLength.Text = "파일 크기";
            this.FileLength.Width = 200;
            // 
            // DirName
            // 
            this.DirName.Items.Add("C");
            this.DirName.Items.Add("D");
            this.DirName.Items.Add("E");
            this.DirName.Items.Add("F");
            this.DirName.Items.Add("G");
            this.DirName.Items.Add("H");
            this.DirName.Items.Add("I");
            this.DirName.Items.Add("J");
            this.DirName.Items.Add("K");
            this.DirName.Items.Add("L");
            this.DirName.Items.Add("M");
            this.DirName.Items.Add("N");
            this.DirName.Items.Add("O");
            this.DirName.Items.Add("P");
            this.DirName.Items.Add("Q");
            this.DirName.Items.Add("R");
            this.DirName.Items.Add("S");
            this.DirName.Items.Add("T");
            this.DirName.Items.Add("U");
            this.DirName.Items.Add("V");
            this.DirName.Items.Add("W");
            this.DirName.Items.Add("X");
            this.DirName.Items.Add("Y");
            this.DirName.Items.Add("Z");
            this.DirName.Items.Add("A");
            this.DirName.Items.Add("B");
            this.DirName.Location = new System.Drawing.Point(114, 117);
            this.DirName.Name = "DirName";
            this.DirName.Size = new System.Drawing.Size(74, 21);
            this.DirName.TabIndex = 5;
            this.DirName.Text = "C";
            this.DirName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DirName.Visible = false;
            // 
            // OpenFolderBT
            // 
            this.OpenFolderBT.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OpenFolderBT.Location = new System.Drawing.Point(593, 105);
            this.OpenFolderBT.Name = "OpenFolderBT";
            this.OpenFolderBT.Size = new System.Drawing.Size(119, 42);
            this.OpenFolderBT.TabIndex = 6;
            this.OpenFolderBT.Text = "폴더 열기";
            this.OpenFolderBT.UseVisualStyleBackColor = true;
            this.OpenFolderBT.Visible = false;
            this.OpenFolderBT.Click += new System.EventHandler(this.OpenFolderBT_Click);
            // 
            // MakeCopyBT
            // 
            this.MakeCopyBT.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MakeCopyBT.Location = new System.Drawing.Point(718, 105);
            this.MakeCopyBT.Name = "MakeCopyBT";
            this.MakeCopyBT.Size = new System.Drawing.Size(119, 42);
            this.MakeCopyBT.TabIndex = 7;
            this.MakeCopyBT.Text = "바로가기 만들기";
            this.MakeCopyBT.UseVisualStyleBackColor = true;
            this.MakeCopyBT.Visible = false;
            this.MakeCopyBT.Click += new System.EventHandler(this.MakeCopyBT_Click);
            // 
            // ListSearchList
            // 
            this.ListSearchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListName,
            this.ListPath,
            this.ListDate,
            this.ListLength});
            this.ListSearchList.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListSearchList.HideSelection = false;
            this.ListSearchList.Location = new System.Drawing.Point(760, 154);
            this.ListSearchList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListSearchList.Name = "ListSearchList";
            this.ListSearchList.Size = new System.Drawing.Size(744, 682);
            this.ListSearchList.TabIndex = 8;
            this.ListSearchList.UseCompatibleStateImageBehavior = false;
            this.ListSearchList.View = System.Windows.Forms.View.Details;
            this.ListSearchList.Visible = false;
            this.ListSearchList.DoubleClick += new System.EventHandler(this.ListSearchList_DoubleClick);
            // 
            // ListName
            // 
            this.ListName.Text = "이름";
            this.ListName.Width = 300;
            // 
            // ListPath
            // 
            this.ListPath.Text = "경로";
            this.ListPath.Width = 300;
            // 
            // ListDate
            // 
            this.ListDate.Text = "생성일";
            this.ListDate.Width = 150;
            // 
            // ListLength
            // 
            this.ListLength.Text = "크기";
            this.ListLength.Width = 150;
            // 
            // ListSearchTree
            // 
            this.ListSearchTree.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListSearchTree.FullRowSelect = true;
            this.ListSearchTree.Location = new System.Drawing.Point(10, 153);
            this.ListSearchTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListSearchTree.Name = "ListSearchTree";
            this.ListSearchTree.Size = new System.Drawing.Size(744, 682);
            this.ListSearchTree.TabIndex = 9;
            this.ListSearchTree.Visible = false;
            this.ListSearchTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.ListSearchTree_BeforeExpand);
            this.ListSearchTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ListSearchTree_AfterSelect);
            // 
            // ListSearchBT
            // 
            this.ListSearchBT.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListSearchBT.Location = new System.Drawing.Point(52, 102);
            this.ListSearchBT.Name = "ListSearchBT";
            this.ListSearchBT.Size = new System.Drawing.Size(127, 46);
            this.ListSearchBT.TabIndex = 10;
            this.ListSearchBT.Text = "찾을 위치 설정";
            this.ListSearchBT.UseVisualStyleBackColor = true;
            this.ListSearchBT.Visible = false;
            this.ListSearchBT.Click += new System.EventHandler(this.ListSearchBT_Click);
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListLabel.Location = new System.Drawing.Point(539, 117);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(0, 16);
            this.ListLabel.TabIndex = 11;
            // 
            // ListSearchBT2
            // 
            this.ListSearchBT2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListSearchBT2.Location = new System.Drawing.Point(453, 113);
            this.ListSearchBT2.Name = "ListSearchBT2";
            this.ListSearchBT2.Size = new System.Drawing.Size(77, 27);
            this.ListSearchBT2.TabIndex = 12;
            this.ListSearchBT2.Text = "검색";
            this.ListSearchBT2.UseVisualStyleBackColor = true;
            this.ListSearchBT2.Visible = false;
            this.ListSearchBT2.Click += new System.EventHandler(this.ListSearchBT2_Click);
            // 
            // ListSearchTB
            // 
            this.ListSearchTB.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListSearchTB.Location = new System.Drawing.Point(194, 114);
            this.ListSearchTB.Name = "ListSearchTB";
            this.ListSearchTB.Size = new System.Drawing.Size(253, 26);
            this.ListSearchTB.TabIndex = 13;
            this.ListSearchTB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 844);
            this.Controls.Add(this.ListSearchTB);
            this.Controls.Add(this.ListSearchBT2);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.ListSearchTree);
            this.Controls.Add(this.ListSearchBT);
            this.Controls.Add(this.ListSearchList);
            this.Controls.Add(this.MakeCopyBT);
            this.Controls.Add(this.OpenFolderBT);
            this.Controls.Add(this.DirName);
            this.Controls.Add(this.FilenameBT);
            this.Controls.Add(this.FIlenameLabel);
            this.Controls.Add(this.FilenameTB);
            this.Controls.Add(this.ListSearchBut);
            this.Controls.Add(this.nameSearchBut);
            this.Controls.Add(this.FilenameListBox);
            this.Name = "Form1";
            this.Text = "파일 탐색기";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nameSearchBut;
        private System.Windows.Forms.Button ListSearchBut;
        private System.Windows.Forms.TextBox FilenameTB;
        private System.Windows.Forms.Label FIlenameLabel;
        private System.Windows.Forms.Button FilenameBT;
        private System.Windows.Forms.ListView FilenameListBox;
        private System.Windows.Forms.ColumnHeader Filename;
        private System.Windows.Forms.ColumnHeader Filepath;
        private System.Windows.Forms.ColumnHeader Filedate;
        private System.Windows.Forms.ColumnHeader FileLength;
        private System.Windows.Forms.DomainUpDown DirName;
        private System.Windows.Forms.Button OpenFolderBT;
        private System.Windows.Forms.Button MakeCopyBT;
        private System.Windows.Forms.ListView ListSearchList;
        private System.Windows.Forms.TreeView ListSearchTree;
        private System.Windows.Forms.Button ListSearchBT;
        private System.Windows.Forms.ColumnHeader ListName;
        private System.Windows.Forms.ColumnHeader ListPath;
        private System.Windows.Forms.ColumnHeader ListDate;
        private System.Windows.Forms.ColumnHeader ListLength;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Button ListSearchBT2;
        private System.Windows.Forms.TextBox ListSearchTB;
    }
}

