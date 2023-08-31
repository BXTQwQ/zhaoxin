using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_start : MonoBehaviour
{
    public GameObject nextMenu;
    
    public void PlayGame()
    {
        nextMenu.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
