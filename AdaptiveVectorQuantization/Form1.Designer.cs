namespace AdaptiveVectorQuantization
{
    partial class FormAVQ
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
            this.panelOriginalImage = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelDestination = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelThreshold = new System.Windows.Forms.Label();
            this.labelDictionarySize = new System.Windows.Forms.Label();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.panelBlockPaint = new System.Windows.Forms.Panel();
            this.comboBoxDictionarySize = new System.Windows.Forms.ComboBox();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.labelSimulationStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelOriginalImage
            // 
            this.panelOriginalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelOriginalImage.Location = new System.Drawing.Point(12, 12);
            this.panelOriginalImage.Name = "panelOriginalImage";
            this.panelOriginalImage.Size = new System.Drawing.Size(400, 400);
            this.panelOriginalImage.TabIndex = 0;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(15, 438);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(129, 44);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panelDestination
            // 
            this.panelDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDestination.Location = new System.Drawing.Point(921, 12);
            this.panelDestination.Name = "panelDestination";
            this.panelDestination.Size = new System.Drawing.Size(400, 400);
            this.panelDestination.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(15, 589);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(129, 44);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Compress";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.Location = new System.Drawing.Point(164, 504);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(102, 22);
            this.textBoxThreshold.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.Location = new System.Drawing.Point(12, 507);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(72, 17);
            this.labelThreshold.TabIndex = 5;
            this.labelThreshold.Text = "Threshold";
            // 
            // labelDictionarySize
            // 
            this.labelDictionarySize.AutoSize = true;
            this.labelDictionarySize.Location = new System.Drawing.Point(12, 540);
            this.labelDictionarySize.Name = "labelDictionarySize";
            this.labelDictionarySize.Size = new System.Drawing.Size(100, 17);
            this.labelDictionarySize.TabIndex = 8;
            this.labelDictionarySize.Text = "Dictionary size";
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(164, 589);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(129, 44);
            this.buttonDecode.TabIndex = 11;
            this.buttonDecode.Text = "Decompress";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // panelBlockPaint
            // 
            this.panelBlockPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBlockPaint.Location = new System.Drawing.Point(466, 12);
            this.panelBlockPaint.Name = "panelBlockPaint";
            this.panelBlockPaint.Size = new System.Drawing.Size(400, 400);
            this.panelBlockPaint.TabIndex = 12;
            // 
            // comboBoxDictionarySize
            // 
            this.comboBoxDictionarySize.FormattingEnabled = true;
            this.comboBoxDictionarySize.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096",
            "8192",
            "16384",
            "32768",
            "65536",
            "131072",
            "262144"});
            this.comboBoxDictionarySize.Location = new System.Drawing.Point(164, 537);
            this.comboBoxDictionarySize.Name = "comboBoxDictionarySize";
            this.comboBoxDictionarySize.Size = new System.Drawing.Size(102, 24);
            this.comboBoxDictionarySize.TabIndex = 13;
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Location = new System.Drawing.Point(15, 653);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(129, 44);
            this.buttonSimulate.TabIndex = 14;
            this.buttonSimulate.Text = "Simulate";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSimulationStatus
            // 
            this.labelSimulationStatus.AutoSize = true;
            this.labelSimulationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimulationStatus.Location = new System.Drawing.Point(512, 653);
            this.labelSimulationStatus.Name = "labelSimulationStatus";
            this.labelSimulationStatus.Size = new System.Drawing.Size(0, 20);
            this.labelSimulationStatus.TabIndex = 16;
            this.labelSimulationStatus.Visible = false;
            // 
            // FormAVQ
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1482, 712);
            this.Controls.Add(this.labelSimulationStatus);
            this.Controls.Add(this.buttonSimulate);
            this.Controls.Add(this.panelBlockPaint);
            this.Controls.Add(this.comboBoxDictionarySize);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.labelDictionarySize);
            this.Controls.Add(this.labelThreshold);
            this.Controls.Add(this.textBoxThreshold);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelDestination);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.panelOriginalImage);
            this.Name = "FormAVQ";
            this.Text = "Image compression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOriginalImage;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panelDestination;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxThreshold;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.Label labelDictionarySize;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Panel panelBlockPaint;
        private System.Windows.Forms.ComboBox comboBoxDictionarySize;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.Label labelSimulationStatus;
    }
}

