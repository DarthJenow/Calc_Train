namespace Calc_Train
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.checkBoxMultiply = new System.Windows.Forms.CheckBox();
            this.checkBoxMinus = new System.Windows.Forms.CheckBox();
            this.checkBoxDivide = new System.Windows.Forms.CheckBox();
            this.checkBoxPlus = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(116, 226);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(197, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 208);
            this.tabControl1.TabIndex = 6;
            // 
            // checkBoxMultiply
            // 
            this.checkBoxMultiply.AutoSize = true;
            this.checkBoxMultiply.Location = new System.Drawing.Point(6, 51);
            this.checkBoxMultiply.Name = "checkBoxMultiply";
            this.checkBoxMultiply.Size = new System.Drawing.Size(81, 17);
            this.checkBoxMultiply.TabIndex = 4;
            this.checkBoxMultiply.Text = "Multiply ( x )";
            this.checkBoxMultiply.UseVisualStyleBackColor = true;
            // 
            // checkBoxMinus
            // 
            this.checkBoxMinus.AutoSize = true;
            this.checkBoxMinus.Location = new System.Drawing.Point(6, 29);
            this.checkBoxMinus.Name = "checkBoxMinus";
            this.checkBoxMinus.Size = new System.Drawing.Size(72, 17);
            this.checkBoxMinus.TabIndex = 3;
            this.checkBoxMinus.Text = "Minus ( - )";
            this.checkBoxMinus.UseVisualStyleBackColor = true;
            // 
            // checkBoxDivide
            // 
            this.checkBoxDivide.AutoSize = true;
            this.checkBoxDivide.Location = new System.Drawing.Point(6, 74);
            this.checkBoxDivide.Name = "checkBoxDivide";
            this.checkBoxDivide.Size = new System.Drawing.Size(76, 17);
            this.checkBoxDivide.TabIndex = 5;
            this.checkBoxDivide.Text = "Divide ( / )";
            this.checkBoxDivide.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlus
            // 
            this.checkBoxPlus.AutoSize = true;
            this.checkBoxPlus.Location = new System.Drawing.Point(6, 6);
            this.checkBoxPlus.Name = "checkBoxPlus";
            this.checkBoxPlus.Size = new System.Drawing.Size(67, 17);
            this.checkBoxPlus.TabIndex = 2;
            this.checkBoxPlus.Text = "Plus ( + )";
            this.checkBoxPlus.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxPlus);
            this.tabPage1.Controls.Add(this.checkBoxDivide);
            this.tabPage1.Controls.Add(this.checkBoxMinus);
            this.tabPage1.Controls.Add(this.checkBoxMultiply);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(252, 182);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operands";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.CheckBox checkBoxPlus;
        public System.Windows.Forms.CheckBox checkBoxDivide;
        public System.Windows.Forms.CheckBox checkBoxMinus;
        public System.Windows.Forms.CheckBox checkBoxMultiply;
    }
}