using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baller.Entity
{
    public class Flieger : Shootable 
    {
        public override int getPoitsForShootable()
        {
            return 10;
        }

        public override void OnHit()
        {
            Destroy(gameObject);
            //gun.SubLife();
        } 
        
}
}
