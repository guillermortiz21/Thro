using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navigationScript : MonoBehaviour{
    public void goToCredits(){
        Application.LoadLevel("Credits");
    }
    public void goToFail(){
        Application.LoadLevel("FailScene");
    }
    public void goToGame(){
        Application.LoadLevel("Game");
    }
    public void goToStory(){
        Application.LoadLevel("GameStory");
    }
    public void goToMenu(){
        Application.LoadLevel("MainMenu");
    }
    public void goToWin(){
        Application.LoadLevel("WinScene");
    }
    public void quitGame(){
        Application.Quit();
    }
}
