using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

namespace Baller.UI
{
   
    
    public class CursorManager : MonoBehaviour {

    [SerializeField] private Texture2D cursorTexture;
    private Vector2 cursorHotspot;

    private void Start() {
        cursorHotspot = new Vector2(cursorTexture.width /2 , cursorTexture.height /2 );
        Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);
    }
    }
    
        
    
}