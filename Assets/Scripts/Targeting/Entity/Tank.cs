using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Baller.Entity
{
    public class Tank : Shootable
    {

        public int tankLife;
        
        
        public override void OnHit() 
            {
                
                if (tankLife > 0)
                {
                    tankLife--;
                }
                else
                {
                    Destroy(gameObject);
                }
            }

            public override int getPoitsForShootable()
        {
            return 30;
        }
        
        
    }

}