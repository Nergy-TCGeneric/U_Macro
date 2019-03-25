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

        private void recordMacro_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                isRecording = false;
                recordMacro.Text = "기록 시작";
                MouseHook.StopHook();
            }
            else
            {
                isRecording = true;
                recordMacro.Text = "기록 중지";
                MouseHook.startHook();
                MouseHook.mouseEvent += mouseEvent;
            }
        }

        private void mouseEvent(object sender, MouseHook.MouseHookEventArgs e)
        {
            // TODO: Make it more fancier.
            procedureList.Items.Add(e);
        }

        private void keyboardEvent(object sender, KeyboardHook.KeyboardHookEventArgs e)
        {
            // TODO: Make it more fancier.
            procedureList.Items.Add(e);
        }

        private void exportToFile_Click(object sender, EventArgs e)
        {

        }

        private void deleteSelectedMacro_Click(object sender, EventArgs e)
        {
            if(procedureList.SelectedIndex > -1)
                procedureList.Items.RemoveAt(procedureList.SelectedIndex);
        }
    }
}
