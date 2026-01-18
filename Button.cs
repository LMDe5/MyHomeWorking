using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plohoe_TZ_result_HZ
{
    internal class Button : GameObject, IInteractable
    {
        private ITriggerable target;
        public Button(int Id, string Name, bool IsActive = false, ITriggerable target = null) : base(Id, Name, IsActive)
        {
            this.target = target;
        }
        public string Interact(Player player)
        {
            target.Trigger();
            return "Кнопка нажата!";
        }
        public override string Info()
        {
            throw new NotImplementedException();
        }
    }
}
