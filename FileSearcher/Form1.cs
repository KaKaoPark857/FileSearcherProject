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
using System.Diagnostics; //process로 파일 및 폴더를 열기 위한 클래스
using IWshRuntimeLibrary; //바탕화면 바로가기 참조(com/windows script host object model) 추가 후 사용하기 위해 추가

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
            ListSearchList.FullRowSelect = true;
            ListSearchList.GridLines = true;
        }

        private void nameSearchBut_Click(object sender, EventArgs e)
        {
            FIlenameLabel.Visible = true;
            FilenameTB.Visible = true;
            FilenameBT.Visible = true;
            FilenameListBox.Visible = true;
            DirName.Visible = true;
            ListSearchList.Visible = false;
            ListSearchTree.Visible = false;
            ListSearchBT.Visible = false;
        }
       
        private void FilenameBT_Click(object sender, EventArgs e)
        {
            string spath = DirName.Text;
            FilenameListBox.Items.Clear();
            
            DirectoryInfo di = new DirectoryInfo(spath + ":\\visual Workspace\\");

            //FileInfo file = new FileInfo(spath+"\\");

            if (di.Exists == false) //디렉토리 존재여부 확인
            {
                MessageBox.Show("해당 디렉토리가 존재하지 않습니다.");
                return;
            }
            else if (FilenameTB.Text == "")
            {
                MessageBox.Show("파일 이름을 입력해주세요.");
            }
            else
            {

                OpenFolderBT.Visible = true;
                MakeCopyBT.Visible = true;
                
                FileInfo[] filestr = di.GetFiles(FilenameTB.Text, SearchOption.AllDirectories);
                try
                {
                    foreach (FileInfo file in filestr)//di.GetFiles(FilenameTB.Text, SearchOption.AllDirectories))
                    {
                        FilenameListBox.Items.Add(new ListViewItem(new string[] { file.Name, file.DirectoryName, file.CreationTime.ToString(), file.Length.ToString() }));
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Access Error!!");
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
            DirName.Visible = true;
            OpenFolderBT.Visible = false;
            MakeCopyBT.Visible = false;
            ListSearchList.Visible = true;
            ListSearchTree.Visible = true;
            ListSearchBT.Visible = true;


            string spath = DirName.Text;
            DirectoryInfo di = new DirectoryInfo(spath + ":\\");
            ListSearchTree.Nodes.Clear();
            if (di.Exists == false) //디렉토리 존재여부 확인
            {
                MessageBox.Show("해당 디렉토리가 존재하지 않습니다.");
                return;
            }

            init(ListSearchTree);
           
        }

        public static void init(TreeView DirTree)
        {
            
            string[] Drives = Directory.GetLogicalDrives();
            foreach (string drive in Drives)
            {
                DirectoryInfo dir = new DirectoryInfo(drive);
                TreeNode root = new TreeNode(drive);
                DirTree.Nodes.Add(root);
                GetDirectoryNodes(root, dir.FullName);
            }

            //string path = "C:\\test";
            //TreeNode trvi = new TreeNode("Test");
            //DirTree.Nodes.Add(trvi);
            //GetDirectoryNodes(trvi, path);
        }

        private static void GetDirectoryNodes(TreeNode root, string _path)
        {
            DirectoryInfo dir = new DirectoryInfo(_path);
            foreach (var di in dir.GetDirectories())
            {
                TreeNode trviParent = new TreeNode(di.Name);
                root.Nodes.Add(trviParent);
                GetDirectoryNodes(trviParent, di.FullName);
            }

            foreach (var file in dir.GetFiles())
            {
                TreeNode trvi = new TreeNode(file.Name);
                root.Nodes.Add(trvi);
            }
        }
        private void OpenFolderBT_Click(object sender, EventArgs e)
        {
            string path = FilenameListBox.SelectedItems[0].SubItems[1].Text;
            Process.Start(path);
        }

        private void MakeCopyBT_Click(object sender, EventArgs e)
        {            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //바탕화면 경로지정

            string linkFile = path + "\\" + FilenameListBox.SelectedItems[0].SubItems[0].Text + ".lnk";

            FileInfo linkFileCreate = new FileInfo(linkFile);
            if (linkFileCreate.Exists) return; //바로가기 파일 존재여부 확인
            try
            {
                WshShell wshShell = new WshShell();
                IWshShortcut link = (IWshShortcut)wshShell.CreateShortcut(linkFileCreate.FullName);
                link.TargetPath = FilenameListBox.SelectedItems[0].SubItems[1].Text + "\\" + FilenameListBox.SelectedItems[0].SubItems[0].Text; //리스트 박스에서 선택한 파일 경로 선택
                link.Save(); //바로가기 저장
            }
            catch (Exception)
            {
                MessageBox.Show("바로가기 만들기에 실패하였습니다!");
            }

            
        }

        private void ListSearchBT_Click(object sender, EventArgs e)
        {
            
        }

        private void ListSearchTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
         
        }
    }
}
