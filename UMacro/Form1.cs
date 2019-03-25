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
        private bool isPlaying = false;
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

        private void InsertMacroProcedure_Click(object sender, EventArgs e)
        {
            // TODO: Make new windows.
            // TODO: Users can specifiy type, other details and can insert macro to procedureList.

        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if(!isRecording)
            {
                recordMacro.Enabled = false;
                foreach(object eventArgs in procedureList.Items) {
                    if(eventArgs is MouseHook.MouseHookEventArgs)
                    {
                        this.Cursor = new Cursor(Cursor.Current.Handle);
                        MouseHook.MouseHookEventArgs mEvent = (MouseHook.MouseHookEventArgs) eventArgs;
                        this.Cursor.Position = new Point(mEvent.X, mEvent.Y);

                    }
                    else if(eventArgs is KeyboardHook.KeyboardHookEventArgs)
                    {

                    }
                }
            }
        }
    }
}
 