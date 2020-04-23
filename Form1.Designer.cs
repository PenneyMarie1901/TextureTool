using System;

namespace TextureTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraEffectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipImageVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipImageHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resizeToGameTextureButton = new System.Windows.Forms.Button();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSelectFolder = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.batchResizeButton = new System.Windows.Forms.Button();
            this.textBoxBatchHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBatchWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.extraEffectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageFileToolStripMenuItem,
            this.saveImageFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImageFileToolStripMenuItem
            // 
            this.openImageFileToolStripMenuItem.Name = "openImageFileToolStripMenuItem";
            this.openImageFileToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openImageFileToolStripMenuItem.Text = "Open Image File";
            this.openImageFileToolStripMenuItem.Click += new System.EventHandler(this.openImageFileToolStripMenuItem_Click);
            // 
            // saveImageFileToolStripMenuItem
            // 
            this.saveImageFileToolStripMenuItem.Name = "saveImageFileToolStripMenuItem";
            this.saveImageFileToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveImageFileToolStripMenuItem.Text = "Save Image File";
            this.saveImageFileToolStripMenuItem.Click += new System.EventHandler(this.saveImageFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayScaleToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.grayScaleToolStripMenuItem.Text = "GrayScale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click_1);
            // 
            // extraEffectsToolStripMenuItem
            // 
            this.extraEffectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipImageVerticallyToolStripMenuItem,
            this.flipImageHorizontallyToolStripMenuItem});
            this.extraEffectsToolStripMenuItem.Name = "extraEffectsToolStripMenuItem";
            this.extraEffectsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.extraEffectsToolStripMenuItem.Text = "Extra Effects";
            // 
            // flipImageVerticallyToolStripMenuItem
            // 
            this.flipImageVerticallyToolStripMenuItem.Name = "flipImageVerticallyToolStripMenuItem";
            this.flipImageVerticallyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.flipImageVerticallyToolStripMenuItem.Text = "Flip Image Vertically";
            this.flipImageVerticallyToolStripMenuItem.Click += new System.EventHandler(this.flipImageVerticallyToolStripMenuItem_Click);
            // 
            // flipImageHorizontallyToolStripMenuItem
            // 
            this.flipImageHorizontallyToolStripMenuItem.Name = "flipImageHorizontallyToolStripMenuItem";
            this.flipImageHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.flipImageHorizontallyToolStripMenuItem.Text = "Flip Image Horizontally";
            this.flipImageHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.flipImageHorizontallyToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // resizeToGameTextureButton
            // 
            this.resizeToGameTextureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeToGameTextureButton.Location = new System.Drawing.Point(280, 482);
            this.resizeToGameTextureButton.Name = "resizeToGameTextureButton";
            this.resizeToGameTextureButton.Size = new System.Drawing.Size(113, 26);
            this.resizeToGameTextureButton.TabIndex = 2;
            this.resizeToGameTextureButton.Text = "Resize to 128 x 128";
            this.resizeToGameTextureButton.UseVisualStyleBackColor = true;
            this.resizeToGameTextureButton.Click += new System.EventHandler(this.resizeToGameTextureButton_Click);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(12, 460);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(170, 20);
            this.textBoxWidth.TabIndex = 3;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(45, 407);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(114, 18);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Custom Scale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width (In Pixels)";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHeight.Location = new System.Drawing.Point(12, 486);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(170, 20);
            this.textBoxHeight.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height (In Pixels)";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Resize to Custom Scale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(412, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(376, 341);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Original";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Edited";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(280, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "Clear loaded Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSelectFolder
            // 
            this.textBoxSelectFolder.Location = new System.Drawing.Point(412, 393);
            this.textBoxSelectFolder.Name = "textBoxSelectFolder";
            this.textBoxSelectFolder.Size = new System.Drawing.Size(231, 20);
            this.textBoxSelectFolder.TabIndex = 13;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(649, 392);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(139, 23);
            this.buttonSelectFolder.TabIndex = 14;
            this.buttonSelectFolder.Text = "Select Images Folder...";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.ButtonSelectFolder_Click);
            // 
            // batchResizeButton
            // 
            this.batchResizeButton.Location = new System.Drawing.Point(412, 483);
            this.batchResizeButton.Name = "batchResizeButton";
            this.batchResizeButton.Size = new System.Drawing.Size(231, 23);
            this.batchResizeButton.TabIndex = 17;
            this.batchResizeButton.Text = "Batch Resize";
            this.batchResizeButton.UseVisualStyleBackColor = true;
            this.batchResizeButton.Click += new System.EventHandler(this.BatchResizeButton_Click);
            // 
            // textBoxBatchHeight
            // 
            this.textBoxBatchHeight.Location = new System.Drawing.Point(412, 460);
            this.textBoxBatchHeight.Name = "textBoxBatchHeight";
            this.textBoxBatchHeight.Size = new System.Drawing.Size(231, 20);
            this.textBoxBatchHeight.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Enter Scale (pixels)";
            // 
            // textBoxBatchWidth
            // 
            this.textBoxBatchWidth.Location = new System.Drawing.Point(412, 434);
            this.textBoxBatchWidth.Name = "textBoxBatchWidth";
            this.textBoxBatchWidth.Size = new System.Drawing.Size(231, 20);
            this.textBoxBatchWidth.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Height";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(690, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 44);
            this.button3.TabIndex = 23;
            this.button3.Text = "Batch Scale All to 128 x 128";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(690, 464);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 44);
            this.button4.TabIndex = 24;
            this.button4.Text = "Reset all Fields";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBatchWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBatchHeight);
            this.Controls.Add(this.batchResizeButton);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.textBoxSelectFolder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.resizeToGameTextureButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TextureTool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageFileToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resizeToGameTextureButton;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraEffectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipImageVerticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipImageHorizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSelectFolder;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Button batchResizeButton;
        private System.Windows.Forms.TextBox textBoxBatchHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBatchWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

