using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace SolidWorksFaceManager
{
    public class ColorListBox
    {
        public readonly ListBox listBox;

        private FeatureFaceManager FFM;

        public ColorListBox(ListBox listBox, FeatureFaceManager FFM) {

            this.listBox = listBox;

            this.FFM = FFM;

            SetSettings();

        }

        private void SetSettings()
        {

            listBox.DrawMode = DrawMode.OwnerDrawFixed;

            listBox.SelectionMode = SelectionMode.MultiSimple;

            //listBox.Sorted = true;

            listBox.DrawItem += new DrawItemEventHandler(DrawItem);

            listBox.SelectedIndexChanged += new EventHandler(SelectedIndexChanged);

        }

        public void FillListBoxFreeFaces() {
            listBox.Items.Clear();
            FillListBox(FFM.freeFaces);
        }

        public void FillListBoxLoadFaces() {
            FillListBox(FFM.busyFaces);
        }

        public void FillListBox(IEnumerable<FeatureFace> faces) {
            listBox.Items.Clear();
            listBox.Items.AddRange(faces.ToArray());
        }

        public IEnumerable<FeatureFace> GetSelectedFaces() {

            HashSet<FeatureFace> result = new HashSet<FeatureFace>();

            ListBox.SelectedObjectCollection selectedItems = listBox.SelectedItems;

            foreach (object item in selectedItems)
            {

                FeatureFace featureFace = FFM.nameFaces[item.ToString()];

                result.Add(featureFace);
            }

            return result;
        }

        private void DrawItem(object sender, DrawItemEventArgs e) {

            e.DrawBackground();

            if (e.Index != -1) {

                string text = listBox.Items[e.Index].ToString();

                Color boxColor = FFM.nameFaces[text].color;

                Draw(e, boxColor, text);

            }
            
            e.DrawFocusRectangle();

        }

        private void Draw(DrawItemEventArgs e, Color boxColor, string text) {

            Graphics g = e.Graphics;

            int space = 2;

            int x = e.Bounds.Location.X + space;
            int y = e.Bounds.Location.Y + space;
            int w = 20;
            int h = e.Bounds.Size.Height - 2 * space;


            Rectangle borderBox = new Rectangle(x, y, w, h);

            Rectangle colorBox = new Rectangle(x + space, y + space, w - 2 * space, h - 2 * space);

            Rectangle textBox = e.Bounds;
            textBox.X += 2 * space + w;

            Brush textBrush = Brushes.Black;

            SolidBrush borderBrush = new SolidBrush(Color.Black);

            SolidBrush boxColorBrush = new SolidBrush(boxColor);

            g.FillRectangle(
                borderBrush,
                borderBox);

            g.FillRectangle(
                boxColorBrush,
                colorBox);

            g.DrawString(
                text,
                e.Font,
                textBrush,
                textBox,
                StringFormat.GenericDefault);

        }

        private void SelectedIndexChanged(object sender, EventArgs e) {

            ListBox listBix = (ListBox)sender;

            FFM.freeFaces.First().Select();
            FFM.freeFaces.First().DeSelect();

            foreach (int id in listBix.SelectedIndices) {

                FFM.freeFaces.FirstOrDefault( 
                    (ff) => ff.name == listBix.Items[id].ToString()
                    ).Select(true);
            }

        }
    }

}
