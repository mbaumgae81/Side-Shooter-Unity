using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Baller.Sound
{
        public class SoundManager :MonoBehaviour
        {
            [SerializeField] private AudioSource _musicSource, _effectSource;

            public static SoundManager Instance;

            void Awake(){
                if (Instance == null){
                    Instance = this;
                    DontDestroyOnLoad(gameObject);
                }
                else
                {
                    Destroy(gameObject);
                }
            }

            public void PlaySound(AudioClip clip)
            {
                _effectSource.PlayOneShot(clip);
            }
        }
}
