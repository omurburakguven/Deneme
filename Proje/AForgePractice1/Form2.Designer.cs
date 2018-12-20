namespace AForgePractice1
{
    partial class Form2
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
            this.btnSelectVideoResolution = new System.Windows.Forms.Button();
            this.cbVideoResolutions = new System.Windows.Forms.ComboBox();
            this.btnSelectCaptureDevice = new System.Windows.Forms.Button();
            this.cbCaptureDevices = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pbCloneimage = new System.Windows.Forms.PictureBox();
            this.pbOrjinalimage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCloneimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrjinalimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectVideoResolution
            // 
            this.btnSelectVideoResolution.Enabled = false;
            this.btnSelectVideoResolution.Location = new System.Drawing.Point(395, 61);
            this.btnSelectVideoResolution.Name = "btnSelectVideoResolution";
            this.btnSelectVideoResolution.Size = new System.Drawing.Size(75, 23);
            this.btnSelectVideoResolution.TabIndex = 9;
            this.btnSelectVideoResolution.Text = "Seç";
            this.btnSelectVideoResolution.UseVisualStyleBackColor = true;
            this.btnSelectVideoResolution.Click += new System.EventHandler(this.btnSelectVideoResolution_Click);
            // 
            // cbVideoResolutions
            // 
            this.cbVideoResolutions.Enabled = false;
            this.cbVideoResolutions.FormattingEnabled = true;
            this.cbVideoResolutions.Location = new System.Drawing.Point(30, 61);
            this.cbVideoResolutions.Name = "cbVideoResolutions";
            this.cbVideoResolutions.Size = new System.Drawing.Size(359, 21);
            this.cbVideoResolutions.TabIndex = 8;
            // 
            // btnSelectCaptureDevice
            // 
            this.btnSelectCaptureDevice.Location = new System.Drawing.Point(761, 31);
            this.btnSelectCaptureDevice.Name = "btnSelectCaptureDevice";
            this.btnSelectCaptureDevice.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCaptureDevice.TabIndex = 7;
            this.btnSelectCaptureDevice.Text = "Seç";
            this.btnSelectCaptureDevice.UseVisualStyleBackColor = true;
            this.btnSelectCaptureDevice.Click += new System.EventHandler(this.btnSelectCaptureDevice_Click);
            // 
            // cbCaptureDevices
            // 
            this.cbCaptureDevices.FormattingEnabled = true;
            this.cbCaptureDevices.Location = new System.Drawing.Point(29, 33);
            this.cbCaptureDevices.Name = "cbCaptureDevices";
            this.cbCaptureDevices.Size = new System.Drawing.Size(726, 21);
            this.cbCaptureDevices.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1120, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(952, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // pbCloneimage
            // 
            this.pbCloneimage.Location = new System.Drawing.Point(698, 110);
            this.pbCloneimage.Name = "pbCloneimage";
            this.pbCloneimage.Size = new System.Drawing.Size(640, 480);
            this.pbCloneimage.TabIndex = 20;
            this.pbCloneimage.TabStop = false;
            // 
            // pbOrjinalimage
            // 
            this.pbOrjinalimage.Location = new System.Drawing.Point(29, 110);
            this.pbOrjinalimage.Name = "pbOrjinalimage";
            this.pbOrjinalimage.Size = new System.Drawing.Size(640, 480);
            this.pbOrjinalimage.TabIndex = 19;
            this.pbOrjinalimage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 642);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 639);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(490, 699);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(289, 699);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 699);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(490, 658);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 23;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(285, 658);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 22;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(72, 658);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pbCloneimage);
            this.Controls.Add(this.pbOrjinalimage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSelectVideoResolution);
            this.Controls.Add(this.cbVideoResolutions);
            this.Controls.Add(this.btnSelectCaptureDevice);
            this.Controls.Add(this.cbCaptureDevices);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbCloneimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrjinalimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectVideoResolution;
        private System.Windows.Forms.ComboBox cbVideoResolutions;
        private System.Windows.Forms.Button btnSelectCaptureDevice;
        private System.Windows.Forms.ComboBox cbCaptureDevices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pbCloneimage;
        private System.Windows.Forms.PictureBox pbOrjinalimage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.IO.Ports.SerialPort serialPort2;
    }
}