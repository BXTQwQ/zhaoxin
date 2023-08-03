using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityControl : MonoBehaviour
{
    #region movementControl
    public void debugging()
    {
        Debug.Log(gameObject.name);
    }
    /// <summary> Let object move towards to given direction with given velocity. 
    /// NOTICE: Please use it ONLY in FixedUpdate, 
    /// anything that related with force, velocity, etc. ARE strictly required to place in FixedUpdate.
    /// </summary>
    /// <param name="dir">No need to normalize, it has been done.</param>
    /// <param name="vel">How much velocity it will have.</param>
    public void moveToward(Vector2 dir, float vel)
    {
        if(gameObject.TryGetComponent<Rigidbody2D>(out Rigidbody2D rigid))
        {
            Debug.Log("dir" + dir + " vel:" + vel);
            rigid.velocity = dir.normalized * vel;
        }
        else
            throw new System.Exception("Target object does not contain component \"RigidBody2D\" ");
    }
    /// <summary> Give certain force to certain direction
    /// 
    /// </summary>
    /// <param name="dir">No need to normalize, it has been done. </param>
    /// <param name="force">How much force to apply to. </param>
    public void giveForce(Vector2 dir, float force)
    {
        if(gameObject.TryGetComponent<Rigidbody2D>(out Rigidbody2D rigid))
            rigid.AddForce(dir.normalized * force);
        else
            throw new System.Exception("Target object does not contain component \"RigidBody2D\" ");
    }

    public Vector2 getInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        return new Vector2(x,y);
    }

    #endregion
}
