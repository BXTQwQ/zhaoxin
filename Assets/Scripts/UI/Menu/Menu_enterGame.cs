using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_enterGame : MonoBehaviour
{
    public GameObject existMenu;
    public void Confirm_M()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Return_M()
    {
        existMenu.SetActive(false);
    }
}
