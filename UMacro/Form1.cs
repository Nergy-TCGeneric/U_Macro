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
using Hook;

namespace UMacro
{
    public partial class Form1 : Form
    {
        private bool isRecording = false;
        private DateTime prevEventTime = DateTime.Now;
        private const int stub_recInterval = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void recordMouseMacro_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                isRecording = false;
                recordMouseMacro.Text = "마우스 기록 시작";
                MouseHook.StopHook();
            }
            else
            {
                isRecording = true;
                recordMouseMacro.Text = "마우스 기록 중지";
                MouseHook.startHook();
                // Thread moveThread = new Thread(new ThreadStart(recordMouseMovement));
            }
        }

        private void clickEvent(object sender, MouseHook.HookEventArgs e)
        {
           // procedureList.Items.Add()
           if(e.invokedTime.Subtract(prevEventTime) >= 10)

        }
    }
}
