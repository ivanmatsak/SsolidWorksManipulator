using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace SolidWorksSimulationManager
{
    public class ElementListView
    {
        protected ListView listView;

        protected List<ListViewItem> items;

        protected IEnumerable<Element> elements;


        public ElementListView(ListView listView, IEnumerable<Element> elements)
        {

            this.listView = listView;

            this.elements = elements;

            SetListViewSettings(elements.Count());

            FillListView(elements);

        }

        protected void SetListViewSettings(int elements)
        {

            this.listView.Columns.Clear();

            this.listView.Items.Clear();

            this.listView.LabelEdit = false;

            this.listView.Scrollable = true;

            this.listView.MultiSelect = true;

            this.listView.FullRowSelect = true;

            this.listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            this.listView.View = View.Details;

            this.listView.GridLines = true;

            this.listView.VirtualMode = true;

            this.listView.VirtualListSize = elements;

            this.listView.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(RetrieveVirtualItem);

        }

        protected void FillListView(IEnumerable<Element> elements)
        {

            this.listView.Columns.AddRange(GetHeaders().ToArray());
            this.items = GetItems(elements);

        }
        
        public List<ListViewItem> GetItems(IEnumerable<Element> elements)
        {
            List<ListViewItem> result = new List<ListViewItem>();

            foreach (Element element in elements)
            {

                result.Add(GetItem(element));


            }

            return result;
        }

        public ListViewItem GetItem(Element element)
        {

            ListViewItem item = new ListViewItem(element.number.ToString());

            foreach (Node node in element.nodes) {

                item.SubItems.Add(node.ToString());
            }

            return item;
        }

        private IEnumerable<ColumnHeader> GetHeaders()
        {

            List<ColumnHeader> headers = new List<ColumnHeader>();

            headers.Add(new ColumnHeader()
            {
                Text = "Id",
                Name = "Id",
                TextAlign = HorizontalAlignment.Center,
                Width = 100,
            });

            for (int i = 1; i < 5; i ++) {

                ColumnHeader header = new ColumnHeader()
                {
                    Text = "Вершина " + i,
                    Name = "Vertex" + i,
                    TextAlign = HorizontalAlignment.Center,
                    Width = 200,
                };

                headers.Add(header);
            }

            return headers;
        }

        public IEnumerable<Element> GetSelectedItems()
        {
            List<Element> result = new List<Element>();

            foreach (int index in listView.SelectedIndices)
            {

                int number = Convert.ToInt32(items[index].Text);

                Element element = elements.FirstOrDefault(
                        (elem) => { return elem.number == number; }
                    );

                result.Add(element);

            }

            return result;
        }

        private void RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {

            if (e.ItemIndex <= items.Count())
            {
                e.Item = items[e.ItemIndex];
            }
            else
            {
                e.Item = items[items.Count() - 1];
            }

        }

    }
}
