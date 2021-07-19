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
using System.Threading;

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
            ListSearchBT2.Visible = false;
            ListSearchTB.Visible = false;
        }
       
        private void FilenameBT_Click(object sender, EventArgs e)
        {
            string spath = DirName.Text;
            FilenameListBox.Items.Clear();

            DirectoryInfo di = new DirectoryInfo(spath + ":\\");// 3D Printer\\");// visual Workspace

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


        string m_curPath = "";
        Thread m_thread;

        private void ListSearchBut_Click(object sender, EventArgs e)
        {
            FIlenameLabel.Visible = false;
            FilenameTB.Visible = false;
            FilenameBT.Visible = false;
            FilenameListBox.Visible = false;
            DirName.Visible = false;
            OpenFolderBT.Visible = false;
            MakeCopyBT.Visible = false;
            ListSearchList.Visible = true;
            ListSearchTree.Visible = true;
            ListSearchBT.Visible = true;
            ListSearchBT2.Visible = true;
            ListSearchTB.Visible = true;

           
            m_curPath = "Root";
            ListLabel.Text = m_curPath;

            TreeNode root = ListSearchTree.Nodes.Add(m_curPath);
            
            string[] drives = Directory.GetLogicalDrives();//드라이브 읽어오기    

            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);

                if (di.IsReady)        //드라이브 존재 여부 확인
                {
                    TreeNode node = root.Nodes.Add(drive);
                    node.Nodes.Add("\\");//파일 경로에 \ 추가
                }
            }



        }
        private void ListSearchTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text.Equals("\\"))
                {
                    e.Node.Nodes.Clear();

                    string path = e.Node.FullPath.Substring(e.Node.FullPath.IndexOf("\\") + 1);

                    string[] directories = Directory.GetDirectories(path);//노드에 하위 디렉토리 추가
                    foreach (string directory in directories)
                    {
                        TreeNode newNode = e.Node.Nodes.Add(directory.Substring(directory.LastIndexOf("\\") + 1));
                        newNode.Nodes.Add("\\");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("treeView1_BeforeExpand : " + ex.Message);
            }
        }
        private void ViewDirectoryList(string path)
        {
            if (m_thread != null && m_thread.IsAlive)
                m_thread.Abort();

            string curPath = path;

            Console.WriteLine(path.IndexOf("Root\\"));
            if (path.IndexOf("Root\\") == 0)
            {
                curPath = path.Substring(path.IndexOf("\\") + 1);
                ListLabel.Text = (curPath.Length > 4) ? curPath.Remove(curPath.IndexOf("\\") + 1, 1) : curPath;
                m_curPath = ListLabel.Text;
            }
            else
            {
                ListLabel.Text = path;
                m_curPath = path;
            }

            try
            {
                ListSearchList.Items.Clear();

                string[] directories = Directory.GetDirectories(curPath);

                foreach (string directory in directories)
                {
                    DirectoryInfo info = new DirectoryInfo(directory);
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        info.Name,"" ,info.LastWriteTime.ToString(), "폴더"
                    });
                    ListSearchList.Items.Add(item);
                }

                string[] files = Directory.GetFiles(curPath);

                foreach (string file in files)
                {
                    FileInfo info = new FileInfo(file);
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        info.Name, info.FullName, info.CreationTime.ToString(), ((info.Length/1000)+1).ToString()+"KB"
                    });
                    ListSearchList.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ViewDirectoryList : " + ex.Message);
            }
        }
        private void SelectTreeView(TreeNode node)
        {
            if (node.FullPath == null)
            {
                MessageBox.Show("empth node.FullPath");
                return;
            }

            string path = node.FullPath;

            ViewDirectoryList(path);
        }
        private void ListSearchTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectTreeView(e.Node);
        }

        private void ListSearchBT_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                m_curPath = fbd.SelectedPath;
                Console.WriteLine(m_curPath);
                ListLabel.Text = m_curPath;

                ViewDirectoryList(m_curPath);
            }
        }
        private void ListSearchList_DoubleClick(object sender, EventArgs e)
        {
            if (ListSearchList.SelectedItems.Count == 1)
            {
                string processPath;
                if (ListSearchList.SelectedItems[0].Text.IndexOf("\\") > 0)
                    processPath = ListSearchList.SelectedItems[0].Text;
                else
                    processPath = m_curPath + "\\" + ListSearchList.SelectedItems[0].Text;

                Process.Start("explorer.exe", processPath);
            }
        }
        private void ListSearchBT2_Click(object sender, EventArgs e)
        {
            if (m_thread != null && m_thread.IsAlive)
                m_thread.Abort();

            m_curPath = ListLabel.Text;
            DirectoryInfo rootDirInfo = new DirectoryInfo(m_curPath);
            string searchFiles = ListSearchTB.Text;

            m_thread = new Thread(delegate ()
            {
                WalkDirectoryTree(rootDirInfo, searchFiles);
            });
            m_thread.Start();
        }

        public void WalkDirectoryTree(DirectoryInfo dirInfo, string searchFiles)
        {
            ListSearchList.Items.Find(searchFiles, true);

            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            try
            {
                files = dirInfo.GetFiles(searchFiles + "*.*");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                DirectoryInfo tempDirInfo = new DirectoryInfo(m_curPath);

                if (dirInfo.ToString() == tempDirInfo.ToString())
                    ListSearchList.Items.Clear();

                foreach (FileInfo fi in files)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        fi.Name, fi.FullName, fi.CreationTime.ToString(), ((fi.Length/1000)+1).ToString()+"KB"
                    });
                    ListSearchList.Items.Add(item);
                }

                subDirs = dirInfo.GetDirectories();
                foreach (DirectoryInfo di in subDirs)
                {
                    WalkDirectoryTree(di, searchFiles);
                }
            }
        }
        private void ListSearchTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
         
        }

        
    }
}
