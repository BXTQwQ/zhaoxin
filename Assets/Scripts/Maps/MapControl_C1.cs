using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapControl_C1 : MonoBehaviour
{
    public GameObject player,map1,map2,map3,map4;

    void Start()
    {
        
    }

    
    void Update()
    {
        MapMove();
    }

    void MapMove()
    {
        int cm = CenterMap();
        float xDist, yDist;
        int xd, yd;
        switch(cm)
        {
            case 0:
                 xDist = player.transform.position.x - map1.transform.position.x;
                 yDist = player.transform.position.y - map1.transform.position.y;
                float dis12 = map1.transform.position.x - map2.transform.position.x;
                float dis13 = map1.transform.position.y - map3.transform.position.y;
                int d12, d13;

                if (xDist > 0) xd = 1;
                else xd = -1;
                if (yDist > 0) yd = 1;
                else yd = -1;
                if (dis12 > 0) d12 = 1;
                else d12 = -1;
                if(dis13 > 0) d13 = 1;
                else d13 = -1;

                if (xd*d12 > 0)
                {
                    map2.transform.position = new Vector3(map2.transform.position.x + 50*xd, map2.transform.position.y, map2.transform.position.z);
                    map4.transform.position = new Vector3(map4.transform.position.x + 50*xd, map4.transform.position.y, map4.transform.position.z);
                }
                if (yd*d13 > 0 )
                {
                    map3.transform.position = new Vector3(map3.transform.position.x, map3.transform.position.y + 50*yd, map3.transform.position.z);
                    map4.transform.position = new Vector3(map4.transform.position.x, map4.transform.position.y + 50*yd, map4.transform.position.z);
                }
            break;
            case 1:
                 xDist = player.transform.position.x - map2.transform.position.x;
                 yDist = player.transform.position.y - map2.transform.position.y;
                float dis21 = map2.transform.position.x - map1.transform.position.x;
                float dis24 = map2.transform.position.y - map4.transform.position.y;
                int d21, d24;

                if (xDist > 0) xd = 1;
                else xd = -1;
                if (yDist > 0) yd = 1;
                else yd = -1;
                if (dis21 > 0) d21 = 1;
                else d21 = -1;
                if (dis24 > 0) d24 = 1;
                else d24 = -1;

                if (xd * d21 > 0)
                {
                    map1.transform.position = new Vector3(map1.transform.position.x + 50 * xd, map1.transform.position.y, map1.transform.position.z);
                    map3.transform.position = new Vector3(map3.transform.position.x + 50 * xd,map3.transform.position.y, map3.transform.position.z);  
                }
                if (yd * d24 > 0)
                {
                    map4.transform.position = new Vector3(map4.transform.position.x, map4.transform.position.y + 50 * yd, map4.transform.position.z);
                    map3.transform.position = new Vector3(map3.transform.position.x, map3.transform.position.y + 50 * yd, map3.transform.position.z);
                }
                break;
            case 2:
                xDist = player.transform.position.x - map3.transform.position.x;
                yDist = player.transform.position.y - map3.transform.position.y;
                float dis34 = map3.transform.position.x - map4.transform.position.x;
                float dis31 = map3.transform.position.y - map1.transform.position.y;
                int d34, d31;

                if (xDist > 0) xd = 1;
                else xd = -1;
                if (yDist > 0) yd = 1;
                else yd = -1;
                if (dis34 > 0) d34 = 1;
                else d34 = -1;
                if (dis31 > 0) d31 = 1;
                else d31 = -1;

                if (xd * d34 > 0)
                {
                    map4.transform.position = new Vector3(map4.transform.position.x + 50 * xd, map4.transform.position.y, map4.transform.position.z);
                    map2.transform.position = new Vector3(map2.transform.position.x + 50 * xd, map2.transform.position.y, map2.transform.position.z);
                }
                if (yd * d31 > 0)
                {
                    map1.transform.position = new Vector3(map1.transform.position.x, map1.transform.position.y + 50 * yd, map1.transform.position.z);
                    map2.transform.position = new Vector3(map2.transform.position.x, map2.transform.position.y + 50 * yd, map2.transform.position.z);
                }
                break;
            case 3:
                xDist = player.transform.position.x - map4.transform.position.x;
                yDist = player.transform.position.y - map4.transform.position.y;
                float dis43 = map4.transform.position.x - map3.transform.position.x;
                float dis42 = map4.transform.position.y - map2.transform.position.y;
                int d43, d42;

                if (xDist > 0) xd = 1;
                else xd = -1;
                if (yDist > 0) yd = 1;
                else yd = -1;
                if (dis43 > 0) d43 = 1;
                else d43 = -1;
                if (dis42 > 0) d42 = 1;
                else d42 = -1;

                if (xd * d43 > 0)
                {
                    map3.transform.position = new Vector3(map3.transform.position.x + 50 * xd, map3.transform.position.y, map3.transform.position.z);
                    map1.transform.position = new Vector3(map1.transform.position.x + 50 * xd, map1.transform.position.y, map1.transform.position.z);
                }
                if (yd * d42 > 0)
                {
                    map2.transform.position = new Vector3(map2.transform.position.x, map2.transform.position.y + 50 * yd, map2.transform.position.z);
                    map1.transform.position = new Vector3(map1.transform.position.x, map1.transform.position.y + 50 * yd, map1.transform.position.z);
                }
                break;

        }
    }

    int CenterMap()//text which one is the center map
    {
        float x1 = player.transform.position.x - map1.transform.position.x;
        float x2 = player.transform.position.x - map2.transform.position.x;
        float x3 = player.transform.position.x - map3.transform.position.x;
        float x4 = player.transform.position.x - map4.transform.position.x;
        float y1 = player.transform.position.y - map1.transform.position.y;
        float y2 = player.transform.position.y - map3.transform.position.y;

        int cm;

        if(System.Math.Abs(y1) < System.Math.Abs(y2))
        {
            if (System.Math.Abs(x1) < System.Math.Abs(x2))
            {
                cm = 0;
            }
            else cm = 1;
        }
        else
        {
            if(System.Math.Abs(x3) < System.Math.Abs(x4))
            {
                cm = 2;
            }
            else cm=3;  
        }

        
        Debug.Log(cm);
        return cm;

    }
}
