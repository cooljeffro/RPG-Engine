using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Tileset_Editor
{
	public partial class TilesetOutputDialog : Form
	{
		public int tilesToShowHorizontally = 10;
		public int drawScale = 1;

		public Tileset tileset;

		public TilesetOutputDialog(Tileset tileset, int totalTilesDetected, long duration)
		{
			InitializeComponent();
			this.tileset = tileset;
			totalTilesLabel.Text = "" + totalTilesDetected;
			uniqueTilesLabel.Text = "" + tileset.tileList.Count;
			durationLabel.Text = "" + duration;

			drawScale = (outputPanel.Width / tilesToShowHorizontally) / tileset.tileSize;
			outputPictureBox.Width = drawScale * tileset.image.Width;
			outputPictureBox.Height = drawScale * tileset.image.Height;
			outputPictureBox.Invalidate();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveDialog = new SaveFileDialog();
			saveDialog.Filter = "JSON File|*.json";
			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				if (encodeBase64RadioButton.Checked)
				{
					tileset.saveToFile(saveDialog.FileName);
				}
				else
				{
					tileset.saveToFile(saveDialog.FileName, saveDialog.FileName);
				}
				//doneButton.DialogResult = DialogResult.OK;
				//doneButton.Text = "Done";
			}
		}

		private void outputPictureBox_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			g.DrawImage(tileset.image, 0, 0, outputPictureBox.Width, outputPictureBox.Height);
		}
	}
}
