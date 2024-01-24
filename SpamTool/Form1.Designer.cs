namespace SpamTool
{
    partial class ToolBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBox));
            Start1 = new Button();
            LeftClick = new CheckBox();
            RightClick = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox7 = new GroupBox();
            runKey = new CheckBox();
            SpamText = new RichTextBox();
            groupBox6 = new GroupBox();
            KEY_EVENT = new TrackBar();
            groupBox5 = new GroupBox();
            CPS_R_VOL = new TrackBar();
            groupBox2 = new GroupBox();
            CPS_LEFT_VOL = new TrackBar();
            groupBox1 = new GroupBox();
            CPS_R = new Label();
            CPS_L = new Label();
            tabPage2 = new TabPage();
            groupBox8 = new GroupBox();
            SpamCtrl = new CheckBox();
            SpamAlt = new CheckBox();
            SpamShift = new CheckBox();
            SpamKey = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox4 = new GroupBox();
            CtrlRight = new CheckBox();
            AltRight = new CheckBox();
            ShiftRight = new CheckBox();
            ShowKeyRight = new TextBox();
            HotKeySetRight = new Button();
            ResetHotKeyRight = new Button();
            groupBox3 = new GroupBox();
            CtrlLeft = new CheckBox();
            AltLeft = new CheckBox();
            ResetHotKeyLeft = new Button();
            HotKeySetLeft = new Button();
            ShiftLeft = new CheckBox();
            ShowKeyLeft = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KEY_EVENT).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CPS_R_VOL).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CPS_LEFT_VOL).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // Start1
            // 
            resources.ApplyResources(Start1, "Start1");
            Start1.Name = "Start1";
            Start1.UseVisualStyleBackColor = true;
            Start1.Click += Start_Click;
            Start1.MouseLeave += ToolBox_MouseLeave;
            Start1.MouseHover += ToolBox_MouseHover;
            // 
            // LeftClick
            // 
            resources.ApplyResources(LeftClick, "LeftClick");
            LeftClick.Name = "LeftClick";
            LeftClick.UseVisualStyleBackColor = true;
            LeftClick.MouseLeave += ToolBox_MouseLeave;
            LeftClick.MouseHover += ToolBox_MouseHover;
            // 
            // RightClick
            // 
            resources.ApplyResources(RightClick, "RightClick");
            RightClick.Name = "RightClick";
            RightClick.UseVisualStyleBackColor = true;
            RightClick.MouseLeave += ToolBox_MouseLeave;
            RightClick.MouseHover += ToolBox_MouseHover;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox7);
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(runKey);
            groupBox7.Controls.Add(SpamText);
            resources.ApplyResources(groupBox7, "groupBox7");
            groupBox7.Name = "groupBox7";
            groupBox7.TabStop = false;
            // 
            // runKey
            // 
            resources.ApplyResources(runKey, "runKey");
            runKey.Name = "runKey";
            runKey.UseVisualStyleBackColor = true;
            runKey.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // SpamText
            // 
            resources.ApplyResources(SpamText, "SpamText");
            SpamText.Name = "SpamText";
            SpamText.TextChanged += SpamText_TextChanged;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.WhiteSmoke;
            groupBox6.Controls.Add(KEY_EVENT);
            resources.ApplyResources(groupBox6, "groupBox6");
            groupBox6.Name = "groupBox6";
            groupBox6.TabStop = false;
            // 
            // KEY_EVENT
            // 
            KEY_EVENT.BackColor = Color.WhiteSmoke;
            resources.ApplyResources(KEY_EVENT, "KEY_EVENT");
            KEY_EVENT.Minimum = 1;
            KEY_EVENT.Name = "KEY_EVENT";
            KEY_EVENT.TickFrequency = 10;
            KEY_EVENT.TickStyle = TickStyle.Both;
            KEY_EVENT.Value = 1;
            KEY_EVENT.Scroll += KEY_EVENT_Scroll;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.WhiteSmoke;
            groupBox5.Controls.Add(CPS_R_VOL);
            resources.ApplyResources(groupBox5, "groupBox5");
            groupBox5.Name = "groupBox5";
            groupBox5.TabStop = false;
            // 
            // CPS_R_VOL
            // 
            CPS_R_VOL.BackColor = Color.WhiteSmoke;
            resources.ApplyResources(CPS_R_VOL, "CPS_R_VOL");
            CPS_R_VOL.Maximum = 100;
            CPS_R_VOL.Minimum = 1;
            CPS_R_VOL.Name = "CPS_R_VOL";
            CPS_R_VOL.TickFrequency = 10;
            CPS_R_VOL.TickStyle = TickStyle.Both;
            CPS_R_VOL.Value = 10;
            CPS_R_VOL.Scroll += CPS_R_VOL_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(CPS_LEFT_VOL);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // CPS_LEFT_VOL
            // 
            CPS_LEFT_VOL.BackColor = Color.WhiteSmoke;
            resources.ApplyResources(CPS_LEFT_VOL, "CPS_LEFT_VOL");
            CPS_LEFT_VOL.Maximum = 100;
            CPS_LEFT_VOL.Minimum = 1;
            CPS_LEFT_VOL.Name = "CPS_LEFT_VOL";
            CPS_LEFT_VOL.TickFrequency = 10;
            CPS_LEFT_VOL.TickStyle = TickStyle.Both;
            CPS_LEFT_VOL.Value = 10;
            CPS_LEFT_VOL.Scroll += CPS_LEFT_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CPS_R);
            groupBox1.Controls.Add(CPS_L);
            groupBox1.Controls.Add(Start1);
            groupBox1.Controls.Add(RightClick);
            groupBox1.Controls.Add(LeftClick);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // CPS_R
            // 
            resources.ApplyResources(CPS_R, "CPS_R");
            CPS_R.Name = "CPS_R";
            // 
            // CPS_L
            // 
            resources.ApplyResources(CPS_L, "CPS_L");
            CPS_L.Name = "CPS_L";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox8);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(SpamCtrl);
            groupBox8.Controls.Add(SpamAlt);
            groupBox8.Controls.Add(SpamShift);
            groupBox8.Controls.Add(SpamKey);
            groupBox8.Controls.Add(button1);
            groupBox8.Controls.Add(button2);
            resources.ApplyResources(groupBox8, "groupBox8");
            groupBox8.Name = "groupBox8";
            groupBox8.TabStop = false;
            // 
            // SpamCtrl
            // 
            resources.ApplyResources(SpamCtrl, "SpamCtrl");
            SpamCtrl.Name = "SpamCtrl";
            SpamCtrl.UseVisualStyleBackColor = true;
            SpamCtrl.CheckedChanged += SpamCtrl_CheckedChanged;
            // 
            // SpamAlt
            // 
            resources.ApplyResources(SpamAlt, "SpamAlt");
            SpamAlt.Name = "SpamAlt";
            SpamAlt.UseVisualStyleBackColor = true;
            SpamAlt.CheckedChanged += SpamAlt_CheckedChanged;
            // 
            // SpamShift
            // 
            resources.ApplyResources(SpamShift, "SpamShift");
            SpamShift.Name = "SpamShift";
            SpamShift.UseVisualStyleBackColor = true;
            SpamShift.CheckedChanged += SpamShift_CheckedChanged;
            // 
            // SpamKey
            // 
            resources.ApplyResources(SpamKey, "SpamKey");
            SpamKey.Name = "SpamKey";
            SpamKey.ReadOnly = true;
            SpamKey.KeyDown += SpamKey_KeyDown;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(CtrlRight);
            groupBox4.Controls.Add(AltRight);
            groupBox4.Controls.Add(ShiftRight);
            groupBox4.Controls.Add(ShowKeyRight);
            groupBox4.Controls.Add(HotKeySetRight);
            groupBox4.Controls.Add(ResetHotKeyRight);
            resources.ApplyResources(groupBox4, "groupBox4");
            groupBox4.Name = "groupBox4";
            groupBox4.TabStop = false;
            // 
            // CtrlRight
            // 
            resources.ApplyResources(CtrlRight, "CtrlRight");
            CtrlRight.Name = "CtrlRight";
            CtrlRight.UseVisualStyleBackColor = true;
            CtrlRight.CheckedChanged += CtrlRight_CheckedChanged;
            // 
            // AltRight
            // 
            resources.ApplyResources(AltRight, "AltRight");
            AltRight.Name = "AltRight";
            AltRight.UseVisualStyleBackColor = true;
            AltRight.CheckedChanged += AltRight_CheckedChanged;
            // 
            // ShiftRight
            // 
            resources.ApplyResources(ShiftRight, "ShiftRight");
            ShiftRight.Name = "ShiftRight";
            ShiftRight.UseVisualStyleBackColor = true;
            ShiftRight.CheckedChanged += ShiftRight_CheckedChanged;
            // 
            // ShowKeyRight
            // 
            resources.ApplyResources(ShowKeyRight, "ShowKeyRight");
            ShowKeyRight.Name = "ShowKeyRight";
            ShowKeyRight.ReadOnly = true;
            ShowKeyRight.KeyDown += ShowKeyRight_KeyDown;
            // 
            // HotKeySetRight
            // 
            resources.ApplyResources(HotKeySetRight, "HotKeySetRight");
            HotKeySetRight.Name = "HotKeySetRight";
            HotKeySetRight.UseVisualStyleBackColor = true;
            HotKeySetRight.Click += HotKeySetRight_Click;
            // 
            // ResetHotKeyRight
            // 
            resources.ApplyResources(ResetHotKeyRight, "ResetHotKeyRight");
            ResetHotKeyRight.Name = "ResetHotKeyRight";
            ResetHotKeyRight.UseVisualStyleBackColor = true;
            ResetHotKeyRight.Click += ResetHotKeyRight_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(CtrlLeft);
            groupBox3.Controls.Add(AltLeft);
            groupBox3.Controls.Add(ResetHotKeyLeft);
            groupBox3.Controls.Add(HotKeySetLeft);
            groupBox3.Controls.Add(ShiftLeft);
            groupBox3.Controls.Add(ShowKeyLeft);
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // CtrlLeft
            // 
            resources.ApplyResources(CtrlLeft, "CtrlLeft");
            CtrlLeft.Name = "CtrlLeft";
            CtrlLeft.UseVisualStyleBackColor = true;
            CtrlLeft.CheckedChanged += CtrlLeft_CheckedChanged;
            // 
            // AltLeft
            // 
            resources.ApplyResources(AltLeft, "AltLeft");
            AltLeft.Name = "AltLeft";
            AltLeft.UseVisualStyleBackColor = true;
            AltLeft.CheckedChanged += AltLeft_CheckedChanged;
            // 
            // ResetHotKeyLeft
            // 
            resources.ApplyResources(ResetHotKeyLeft, "ResetHotKeyLeft");
            ResetHotKeyLeft.Name = "ResetHotKeyLeft";
            ResetHotKeyLeft.UseVisualStyleBackColor = true;
            ResetHotKeyLeft.Click += ResetHotKeyLeft_Click;
            // 
            // HotKeySetLeft
            // 
            resources.ApplyResources(HotKeySetLeft, "HotKeySetLeft");
            HotKeySetLeft.Name = "HotKeySetLeft";
            HotKeySetLeft.UseVisualStyleBackColor = true;
            HotKeySetLeft.Click += HotKeySetLeft_Click;
            // 
            // ShiftLeft
            // 
            resources.ApplyResources(ShiftLeft, "ShiftLeft");
            ShiftLeft.Name = "ShiftLeft";
            ShiftLeft.UseVisualStyleBackColor = true;
            ShiftLeft.CheckedChanged += ShiftLeft_CheckedChanged;
            // 
            // ShowKeyLeft
            // 
            resources.ApplyResources(ShowKeyLeft, "ShowKeyLeft");
            ShowKeyLeft.Name = "ShowKeyLeft";
            ShowKeyLeft.ReadOnly = true;
            ShowKeyLeft.KeyDown += ShowKey_KeyDown;
            // 
            // ToolBox
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "ToolBox";
            FormClosing += ToolBox_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)KEY_EVENT).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CPS_R_VOL).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CPS_LEFT_VOL).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Start1;
        private CheckBox LeftClick;
        private CheckBox RightClick;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private TrackBar CPS_LEFT_VOL;
        private GroupBox groupBox4;
        private TextBox ShowKeyRight;
        private Button HotKeySetRight;
        private Button ResetHotKeyRight;
        private GroupBox groupBox3;
        private CheckBox CtrlLeft;
        private CheckBox AltLeft;
        private CheckBox ShiftLeft;
        private TextBox ShowKeyLeft;
        private Button HotKeySetLeft;
        private Button ResetHotKeyLeft;
        private CheckBox CtrlRight;
        private CheckBox AltRight;
        private CheckBox ShiftRight;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private TrackBar CPS_R_VOL;
        private Label CPS_R;
        private Label CPS_L;
        private GroupBox groupBox7;
        private RichTextBox SpamText;
        private GroupBox groupBox6;
        private TrackBar KEY_EVENT;
        private GroupBox groupBox8;
        private CheckBox SpamCtrl;
        private CheckBox SpamAlt;
        private CheckBox SpamShift;
        private TextBox SpamKey;
        private Button button1;
        private Button button2;
        private CheckBox runKey;
    }
}
