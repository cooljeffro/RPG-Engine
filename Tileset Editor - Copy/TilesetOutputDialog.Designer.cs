namespace Tileset_Editor
{
	partial class TilesetOutputDialog
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
			this.outputPanel = new System.Windows.Forms.Panel();
			this.outputPictureBox = new System.Windows.Forms.PictureBox();
			this.encodeBase64RadioButton = new System.Windows.Forms.RadioButton();
			this.encodeFilenameRadioButton = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.durationLabel = new System.Windows.Forms.Label();
			this.uniqueTilesLabel = new System.Windows.Forms.Label();
			this.totalTilesLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.outputPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// outputPanel
			// 
			this.outputPanel.AutoScroll = true;
			this.outputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.outputPanel.Controls.Add(this.outputPictureBox);
			this.outputPanel.Location = new System.Drawing.Point(12, 25);
			this.outputPanel.Name = "outputPanel";
			this.outputPanel.Size = new System.Drawing.Size(502, 271);
			this.outputPanel.TabIndex = 0;
			// 
			// outputPictureBox
			// 
			this.outputPictureBox.Location = new System.Drawing.Point(0, 0);
			this.outputPictureBox.Name = "outputPictureBox";
			this.outputPictureBox.Size = new System.Drawing.Size(100, 50);
			this.outputPictureBox.TabIndex = 0;
			this.outputPictureBox.TabStop = false;
			this.outputPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.outputPictureBox_Paint);
			// 
			// encodeBase64RadioButton
			// 
			this.encodeBase64RadioButton.AutoSize = true;
			this.encodeBase64RadioButton.Checked = true;
			this.encodeBase64RadioButton.Location = new System.Drawing.Point(6, 19);
			this.encodeBase64RadioButton.Name = "encodeBase64RadioButton";
			this.encodeBase64RadioButton.Size = new System.Drawing.Size(175, 17);
			this.encodeBase64RadioButton.TabIndex = 1;
			this.encodeBase64RadioButton.TabStop = true;
			this.encodeBase64RadioButton.Text = "Encode tileset image as base64";
			this.encodeBase64RadioButton.UseVisualStyleBackColor = true;
			// 
			// encodeFilenameRadioButton
			// 
			this.encodeFilenameRadioButton.AutoSize = true;
			this.encodeFilenameRadioButton.Location = new System.Drawing.Point(6, 42);
			this.encodeFilenameRadioButton.Name = "encodeFilenameRadioButton";
			this.encodeFilenameRadioButton.Size = new System.Drawing.Size(227, 17);
			this.encodeFilenameRadioButton.TabIndex = 2;
			this.encodeFilenameRadioButton.Text = "Encode tileset image as filename reference";
			this.encodeFilenameRadioButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Preview Tileset:";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(201, 65);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.durationLabel);
			this.groupBox1.Controls.Add(this.uniqueTilesLabel);
			this.groupBox1.Controls.Add(this.totalTilesLabel);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 305);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(214, 86);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Output Results";
			// 
			// durationLabel
			// 
			this.durationLabel.AutoSize = true;
			this.durationLabel.Location = new System.Drawing.Point(89, 49);
			this.durationLabel.Name = "durationLabel";
			this.durationLabel.Size = new System.Drawing.Size(77, 13);
			this.durationLabel.TabIndex = 5;
			this.durationLabel.Text = "0.001 seconds";
			// 
			// uniqueTilesLabel
			// 
			this.uniqueTilesLabel.AutoSize = true;
			this.uniqueTilesLabel.Location = new System.Drawing.Point(89, 36);
			this.uniqueTilesLabel.Name = "uniqueTilesLabel";
			this.uniqueTilesLabel.Size = new System.Drawing.Size(25, 13);
			this.uniqueTilesLabel.TabIndex = 4;
			this.uniqueTilesLabel.Text = "110";
			// 
			// totalTilesLabel
			// 
			this.totalTilesLabel.AutoSize = true;
			this.totalTilesLabel.Location = new System.Drawing.Point(89, 23);
			this.totalTilesLabel.Name = "totalTilesLabel";
			this.totalTilesLabel.Size = new System.Drawing.Size(37, 13);
			this.totalTilesLabel.TabIndex = 3;
			this.totalTilesLabel.Text = "65536";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Duration:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Tiles detected:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Unique tiles:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.encodeFilenameRadioButton);
			this.groupBox2.Controls.Add(this.encodeBase64RadioButton);
			this.groupBox2.Controls.Add(this.saveButton);
			this.groupBox2.Location = new System.Drawing.Point(232, 305);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(282, 97);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Save tileset to file (JSON)";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.radioButton2);
			this.groupBox3.Controls.Add(this.radioButton1);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Location = new System.Drawing.Point(232, 409);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(282, 100);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Save source map to file (JSON)";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(201, 67);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(7, 20);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(128, 17);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Encode tileset as json";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(7, 44);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(190, 17);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "Encode tileset as fileame reference";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// TilesetOutputDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 572);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.outputPanel);
			this.Name = "TilesetOutputDialog";
			this.Text = "Tileset Output";
			this.outputPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.outputPictureBox)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel outputPanel;
		private System.Windows.Forms.RadioButton encodeBase64RadioButton;
		private System.Windows.Forms.RadioButton encodeFilenameRadioButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.PictureBox outputPictureBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label durationLabel;
		private System.Windows.Forms.Label uniqueTilesLabel;
		private System.Windows.Forms.Label totalTilesLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button button1;
	}
}