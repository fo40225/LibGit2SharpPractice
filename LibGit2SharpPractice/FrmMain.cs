using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibGit2Sharp;

namespace LibGit2SharpPractice
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            fbdGitFolder.ShowDialog();
            this.Text = fbdGitFolder.SelectedPath;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            Repository.Init(fbdGitFolder.SelectedPath);
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            ofdGitFile.ShowDialog();
            txtFilePath.Text = ofdGitFile.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(fbdGitFolder.SelectedPath))
            {
                repo.Stage(ofdGitFile.FileName);
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(fbdGitFolder.SelectedPath))
            {
                repo.Commit(txtComment.Text);
            }
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            Repository.Clone(txtUrl.Text, fbdGitFolder.SelectedPath);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(fbdGitFolder.SelectedPath))
            {
                foreach (var item in repo.RetrieveStatus())
                {
                    Console.WriteLine(item.State+"\t"+item.FilePath);
                }
                Console.WriteLine("--");
            }
        }

        private void btnRm_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(fbdGitFolder.SelectedPath))
            {
                repo.Remove(ofdGitFile.FileName);
            }
        }

        private void btnFileUndo_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(fbdGitFolder.SelectedPath))
            {
                var UndoList=new List<string>();
                UndoList.Add(ofdGitFile.FileName);
                CheckoutOptions options = new CheckoutOptions
                {
                    CheckoutModifiers = CheckoutModifiers.Force
                };
                repo.CheckoutPaths(repo.Head.Name, UndoList, options);
            }
        }

        private void btnRemote_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(fbdGitFolder.SelectedPath))
            {
                cbRemoteName.Items.Clear();
                foreach (var Remote in repo.Network.Remotes)
                {
                    Console.WriteLine(Remote.Name+"\t"+Remote.Url);
                    cbRemoteName.Items.Add(Remote.Name);
                }
                Console.WriteLine("--");
            }
        }

        private void btnRemoteAdd_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(fbdGitFolder.SelectedPath))
            {
                repo.Network.Remotes.Add(txtRemoteName.Text, txtRemoteUrl.Text);
            }
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(fbdGitFolder.SelectedPath))
            {
                repo.Fetch(cbRemoteName.Text);
            }
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(fbdGitFolder.SelectedPath))
            {
                cbBranches.Items.Clear();
                foreach (var Branch in repo.Branches)
                {
                    cbBranches.Items.Add(Branch.Name);
                    Console.WriteLine(Branch.Name+" Is HEAD:"+Branch.IsCurrentRepositoryHead);
                }
                Console.WriteLine("--");
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(fbdGitFolder.SelectedPath))
            {
                repo.Checkout(cbBranches.Text);
            }
        }

        private void btnBranchAdd_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(fbdGitFolder.SelectedPath))
            {
                repo.CreateBranch(txtBranchName.Text);
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(fbdGitFolder.SelectedPath))
            {
                Signature merger = new Signature("Tester", "Test@abc.com", DateTime.Now);
                repo.Merge(repo.Branches[cbBranches.Text], merger);
            }
        }
    }
}
