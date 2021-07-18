
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
            this.SuspendLayout();
            // 
            // nameSearchBut
            // 
            this.nameSearchBut.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameSearchBut.Location = new System.Drawing.Point(35, 58);
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
            this.ListSearchBut.Location = new System.Drawing.Point(277, 58);
            this.ListSearchBut.Name = "ListSearchBut";
            this.ListSearchBut.Size = new System.Drawing.Size(150, 50);
            this.ListSearchBut.TabIndex = 1;
            this.ListSearchBut.Text = "리스트로 찾기";
            this.ListSearchBut.UseVisualStyleBackColor = true;
            // 
            // FilenameTB
            // 
            this.FilenameTB.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FilenameTB.Location = new System.Drawing.Point(111, 195);
            this.FilenameTB.Name = "FilenameTB";
            this.FilenameTB.Size = new System.Drawing.Size(253, 26);
            this.FilenameTB.TabIndex = 2;
            this.FilenameTB.Visible = false;
            // 
            // FIlenameLabel
            // 
            this.FIlenameLabel.AutoSize = true;
            this.FIlenameLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FIlenameLabel.Location = new System.Drawing.Point(10, 198);
            this.FIlenameLabel.Name = "FIlenameLabel";
            this.FIlenameLabel.Size = new System.Drawing.Size(82, 16);
            this.FIlenameLabel.TabIndex = 3;
            this.FIlenameLabel.Text = "파일 이름";
            this.FIlenameLabel.Visible = false;
            // 
            // FilenameBT
            // 
            this.FilenameBT.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FilenameBT.Location = new System.Drawing.Point(379, 194);
            this.FilenameBT.Name = "FilenameBT";
            this.FilenameBT.Size = new System.Drawing.Size(77, 27);
            this.FilenameBT.TabIndex = 4;
            this.FilenameBT.Text = "검색";
            this.FilenameBT.UseVisualStyleBackColor = true;
            this.FilenameBT.Visible = false;
            this.FilenameBT.Click += new System.EventHandler(this.FilenameBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.FilenameBT);
            this.Controls.Add(this.FIlenameLabel);
            this.Controls.Add(this.FilenameTB);
            this.Controls.Add(this.ListSearchBut);
            this.Controls.Add(this.nameSearchBut);
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
    }
}

