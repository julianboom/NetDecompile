namespace de4dot反编译工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skinB_Run = new CCWin.SkinControl.SkinButtom();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinTB_Address = new CCWin.SkinControl.SkinTextBox();
            this.skinCB_Type = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinB_View = new CCWin.SkinControl.SkinButtom();
            this.skinTB_Msg = new CCWin.SkinControl.SkinTextBox();
            this.SuspendLayout();
            // 
            // skinB_Run
            // 
            this.skinB_Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinB_Run.BackColor = System.Drawing.Color.Transparent;
            this.skinB_Run.BaseColor = System.Drawing.Color.BlueViolet;
            this.skinB_Run.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinB_Run.DownBack = null;
            this.skinB_Run.Location = new System.Drawing.Point(517, 66);
            this.skinB_Run.MouseBack = null;
            this.skinB_Run.Name = "skinB_Run";
            this.skinB_Run.NormlBack = null;
            this.skinB_Run.Size = new System.Drawing.Size(75, 23);
            this.skinB_Run.TabIndex = 0;
            this.skinB_Run.Text = "运行";
            this.skinB_Run.UseVisualStyleBackColor = false;
            this.skinB_Run.Click += new System.EventHandler(this.skinB_Run_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(15, 38);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "文件地址：";
            // 
            // skinTB_Address
            // 
            this.skinTB_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTB_Address.BackColor = System.Drawing.Color.Transparent;
            this.skinTB_Address.Icon = null;
            this.skinTB_Address.IconIsButton = false;
            this.skinTB_Address.IsPasswordChat = '\0';
            this.skinTB_Address.IsSystemPasswordChar = false;
            this.skinTB_Address.Lines = new string[0];
            this.skinTB_Address.Location = new System.Drawing.Point(74, 33);
            this.skinTB_Address.Margin = new System.Windows.Forms.Padding(0);
            this.skinTB_Address.MaxLength = 32767;
            this.skinTB_Address.MinimumSize = new System.Drawing.Size(0, 28);
            this.skinTB_Address.MouseBack = null;
            this.skinTB_Address.Multiline = false;
            this.skinTB_Address.Name = "skinTB_Address";
            this.skinTB_Address.NormlBack = null;
            this.skinTB_Address.Padding = new System.Windows.Forms.Padding(5);
            this.skinTB_Address.ReadOnly = true;
            this.skinTB_Address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTB_Address.Size = new System.Drawing.Size(518, 28);
            this.skinTB_Address.TabIndex = 2;
            this.skinTB_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTB_Address.WaterColor = System.Drawing.Color.DarkGray;
            this.skinTB_Address.WaterText = "";
            this.skinTB_Address.WordWrap = true;
            // 
            // skinCB_Type
            // 
            this.skinCB_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCB_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCB_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skinCB_Type.FormattingEnabled = true;
            this.skinCB_Type.Items.AddRange(new object[] {
            "un#(Unknown)",
            "bl#(Babel .NET)",
            "cf#(CodeFort)",
            "cv#(CodeVeil)",
            "cw#(CodeWall)",
            "co#(Crypto Obfuscator)",
            "ds#(DeepSea)",
            "df#(Dotfuscator)",
            "dr3#(.NET Reactor)",
            "dr4#(.NET Reactor)",
            "ef#(Eazfuscator.NET)",
            "go#(Goliath.NET)",
            "il#(ILProtector)",
            "mc#(MaxtoCode)",
            "mp#(MPRESS)",
            "rm#(Rummage)",
            "sk#(Skater .NET)",
            "sa#(SmartAssembly)",
            "sn#(Spices.Net)",
            "xc#(Xenocode)"});
            this.skinCB_Type.Location = new System.Drawing.Point(74, 64);
            this.skinCB_Type.Name = "skinCB_Type";
            this.skinCB_Type.Size = new System.Drawing.Size(121, 22);
            this.skinCB_Type.TabIndex = 3;
            this.skinCB_Type.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(13, 66);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 17);
            this.skinLabel2.TabIndex = 4;
            this.skinLabel2.Text = "解密类别：";
            // 
            // skinB_View
            // 
            this.skinB_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinB_View.BackColor = System.Drawing.Color.Transparent;
            this.skinB_View.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinB_View.DownBack = null;
            this.skinB_View.Location = new System.Drawing.Point(436, 66);
            this.skinB_View.MouseBack = null;
            this.skinB_View.Name = "skinB_View";
            this.skinB_View.NormlBack = null;
            this.skinB_View.Size = new System.Drawing.Size(75, 23);
            this.skinB_View.TabIndex = 5;
            this.skinB_View.Text = "浏览";
            this.skinB_View.UseVisualStyleBackColor = false;
            this.skinB_View.Click += new System.EventHandler(this.skinB_View_Click);
            // 
            // skinTB_Msg
            // 
            this.skinTB_Msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTB_Msg.BackColor = System.Drawing.Color.Transparent;
            this.skinTB_Msg.Icon = null;
            this.skinTB_Msg.IconIsButton = false;
            this.skinTB_Msg.IsPasswordChat = '\0';
            this.skinTB_Msg.IsSystemPasswordChar = false;
            this.skinTB_Msg.Lines = new string[] {
        "日志"};
            this.skinTB_Msg.Location = new System.Drawing.Point(3, 92);
            this.skinTB_Msg.Margin = new System.Windows.Forms.Padding(0);
            this.skinTB_Msg.MaxLength = 32767;
            this.skinTB_Msg.MinimumSize = new System.Drawing.Size(0, 28);
            this.skinTB_Msg.MouseBack = null;
            this.skinTB_Msg.Multiline = true;
            this.skinTB_Msg.Name = "skinTB_Msg";
            this.skinTB_Msg.NormlBack = null;
            this.skinTB_Msg.Padding = new System.Windows.Forms.Padding(5);
            this.skinTB_Msg.ReadOnly = false;
            this.skinTB_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.skinTB_Msg.Size = new System.Drawing.Size(594, 305);
            this.skinTB_Msg.TabIndex = 6;
            this.skinTB_Msg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTB_Msg.WaterColor = System.Drawing.Color.DarkGray;
            this.skinTB_Msg.WaterText = "";
            this.skinTB_Msg.WordWrap = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.skinTB_Msg);
            this.Controls.Add(this.skinB_View);
            this.Controls.Add(this.skinCB_Type);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinTB_Address);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinB_Run);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "de4dot反编译工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButtom skinB_Run;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox skinTB_Address;
        private CCWin.SkinControl.SkinComboBox skinCB_Type;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButtom skinB_View;
        private CCWin.SkinControl.SkinTextBox skinTB_Msg;
    }
}

