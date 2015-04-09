using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gtfx
{
    public class ComponentCollection
        : Collection<IComponent>
    {
        protected override void InsertItem(int index, IComponent item)
        {
            if (item.GetType() == typeof(TransformComponent))
            {
                /** let the tranform manager track **/
            }
            else if (item.GetType() == typeof(ColliderComponent))
            {
                /** let the collision manager track **/
            }
            base.InsertItem(index, item);
        }
    }
}
