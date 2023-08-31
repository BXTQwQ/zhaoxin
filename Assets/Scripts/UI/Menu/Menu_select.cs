using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_select : MonoBehaviour
{
    public GameObject existMenu;
    public GameObject nextMenu;
   public void Confirm_M()
    {
        nextMenu.SetActive(true);
    }

   public void Return_M()
    {
        existMenu.SetActive(false);
    }
}
