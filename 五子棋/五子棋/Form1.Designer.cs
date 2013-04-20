namespace 五子棋
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.悔棋HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人机模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.双人模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.先手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑子先下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.白子先下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.无禁手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.是ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.有禁手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.等级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.低级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.神级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.时间textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox0 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.comboBoxA = new System.Windows.Forms.ComboBox();
            this.labelA = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.comboBoxB = new System.Windows.Forms.ComboBox();
            this.labelB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设置EToolStripMenuItem,
            this.等级ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始SToolStripMenuItem,
            this.悔棋HToolStripMenuItem,
            this.暂停SToolStripMenuItem,
            this.退出CToolStripMenuItem,
            this.读取RToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.文件ToolStripMenuItem.Text = "游戏（&F）";
            // 
            // 开始SToolStripMenuItem
            // 
            this.开始SToolStripMenuItem.Name = "开始SToolStripMenuItem";
            this.开始SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.开始SToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.开始SToolStripMenuItem.Text = "新游戏（&N）";
            this.开始SToolStripMenuItem.Click += new System.EventHandler(this.开始SToolStripMenuItem_Click);
            // 
            // 悔棋HToolStripMenuItem
            // 
            this.悔棋HToolStripMenuItem.Name = "悔棋HToolStripMenuItem";
            this.悔棋HToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.悔棋HToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.悔棋HToolStripMenuItem.Text = "悔棋（&D）";
            this.悔棋HToolStripMenuItem.Click += new System.EventHandler(this.悔棋HToolStripMenuItem_Click);
            // 
            // 暂停SToolStripMenuItem
            // 
            this.暂停SToolStripMenuItem.Name = "暂停SToolStripMenuItem";
            this.暂停SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.暂停SToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.暂停SToolStripMenuItem.Text = "暂停（&S）";
            this.暂停SToolStripMenuItem.Click += new System.EventHandler(this.暂停SToolStripMenuItem_Click);
            // 
            // 退出CToolStripMenuItem
            // 
            this.退出CToolStripMenuItem.Name = "退出CToolStripMenuItem";
            this.退出CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.退出CToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.退出CToolStripMenuItem.Text = "退出（&C）";
            this.退出CToolStripMenuItem.Click += new System.EventHandler(this.退出CToolStripMenuItem_Click);
            // 
            // 读取RToolStripMenuItem
            // 
            this.读取RToolStripMenuItem.Name = "读取RToolStripMenuItem";
            this.读取RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.读取RToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.读取RToolStripMenuItem.Text = "读取（&R）";
            this.读取RToolStripMenuItem.Click += new System.EventHandler(this.读取RToolStripMenuItem_Click);
            // 
            // 设置EToolStripMenuItem
            // 
            this.设置EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模式ToolStripMenuItem,
            this.先手ToolStripMenuItem,
            this.无禁手ToolStripMenuItem});
            this.设置EToolStripMenuItem.Name = "设置EToolStripMenuItem";
            this.设置EToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.设置EToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.设置EToolStripMenuItem.Text = "设置（&E）";
            // 
            // 模式ToolStripMenuItem
            // 
            this.模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人机模式ToolStripMenuItem,
            this.双人模式ToolStripMenuItem});
            this.模式ToolStripMenuItem.Name = "模式ToolStripMenuItem";
            this.模式ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.模式ToolStripMenuItem.Text = "模式";
            // 
            // 人机模式ToolStripMenuItem
            // 
            this.人机模式ToolStripMenuItem.Checked = true;
            this.人机模式ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.人机模式ToolStripMenuItem.Name = "人机模式ToolStripMenuItem";
            this.人机模式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.人机模式ToolStripMenuItem.Text = "人机模式";
            this.人机模式ToolStripMenuItem.Click += new System.EventHandler(this.人机模式ToolStripMenuItem_Click);
            // 
            // 双人模式ToolStripMenuItem
            // 
            this.双人模式ToolStripMenuItem.Name = "双人模式ToolStripMenuItem";
            this.双人模式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.双人模式ToolStripMenuItem.Text = "双人模式";
            this.双人模式ToolStripMenuItem.Click += new System.EventHandler(this.双人模式ToolStripMenuItem_Click);
            // 
            // 先手ToolStripMenuItem
            // 
            this.先手ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.黑子先下ToolStripMenuItem,
            this.白子先下ToolStripMenuItem});
            this.先手ToolStripMenuItem.Name = "先手ToolStripMenuItem";
            this.先手ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.先手ToolStripMenuItem.Text = "先手";
            // 
            // 黑子先下ToolStripMenuItem
            // 
            this.黑子先下ToolStripMenuItem.Checked = true;
            this.黑子先下ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.黑子先下ToolStripMenuItem.Name = "黑子先下ToolStripMenuItem";
            this.黑子先下ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.黑子先下ToolStripMenuItem.Text = "黑子先下";
            this.黑子先下ToolStripMenuItem.Click += new System.EventHandler(this.黑子先下ToolStripMenuItem_Click_1);
            // 
            // 白子先下ToolStripMenuItem
            // 
            this.白子先下ToolStripMenuItem.Name = "白子先下ToolStripMenuItem";
            this.白子先下ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.白子先下ToolStripMenuItem.Text = "白子先下";
            this.白子先下ToolStripMenuItem.Click += new System.EventHandler(this.白子先下ToolStripMenuItem_Click);
            // 
            // 无禁手ToolStripMenuItem
            // 
            this.无禁手ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.是ToolStripMenuItem,
            this.有禁手ToolStripMenuItem});
            this.无禁手ToolStripMenuItem.Name = "无禁手ToolStripMenuItem";
            this.无禁手ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.无禁手ToolStripMenuItem.Text = "禁手";
            // 
            // 是ToolStripMenuItem
            // 
            this.是ToolStripMenuItem.Checked = true;
            this.是ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.是ToolStripMenuItem.Name = "是ToolStripMenuItem";
            this.是ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.是ToolStripMenuItem.Text = "无禁手";
            // 
            // 有禁手ToolStripMenuItem
            // 
            this.有禁手ToolStripMenuItem.Name = "有禁手ToolStripMenuItem";
            this.有禁手ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.有禁手ToolStripMenuItem.Text = "有禁手";
            // 
            // 等级ToolStripMenuItem
            // 
            this.等级ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.低级ToolStripMenuItem,
            this.中级ToolStripMenuItem,
            this.高级ToolStripMenuItem,
            this.神级ToolStripMenuItem});
            this.等级ToolStripMenuItem.Name = "等级ToolStripMenuItem";
            this.等级ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.等级ToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.等级ToolStripMenuItem.Text = "等级（&S）";
            // 
            // 低级ToolStripMenuItem
            // 
            this.低级ToolStripMenuItem.Checked = true;
            this.低级ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.低级ToolStripMenuItem.Name = "低级ToolStripMenuItem";
            this.低级ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.低级ToolStripMenuItem.Text = "低级";
            // 
            // 中级ToolStripMenuItem
            // 
            this.中级ToolStripMenuItem.Name = "中级ToolStripMenuItem";
            this.中级ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.中级ToolStripMenuItem.Text = "中级";
            // 
            // 高级ToolStripMenuItem
            // 
            this.高级ToolStripMenuItem.Name = "高级ToolStripMenuItem";
            this.高级ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.高级ToolStripMenuItem.Text = "高级";
            // 
            // 神级ToolStripMenuItem
            // 
            this.神级ToolStripMenuItem.Name = "神级ToolStripMenuItem";
            this.神级ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.神级ToolStripMenuItem.Text = "神级";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem,
            this.说明BToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.帮助HToolStripMenuItem.Text = "帮助（&H）";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.关于AToolStripMenuItem.Text = "关于（&A）";
            // 
            // 说明BToolStripMenuItem
            // 
            this.说明BToolStripMenuItem.Name = "说明BToolStripMenuItem";
            this.说明BToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.说明BToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.说明BToolStripMenuItem.Text = "说明（&B）";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "开始";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Window;
            this.textBox.Location = new System.Drawing.Point(456, 62);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(147, 100);
            this.textBox.TabIndex = 3;
            this.textBox.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "悔棋";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(456, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(36, 79);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "下一步";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(457, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "轮到：";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(453, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "剩余时间：";
            // 
            // 时间textBox
            // 
            this.时间textBox.BackColor = System.Drawing.SystemColors.Window;
            this.时间textBox.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.时间textBox.Location = new System.Drawing.Point(531, 33);
            this.时间textBox.Name = "时间textBox";
            this.时间textBox.ReadOnly = true;
            this.时间textBox.Size = new System.Drawing.Size(36, 23);
            this.时间textBox.TabIndex = 10;
            this.时间textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(573, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "秒";
            // 
            // richTextBox0
            // 
            this.richTextBox0.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox0.Location = new System.Drawing.Point(100, 480);
            this.richTextBox0.Name = "richTextBox0";
            this.richTextBox0.ReadOnly = true;
            this.richTextBox0.Size = new System.Drawing.Size(200, 85);
            this.richTextBox0.TabIndex = 12;
            this.richTextBox0.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(302, 480);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(200, 85);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioButtonA);
            this.groupBox2.Controls.Add(this.comboBoxA);
            this.groupBox2.Controls.Add(this.labelA);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(-2, 472);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 93);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.BackColor = System.Drawing.Color.Gold;
            this.radioButtonA.Checked = true;
            this.radioButtonA.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonA.Location = new System.Drawing.Point(2, 8);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(60, 20);
            this.radioButtonA.TabIndex = 2;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "先手";
            this.radioButtonA.UseVisualStyleBackColor = false;
            this.radioButtonA.CheckedChanged += new System.EventHandler(this.radioButtonA_CheckedChanged);
            // 
            // comboBoxA
            // 
            this.comboBoxA.FormattingEnabled = true;
            this.comboBoxA.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxA.Items.AddRange(new object[] {
            "黑子",
            "白子"});
            this.comboBoxA.Location = new System.Drawing.Point(20, 52);
            this.comboBoxA.Name = "comboBoxA";
            this.comboBoxA.Size = new System.Drawing.Size(60, 24);
            this.comboBoxA.TabIndex = 1;
            this.comboBoxA.Text = "黑子";
            this.comboBoxA.SelectedIndexChanged += new System.EventHandler(this.comboBoxA_SelectedIndexChanged);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA.ForeColor = System.Drawing.Color.Red;
            this.labelA.Location = new System.Drawing.Point(20, 35);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(51, 16);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "玩家:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.radioButtonB);
            this.groupBox3.Controls.Add(this.comboBoxB);
            this.groupBox3.Controls.Add(this.labelB);
            this.groupBox3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(504, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 93);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.BackColor = System.Drawing.Color.Gold;
            this.radioButtonB.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonB.Location = new System.Drawing.Point(3, 8);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(60, 20);
            this.radioButtonB.TabIndex = 17;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "先手";
            this.radioButtonB.UseVisualStyleBackColor = false;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // comboBoxB
            // 
            this.comboBoxB.FormattingEnabled = true;
            this.comboBoxB.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxB.Items.AddRange(new object[] {
            "白子",
            "黑子"});
            this.comboBoxB.Location = new System.Drawing.Point(20, 52);
            this.comboBoxB.Name = "comboBoxB";
            this.comboBoxB.Size = new System.Drawing.Size(60, 24);
            this.comboBoxB.TabIndex = 3;
            this.comboBoxB.Text = "白子";
            this.comboBoxB.SelectedIndexChanged += new System.EventHandler(this.comboBoxB_SelectedIndexChanged);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelB.ForeColor = System.Drawing.Color.Blue;
            this.labelB.Location = new System.Drawing.Point(20, 35);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(51, 16);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "电脑:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(290, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "VS";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "分析";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(603, 566);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.时间textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五子棋";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem 开始SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 悔棋HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人机模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 双人模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 先手ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑子先下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 白子先下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 无禁手ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 是ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 有禁手ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 等级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 低级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 神级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 说明BToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 时间textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox0;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem 读取RToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.Button button4;
    }
}

