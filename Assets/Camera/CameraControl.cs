using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    Transform target;
    float ratio;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    void Update()
    {
        getProperty();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        follow();
    }

    void getProperty()
    {
        target = CameraProperty.target.transform;
        ratio = CameraProperty.ratio;
    }
    void follow()
    {
        gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, target.position, ratio);
    }
}

public static class CameraProperty
{
    public static GameObject target;
    public static float ratio;
    public static void changeTarget(GameObject target, float ratio)
    {
        CameraProperty.target = target;
        CameraProperty.ratio = ratio;
    }
}
