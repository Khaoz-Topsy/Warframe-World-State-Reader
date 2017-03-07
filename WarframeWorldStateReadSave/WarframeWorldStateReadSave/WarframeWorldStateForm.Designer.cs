namespace WarframeWorldStateReadSave
{
    partial class WarframeWorldStateForm
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
            this.BtnReadData = new System.Windows.Forms.Button();
            this.richDisplay = new System.Windows.Forms.RichTextBox();
            this.BtnSaveToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnReadData
            // 
            this.BtnReadData.Location = new System.Drawing.Point(12, 12);
            this.BtnReadData.Name = "BtnReadData";
            this.BtnReadData.Size = new System.Drawing.Size(375, 50);
            this.BtnReadData.TabIndex = 0;
            this.BtnReadData.Text = "Read Warframe World State";
            this.BtnReadData.UseVisualStyleBackColor = true;
            this.BtnReadData.Click += new System.EventHandler(this.BtnReadData_Click);
            // 
            // richDisplay
            // 
            this.richDisplay.Location = new System.Drawing.Point(12, 68);
            this.richDisplay.Name = "richDisplay";
            this.richDisplay.Size = new System.Drawing.Size(756, 477);
            this.richDisplay.TabIndex = 1;
            this.richDisplay.Text = "";
            // 
            // BtnSaveToFile
            // 
            this.BtnSaveToFile.Enabled = false;
            this.BtnSaveToFile.Location = new System.Drawing.Point(393, 12);
            this.BtnSaveToFile.Name = "BtnSaveToFile";
            this.BtnSaveToFile.Size = new System.Drawing.Size(375, 50);
            this.BtnSaveToFile.TabIndex = 2;
            this.BtnSaveToFile.Text = "Save to file";
            this.BtnSaveToFile.UseVisualStyleBackColor = true;
            // 
            // WarframeWorldStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.BtnSaveToFile);
            this.Controls.Add(this.richDisplay);
            this.Controls.Add(this.BtnReadData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WarframeWorldStateForm";
            this.Text = "Warframe World State Read and Save";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnReadData;
        private System.Windows.Forms.RichTextBox richDisplay;
        private System.Windows.Forms.Button BtnSaveToFile;
    }
}

