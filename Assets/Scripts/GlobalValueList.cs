using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalValueList : MonoBehaviour
{
    void Start()
    {
        MonoSingleton.Add<bool>("isPause", false);
    }
}
