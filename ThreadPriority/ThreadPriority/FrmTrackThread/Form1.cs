using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FrmTrackThread
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");

            ThreadClass threadClass = new ThreadClass();

            Thread threadA = new Thread(new ThreadStart(threadClass.Thread1));
            Thread threadB = new Thread(new ThreadStart(threadClass.Thread2));
            Thread threadC = new Thread(new ThreadStart(threadClass.Thread1));
            Thread threadD = new Thread(new ThreadStart(threadClass.Thread2));

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Name = "Thread A Process";        
            threadB.Name = "Thread B Process";
            threadC.Name = "Thread C Process";
            threadD.Name = "Thread D Process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            lblThread.Text = "-End Thread-";
            Console.WriteLine("-End Thread-");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblThread_Click(object sender, EventArgs e)
        {

        }
    }
}
