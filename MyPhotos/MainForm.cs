using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetTitleBar();
            SetStatusStrip(null);

            menuView.DropDown = ctxMenuPhoto;
        }

        private void SetTitleBar()
        {
            Version ver = new Version(Application.ProductVersion);
            Text = String.Format("MyPhotos {0:0}.{1:0}", ver.Major, ver.Minor);
        }

        private void LoadPhoto()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Photo";
            dlg.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbxPhoto.Image = new Bitmap(dlg.OpenFile());
                    SetStatusStrip(dlg.FileName);
                    // Testing
                    // MessageBox.Show(GetFileName(dlg.FileName));
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Unable to load file: " + ex.Message);
                }
            }
            dlg.Dispose();
        }

        //private Image LoadPhoto2()
        //{
        //    Image result = null;
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    dlg.Title = "Open Photo";
        //    dlg.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
        //    if (dlg.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            result = new Bitmap(dlg.OpenFile());
        //        }
        //        catch (ArgumentException ex)
        //        {
        //            MessageBox.Show("Unable to load file: " + ex.Message);
        //            result = null;
        //        }
        //    }
        //    dlg.Dispose();
        //    return result;
        //}

        private void menuFileLoad_Click(object sender, EventArgs e)
        {
            // pbxPhoto.Image = LoadPhoto2();
            LoadPhoto();
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuFileClear_Click(object sender, EventArgs e)
        {
            pbxPhoto.Image = null;
        }

        private void menuImage_DropDownItemClicked(object sender, 
            ToolStripItemClickedEventArgs e)
        {
            ProcessImageClick(e);
        }

        private void ProcessImageClick(ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            string enumVal = item.Tag as string;
            if (enumVal != null)
            {
                pbxPhoto.SizeMode = (PictureBoxSizeMode)
                    Enum.Parse(typeof(PictureBoxSizeMode),
                        enumVal);
            }
        }

        private void menuImage_DropDownOpening(object sender,
            EventArgs e)
        {
            ProcessImageOpening(sender as ToolStripDropDownItem);
        }

        private void ProcessImageOpening(ToolStripDropDownItem parent)
        {
            if (parent != null)
            {
                string enumVal = pbxPhoto.SizeMode.ToString();
                foreach (ToolStripMenuItem item in parent.DropDownItems)
                {
                    item.Enabled = (pbxPhoto.Image != null);
                    item.Checked = item.Tag.Equals(enumVal);
                }
            }
        }

        private void SetStatusStrip(string path)
        {
            if (pbxPhoto.Image != null)
            {
                // statusInfo.Text = path;
                statusInfo.Text = GetFileName(path);
                statusInfo.ToolTipText = path;
                statusImageSize.Text = String.Format("{0:#}x{1:#}",
                                            pbxPhoto.Image.Width,
                                            pbxPhoto.Image.Height);
                // statusAlbumPos is set in chapter 6
            }
            else
            {
                statusInfo.Text = null;
                statusImageSize.Text = null;
                statusAlbumPos.Text = null;
            }
        }

        private string GetFileName(string path)
        {
            string result = null;
            string[] extensions = { ".jpg", ".png", ".bmp" };
            string[] subs = path.Split('\\');
            result = subs[subs.Length - 1];
            // result = result.Substring(0, result.Length - 4);
            return result;
        }
    }
}
