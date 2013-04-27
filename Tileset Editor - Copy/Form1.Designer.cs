namespace Tileset_Editor
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
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.mapToTilesetProgressBar = new System.Windows.Forms.ProgressBar();
			this.mapToTilesetButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.mapImageToTilesetButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tileSizeTextbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.mapToTilesetTextbox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.tileSizeToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.exListView = new EXControls.EXListView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.mapToTilesetProgressBar);
			this.groupBox1.Controls.Add(this.mapToTilesetButton);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.mapImageToTilesetButton);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tileSizeTextbox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.mapToTilesetTextbox);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(445, 106);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Convert Map Image to Tileset (JSON)";
			// 
			// mapToTilesetProgressBar
			// 
			this.mapToTilesetProgressBar.Location = new System.Drawing.Point(74, 74);
			this.mapToTilesetProgressBar.Name = "mapToTilesetProgressBar";
			this.mapToTilesetProgressBar.Size = new System.Drawing.Size(247, 23);
			this.mapToTilesetProgressBar.Step = 1;
			this.mapToTilesetProgressBar.TabIndex = 7;
			// 
			// mapToTilesetButton
			// 
			this.mapToTilesetButton.Location = new System.Drawing.Point(327, 74);
			this.mapToTilesetButton.Name = "mapToTilesetButton";
			this.mapToTilesetButton.Size = new System.Drawing.Size(75, 23);
			this.mapToTilesetButton.TabIndex = 6;
			this.mapToTilesetButton.Text = "Convert";
			this.mapToTilesetButton.UseVisualStyleBackColor = true;
			this.mapToTilesetButton.Click += new System.EventHandler(this.mapToTilesetButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(107, 25);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(18, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "px";
			// 
			// mapImageToTilesetButton
			// 
			this.mapImageToTilesetButton.Location = new System.Drawing.Point(327, 46);
			this.mapImageToTilesetButton.Name = "mapImageToTilesetButton";
			this.mapImageToTilesetButton.Size = new System.Drawing.Size(92, 23);
			this.mapImageToTilesetButton.TabIndex = 4;
			this.mapImageToTilesetButton.Text = "Choose File";
			this.mapImageToTilesetButton.UseVisualStyleBackColor = true;
			this.mapImageToTilesetButton.Click += new System.EventHandler(this.mapImageToTilesetButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tile size:";
			// 
			// tileSizeTextbox
			// 
			this.tileSizeTextbox.Location = new System.Drawing.Point(73, 22);
			this.tileSizeTextbox.Name = "tileSizeTextbox";
			this.tileSizeTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tileSizeTextbox.Size = new System.Drawing.Size(34, 20);
			this.tileSizeTextbox.TabIndex = 0;
			this.tileSizeTextbox.Text = "16";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Map image:";
			// 
			// mapToTilesetTextbox
			// 
			this.mapToTilesetTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.mapToTilesetTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.mapToTilesetTextbox.Location = new System.Drawing.Point(74, 48);
			this.mapToTilesetTextbox.Name = "mapToTilesetTextbox";
			this.mapToTilesetTextbox.Size = new System.Drawing.Size(247, 20);
			this.mapToTilesetTextbox.TabIndex = 1;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// tileSizeToolTip
			// 
			this.tileSizeToolTip.IsBalloon = true;
			this.tileSizeToolTip.ShowAlways = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 155);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(517, 370);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.AllowDrop = true;
			this.tabPage1.Controls.Add(this.exListView);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(509, 344);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Create Tileset";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// exListView
			// 
			this.exListView.AllowDrop = true;
			this.exListView.ControlPadding = 4;
			this.exListView.FullRowSelect = true;
			this.exListView.Location = new System.Drawing.Point(6, 42);
			this.exListView.Name = "exListView";
			this.exListView.OwnerDraw = true;
			this.exListView.Size = new System.Drawing.Size(497, 188);
			this.exListView.TabIndex = 1;
			this.exListView.UseCompatibleStateImageBehavior = false;
			this.exListView.View = System.Windows.Forms.View.Details;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(509, 344);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Add Properties";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 569);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mapToTilesetTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mapImageToTilesetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tileSizeTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip tileSizeToolTip;
		private System.Windows.Forms.Button mapToTilesetButton;
		private System.Windows.Forms.ProgressBar mapToTilesetProgressBar;
		private EXControls.EXListView exListView;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
    }
}

