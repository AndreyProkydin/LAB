using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab13
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
            treeView1.Dock = DockStyle.Fill;
            Controls.Add(treeView1);
            treeView1.BeforeSelect += treeView1_BeforeSelect;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.AfterSelect += treeView1_AfterSelect;
            FillDriveNodes();
         
        }

        void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node?.Nodes.Clear();
            try
            {
                if (Directory.Exists(e.Node?.FullPath))
                {
                    string[] dirs = Directory.GetDirectories(e.Node.FullPath);
                    foreach (string dir in dirs)
                    {
                        TreeNode dirNode = new TreeNode(new DirectoryInfo(dir).Name);
                        FillTreeNode(dirNode, dir);
                        e.Node.Nodes.Add(dirNode);
                    }
                }
            }
            catch (Exception) { }
        }
 
        void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node?.Nodes.Clear();
            try
            {
                if (Directory.Exists(e.Node?.FullPath))
                {
                    string[] dirs = Directory.GetDirectories(e.Node.FullPath);

                    foreach (string dir in dirs)
                    {
                        TreeNode dirNode = new TreeNode(new DirectoryInfo(dir).Name);
                        FillTreeNode(dirNode, dir);
                        e.Node.Nodes.Add(dirNode);
                    }
                }
            }
            catch (Exception) { }
        }

        
        private void FillDriveNodes()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name };
                    FillTreeNode(driveNode, drive.Name);
                    treeView1.Nodes.Add(driveNode);
                }
            }
            catch (Exception) { }
        }
       
        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception) { }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
          
            TreeNode selectedNode = e.Node;

            if (selectedNode != null)
            {
            
                string fullPath = selectedNode.FullPath;
                string name = selectedNode.Text;
                DirectoryInfo dirInfo = new DirectoryInfo(selectedNode.FullPath);
                DateTime creationTime = dirInfo.CreationTime;
                DateTime lastAccessTime = dirInfo.LastAccessTime;
                DateTime lastWriteTime = dirInfo.LastWriteTime;

                lblFullPath.Text = fullPath;
                lblName.Text = name;
                lblCreationTime.Text = $"Creation time:"+creationTime.ToString();
                lblLastAccessTime.Text = $"Last access time:" + lastAccessTime.ToString();
                lblLastWriteTime.Text = $"Last write time:" + lastWriteTime.ToString();
            }
            else
            {
      
                lblFullPath.Text = string.Empty;
                lblName.Text = string.Empty;
                lblCreationTime.Text = string.Empty;
                lblLastAccessTime.Text = string.Empty;
                lblLastWriteTime.Text = string.Empty;
            }
        }
    }
}

