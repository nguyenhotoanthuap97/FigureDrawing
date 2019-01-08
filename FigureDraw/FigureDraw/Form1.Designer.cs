namespace FigureDraw
{
    partial class MainForm
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
            this.drawBtn = new System.Windows.Forms.Button();
            this.aLa = new System.Windows.Forms.Label();
            this.bLa = new System.Windows.Forms.Label();
            this.cLa = new System.Windows.Forms.Label();
            this.dLa = new System.Windows.Forms.Label();
            this.aTxtBox = new System.Windows.Forms.TextBox();
            this.bTxtBox = new System.Windows.Forms.TextBox();
            this.cTxtBox = new System.Windows.Forms.TextBox();
            this.dTxtBox = new System.Windows.Forms.TextBox();
            this.libCBB = new System.Windows.Forms.ComboBox();
            this.shapeCBB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.libLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exportBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawBtn
            // 
            this.drawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drawBtn.Location = new System.Drawing.Point(21, 347);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(86, 42);
            this.drawBtn.TabIndex = 0;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // aLa
            // 
            this.aLa.AutoSize = true;
            this.aLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aLa.Location = new System.Drawing.Point(17, 173);
            this.aLa.Name = "aLa";
            this.aLa.Size = new System.Drawing.Size(25, 20);
            this.aLa.TabIndex = 1;
            this.aLa.Text = "x1";
            // 
            // bLa
            // 
            this.bLa.AutoSize = true;
            this.bLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bLa.Location = new System.Drawing.Point(17, 216);
            this.bLa.Name = "bLa";
            this.bLa.Size = new System.Drawing.Size(25, 20);
            this.bLa.TabIndex = 2;
            this.bLa.Text = "y1";
            // 
            // cLa
            // 
            this.cLa.AutoSize = true;
            this.cLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cLa.Location = new System.Drawing.Point(17, 260);
            this.cLa.Name = "cLa";
            this.cLa.Size = new System.Drawing.Size(25, 20);
            this.cLa.TabIndex = 3;
            this.cLa.Text = "x2";
            // 
            // dLa
            // 
            this.dLa.AutoSize = true;
            this.dLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dLa.Location = new System.Drawing.Point(17, 302);
            this.dLa.Name = "dLa";
            this.dLa.Size = new System.Drawing.Size(25, 20);
            this.dLa.TabIndex = 4;
            this.dLa.Text = "y2";
            // 
            // aTxtBox
            // 
            this.aTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aTxtBox.Location = new System.Drawing.Point(907, 179);
            this.aTxtBox.Name = "aTxtBox";
            this.aTxtBox.Size = new System.Drawing.Size(61, 26);
            this.aTxtBox.TabIndex = 5;
            // 
            // bTxtBox
            // 
            this.bTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bTxtBox.Location = new System.Drawing.Point(907, 222);
            this.bTxtBox.Name = "bTxtBox";
            this.bTxtBox.Size = new System.Drawing.Size(61, 26);
            this.bTxtBox.TabIndex = 6;
            // 
            // cTxtBox
            // 
            this.cTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cTxtBox.Location = new System.Drawing.Point(907, 266);
            this.cTxtBox.Name = "cTxtBox";
            this.cTxtBox.Size = new System.Drawing.Size(61, 26);
            this.cTxtBox.TabIndex = 7;
            // 
            // dTxtBox
            // 
            this.dTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dTxtBox.Location = new System.Drawing.Point(907, 308);
            this.dTxtBox.Name = "dTxtBox";
            this.dTxtBox.Size = new System.Drawing.Size(61, 26);
            this.dTxtBox.TabIndex = 8;
            // 
            // libCBB
            // 
            this.libCBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.libCBB.FormattingEnabled = true;
            this.libCBB.Items.AddRange(new object[] {
            "GDI+",
            "Cairo"});
            this.libCBB.Location = new System.Drawing.Point(846, 135);
            this.libCBB.Name = "libCBB";
            this.libCBB.Size = new System.Drawing.Size(157, 28);
            this.libCBB.TabIndex = 9;
            // 
            // shapeCBB
            // 
            this.shapeCBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shapeCBB.FormattingEnabled = true;
            this.shapeCBB.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Ellipse"});
            this.shapeCBB.Location = new System.Drawing.Point(846, 73);
            this.shapeCBB.Name = "shapeCBB";
            this.shapeCBB.Size = new System.Drawing.Size(157, 28);
            this.shapeCBB.TabIndex = 10;
            this.shapeCBB.SelectedIndexChanged += new System.EventHandler(this.changeShape);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(842, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Shape";
            // 
            // libLabel
            // 
            this.libLabel.AutoSize = true;
            this.libLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.libLabel.Location = new System.Drawing.Point(846, 112);
            this.libLabel.Name = "libLabel";
            this.libLabel.Size = new System.Drawing.Size(56, 20);
            this.libLabel.TabIndex = 12;
            this.libLabel.Text = "Library";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exportBtn);
            this.groupBox1.Controls.Add(this.drawBtn);
            this.groupBox1.Controls.Add(this.bLa);
            this.groupBox1.Controls.Add(this.aLa);
            this.groupBox1.Controls.Add(this.cLa);
            this.groupBox1.Controls.Add(this.dLa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(813, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 426);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(113, 347);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(86, 42);
            this.exportBtn.TabIndex = 5;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.dTxtBox);
            this.Controls.Add(this.libLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeCBB);
            this.Controls.Add(this.aTxtBox);
            this.Controls.Add(this.libCBB);
            this.Controls.Add(this.bTxtBox);
            this.Controls.Add(this.cTxtBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Figure Draw";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Label aLa;
        private System.Windows.Forms.Label bLa;
        private System.Windows.Forms.Label cLa;
        private System.Windows.Forms.Label dLa;
        private System.Windows.Forms.TextBox aTxtBox;
        private System.Windows.Forms.TextBox bTxtBox;
        private System.Windows.Forms.TextBox cTxtBox;
        private System.Windows.Forms.TextBox dTxtBox;
        private System.Windows.Forms.Label libLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox shapeCBB;
        private System.Windows.Forms.ComboBox libCBB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exportBtn;
    }
}

