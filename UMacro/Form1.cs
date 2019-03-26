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
using WindowsInput;
using System.Xml.Serialization;
using System.IO;

namespace UMacro
{
    public partial class Form1 : Form
    {
        private bool isRecording = false;
        private static int mRecordIntv;
        private static int kRecordIntv;
        private static int pIntv;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pIntv = getIntervalFromControls(playInterval.Text);
            mRecordIntv = getIntervalFromControls(mouseRecordInterval.Text);
            kRecordIntv = getIntervalFromControls(keyboardRecordInterval.Text);

            KeyboardHook.startHook();
            KeyboardHook.keyboardEvent += keyboardEventForForm;
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
                playBtn.Enabled = true;
                recordMacro.Text = "기록 시작";
                MouseHook.StopHook();
                MouseHook.mouseEvent -= mouseEvent;
                KeyboardHook.keyboardEvent -= keyboardEvent;
            }
            else
            {
                isRecording = true;
                playBtn.Enabled = false;
                recordMacro.Text = "기록 중지";
                procedureList.Items.Clear();
                MouseHook.startHook();
                MouseHook.mouseEvent += mouseEvent;
                KeyboardHook.keyboardEvent += keyboardEvent;
            }
        }

        private void playMacro()
        {
            if (!isRecording)
            {
                recordMacro.Enabled = false;
                playInterval.Enabled = false;
                InputSimulator inputSim = new InputSimulator();

                // Doesn't look good. CLARIFY DATA TYPE IMMEDIATELY!
                foreach (object events in procedureList.Items)
                {
                    Thread.Sleep(pIntv);
                    if (events is MouseHook.MouseHookEventArgs)
                    {
                        MouseHook.MouseHookEventArgs mEvent = (MouseHook.MouseHookEventArgs)events;
                        Console.WriteLine(mEvent.type);
                        Cursor = new Cursor(Cursor.Current.Handle);

                        if (mEvent.type == MouseHook.MouseMessages.WM_MOUSEMOVE)
                        {
                            Cursor.Position = new Point(mEvent.X, mEvent.Y);
                        }
                        else
                        {
                            MouseHook.processClick(mEvent.type, mEvent.X, mEvent.Y);
                        }
                    }
                    else if (events is KeyboardHook.KeyboardHookEventArgs)
                    {
                        KeyboardHook.KeyboardHookEventArgs kEvent = (KeyboardHook.KeyboardHookEventArgs)events;
                        // Assuming that every kEvent is KeyDown event...

                    }
                    else if (events is Delay)
                    {
                        Delay dEvent = (Delay)events;
                        Thread.Sleep(dEvent.delayTimeSpan);
                    }
                }
                recordMacro.Enabled = true;
                playInterval.Enabled = true;
            }
        }

        private void mouseEvent(object sender, MouseHook.MouseHookEventArgs e)
        {
            procedureList.Items.Add(e);
            procedureList.Items.Add(new Delay(e.diff));
        }

        private void keyboardEvent(object sender, KeyboardHook.KeyboardHookEventArgs e)
        {
            if (e.KeyCode != 119)
            {
                procedureList.Items.Add(e);
                procedureList.Items.Add(new Delay(e.diff));
            }
        }

        private void keyboardEventForForm(object sender, KeyboardHook.KeyboardHookEventArgs e)
        {
            if (e.KeyCode == 119) {
                toggleRecord();
            }
            else if (e.KeyCode == 120) {
                playMacro();
            }
        }

        // TODO: Serialize into any type. XML or binary.. whatever is ok.
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

        // TODO: Make new windows, and make user can change its macro.
        private void modifySelectedMacro_Click(object sender, EventArgs e)
        {

        }

        private void importFromFile_Click(object sender, EventArgs e)
        {

        }

        private void playBtn_Click(object sender, EventArgs e) {
            playMacro();
        }

        private int getIntervalFromControls(String ctrText)
        {
            try
            {
                int parsed = Int32.Parse(ctrText);
                if (parsed > 0)
                    return parsed;
                throw new FormatException();
            }
            catch(FormatException)
            {
                MessageBox.Show("간격은 숫자이고 0ms보다 커야 합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // TODO: substitute with class constants as 'default value'
                return 33;
            }
        }

        public static int getMouseRecordInterval() { return mRecordIntv; }
        public static int getKeyboardRecordInterval() { return kRecordIntv;  }

        private void mouseRecordInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) {
                mRecordIntv = getIntervalFromControls(mouseRecordInterval.Text);
            }
        }

        private void playInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                pIntv = getIntervalFromControls(playInterval.Text);
        }

        private void keyboardRecordInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                kRecordIntv = getIntervalFromControls(keyboardRecordInterval.Text);
        }
    }
}
 