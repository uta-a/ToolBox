using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;


namespace SpamTool
{
    public partial class ToolBox : Form
    {
        private IInputSimulator leftClicktSimulator;
        private IInputSimulator rightClickSimulator;
        private IInputSimulator keyEvent;
        private Thread leftClickThread;
        private Thread rightClickThread;
        private Thread keyEventThread;
        private bool autoClicking;
        private bool keyboardEvent;
        private bool OnToolBox;
        private int timeoutLeft = 10;
        private int timeoutRight = 10;
        private int timeoutKey = 1;
        private string inputText;

        //Hot Key
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int AutoClickHotKeyLeft = 1;
        private const int AutoClickHotKeyRight = 2;
        private const int SpamHotKey = 3;

        //HotKeys
        private uint HotKeyLeft;
        private uint HotKeyRight;
        private uint HotKeySpam;




        public ToolBox()
        {
            InitializeComponent();

            //Mouse
            leftClicktSimulator = new InputSimulator();
            rightClickSimulator = new InputSimulator();
            keyEvent = new InputSimulator();
            leftClickThread = new Thread(() => AutoClickLeft());
            rightClickThread = new Thread(() => AutoClickRight());
            keyEventThread = new Thread(() => KeyEvent());
            autoClicking = false;
            keyboardEvent = false;

        }

        private void AutoClickLeft()
        {
            while (autoClicking)
            {
                if (!OnToolBox)
                {
                    if (LeftClick.Checked)
                    {
                        // マウスの左クリックをシミュレート
                        leftClicktSimulator.Mouse.LeftButtonClick();
                    }

                    // 連打の間隔（ミリ秒）
                    Thread.Sleep(1000 / timeoutLeft);
                }
            }
        }

        private void AutoClickRight()
        {
            while (autoClicking)
            {
                if (!OnToolBox)
                {
                    if (RightClick.Checked)
                    {
                        // マウスの右クリックをシミュレート
                        rightClickSimulator.Mouse.RightButtonClick();
                    }

                    // 連打の間隔（ミリ秒）
                    Thread.Sleep(1000 / timeoutRight);
                }
            }
        }

        private void KeyEvent()
        {
            while (keyboardEvent)
            {
                keyEvent.Keyboard.TextEntry(inputText);
                keyEvent.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);


                // 連打の間隔（ミリ秒）
                Thread.Sleep(1000 / timeoutKey);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            StartAutoClick();
        }

