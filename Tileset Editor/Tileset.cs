using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using Newtonsoft.Json;
using System.IO;

namespace Tileset_Editor
{
	public class Tileset
	{
		public Bitmap image;
		public int tileSize;
		public List<Tile> tileList;
		public int tilesPerRow;

		public Tileset(int tileSize, int tilesPerRow, Bitmap image, int uniqueTiles)
		{
			this.tileSize = tileSize;
			this.tilesPerRow = tilesPerRow;
			this.image = image;

			this.tileList = new List<Tile>();
			for (int i = 0; i < uniqueTiles; i++)
			{
				Tile tile = new Tile();
				tileList.Add(tile);
			}
		}

		public void saveToFile(string tilesetFilename, string imageFilename)
		{
			tilesetFilename = Util.addExtension(tilesetFilename, "json");
			imageFilename = Util.addExtension(
				Util.removeExtension(imageFilename, "json"), "bmp");
			
			TilesetJSON tilesetJSON = new TilesetJSON(this, false);
			tilesetJSON.setImageFilename(imageFilename);

			string json = JsonConvert.SerializeObject(tilesetJSON, Formatting.Indented);
			File.WriteAllText(tilesetFilename, json);

			image.Save(imageFilename, ImageFormat.Bmp);
		}

		public void saveToFile(string filename)
		{
			filename = Util.addExtension(filename, "json");
			
			TilesetJSON tilesetJSON = new TilesetJSON(this, true);
			string base64Tileset = Util.ImageToBase64(this.image);
			tilesetJSON.setImageData(base64Tileset, "bmp");

			string json = JsonConvert.SerializeObject(tilesetJSON, Formatting.Indented);
			File.WriteAllText(filename, json);
		}
	}

	public class Tile
	{
		public Dictionary<string, object> properties;
		
		public Tile()
		{
			properties = new Dictionary<string, object>();
		}

		public Tile(Dictionary<string, object> properties)
		{
			this.properties = properties;
		}

		public void addProperty(string key, object value)
		{
			properties.Add(key, value);
		}
	}

	class TilesetJSON
	{
		public int tileSize;
		public List<Tile> tiles;
		public Dictionary<string, string> tilesetImage;
		public Dictionary<string, string> defaultProperties;
		
		public TilesetJSON(Tileset source, bool imageIsEmbedded)
		{
			tileSize = source.tileSize;
			tiles = source.tileList;
			tilesetImage = new Dictionary<string, string>();
			defaultProperties = new Dictionary<string, string>();

			if (imageIsEmbedded)
				tilesetImage.Add("type", "base64");
			else
				tilesetImage.Add("type", "file");
		}

		public void setImageData(string imageBase64, string format)
		{
			tilesetImage.Add("data", imageBase64);
			tilesetImage.Add("format", format);
		}

		public void setImageFilename(string filename)
		{
			tilesetImage.Add("filename", filename);
		}
	}
}
