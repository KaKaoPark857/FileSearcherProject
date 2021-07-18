using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * 상위 경로 설정 후 하위 디렉토리까지 모두 다 찾기
 * 리스트 박스내 파일 클릭 시 해당 폴더 열기 or 파일 열기
 * 버튼으로 클릭
 * 버튼으로 선택한 파일 바탕화면에 바로가기 만들기
 */

namespace FileSearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FilenameListBox.FullRowSelect = true;
            FilenameListBox.GridLines = true;
        }

        private void nameSearchBut_Click(object sender, EventArgs e)
        {
            FIlenameLabel.Visible = true;
            FilenameTB.Visible = true;
            FilenameBT.Visible = true;
            FilenameListBox.Visible = true;
            DirName.Visible = true;
        }

        private void FilenameBT_Click(object sender, EventArgs e)
        {
            string spath = DirName.Text;
            
            DirectoryInfo di = new DirectoryInfo(spath+":\\");
            if(di.Exists == false) //디렉토리 존재여부 확인
            {
                MessageBox.Show("해당 디렉토리가 존재하지 않습니다.");
                return;
            }
            else if(FilenameTB.Text == "")
            {
                MessageBox.Show("파일 이름을 입력해주세요.");
            }
            else
            {
                foreach (FileInfo file in di.GetFiles(FilenameTB.Text))
                {
                    FilenameListBox.Items.Add(new ListViewItem(new string[] { file.Name, file.FullName, file.CreationTime.ToString(), file.Length.ToString() }));
                }
                
            }

            FilenameTB.Clear();
        }

        private void ListSearchBut_Click(object sender, EventArgs e)
        {
            FIlenameLabel.Visible = false;
            FilenameTB.Visible = false;
            FilenameBT.Visible = false;
            FilenameListBox.Visible = false;
        }
    }
}
