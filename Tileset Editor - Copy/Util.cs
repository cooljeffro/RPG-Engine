using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Tileset_Editor
{
	class Util
	{
		public static bool doRectanglesMatch(Bitmap map, Rectangle rect1, Rectangle rect2)
		{
			for (int i = 0; i < rect1.Width; i++)
			{
				for (int j = 0; j < rect1.Height; j++)
				{
					if (map.GetPixel(rect1.X + i, rect1.Y + j).ToArgb() != map.GetPixel(rect2.X + i, rect2.Y + j).ToArgb())
					{
						return false;
					}
				}
			}
			return true;
		}

		public static Tileset generateTileset(Image map, int tileSize, int rowLength, Func<double, int> onProgressUpdate, out int[,] tileMapping)
		{
			List<Rectangle> uniqueTiles = new List<Rectangle>();
			List<Rectangle>[] firstPixelMap = new List<Rectangle>[256*256*256];
			LockedImage lockedImage = new LockedImage(map, tileSize);

			int d2 = 256 * 256;
			int midWay = tileSize / 2;

			Bitmap mapBitmap = new Bitmap(map);

			int tilesPerColumn = map.Height / tileSize;
			int tilesPerRow = map.Width / tileSize;

			tileMapping = new int[tilesPerRow,tilesPerColumn];

			double totalTiles = tilesPerColumn * tilesPerRow;

			bool done = false;
			for (int i = 0; !done; i++)
			{	
				onProgressUpdate((i / totalTiles));
				
				if (i / tilesPerRow == tilesPerColumn)
				{
					done = true;
					continue;
				}

				var x = i % tilesPerRow;
				var y = i / tilesPerRow;

				Rectangle r = new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize);
				byte[] firstBytes = lockedImage.getPixelBytes(r.X + midWay, r.Y + midWay);
				int firstColor = int.Parse("" + ((d2)*firstBytes[0] + (256)*firstBytes[1] + firstBytes[2]));

				bool matchFound = false;

				List<Rectangle> listToCheck = firstPixelMap[firstColor];
				int count = 0;
				if (listToCheck != null)
					count = listToCheck.Count;

				for (int j = 0; !matchFound && j < count; j++)
				{
					if (lockedImage.doRectanlgesMatch(r, listToCheck[j]))
					{
						matchFound = true;
						tileMapping[x, y] = j;
					}
				}
				if (!matchFound)
				{
					uniqueTiles.Add(r);
					tileMapping[x, y] = uniqueTiles.Count - 1;

					if (firstPixelMap[firstColor] == null)
						firstPixelMap[firstColor] = new List<Rectangle>();
					else
						firstPixelMap[firstColor].Add(r);
				}
			}

			int columnLength = (uniqueTiles.Count / rowLength) + 1;
			Bitmap outputTileSet = new Bitmap(rowLength * tileSize, columnLength * tileSize);

			Graphics g = Graphics.FromImage(outputTileSet);
			g.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, outputTileSet.Width, outputTileSet.Height));

			for (int i = 0; i < uniqueTiles.Count; i++)
			{
				Rectangle r = new Rectangle((i % rowLength) * tileSize, (i / rowLength) * tileSize, tileSize, tileSize);
				g.DrawImage(map, r, uniqueTiles[i], GraphicsUnit.Pixel);
			}

			Tileset result = new Tileset(tileSize, tilesPerRow, outputTileSet, uniqueTiles.Count);
			return result;
		}

		public static string ImageToBase64(Image image)
		{
			MemoryStream ms = new MemoryStream();

			// Convert Image to byte[]
			image.Save(ms, ImageFormat.Bmp);
			byte[] imageBytes = ms.ToArray();

			// Convert byte[] to Base64 String
			string base64String = Convert.ToBase64String(imageBytes);
			return base64String;
		}

		public static Image Base64ToImage(string base64String)
		{
			// Convert Base64 String to byte[]
			byte[] imageBytes = Convert.FromBase64String(base64String);
			MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

			// Convert byte[] to Image
			ms.Write(imageBytes, 0, imageBytes.Length);
			Image image = Image.FromStream(ms, true);
			return image;
		}

		public static string addExtension(string filename, string extension)
		{
			if (filename.Substring(filename.Length - extension.Length) != extension)
				return filename + "." + extension;
			else
				return filename;
		}

		public static string removeExtension(string filename, string extension)
		{
			if (filename.Substring(filename.Length - extension.Length) != extension)
				return filename;
			else
				return filename.Substring(0, filename.Length - extension.Length - 1);
		}
	}
}
