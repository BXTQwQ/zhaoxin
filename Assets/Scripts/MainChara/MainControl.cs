using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : EntityControl
{
    
    public bool isPaused;
    Rigidbody2D rigid;
    Charastat stat;
    Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!(bool)MonoSingleton.Get("isPause"))
        {
            dir = getInput();
        }
    }

    void FixedUpdate()
    {
        moveToward(dir, stat.speed * stat.speedMultiplier * Time.fixedDeltaTime);
    }
}
