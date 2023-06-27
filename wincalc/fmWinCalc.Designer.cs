namespace wincalc
{
    partial class fmWinCalc
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
            btnClear = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinus = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMuttply = new Button();
            btnDat = new Button();
            btn0 = new Button();
            btnEqual = new Button();
            btnDivide = new Button();
            btnBack = new Button();
            txtDisplay = new TextBox();
            btnAdd = new Button();
            menuStrip2 = new MenuStrip();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            abountToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.MouseDownBackColor = Color.Red;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btnClear.Location = new Point(12, 78);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 40);
            btnClear.TabIndex = 0;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 124);
            btn7.Name = "btn7";
            btn7.Size = new Size(40, 40);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(67, 124);
            btn8.Name = "btn8";
            btn8.Size = new Size(40, 40);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(126, 124);
            btn9.Name = "btn9";
            btn9.Size = new Size(40, 40);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button7_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 170);
            btn4.Name = "btn4";
            btn4.Size = new Size(40, 40);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(67, 170);
            btn5.Name = "btn5";
            btn5.Size = new Size(40, 40);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(126, 170);
            btn6.Name = "btn6";
            btn6.Size = new Size(40, 40);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(181, 170);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(40, 40);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 216);
            btn1.Name = "btn1";
            btn1.Size = new Size(40, 40);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(67, 216);
            btn2.Name = "btn2";
            btn2.Size = new Size(40, 40);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(126, 216);
            btn3.Name = "btn3";
            btn3.Size = new Size(40, 40);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btnMuttply
            // 
            btnMuttply.Location = new Point(181, 216);
            btnMuttply.Name = "btnMuttply";
            btnMuttply.Size = new Size(40, 40);
            btnMuttply.TabIndex = 16;
            btnMuttply.Text = "x";
            btnMuttply.UseVisualStyleBackColor = true;
            btnMuttply.Click += button16_Click;
            // 
            // btnDat
            // 
            btnDat.Location = new Point(12, 262);
            btnDat.Name = "btnDat";
            btnDat.Size = new Size(40, 40);
            btnDat.TabIndex = 17;
            btnDat.Text = " .";
            btnDat.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(67, 262);
            btn0.Name = "btn0";
            btn0.Size = new Size(40, 40);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(126, 262);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(40, 40);
            btnEqual.TabIndex = 19;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(181, 262);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(40, 40);
            btnDivide.TabIndex = 20;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += button20_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(126, 78);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 40);
            btnBack.TabIndex = 21;
            btnBack.Text = "<--";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += button2_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(12, 27);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(209, 45);
            txtDisplay.TabIndex = 1;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(181, 124);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(40, 40);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // menuStrip2
            // 
            menuStrip2.Location = new Point(0, 24);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(227, 24);
            menuStrip2.TabIndex = 23;
            menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(227, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            clearToolStripMenuItem.Size = new Size(180, 22);
            clearToolStripMenuItem.Text = "Clear";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abountToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // abountToolStripMenuItem
            // 
            abountToolStripMenuItem.Name = "abountToolStripMenuItem";
            abountToolStripMenuItem.Size = new Size(180, 22);
            abountToolStripMenuItem.Text = "Abount";
            // 
            // fmWinCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 334);
            Controls.Add(btnBack);
            Controls.Add(btnDivide);
            Controls.Add(btnEqual);
            Controls.Add(btn0);
            Controls.Add(btnDat);
            Controls.Add(btnMuttply);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMinus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Controls.Add(btnClear);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip1);
            Name = "fmWinCalc";
            Text = "fmWinCalc";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMuttply;
        private Button btnDat;
        private Button btn0;
        private Button btnEqual;
        private Button btnDivide;
        private Button btnBack;
        private TextBox txtDisplay;
        private Button btnAdd;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem abountToolStripMenuItem;
    }
}