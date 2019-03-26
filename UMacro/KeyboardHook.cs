using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMacro;

namespace Hook
{
    public class KeyboardHook : Hook
    {
        private static int hookHandle = 0;
        private static HookProc callBackDelegate;
        private static KeyboardHookEventArgs latestEvent;

        public static event EventHandler<KeyboardHookEventArgs> keyboardEvent = delegate { };

        public class KeyboardHookEventArgs : EventArgs
        {
            public KeyboardMessages type;
            public int KeyCode;
            public DateTime invokedTime;

            public override string ToString() {
                string prefix = "(키보드) ";
                if (type == KeyboardMessages.WM_KEYDOWN)
                    return String.Format(prefix + "{0} 눌림", (Keys)KeyCode);
                else if (type == KeyboardMessages.WM_KEYUP)
                    return String.Format(prefix + "{0} 뗌", (Keys)KeyCode);
                return base.ToString();
            }
        }
        
        public enum KeyboardMessages
        {
            WM_KEYDOWN = 0x0100,
            WM_KEYUP = 0x0101
        }

        public static void startHook()
        {
            if (callBackDelegate == null)
                callBackDelegate = new HookProc(CallBack);

            if (hookHandle != 0)
            {
                return;
            }
            hookHandle = SetWindowsHookEx(WH_KEYBOARD_LL, callBackDelegate, IntPtr.Zero, 0);
            Console.WriteLine(hookHandle);
        }

        public static void StopHook()
        {
            UnhookWindowsHookEx(hookHandle);
            hookHandle = 0;
            callBackDelegate = null;
        }

        public static int CallBack(int nCode, IntPtr wParam, IntPtr IParam)
        {
           if(nCode >= 0)
            {
                int keyCode = Marshal.ReadInt32(IParam);
                KeyboardHookEventArgs args = new KeyboardHookEventArgs();
                args.KeyCode = keyCode;
                args.invokedTime = DateTime.Now;

                if (wParam == (IntPtr)KeyboardMessages.WM_KEYUP)
                    args.type = KeyboardMessages.WM_KEYUP;
                else if (wParam == (IntPtr)KeyboardMessages.WM_KEYDOWN)
                    args.type = KeyboardMessages.WM_KEYDOWN;
                else 
                    args.type = (KeyboardMessages)wParam;

                if(latestEvent == null) {
                    latestEvent = args;
                }

                /*
                TimeSpan diff = args.invokedTime.Subtract(latestEvent.invokedTime);
                if (diff.CompareTo(new TimeSpan(0, 0, 0, 0, Form1.getKeyboardRecordInterval())) >= 0)
                {
                    args.diff = diff.Subtract(new TimeSpan(0, 0, 0, 0, Form1.getKeyboardRecordInterval()));
                    keyboardEvent(null, args);
                    latestEvent = args;
                }
                */
                keyboardEvent(null, args);
                latestEvent = args;
            }
            return CallNextHookEx(hookHandle, nCode, wParam, IParam);
        }

        public static int getHookHandle() { return hookHandle; }
    }
}
