using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private SceneController scenecontroller;
    public void StartGame()
    {
        scenecontroller.LoadScene("Gameplay");
    }

    public void StartCredit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void StartExit()
    {
        Application.Quit();

        // saat unity editor, stop playing the scene
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
