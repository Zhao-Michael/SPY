using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SPY.My.Resources;

namespace SPY
{
    public partial class MessageHandle
    {
        Dictionary<string, int> msgMapping = new Dictionary<string, int>();

        public MessageHandle()
        {
            InitializeComponent();
            _TextBoxHwnd.Name = "TextBoxHwnd";
            _TextBoxMsgID.Name = "TextBoxMsgID";
            _TextBoxLP.Name = "TextBoxLP";
            _TextBoxWP.Name = "TextBoxWP";
            _ButtonSend.Name = "ButtonSend";


            var mapping = Encoding.ASCII.GetString(Resources.WinMessageMapping);

            foreach (var item in mapping.Split('\n'))
            {
                if (!string.IsNullOrWhiteSpace(item) && item.Contains(","))
                {
                    var key = item.Split(',')[0];
                    var value = int.Parse(item.Split(',')[1]);
                    if (!msgMapping.ContainsKey(key))
                        msgMapping.Add(key, value);
                }
            }
        }

        private void MessageHandle_Load(object sender, EventArgs e)
        {
            SpyForm.Intance.HwndChanged += GetMainHwnd;
        }

        private void MessageHandle_Activated(object sender, EventArgs e)
        {
            GetMainHwnd();
        }

        public void GetMainHwnd()
        {
            if (CheckBoxAutoSync.Checked)
            {
                TextBoxHwnd.Text = SpyForm.Intance.textBoxHwnd.Text;
            }
        }

        private void TextBoxHwnd_TextChanged(object sender, EventArgs e)
        {
            int hex = 0;
            int.TryParse(TextBoxHwnd.Text, out hex);
            LabelHwnd16.Text = "0x" + Convert.ToString(hex, 16);
        }

        private void TextBoxMsgID_TextChanged(object sender, EventArgs e)
        {

            updateListView();

            if (TextBoxMsgID.Text.StartsWith("WM"))
            {
                if (msgMapping.ContainsKey(TextBoxMsgID.Text))
                {
                    LabelMsg16.Text = "0x" + Convert.ToString(msgMapping[TextBoxMsgID.Text], 16);
                }
            }
            else
            {
                int hex = 0;
                int.TryParse(TextBoxMsgID.Text, out hex);
                LabelMsg16.Text = "0x" + Convert.ToString(hex, 16);
            }
        }

        private void updateListView()
        {
            listBox1.Items.Clear();
            var str = TextBoxMsgID.Text;
            foreach (var item in msgMapping)
            {
                if (item.Key.Contains(str.ToUpper()))
                {
                    listBox1.Items.Add(item.Key);
                }
            }
        }

        private void TextBoxLP_TextChanged(object sender, EventArgs e)
        {
            int hex = 0;
            int.TryParse(TextBoxLP.Text, out hex);
            LabelLP16.Text = "0x" + Convert.ToString(hex, 16);
        }

        private void TextBoxWP_TextChanged(object sender, EventArgs e)
        {
            int hex = 0;
            int.TryParse(TextBoxWP.Text, out hex);
            LabelWP16.Text = "0x" + Convert.ToString(hex, 16);
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            try
            {
                labelResult.ResetText();
                var hwnd = 0;
                if (msgMapping.ContainsKey(_TextBoxMsgID.Text))
                {
                    hwnd = msgMapping[_TextBoxMsgID.Text];
                }
                else
                {
                    hwnd = Conversions.ToInteger(TextBoxMsgID.Text);
                }

                long result = SpyAPI.SendMessage(Conversions.ToInteger(TextBoxHwnd.Text), hwnd, Conversions.ToInteger(TextBoxLP.Text), Conversions.ToInteger(TextBoxWP.Text));
                labelResult.Text = "Result:  " + result + "  ( 0x" + Convert.ToString(result, 16) + " )";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                TextBoxMsgID.Text = listBox1.SelectedItem.ToString();
                LabelMsg16.Text = "0x" + Convert.ToString(msgMapping[TextBoxMsgID.Text], 16);
            }
        }
    }
}