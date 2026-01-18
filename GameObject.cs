using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plohoe_TZ_result_HZ
{
    internal abstract class GameObject
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        private bool IsActive { get; set; }

        public GameObject(int Id, string Name, bool IsActive = true)
        {
            this.Id = Id;
            this.Name = Name;
            this.IsActive = true;
        }

        public void Enable ()
        {
            IsActive = true;
        }
        public void Disable () 
        {
            IsActive = false;
        }
        public abstract string Info();
    }
}
