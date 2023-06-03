using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baller.Entity
{
    public class FliegerTWO : Shootable 
    {
        public override int getPoitsForShootable()
        {
            return 15;
        }

        public override void OnHit()
        {
            Destroy(gameObject);
            //gun.SubLife();
        } 
        
}
}
