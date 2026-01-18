using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plohoe_TZ_result_HZ
{
    internal class Light : GameObject, ITriggerable
    {
        private bool IsOn;
        public Light(int Id, string Name, bool IsActive = true, bool isOn = false) : base(Id, Name, IsActive)
        {
            IsOn = isOn;
        }
        public void Trigger()
        {
            if (IsOn)
            {
                IsOn = false;
            }
            else
            {
                IsOn = true;
            }
        }
        public override string Info()
        {
            throw new NotImplementedException();
        }
    }
}
