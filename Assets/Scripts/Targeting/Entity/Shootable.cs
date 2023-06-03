using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace Baller.Entity
{

    [RequireComponent(typeof(Collider2D))]
    public abstract class Shootable : MonoBehaviour {
        public abstract int getPoitsForShootable();
        public abstract void OnHit();

    }
    
}