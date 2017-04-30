namespace Macro
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxMarco = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.textBoxWait = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelHotkey = new System.Windows.Forms.Label();
            this.groupBoxHotkey = new System.Windows.Forms.GroupBox();
            this.checkBoxHotKey = new System.Windows.Forms.CheckBox();
            this.labelWiatBefore = new System.Windows.Forms.Label();
            this.labelWaitStart = new System.Windows.Forms.Label();
            this.textBoxLoops = new System.Windows.Forms.TextBox();
            this.labelTimes = new System.Windows.Forms.Label();
            this.labelExecutionCount = new System.Windows.Forms.Label();
            this.labelWaitBetween = new System.Windows.Forms.Label();
            this.labelBetween = new System.Windows.Forms.Label();
            this.textBoxPause = new System.Windows.Forms.TextBox();
            this.groupBoxExecution = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelSpecialKeysRight = new System.Windows.Forms.Label();
            this.labelSpecialKeysLeft = new System.Windows.Forms.Label();
            this.labelMacro = new System.Windows.Forms.Label();
            this.groupBoxMacro = new System.Windows.Forms.GroupBox();
            this.groupBoxHotkey.SuspendLayout();
            this.groupBoxExecution.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxMacro.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMarco
            // 
            this.textBoxMarco.AcceptsReturn = true;
            this.textBoxMarco.Location = new System.Drawing.Point(6, 32);
            this.textBoxMarco.Multiline = true;
            this.textBoxMarco.Name = "textBoxMarco";
            this.textBoxMarco.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMarco.Size = new System.Drawing.Size(433, 57);
            this.textBoxMarco.TabIndex = 5;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(185, 91);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 6;
            this.buttonExecute.Text = "Execute Marco";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // textBoxWait
            // 
            this.textBoxWait.Location = new System.Drawing.Point(39, 33);
            this.textBoxWait.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textBoxWait.Name = "textBoxWait";
            this.textBoxWait.Size = new System.Drawing.Size(23, 20);
            this.textBoxWait.TabIndex = 2;
            this.textBoxWait.Text = "0";
            this.textBoxWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHotkey
            // 
            this.labelHotkey.Location = new System.Drawing.Point(6, 16);
            this.labelHotkey.Name = "labelHotkey";
            this.labelHotkey.Size = new System.Drawing.Size(111, 33);
            this.labelHotkey.TabIndex = 20;
            this.labelHotkey.Text = "Use this hotkey to execute this macro:";
            this.labelHotkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelHotkey, "Press any modifier key reset the hotkey to None.");
            // 
            // groupBoxHotkey
            // 
            this.groupBoxHotkey.Controls.Add(this.checkBoxHotKey);
            this.groupBoxHotkey.Controls.Add(this.labelHotkey);
            this.groupBoxHotkey.Location = new System.Drawing.Point(334, 12);
            this.groupBoxHotkey.Name = "groupBoxHotkey";
            this.groupBoxHotkey.Size = new System.Drawing.Size(123, 82);
            this.groupBoxHotkey.TabIndex = 23;
            this.groupBoxHotkey.TabStop = false;
            this.toolTip.SetToolTip(this.groupBoxHotkey, "Press any modifier key reset the hotkey to None.");
            // 
            // checkBoxHotKey
            // 
            this.checkBoxHotKey.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxHotKey.Location = new System.Drawing.Point(16, 52);
            this.checkBoxHotKey.Name = "checkBoxHotKey";
            this.checkBoxHotKey.Size = new System.Drawing.Size(88, 23);
            this.checkBoxHotKey.TabIndex = 4;
            this.checkBoxHotKey.Text = "(None)";
            this.checkBoxHotKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.checkBoxHotKey, "Press any modifier key reset the hotkey to None.");
            this.checkBoxHotKey.UseVisualStyleBackColor = true;
            // 
            // labelWiatBefore
            // 
            this.labelWiatBefore.AutoSize = true;
            this.labelWiatBefore.Location = new System.Drawing.Point(62, 36);
            this.labelWiatBefore.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelWiatBefore.Name = "labelWiatBefore";
            this.labelWiatBefore.Size = new System.Drawing.Size(105, 13);
            this.labelWiatBefore.TabIndex = 8;
            this.labelWiatBefore.Text = "ms before execution.";
            this.labelWiatBefore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWaitStart
            // 
            this.labelWaitStart.AutoSize = true;
            this.labelWaitStart.Location = new System.Drawing.Point(10, 37);
            this.labelWaitStart.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelWaitStart.Name = "labelWaitStart";
            this.labelWaitStart.Size = new System.Drawing.Size(29, 13);
            this.labelWaitStart.TabIndex = 9;
            this.labelWaitStart.Text = "Wait";
            this.labelWaitStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxLoops
            // 
            this.textBoxLoops.Location = new System.Drawing.Point(86, 13);
            this.textBoxLoops.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textBoxLoops.Name = "textBoxLoops";
            this.textBoxLoops.Size = new System.Drawing.Size(23, 20);
            this.textBoxLoops.TabIndex = 1;
            this.textBoxLoops.Text = "1";
            // 
            // labelTimes
            // 
            this.labelTimes.AutoSize = true;
            this.labelTimes.Location = new System.Drawing.Point(109, 16);
            this.labelTimes.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelTimes.Name = "labelTimes";
            this.labelTimes.Size = new System.Drawing.Size(34, 13);
            this.labelTimes.TabIndex = 14;
            this.labelTimes.Text = "times.";
            this.labelTimes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelExecutionCount
            // 
            this.labelExecutionCount.AutoSize = true;
            this.labelExecutionCount.Location = new System.Drawing.Point(8, 16);
            this.labelExecutionCount.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelExecutionCount.Name = "labelExecutionCount";
            this.labelExecutionCount.Size = new System.Drawing.Size(78, 13);
            this.labelExecutionCount.TabIndex = 15;
            this.labelExecutionCount.Text = "Execute macro";
            this.labelExecutionCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelWaitBetween
            // 
            this.labelWaitBetween.AutoSize = true;
            this.labelWaitBetween.Location = new System.Drawing.Point(10, 58);
            this.labelWaitBetween.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelWaitBetween.Name = "labelWaitBetween";
            this.labelWaitBetween.Size = new System.Drawing.Size(29, 13);
            this.labelWaitBetween.TabIndex = 19;
            this.labelWaitBetween.Text = "Wait";
            this.labelWaitBetween.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBetween
            // 
            this.labelBetween.AutoSize = true;
            this.labelBetween.Location = new System.Drawing.Point(62, 58);
            this.labelBetween.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelBetween.Name = "labelBetween";
            this.labelBetween.Size = new System.Drawing.Size(121, 13);
            this.labelBetween.TabIndex = 18;
            this.labelBetween.Text = "ms between executions.";
            this.labelBetween.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPause
            // 
            this.textBoxPause.Location = new System.Drawing.Point(39, 55);
            this.textBoxPause.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textBoxPause.Name = "textBoxPause";
            this.textBoxPause.Size = new System.Drawing.Size(23, 20);
            this.textBoxPause.TabIndex = 3;
            this.textBoxPause.Text = "0";
            this.textBoxPause.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxExecution
            // 
            this.groupBoxExecution.Controls.Add(this.labelTimes);
            this.groupBoxExecution.Controls.Add(this.textBoxLoops);
            this.groupBoxExecution.Controls.Add(this.labelExecutionCount);
            this.groupBoxExecution.Controls.Add(this.labelWaitBetween);
            this.groupBoxExecution.Controls.Add(this.labelWiatBefore);
            this.groupBoxExecution.Controls.Add(this.labelBetween);
            this.groupBoxExecution.Controls.Add(this.textBoxWait);
            this.groupBoxExecution.Controls.Add(this.textBoxPause);
            this.groupBoxExecution.Controls.Add(this.labelWaitStart);
            this.groupBoxExecution.Location = new System.Drawing.Point(12, 12);
            this.groupBoxExecution.Name = "groupBoxExecution";
            this.groupBoxExecution.Size = new System.Drawing.Size(187, 82);
            this.groupBoxExecution.TabIndex = 22;
            this.groupBoxExecution.TabStop = false;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelSpecialKeysRight);
            this.groupBoxInfo.Controls.Add(this.labelSpecialKeysLeft);
            this.groupBoxInfo.Location = new System.Drawing.Point(205, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(123, 82);
            this.groupBoxInfo.TabIndex = 24;
            this.groupBoxInfo.TabStop = false;
            // 
            // labelSpecialKeysRight
            // 
            this.labelSpecialKeysRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSpecialKeysRight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSpecialKeysRight.Location = new System.Drawing.Point(59, 16);
            this.labelSpecialKeysRight.Name = "labelSpecialKeysRight";
            this.labelSpecialKeysRight.Size = new System.Drawing.Size(58, 55);
            this.labelSpecialKeysRight.TabIndex = 1;
            this.labelSpecialKeysRight.Text = "Add=+ Subtract=- Multiply=* Divide=/";
            this.labelSpecialKeysRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSpecialKeysLeft
            // 
            this.labelSpecialKeysLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSpecialKeysLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSpecialKeysLeft.Location = new System.Drawing.Point(6, 16);
            this.labelSpecialKeysLeft.Name = "labelSpecialKeysLeft";
            this.labelSpecialKeysLeft.Size = new System.Drawing.Size(61, 55);
            this.labelSpecialKeysLeft.TabIndex = 0;
            this.labelSpecialKeysLeft.Text = "~=Enter +=Shift ^=Control %=Alt";
            this.labelSpecialKeysLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMacro
            // 
            this.labelMacro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMacro.Location = new System.Drawing.Point(6, 16);
            this.labelMacro.Name = "labelMacro";
            this.labelMacro.Size = new System.Drawing.Size(433, 13);
            this.labelMacro.TabIndex = 25;
            this.labelMacro.Text = "Enter the macro:";
            this.labelMacro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxMacro
            // 
            this.groupBoxMacro.Controls.Add(this.labelMacro);
            this.groupBoxMacro.Controls.Add(this.textBoxMarco);
            this.groupBoxMacro.Controls.Add(this.buttonExecute);
            this.groupBoxMacro.Location = new System.Drawing.Point(12, 95);
            this.groupBoxMacro.Name = "groupBoxMacro";
            this.groupBoxMacro.Size = new System.Drawing.Size(445, 120);
            this.groupBoxMacro.TabIndex = 26;
            this.groupBoxMacro.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 224);
            this.Controls.Add(this.groupBoxMacro);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxHotkey);
            this.Controls.Add(this.groupBoxExecution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Bit Mage\'s Marco Thingy";
            this.groupBoxHotkey.ResumeLayout(false);
            this.groupBoxExecution.ResumeLayout(false);
            this.groupBoxExecution.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxMacro.ResumeLayout(false);
            this.groupBoxMacro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMarco;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.TextBox textBoxWait;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelWiatBefore;
        private System.Windows.Forms.Label labelWaitStart;
        private System.Windows.Forms.TextBox textBoxLoops;
        private System.Windows.Forms.Label labelTimes;
        private System.Windows.Forms.Label labelExecutionCount;
        private System.Windows.Forms.Label labelWaitBetween;
        private System.Windows.Forms.Label labelBetween;
        private System.Windows.Forms.TextBox textBoxPause;
        private System.Windows.Forms.Label labelHotkey;
        private System.Windows.Forms.GroupBox groupBoxExecution;
        private System.Windows.Forms.GroupBox groupBoxHotkey;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelSpecialKeysLeft;
        private System.Windows.Forms.Label labelSpecialKeysRight;
        private System.Windows.Forms.CheckBox checkBoxHotKey;
        private System.Windows.Forms.Label labelMacro;
        private System.Windows.Forms.GroupBox groupBoxMacro;
    }
}

