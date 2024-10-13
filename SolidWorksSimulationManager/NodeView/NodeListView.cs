using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace SolidWorksSimulationManager
{
    public abstract class NodeListView
    {

        protected ListView listView;

        protected List<ListViewItem> items;

        protected IEnumerable<Node> nodes;

        public NodeListView(ListView listView, IEnumerable<Node> nodes) {

            this.listView = listView;
            this.nodes = nodes;
        }

        protected void SetListViewSettings(int countNodes) {

            this.listView.Columns.Clear();

            this.listView.Items.Clear();

            this.listView.LabelEdit = false;

            this.listView.Scrollable = true;

            this.listView.MultiSelect = false;

            this.listView.FullRowSelect = true;

            this.listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            this.listView.View = View.Details;

            this.listView.GridLines  = true;

            this.listView.VirtualMode = true;

            this.listView.VirtualListSize = countNodes;

            this.listView.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(RetrieveVirtualItem);  

        }

        protected void FillListView(IEnumerable<Node> nodes) {

            this.listView.Columns.AddRange(GetHeaders(GetParams()).ToArray());
            this.items = GetItems(nodes);

        }

        public abstract IEnumerable<string> GetParams();

        public abstract float GetParam(Node node,string param);

        public List<ListViewItem> GetItems(IEnumerable<Node> nodes)
        {
            List<ListViewItem> result = new List<ListViewItem>();

            IEnumerable<string> param = GetParams();

            foreach (Node node in nodes)
            {

                result.Add(GetItem(node, param));


            }

            return result;
        }

        public ListViewItem GetItem(Node node, IEnumerable<string> param)
        {

            ListViewItem item = new ListViewItem(node.number.ToString());

            foreach (string key in param)
            {

                item.SubItems.Add(GetParam(node, key).ToString());
            }

            return item;
        }

        private IEnumerable<ColumnHeader> GetHeaders(IEnumerable<string> param) {

            List<ColumnHeader> headers = new List<ColumnHeader>();

            headers.Add(new ColumnHeader() { 
                Text = "Id",
                Name = "Id",
                TextAlign = HorizontalAlignment.Center,
                Width = 100,
            });

            foreach (string name in param) {

                ColumnHeader header = new ColumnHeader() {
                    Text = name,
                    Name = name,
                    TextAlign = HorizontalAlignment.Center,
                    Width = 100,
                };

                headers.Add(header);
            }

            return headers;
        }

        public Node GetSelectedItem() {
            int number = -1;

            foreach (int index in listView.SelectedIndices) {

                number = Convert.ToInt32(items[index].Text) - 1;
            }

            return number != -1 ? nodes.ElementAt(number) : null;          
        }

        public IEnumerable<Node> GetRange(string param, float min, float max)
        {

            if (max < min) {
                float temp = min;
                min = max;
                max = temp;
            }

            IEnumerable<Node> rangeNodes = null;

            IEnumerable<IGrouping<bool, Node>> result =
                nodes.GroupBy(
                    (node) => {

                        float value = GetParam(node,param);
                        return value >= min && value <= max;
                    }
                );

            foreach (IGrouping<bool, Node> group in result)
            {

                if (group.Key)
                {
                    rangeNodes = group.ToList();
                    break;
                }

            }

            return rangeNodes;

        }

        private void RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {

            if (e.ItemIndex <= items.Count())
            {
                e.Item = items[e.ItemIndex];
            }
            else {
                e.Item = items[items.Count() - 1];
            }
           
        }

    }
}
