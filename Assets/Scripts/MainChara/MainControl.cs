using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
    public bool isPaused;
    EntityControl controller;
    Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((bool)MonoSingleton.Get("isPause"))
        {
            //Operate
            dir = controller.getInput();
        }
    }

    void FixedUpdate()
    {
        //controller.moveToward(dir, );
    }
}
