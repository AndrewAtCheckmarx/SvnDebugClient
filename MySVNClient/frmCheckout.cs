using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpSvn;
using SharpSvn.Security;

namespace MySVNClient
{
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (tbLocalPath.Text.Length == 0 || tbRepoURI.Text.Length == 0)
            {
                MessageBox.Show("The 'Repository URI' and 'Local Path' fields cannot be empty.");
                return;
            }

            //SvnUpdateResult provides info about what happened during a checkout
            SvnUpdateResult result;

            //we will use this to tell CheckOut() which revision to fetch
            long revision;

            //SvnCheckoutArgs wraps all of the options for the 'svn checkout' function
            SvnCheckOutArgs args = new SvnCheckOutArgs();

            //path is the path where the local working copy will end up
            string path = tbLocalPath.Text;

            if (long.TryParse(tbRevision.Text, out revision))
            {
                //set the revision number if the user entered a valid number
                args.Revision = new SvnRevision(revision);
            }
            //if args.Revision is not set, it defaults to fetch the HEAD revision.
            else MessageBox.Show("Invalid Revision number, defaulting to HEAD");

            //the using statement is necessary to ensure we are freeing up resources
            using (SharpSvn.SvnClient client = new SharpSvn.SvnClient())
            {
                try
                {
                    //SvnUriTarget is a wrapper class for SVN repository URIs
                    SvnUriTarget target = new SvnUriTarget(tbRepoURI.Text);

                    if (cbAuthenticate.Checked == true)
                    {
                        logMsg("Authenticating");
                        client.Authentication.Clear(); // Clear a previous authentication

                        client.Authentication.SslServerTrustHandlers += new EventHandler<SharpSvn.Security.SvnSslServerTrustEventArgs>(SVN_SSL_Override);

                        client.Authentication.UserNamePasswordHandlers += delegate(object obj, SharpSvn.Security.SvnUserNamePasswordEventArgs val)
                        {
                            val.UserName = textUserid.Text;
                            val.Password = textPassword.Text;
                            val.Save = true;
                        };


                    }
                    logMsg("Checking out from:");
                    logMsg(tbRepoURI.Text);

                    //this is the where 'svn checkout' actually happens.

                    if (client.CheckOut(target, path, args, out result))
                    {
                        MessageBox.Show("Successfully checked out revision " + result.Revision + ".");
                        logMsg("Successfully checked out revision " + result.Revision + ".");
                    }
                }
                catch (SvnException se)
                {
                    MessageBox.Show(textUserid.Text + " " + textPassword.Text + " " + se.Message,
                    "svn checkout error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    logMsg("svn error code: " + se.SubversionErrorCode);
                    logMsg("SvnErrorCategory: " + se.SvnErrorCategory);
                    logMsg(se.StackTrace);
                }
                catch (UriFormatException ufe)
                {
                    MessageBox.Show(ufe.Message,
                    "svn checkout error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        static void logMsg(string lines)
        {
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\svntemp\\log.txt",true);
            file.WriteLine(lines);
            file.Close();
        }

        static void SVN_SSL_Override(object sender, SharpSvn.Security.SvnSslServerTrustEventArgs e)
        {
            e.AcceptedFailures = e.Failures;
            e.Save = true;
        }
    }
}
