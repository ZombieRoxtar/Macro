using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Macro
{
    public partial class FormMain : Form
    {
        Keys HotKey = Keys.None;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, Keys vlc);

        public FormMain()
        {
            InitializeComponent();
        }
        
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x312)//0x312 = WM_HOTKEY
            {
                macroIt();
            }
            base.WndProc(ref m);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (checkBoxHotKey.Checked == true)
            {
                if ((Control.ModifierKeys == Keys.Shift) ||
                    (Control.ModifierKeys == Keys.ShiftKey) ||
                    (Control.ModifierKeys == Keys.Control) ||
                    (Control.ModifierKeys == Keys.ControlKey)||
                    (Control.ModifierKeys == Keys.Alt))
                {
                    checkBoxHotKey.Text = "(None)";
                    HotKey = Keys.None;
                }
                else
                {
                    checkBoxHotKey.Text = keyData.ToString();
                    HotKey = keyData;
                }
                checkBoxHotKey.Checked = false;
                RegisterHotKey(this.Handle, 0, 0, HotKey);
            }
            return false;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            macroIt();
        }

        private void macroIt()
        {
            int num = 0;
            if (!int.TryParse(textBoxWait.Text, out num))
            {
                textBoxWait.Text = "0";
            }
            if (!int.TryParse(textBoxLoops.Text, out num))
            {
                textBoxLoops.Text = "1";
            }
            if (!int.TryParse(textBoxPause.Text, out num))
            {
                textBoxPause.Text = "0";
            }
            System.Threading.Thread.Sleep(int.Parse(textBoxWait.Text));
            for (int i = 0; i < int.Parse(textBoxLoops.Text); i++)
            {
                SendKeys.Send(textBoxMarco.Text);
                System.Threading.Thread.Sleep(int.Parse(textBoxPause.Text));
            }
        }
    }
}
