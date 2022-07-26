using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPY
{
    public partial class HexConvert : Form
    {
        public HexConvert()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 字符串转换为 16 进制字符串
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static string HexEncode(string txt)
        {
            var bs = Encoding.UTF8.GetBytes(txt);
            return BitConverter.ToString(bs).Replace("-", "");
        }

        /// <summary>
        /// 16 进制字符串转换为字符串
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static string HexDecode(string txt)
        {
            if (txt.Length % 2 != 0)
                return null;

            var bs = new byte[txt.Length / 2];
            var sb = new StringBuilder("  ", 2);
            for (int i = 0, j = 0; i < txt.Length; i += 2, j++)
            {
                sb[0] = txt[i];
                sb[1] = txt[i + 1];
                bs[j] = Convert.ToByte(sb.ToString(), 16);
            }

            return Encoding.UTF8.GetString(bs);
        }

        private void labelHex_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxText.Text = HexDecode(textBoxHex.Text);
            }
            catch (Exception)
            {
                textBoxText.Clear();
            }
        }

        private void labelText_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxHex.Text = HexEncode(textBoxText.Text);
            }
            catch (Exception)
            {
                textBoxHex.Clear();
            }
        }

        private void pictureBoxText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxText.Text);
        }

        private void pictureBoxHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxHex.Text);
        }
    }
}
