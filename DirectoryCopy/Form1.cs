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

namespace DirectoryCopy
{
    public partial class DirectoryCopy : Form
    {
        public DirectoryCopy()
        {
            InitializeComponent();
        }

        private void PathFrom_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PathFrom_DragDrop(object sender, DragEventArgs e)
        {
            string[] filepaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            PathFrom.Text = filepaths[0];
        }

        private void PathDest_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PathDest_DragDrop(object sender, DragEventArgs e)
        {
            string[] filepaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            PathDest.Text = filepaths[0];
        }

        private void StartCopy_Click(object sender, EventArgs e)
        {
            CopyDirectory(PathFrom.Text);
            ShowInfo.Text += "Completed!\r\n";
        }

        private void CopyDirectory(string pathfrom)
        {
            DirectoryInfo dir = new DirectoryInfo(pathfrom);
            foreach (DirectoryInfo dChild in dir.GetDirectories())
            {
                try
                {
                    Directory.CreateDirectory(dChild.FullName.Replace(PathFrom.Text, PathDest.Text));
                    CopyDirectory(dChild.FullName);
                }
                catch (Exception)
                {
                    continue;
                }            
            }
        }
    }
}
