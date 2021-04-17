namespace HastaYonetimSistemi_HYS.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pcDoctor = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pcPatient = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pcDiagnosis = new DevExpress.XtraEditors.PictureEdit();
            this.pcExit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDoctor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPatient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDiagnosis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcExit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(392, 36);
            this.labelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.labelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(500, 42);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "HASTANE YÖNETİM SİSTEMİ";
            // 
            // pcDoctor
            // 
            this.pcDoctor.EditValue = ((object)(resources.GetObject("pcDoctor.EditValue")));
            this.pcDoctor.Location = new System.Drawing.Point(90, 148);
            this.pcDoctor.Name = "pcDoctor";
            this.pcDoctor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcDoctor.Properties.Appearance.Options.UseBackColor = true;
            this.pcDoctor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcDoctor.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcDoctor.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pcDoctor.Size = new System.Drawing.Size(137, 130);
            this.pcDoctor.TabIndex = 1;
            this.pcDoctor.Click += new System.EventHandler(this.pcDoctor_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(113, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 26);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "DOKTOR";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(1080, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 26);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "HASTA";
            // 
            // pcPatient
            // 
            this.pcPatient.EditValue = ((object)(resources.GetObject("pcPatient.EditValue")));
            this.pcPatient.Location = new System.Drawing.Point(1048, 148);
            this.pcPatient.Name = "pcPatient";
            this.pcPatient.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcPatient.Properties.Appearance.Options.UseBackColor = true;
            this.pcPatient.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcPatient.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcPatient.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pcPatient.Size = new System.Drawing.Size(137, 130);
            this.pcPatient.TabIndex = 4;
            this.pcPatient.Click += new System.EventHandler(this.pcPatient_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(102, 343);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(121, 26);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "SONUÇLAR";
            // 
            // pcDiagnosis
            // 
            this.pcDiagnosis.EditValue = ((object)(resources.GetObject("pcDiagnosis.EditValue")));
            this.pcDiagnosis.Location = new System.Drawing.Point(90, 375);
            this.pcDiagnosis.Name = "pcDiagnosis";
            this.pcDiagnosis.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcDiagnosis.Properties.Appearance.Options.UseBackColor = true;
            this.pcDiagnosis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcDiagnosis.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcDiagnosis.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pcDiagnosis.Size = new System.Drawing.Size(137, 130);
            this.pcDiagnosis.TabIndex = 8;
            this.pcDiagnosis.Click += new System.EventHandler(this.pcDiagnosis_Click);
            // 
            // pcExit
            // 
            this.pcExit.EditValue = ((object)(resources.GetObject("pcExit.EditValue")));
            this.pcExit.Location = new System.Drawing.Point(1166, 486);
            this.pcExit.Name = "pcExit";
            this.pcExit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pcExit.Properties.Appearance.Options.UseBackColor = true;
            this.pcExit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcExit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcExit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pcExit.Size = new System.Drawing.Size(68, 64);
            this.pcExit.TabIndex = 10;
            this.pcExit.Click += new System.EventHandler(this.pcExit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 593);
            this.Controls.Add(this.pcExit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.pcDiagnosis);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pcPatient);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pcDoctor);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pcDoctor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPatient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDiagnosis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcExit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pcDoctor;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pcPatient;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pcDiagnosis;
        private DevExpress.XtraEditors.PictureEdit pcExit;
    }
}