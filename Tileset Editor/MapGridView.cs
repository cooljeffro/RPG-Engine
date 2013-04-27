using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EXControls;
using System.Drawing;
using System.Windows.Forms;

namespace Tileset_Editor
{
	public class MapGridView
	{
		EXListView listView;
		
		public MapGridView(EXListView exListView)
		{
			this.listView = exListView;
			init();
		}

		public MapGridView()
		{
			this.listView = new EXListView();
			init();
		}

		private void init()
		{
			listView.DragDrop += new DragEventHandler(MapGridView_DragDrop);
			listView.DragEnter +=new DragEventHandler(MapGridView_DragEnter);
			
			listView.MySortBrush = SystemBrushes.ControlLight;
			listView.MyHighlightBrush = Brushes.Goldenrod;
			listView.GridLines = true;

			listView.Columns.Add(new EXColumnHeader("No.", 40));
			listView.Columns.Add(new EXColumnHeader("Filename", 120));
			listView.Columns.Add(new EXColumnHeader("Progress", 120));
		}

		private void MapGridView_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

				for (int i = 0; i < files.Length; i++)
				{
					addItem(files[i]);
				}
			}
		}

		private void MapGridView_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		public void addItem(string filename)
		{
			try
			{
				Image image = Image.FromFile(filename);
			}
			catch (Exception e)
			{
				return;
			}

			filename = filename.Split('\\').Last();
			
			listView.BeginUpdate();
			
			EXListViewItem item = new EXListViewItem("" + (listView.Items.Count + 1));
			EXListViewSubItem filenameSubItem = new EXListViewSubItem(filename);
			item.SubItems.Add(filenameSubItem);

			EXControlListViewSubItem cs = new EXControlListViewSubItem();
			ProgressBar b = new ProgressBar();
			b.Tag = item;
			b.Minimum = 0;
			b.Maximum = 100;
			b.Step = 1;
			item.SubItems.Add(cs);
			listView.AddControlToSubItem(b, cs);
			listView.Items.Add(item);

			listView.EndUpdate();
		}

	}
}
