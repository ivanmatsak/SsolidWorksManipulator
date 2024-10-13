using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace SolidWorksSimulationManager
{
    public class StrainNodeListView : NodeListView
    {
        private IEnumerable<string> parameters;

        public StrainNodeListView(ListView listView, IEnumerable<Node> nodes) : base(listView, nodes) 
        {
            this.parameters = nodes.First().strain.GetParameters().Keys;

            SetListViewSettings(nodes.Count());

            FillListView(nodes);
        }

        public override IEnumerable<string> GetParams()
        {
            return this.parameters;
        }

        public override float GetParam(Node node, string param)
        {
            return node.strain.GetParam(param);
        }
    }
}
