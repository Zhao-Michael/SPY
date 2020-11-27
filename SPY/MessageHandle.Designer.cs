using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SPY
{
    [DesignerGenerated()]
    public partial class MessageHandle : Form
    {

        // Form 重写 Dispose，以清理组件列表。
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Windows 窗体设计器所必需的
        private System.ComponentModel.IContainer components;

        // 注意: 以下过程是 Windows 窗体设计器所必需的
        // 可以使用 Windows 窗体设计器修改它。  
        // 不要使用代码编辑器修改它。
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageHandle));
            this.LabelHwnd = new System.Windows.Forms.Label();
            this._TextBoxHwnd = new System.Windows.Forms.TextBox();
            this.LabelMsgID = new System.Windows.Forms.Label();
            this._TextBoxMsgID = new System.Windows.Forms.TextBox();
            this.LabelWP = new System.Windows.Forms.Label();
            this._TextBoxLP = new System.Windows.Forms.TextBox();
            this.LabelLP = new System.Windows.Forms.Label();
            this._TextBoxWP = new System.Windows.Forms.TextBox();
            this._ButtonSend = new System.Windows.Forms.Button();
            this.CheckBoxAutoSync = new System.Windows.Forms.CheckBox();
            this.LabelHwnd16 = new System.Windows.Forms.Label();
            this.LabelMsg16 = new System.Windows.Forms.Label();
            this.LabelWP16 = new System.Windows.Forms.Label();
            this.LabelLP16 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LabelHwnd
            // 
            this.LabelHwnd.AutoSize = true;
            this.LabelHwnd.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelHwnd.Location = new System.Drawing.Point(29, 20);
            this.LabelHwnd.Name = "LabelHwnd";
            this.LabelHwnd.Size = new System.Drawing.Size(65, 19);
            this.LabelHwnd.TabIndex = 0;
            this.LabelHwnd.Text = "窗口句柄";
            // 
            // _TextBoxHwnd
            // 
            this._TextBoxHwnd.Font = new System.Drawing.Font("SimSun", 10F);
            this._TextBoxHwnd.Location = new System.Drawing.Point(19, 49);
            this._TextBoxHwnd.Name = "_TextBoxHwnd";
            this._TextBoxHwnd.Size = new System.Drawing.Size(81, 23);
            this._TextBoxHwnd.TabIndex = 1;
            this._TextBoxHwnd.TextChanged += new System.EventHandler(this.TextBoxHwnd_TextChanged);
            // 
            // LabelMsgID
            // 
            this.LabelMsgID.AutoSize = true;
            this.LabelMsgID.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelMsgID.Location = new System.Drawing.Point(185, 20);
            this.LabelMsgID.Name = "LabelMsgID";
            this.LabelMsgID.Size = new System.Drawing.Size(57, 19);
            this.LabelMsgID.TabIndex = 0;
            this.LabelMsgID.Text = "消息 ID";
            // 
            // _TextBoxMsgID
            // 
            this._TextBoxMsgID.Font = new System.Drawing.Font("SimSun", 10F);
            this._TextBoxMsgID.Location = new System.Drawing.Point(124, 49);
            this._TextBoxMsgID.Name = "_TextBoxMsgID";
            this._TextBoxMsgID.Size = new System.Drawing.Size(184, 23);
            this._TextBoxMsgID.TabIndex = 1;
            this._TextBoxMsgID.TextChanged += new System.EventHandler(this.TextBoxMsgID_TextChanged);
            // 
            // LabelWP
            // 
            this.LabelWP.AutoSize = true;
            this.LabelWP.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelWP.Location = new System.Drawing.Point(338, 20);
            this.LabelWP.Name = "LabelWP";
            this.LabelWP.Size = new System.Drawing.Size(66, 19);
            this.LabelWP.TabIndex = 0;
            this.LabelWP.Text = "wParam";
            // 
            // _TextBoxLP
            // 
            this._TextBoxLP.Font = new System.Drawing.Font("SimSun", 10F);
            this._TextBoxLP.Location = new System.Drawing.Point(328, 49);
            this._TextBoxLP.Name = "_TextBoxLP";
            this._TextBoxLP.Size = new System.Drawing.Size(86, 23);
            this._TextBoxLP.TabIndex = 1;
            this._TextBoxLP.Text = "0";
            this._TextBoxLP.TextChanged += new System.EventHandler(this.TextBoxLP_TextChanged);
            // 
            // LabelLP
            // 
            this.LabelLP.AutoSize = true;
            this.LabelLP.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelLP.Location = new System.Drawing.Point(446, 20);
            this.LabelLP.Name = "LabelLP";
            this.LabelLP.Size = new System.Drawing.Size(58, 19);
            this.LabelLP.TabIndex = 0;
            this.LabelLP.Text = "lParam";
            // 
            // _TextBoxWP
            // 
            this._TextBoxWP.Font = new System.Drawing.Font("SimSun", 10F);
            this._TextBoxWP.Location = new System.Drawing.Point(437, 49);
            this._TextBoxWP.Name = "_TextBoxWP";
            this._TextBoxWP.Size = new System.Drawing.Size(86, 23);
            this._TextBoxWP.TabIndex = 1;
            this._TextBoxWP.Text = "0";
            this._TextBoxWP.TextChanged += new System.EventHandler(this.TextBoxWP_TextChanged);
            // 
            // _ButtonSend
            // 
            this._ButtonSend.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._ButtonSend.Location = new System.Drawing.Point(416, 132);
            this._ButtonSend.Name = "_ButtonSend";
            this._ButtonSend.Size = new System.Drawing.Size(116, 33);
            this._ButtonSend.TabIndex = 2;
            this._ButtonSend.Text = "发送消息";
            this._ButtonSend.UseVisualStyleBackColor = true;
            this._ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // CheckBoxAutoSync
            // 
            this.CheckBoxAutoSync.AutoSize = true;
            this.CheckBoxAutoSync.Checked = true;
            this.CheckBoxAutoSync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxAutoSync.Location = new System.Drawing.Point(19, 147);
            this.CheckBoxAutoSync.Name = "CheckBoxAutoSync";
            this.CheckBoxAutoSync.Size = new System.Drawing.Size(98, 17);
            this.CheckBoxAutoSync.TabIndex = 3;
            this.CheckBoxAutoSync.Text = "自动同步句柄";
            this.CheckBoxAutoSync.UseVisualStyleBackColor = true;
            // 
            // LabelHwnd16
            // 
            this.LabelHwnd16.AutoSize = true;
            this.LabelHwnd16.Location = new System.Drawing.Point(23, 91);
            this.LabelHwnd16.Name = "LabelHwnd16";
            this.LabelHwnd16.Size = new System.Drawing.Size(0, 13);
            this.LabelHwnd16.TabIndex = 4;
            // 
            // LabelMsg16
            // 
            this.LabelMsg16.AutoSize = true;
            this.LabelMsg16.Location = new System.Drawing.Point(255, 25);
            this.LabelMsg16.Name = "LabelMsg16";
            this.LabelMsg16.Size = new System.Drawing.Size(0, 13);
            this.LabelMsg16.TabIndex = 4;
            // 
            // LabelWP16
            // 
            this.LabelWP16.AutoSize = true;
            this.LabelWP16.Location = new System.Drawing.Point(432, 84);
            this.LabelWP16.Name = "LabelWP16";
            this.LabelWP16.Size = new System.Drawing.Size(0, 13);
            this.LabelWP16.TabIndex = 4;
            // 
            // LabelLP16
            // 
            this.LabelLP16.AutoSize = true;
            this.LabelLP16.Location = new System.Drawing.Point(332, 84);
            this.LabelLP16.Name = "LabelLP16";
            this.LabelLP16.Size = new System.Drawing.Size(0, 13);
            this.LabelLP16.TabIndex = 4;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(324, 142);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Result";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(124, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 95);
            this.listBox1.TabIndex = 6;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // MessageHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(544, 183);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.LabelLP16);
            this.Controls.Add(this.LabelWP16);
            this.Controls.Add(this.LabelMsg16);
            this.Controls.Add(this.LabelHwnd16);
            this.Controls.Add(this.CheckBoxAutoSync);
            this.Controls.Add(this._ButtonSend);
            this.Controls.Add(this._TextBoxWP);
            this.Controls.Add(this.LabelLP);
            this.Controls.Add(this._TextBoxLP);
            this.Controls.Add(this.LabelWP);
            this.Controls.Add(this._TextBoxMsgID);
            this.Controls.Add(this.LabelMsgID);
            this.Controls.Add(this._TextBoxHwnd);
            this.Controls.Add(this.LabelHwnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageHandle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Handle";
            this.Activated += new System.EventHandler(this.MessageHandle_Activated);
            this.Load += new System.EventHandler(this.MessageHandle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Label LabelHwnd;
        private TextBox _TextBoxHwnd;

        internal TextBox TextBoxHwnd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxHwnd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxHwnd != null)
                {
                    _TextBoxHwnd.TextChanged -= TextBoxHwnd_TextChanged;
                }

                _TextBoxHwnd = value;
                if (_TextBoxHwnd != null)
                {
                    _TextBoxHwnd.TextChanged += TextBoxHwnd_TextChanged;
                }
            }
        }

        internal Label LabelMsgID;
        private TextBox _TextBoxMsgID;

        internal TextBox TextBoxMsgID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxMsgID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxMsgID != null)
                {
                    _TextBoxMsgID.TextChanged -= TextBoxMsgID_TextChanged;
                }

                _TextBoxMsgID = value;
                if (_TextBoxMsgID != null)
                {
                    _TextBoxMsgID.TextChanged += TextBoxMsgID_TextChanged;
                }
            }
        }

        internal Label LabelWP;
        private TextBox _TextBoxLP;

        internal TextBox TextBoxLP
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxLP;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxLP != null)
                {
                    _TextBoxLP.TextChanged -= TextBoxLP_TextChanged;
                }

                _TextBoxLP = value;
                if (_TextBoxLP != null)
                {
                    _TextBoxLP.TextChanged += TextBoxLP_TextChanged;
                }
            }
        }

        internal Label LabelLP;
        private TextBox _TextBoxWP;

        internal TextBox TextBoxWP
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxWP;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxWP != null)
                {
                    _TextBoxWP.TextChanged -= TextBoxWP_TextChanged;
                }

                _TextBoxWP = value;
                if (_TextBoxWP != null)
                {
                    _TextBoxWP.TextChanged += TextBoxWP_TextChanged;
                }
            }
        }

        private Button _ButtonSend;

        internal Button ButtonSend
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonSend;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonSend != null)
                {
                    _ButtonSend.Click -= ButtonSend_Click;
                }

                _ButtonSend = value;
                if (_ButtonSend != null)
                {
                    _ButtonSend.Click += ButtonSend_Click;
                }
            }
        }

        internal CheckBox CheckBoxAutoSync;
        internal Label LabelHwnd16;
        internal Label LabelMsg16;
        internal Label LabelWP16;
        internal Label LabelLP16;
        private Label labelResult;
        private ListBox listBox1;
    }
}