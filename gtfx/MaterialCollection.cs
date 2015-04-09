using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class MaterialCollection
            : Collection<Material>
    {
        protected override void InsertItem(int index, Material item)
        {
            base.InsertItem(index, item);
        }
    }
}
