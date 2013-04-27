using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using EXControls;

namespace Tileset_Editor
{
    public partial class Form1 : Form
    {
		public Form1()
        {
            InitializeComponent();

			MapGridView view = new MapGridView(exListView);
        }

		private void mapToTilesetButton_Click(object sender, EventArgs e)
		{
			/*if (tileSizeTextbox.Text != "hello")
				tileSizeToolTip.Show("hello", tileSizeTextbox, new Point(tileSizeTextbox.Width, 0));
			 * */
			int result;
			bool tileSizeError = !int.TryParse(tileSizeTextbox.Text, out result);
			if (tileSizeError)
				MessageBox.Show("Tile size must be an integer!");
			else if (!File.Exists(mapToTilesetTextbox.Text))
				MessageBox.Show("Map image does not exist!");
			else if (!IsValidImage(mapToTilesetTextbox.Text))
				MessageBox.Show("Map image is not a valid image file!");
			else
			{	
				int tileSize = int.Parse(tileSizeTextbox.Text);
				Image mapImage = Image.FromFile(mapToTilesetTextbox.Text);
				int[,] tileMapping;
				DateTime before = DateTime.Now;
				Tileset output = Util.generateTileset(mapImage, tileSize, 10, updateProgressBar, out tileMapping);
				TimeSpan span = new TimeSpan(DateTime.Now.Ticks - before.Ticks);
				long seconds = span.Ticks / TimeSpan.TicksPerSecond;
				long millis = span.Ticks / TimeSpan.TicksPerMillisecond;

				System.GC.Collect();

				TilesetOutputDialog outputDialog = new TilesetOutputDialog(output, mapImage.Width * mapImage.Height / tileSize / tileSize, millis);
				outputDialog.ShowDialog();
				
			}
		}

		private int updateProgressBar(double progress)
		{
			int previousVal = mapToTilesetProgressBar.Value;
			int newVal = (int)(progress * 100);
			if (newVal > previousVal + 1)
				mapToTilesetProgressBar.Value = (int)(progress * 100);
			return 0;
		}

		private void mapImageToTilesetButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = getImageFilter();

			if (fileDialog.ShowDialog() == DialogResult.OK)
				mapToTilesetTextbox.Text = fileDialog.FileName;

			
		}

		private static string getImageFilter()
		{
			var filter = "";
			
			ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

			string extString = "";

			foreach (var c in codecs)
			{
				extString += c.FilenameExtension.ToLower() + ";";
			}

			filter = "Image files|" + extString;
			return filter;
		}

		private static bool IsValidImage(string filename)
		{
			try
			{
				Image newImage = Image.FromFile(filename);
			}
			catch (OutOfMemoryException)
			{
				return false;
			}
			return true;
		}

    }
}
