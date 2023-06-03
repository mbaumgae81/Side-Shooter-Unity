using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Baller.Sound
{
    public class PlaySound : MonoBehaviour
    {
        [SerializeField] private AudioClip _clip;

        private void Start() {
            
            SoundManager.Instance.PlaySound(_clip);
        }

        
    }
}