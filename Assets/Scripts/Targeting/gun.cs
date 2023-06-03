using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Baller.Targeting
{
    public class gun : MonoBehaviour
    {
        [SerializeField] private int defaultAmmo;
        [SerializeField] private float reloadingTime;
        
        [SerializeField] private AudioClip ShootSound;
        [SerializeField] private AudioClip ReloadedSound;
        


        public AmmoSystem AmmoSystem {get; private set;}
        public bool reloading;
        
        private Camera cam;             // Kamera für schuss ray ray
       
        StateMachine goB;
    
       


        private void Start() 
            {
                
                AmmoSystem = new AmmoSystem(defaultAmmo);  // Derzeit ohne Munition
                cam = Camera.main;
                goB = GameObject.Find("StateMachineO").GetComponent<StateMachine>();
                // goB State Machine
                // Leben, Punkte , Level etc.
            }

            private void Update() {
                {
                    if (Input.GetButtonDown("Fire1"))
                        TryToShoot();

                    //if (Input.GetKeyDown(KeyCode.Space))
                    //    TryToShoot();

                }
            }

        private void TryToShoot()
        {
            //Debug.Log("TryToShoot" + "State Reload " + reloading +" Munni: "+  AmmoSystem.CurrentAmmo);
            if(reloading || goB.getGameIsNOTRunning())return;
            if (AmmoSystem.CurrentAmmo <= 0) return;

            AmmoSystem.UseAmmo();
            PerformShot();
            TryToReload();

        }

        

        private void PerformShot()
        {
           
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
               // Debug.Log("Maus Position" + Input.mousePosition);
            Sound.SoundManager.Instance.PlaySound(ShootSound);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            
            if (hit.collider == null ) return;

            if (hit.collider.TryGetComponent(out Entity.Shootable shootable))
                shootable.OnHit();
                goB.AddScore(shootable.getPoitsForShootable()); // Punkte Addieren nach treffer
               
        }

        private void TryToReload()
        {
            Debug.Log("Try Reload");
            if(!reloading)
            {
                AmmoSystem.Reload();
                StartCoroutine(ReloadingRoutine());
            }

        }

        private IEnumerator ReloadingRoutine()
        {
            reloading = true;
            //Debug.Log("Reloading!");
            yield return new WaitForSeconds(reloadingTime);
            reloading = false;
             Sound.SoundManager.Instance.PlaySound(ReloadedSound); // erkennungs sound das nachgeladen ist 
        }
        

       
    }
}