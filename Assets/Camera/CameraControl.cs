using System.Collections;
using System.Collections.Generic;
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

    // Update is called once per frame
    void LateUpdate()
    {
        follow();
    }

    void follow()
    {
        gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, target.position, ratio);
    }

    public void setCameraProperty()
    {
        
    }

    public void changeTarget(GameObject target, float ratio)
    {
        this.target = target.transform;
        this.ratio = ratio;
    }
}
