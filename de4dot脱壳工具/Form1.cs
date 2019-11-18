using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de4dot反编译工具
{
    public partial class Form1 : CCSkinMain
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void skinB_Run_Click(object sender, EventArgs e)
        {
            this.skinTB_Msg.Text = "反编译中,请等待...";
            if (this.skinTB_Address.Text.IsEmpty())
            {
                this.skinTB_Msg.Text = "请选择反编译文件"; 
                return; 
            }
            if (this.skinCB_Type.Text.IsEmpty()) 
            {
                this.skinTB_Msg.Text = "请选择反编译类型";
                return;
            }
            string dot = $@"{AppDomain.CurrentDomain.BaseDirectory}de4dot\de4dot.exe";
            if (!File.Exists(dot))
            {
                this.skinTB_Msg.Text = "系统不完整请检查";
                return;
            }
            string put = Cmd.RunCmd($@"{AppDomain.CurrentDomain.BaseDirectory}de4dot\de4dot {this.skinTB_Address.Text} -p {this.skinCB_Type.Text.Split('#')[0]}");    //执行命令
            this.skinTB_Msg.Text = put;
        }

        private void skinB_View_Click(object sender, EventArgs e)
        {OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "系统文件(*.dll;*.exe;)|*.dll;*.exe;";
            dialog.Multiselect = false;
            dialog.Title = "选择反编译的文件";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.skinTB_Address.Text = dialog.FileName;
            }

        }
    }
}
