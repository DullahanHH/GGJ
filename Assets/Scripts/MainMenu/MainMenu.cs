using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    AudioSource menuBGM;
    public void PlayGame(){
        SceneManager.LoadScene("chapter-choice");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void BackToMainMenu(){
        SceneManager.LoadScene("MainMenuScenes");
    }

    public void Chatper10(){
        
    }
    
}
