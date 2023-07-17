using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateType
{
    Idle , Attack //加入所有需转换的状态
}

[Serializable]
public class Parameter
{
    public int health;

    public float movespeed;

    public float chasespeed;

    public float idletime;

    public Transform[] PatrolPoints;

    public Transform[] ChasePoints;

    public Animator animator;

}







public class FSM : MonoBehaviour
{
    public Parameter parameter = new Parameter();


    private IState currentState;

    private Dictionary<StateType, IState> states = new Dictionary<StateType, IState>();


    void Start()
    {
        states.Add(StateType.Idle, new IdleState(this));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TransitonState(StateType type)
    {
        if(currentState != null)
            currentState.OnExit();

        currentState = states[type];

        currentState.OnEnter();

    }
}
