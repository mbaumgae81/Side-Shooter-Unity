using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



    public class AmmoSystem //: MonoBehaviour
    {
        public event Action<int> OnAmmoChange;
        private int currentAmmo;

        public int DefaultAmmo {get; }
        public int CurrentAmmo{
            get => currentAmmo;
            set{
                currentAmmo = value;
                OnAmmoChange?.Invoke(currentAmmo);

            }
        }

        public AmmoSystem(int defaultAmmo)
        {
            DefaultAmmo = defaultAmmo;
            currentAmmo = defaultAmmo;
        }

        public void UseAmmo()
        {
            // Es wird derzeit keine Munition verbraucht
            
            //if(CurrentAmmo > 0)
            //CurrentAmmo--;
        }
        
        public void Reload() => CurrentAmmo = DefaultAmmo;
    }
