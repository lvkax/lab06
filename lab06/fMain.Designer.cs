namespace lab06
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            cbSphere = new CheckBox();
            cbPyramid = new CheckBox();
            lbSolid = new Label();
            lbLenOrRad = new Label();
            tbLenOrRad = new TextBox();
            lbHeight = new Label();
            tbHeight = new TextBox();
            tbVolume = new TextBox();
            lbVolume = new Label();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // cbSphere
            // 
            cbSphere.AutoSize = true;
            cbSphere.Location = new Point(176, 52);
            cbSphere.Name = "cbSphere";
            cbSphere.Size = new Size(75, 24);
            cbSphere.TabIndex = 0;
            cbSphere.Text = "Сфера";
            cbSphere.UseVisualStyleBackColor = true;
            cbSphere.CheckedChanged += cbSphere_Checked;
            // 
            // cbPyramid
            // 
            cbPyramid.AutoSize = true;
            cbPyramid.Location = new Point(43, 52);
            cbPyramid.Name = "cbPyramid";
            cbPyramid.Size = new Size(94, 24);
            cbPyramid.TabIndex = 1;
            cbPyramid.Text = "Піраміда";
            cbPyramid.UseVisualStyleBackColor = true;
            cbPyramid.CheckedChanged += cbPyramid_Checked;
            // 
            // lbSolid
            // 
            lbSolid.AutoSize = true;
            lbSolid.Location = new Point(43, 18);
            lbSolid.Name = "lbSolid";
            lbSolid.Size = new Size(197, 20);
            lbSolid.TabIndex = 2;
            lbSolid.Text = "Виберіть геометричне тіло";
            // 
            // lbLenOrRad
            // 
            lbLenOrRad.AutoSize = true;
            lbLenOrRad.Location = new Point(43, 109);
            lbLenOrRad.Name = "lbLenOrRad";
            lbLenOrRad.Size = new Size(63, 20);
            lbLenOrRad.TabIndex = 3;
            lbLenOrRad.Text = "---------";
            // 
            // tbLenOrRad
            // 
            tbLenOrRad.Location = new Point(43, 149);
            tbLenOrRad.Name = "tbLenOrRad";
            tbLenOrRad.Size = new Size(101, 27);
            tbLenOrRad.TabIndex = 4;
            // 
            // lbHeight
            // 
            lbHeight.AutoSize = true;
            lbHeight.Location = new Point(176, 109);
            lbHeight.Name = "lbHeight";
            lbHeight.Size = new Size(113, 20);
            lbHeight.TabIndex = 5;
            lbHeight.Text = "Введіть висоту:";
            lbHeight.Visible = false;
            // 
            // tbHeight
            // 
            tbHeight.Location = new Point(176, 149);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(101, 27);
            tbHeight.TabIndex = 6;
            tbHeight.Visible = false;
            // 
            // tbVolume
            // 
            tbVolume.Location = new Point(43, 304);
            tbVolume.Name = "tbVolume";
            tbVolume.ReadOnly = true;
            tbVolume.Size = new Size(125, 27);
            tbVolume.TabIndex = 7;
            // 
            // lbVolume
            // 
            lbVolume.AutoSize = true;
            lbVolume.BackColor = SystemColors.Control;
            lbVolume.Location = new Point(43, 263);
            lbVolume.Name = "lbVolume";
            lbVolume.Size = new Size(83, 20);
            lbVolume.TabIndex = 8;
            lbVolume.Text = "Об'єм тіла:";
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.MediumSpringGreen;
            btnCalc.ForeColor = SystemColors.ControlText;
            btnCalc.Location = new Point(176, 203);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(113, 29);
            btnCalc.TabIndex = 9;
            btnCalc.Text = "Розрахувати ";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(339, 363);
            Controls.Add(btnCalc);
            Controls.Add(lbVolume);
            Controls.Add(tbVolume);
            Controls.Add(tbHeight);
            Controls.Add(lbHeight);
            Controls.Add(tbLenOrRad);
            Controls.Add(lbLenOrRad);
            Controls.Add(lbSolid);
            Controls.Add(cbPyramid);
            Controls.Add(cbSphere);
            Name = "fMain";
            Text = "Лабораторна робота №6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbSphere;
        private CheckBox cbPyramid;
        private Label lbSolid;
        private Label lbLenOrRad;
        private TextBox tbLenOrRad;
        private Label lbHeight;
        private TextBox tbHeight;
        private TextBox tbVolume;
        private Label lbVolume;
        private Button btnCalc;
    }
}




