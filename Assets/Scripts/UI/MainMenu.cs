using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 public void PlayGame() {  
        SceneManager.LoadScene("Fight");  
    }  
    public void QuitGame() {  
        Debug.Log("QUIT");  
        //SceneManager.LoadScene("Quit");  
        Application.Quit();
    }   

    public void ReloadGame()
    {
                Scene scene = SceneManager.GetActiveScene();
                 SceneManager.LoadScene(scene.name);
    }
}
