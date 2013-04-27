using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Tileset_Editor
{
	class LockedImage
	{
		private Bitmap image;

		private byte[] byteArray1;
		private byte[] byteArray2;
		private int stride;
		private int tileSize;
		
		public LockedImage(string filename, int tileSize)
		{
			image = (Bitmap)Image.FromFile(filename);
			init(tileSize);
		}

		public LockedImage(Image srcImage, int tileSize)
		{
			image = (Bitmap)srcImage;
			init(tileSize);
		}

		public void init(int tileSize)
		{
			this.tileSize = tileSize;
			Rectangle bounds = new Rectangle(0, 0, image.Width, image.Height);
			BitmapData bitmapData = image.LockBits(bounds, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

			stride = bitmapData.Stride;
			byteArray1 = new byte[stride * image.Height];
			byteArray2 = new byte[stride * image.Height];
			Marshal.Copy(bitmapData.Scan0, byteArray1, 0, byteArray1.Length);
			Marshal.Copy(bitmapData.Scan0, byteArray2, 0, byteArray2.Length);

			image.UnlockBits(bitmapData);
		}

		public byte[] getPixelBytes(int x, int y)
		{
			byte[] result = new byte[3];
			int startIndex = y * stride + x * 3;

			result[2] = byteArray1[startIndex];
			result[1] = byteArray1[startIndex+1];
			result[0] = byteArray1[startIndex+2];
			return result;
		}

		public Color getPixelColor(int x, int y)
		{
			byte[] bytes = getPixelBytes(x, y);
			return Color.FromArgb((int)bytes[0], (int)bytes[1], (int)bytes[2]);
		}

		public bool doRectanlgesMatch(Rectangle r1, Rectangle r2)
		{
			int r1x = r1.X;
			int r1y = r1.Y;
			int r2x = r2.X;
			int r2y = r2.Y;
			int width = r1.Width;
			int height = r1.Height;
			int i = 0;
			int j = 0;
			byte[] b1, b2;
			
			for (i = 0; i < height; i++)
			{	
				for (j = 0; j < width; j++)
				{
					b1 = getPixelBytes(r1x + j, r1y + i);
					b2 = getPixelBytes(r2x + j, r2y + i);

					if (b1[0] != b2[0] || b1[1] != b2[1] || b1[2] != b2[2])
						return false;
				}
			}
			return true;

			/*
			for (i = 0; i < height; i++)
			{
				int offset1 = r1y * stride + r1x * 3;
				int offset2 = r2y * stride + r2x * 3;

				if (CompareBuffers(byteArray1, offset1, byteArray2, offset2, width * 3) != 0)
					return false;
			}
			return true;
			 * */
		}

		[DllImport("msvcrt.dll")]
		private static extern unsafe int memcmp(byte* b1, byte* b2, int count);

		public static unsafe int CompareBuffers(byte[] buffer1, int offset1, byte[] buffer2, int offset2, int count)
		{
			fixed (byte* b1 = buffer1, b2 = buffer2)
			{
				return memcmp(b1 + offset1, b2 + offset2, count);
			}
		}
	}
}
