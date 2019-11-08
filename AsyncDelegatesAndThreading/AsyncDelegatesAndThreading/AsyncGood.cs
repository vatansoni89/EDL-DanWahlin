using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsAndDelegates
{
    public partial class AsyncGood : Form
    {
        delegate void StartProcessDelegate(int val);
        delegate void ShowProgressDelegate(int val);

        public AsyncGood()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            Application.Run(new AsyncGood());
        }

        private void StartButton_Click(object sender, System.EventArgs e)
        {
            StartProcessDelegate progDel = new StartProcessDelegate(StartProcess);
            progDel.BeginInvoke(100, null, null);
            MessageBox.Show("Done with operation Good!!");

        }

        //Called Asynchronously
        private void StartProcess(int max)
        {
            ShowProgress(0);
            for (int i = 0; i <= max; i++)
            {
                Thread.Sleep(10);
                ShowProgress(i);
            }
        }

        private void ShowProgress(int i)
        {
            //the if block execute in case a background thread hit here.
            //background thread
            if (lblOutput.InvokeRequired==true)
            {
                var del = new ShowProgressDelegate(ShowProgress);

                //Switch from background to GUI (Main) thread
                //this.BeginInvoke(..)
                this.BeginInvoke(del, new object[]
                {
                    i
                });
            }
            else //Its on GUI thread.
            {
                lblOutput.Text = i.ToString();
                pbStatus.Value = i;
            }
        }

    }
}
