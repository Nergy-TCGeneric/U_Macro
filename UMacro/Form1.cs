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
using System.Xml.Serialization;
using System.IO;

namespace UMacro
{
    public partial class Form1 : Form
    {
        private bool isRecording = false;
        // private bool isPlaying = false;
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
            Console.WriteLine(procedureList.SelectedItem);
        }

        private void recordMacro_Click(object sender, EventArgs e) {
            toggleRecord();
        }

        private void toggleRecord()
        {
            if (isRecording)
            {
                isRecording = false;
                recordMacro.Text = "기록 시작";
                MouseHook.StopHook();
                KeyboardHook.StopHook();
                MouseHook.mouseEvent -= mouseEvent;
                KeyboardHook.keyboardEvent -= keyboardEvent;
            }
            else
            {
                isRecording = true;
                recordMacro.Text = "기록 중지";
                procedureList.Items.Clear();
                MouseHook.startHook();
                MouseHook.mouseEvent += mouseEvent;
                KeyboardHook.startHook();
                KeyboardHook.keyboardEvent += keyboardEvent;
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
                // Doesn't look good. CLARIFY DATA TYPE IMMEDIATELY!
                foreach(object eventArgs in procedureList.Items)
                {
                    Thread.Sleep(33);
                    if(eventArgs is MouseHook.MouseHookEventArgs)
                    {
                        MouseHook.MouseHookEventArgs mEvent = (MouseHook.MouseHookEventArgs) eventArgs;
                        Console.WriteLine(mEvent.type);
                        Cursor = new Cursor(Cursor.Current.Handle);

                        if(mEvent.type == MouseHook.MouseMessages.WM_MOUSEMOVE) {
                            Cursor.Position = new Point(mEvent.X, mEvent.Y);
                        }
                        else {
                            MouseHook.processClick(mEvent.type, mEvent.X, mEvent.Y);
                        }
                    }
                    else if(eventArgs is KeyboardHook.KeyboardHookEventArgs)
                    {
                        KeyboardHook.KeyboardHookEventArgs kEvent = (KeyboardHook.KeyboardHookEventArgs) eventArgs;
                        Console.WriteLine((Keys)kEvent.KeyCode);
                    }
                }
                recordMacro.Enabled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Pressed Keyboard: " + e.KeyCode);
            Console.WriteLine("Pressed Keyboard raw: " + e.KeyValue);
            // F8 for 119, F9 for 120
            if(e.KeyValue == 119) {
                toggleRecord();
            }
        }
    }
}
 