        private void StartAutoClick()
        {
            if (autoClicking)
            {
                autoClicking = false;
                Start1.Text = "Start AutoClick";
            }
            else
            {
                autoClicking = true;
                Start1.Text = "Stop AutoClick";

                // left
                leftClickThread = new Thread(() => AutoClickLeft());
                leftClickThread.Start();

                // right
                rightClickThread = new Thread(() => AutoClickRight());
                rightClickThread.Start();
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == AutoClickHotKeyLeft)
            {
                if (!LeftClick.Checked)
                {
                    LeftClick.Checked = true;
                }
                else
                {
                    LeftClick.Checked = false;
                }
            }

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == AutoClickHotKeyRight)
            {
                if (!RightClick.Checked)
                {
                    RightClick.Checked = true;
                }
                else
                {
                    RightClick.Checked = false;
                }

            }

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == SpamHotKey)
            {
                if (!runKey.Checked)
                {
                    runKey.Checked = true;
                }
                else
                {
                    runKey.Checked = false;
                }
            }

        }

        private void ToolBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ホットキーの登録解除
            UnregisterHotKey(Handle, AutoClickHotKeyLeft);
            UnregisterHotKey(Handle, AutoClickHotKeyRight);
            UnregisterHotKey(Handle, SpamHotKey);
        }

        private void ShowKey_KeyDown(object sender, KeyEventArgs e)
        {
            ShowKeyLeft.Text = e.KeyData.ToString();
            HotKeyLeft = (uint)e.KeyValue;

            this.ActiveControl = null;
        }

        private void ToolBox_MouseHover(object sender, EventArgs e)
        {
            OnToolBox = true;
        }

        private void ToolBox_MouseLeave(object sender, EventArgs e)
        {
            OnToolBox = false;
        }

        private void HotKeySetLeft_Click(object sender, EventArgs e)
        {
            uint mode = 0;
            if (ShiftLeft.Checked)
            {
                mode = 4;
            }
            else if (AltLeft.Checked)
            {
                mode = 1;
            }
            else if (CtrlLeft.Checked)
            {
                mode = 2;
            }

            RegisterHotKey(Handle, AutoClickHotKeyLeft, mode, HotKeyLeft);

            MessageBox.Show("ホットキーを保存しました");
        }

        private void ResetHotKeyLeft_Click(object sender, EventArgs e)
        {
            //ホットキーの登録解除
            UnregisterHotKey(Handle, AutoClickHotKeyLeft);

            ShowKeyLeft.Text = "";
            ShiftLeft.Checked = false;
            AltLeft.Checked = false;
            CtrlLeft.Checked = false;

            MessageBox.Show("ホットキーを削除しました");
        }

        private void HotKeySetRight_Click(object sender, EventArgs e)
        {
            uint mode = 0;
            if (ShiftRight.Checked)
            {
                mode = 4;
            }
            else if (AltRight.Checked)
            {
                mode = 1;
            }
            else if (CtrlRight.Checked)
            {
                mode = 2;
            }

            RegisterHotKey(Handle, AutoClickHotKeyRight, mode, HotKeyRight);

            MessageBox.Show("ホットキーを保存しました");
        }

        private void ResetHotKeyRight_Click(object sender, EventArgs e)
        {
            //ホットキーの登録解除
            UnregisterHotKey(Handle, AutoClickHotKeyRight);

            ShowKeyLeft.Text = "";
            ShiftRight.Checked = false;
            AltRight.Checked = false;
            CtrlRight.Checked = false;

            MessageBox.Show("ホットキーを削除しました");
        }

        private void ShowKeyRight_KeyDown(object sender, KeyEventArgs e)
        {
            ShowKeyRight.Text = e.KeyData.ToString();
            HotKeyRight = (uint)e.KeyValue;

            this.ActiveControl = null;
        }

        private void ShiftLeft_CheckedChanged(object sender, EventArgs e)
        {
            AltLeft.Checked = false;
            CtrlLeft.Checked = false;
        }

        private void AltLeft_CheckedChanged(object sender, EventArgs e)
        {
            ShiftLeft.Checked = false;
            CtrlLeft.Checked = false;
        }

        private void CtrlLeft_CheckedChanged(object sender, EventArgs e)
        {
            ShiftLeft.Checked = false;
            AltLeft.Checked = true;
        }

        private void ShiftRight_CheckedChanged(object sender, EventArgs e)
        {
            AltRight.Checked = false;
            CtrlRight.Checked = false;
        }

        private void AltRight_CheckedChanged(object sender, EventArgs e)
        {
            ShiftRight.Checked = false;
            CtrlRight.Checked = false;
        }

        private void CtrlRight_CheckedChanged(object sender, EventArgs e)
        {
            ShiftRight.Checked = false;
            AltRight.Checked = false;
        }

        private void CPS_LEFT_Scroll(object sender, EventArgs e)
        {
            CPS_L.Text = CPS_LEFT_VOL.Value.ToString() + "CPS";
            timeoutLeft = CPS_LEFT_VOL.Value;
        }

        private void CPS_R_VOL_Scroll(object sender, EventArgs e)
        {
            CPS_R.Text = CPS_R_VOL.Value.ToString() + "CPS";
            timeoutRight = CPS_R_VOL.Value;
        }

        private void SpamKey_KeyDown(object sender, KeyEventArgs e)
        {
            SpamKey.Text = e.KeyData.ToString();
            HotKeySpam = (uint)e.KeyValue;

            this.ActiveControl = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint mode = 0;
            if (SpamShift.Checked)
            {
                mode = 4;
            }
            else if (SpamAlt.Checked)
            {
                mode = 1;
            }
            else if (SpamCtrl.Checked)
            {
                mode = 2;
            }

            RegisterHotKey(Handle, SpamHotKey, mode, HotKeySpam);

            MessageBox.Show("ホットキーを保存しました");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ホットキーの登録解除
            UnregisterHotKey(Handle, SpamHotKey);

            SpamKey.Text = "";
            SpamShift.Checked = false;
            SpamAlt.Checked = false;
            SpamCtrl.Checked = false;

            MessageBox.Show("ホットキーを削除しました");
        }

        private void SpamShift_CheckedChanged(object sender, EventArgs e)
        {
            SpamAlt.Checked = false;
            SpamCtrl.Checked = false;
        }

        private void SpamAlt_CheckedChanged(object sender, EventArgs e)
        {
            SpamShift.Checked = false;
            SpamCtrl.Checked = false;
        }

        private void SpamCtrl_CheckedChanged(object sender, EventArgs e)
        {
            SpamShift.Checked = false;
            SpamAlt.Checked = false;
        }

        private void KEY_EVENT_Scroll(object sender, EventArgs e)
        {
            timeoutKey = KEY_EVENT.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!keyboardEvent)
            {
                keyboardEvent = true;
                keyEventThread = new Thread(() => KeyEvent());
                keyEventThread.Start();
            }
            else
            {
                keyboardEvent = false;
            }
        }

        private void SpamText_TextChanged(object sender, EventArgs e)
        {
            inputText = SpamText.Text;
        }
    }
}
