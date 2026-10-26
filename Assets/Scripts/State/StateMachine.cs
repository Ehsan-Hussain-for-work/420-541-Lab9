using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StateMachine
{
    private Dictionary<StateType, IStates> states = new Dictionary<StateType, IStates>();
    private IStates currentState;

    public StateType GetCurrentStateType()
    {
        return currentState.Type;
    }

    public void AddState(IStates state)
    {
        if (!states.ContainsKey(state.Type))
        {
            states.Add(state.Type, state);
        }
    }

    public void TransitionToState(StateType type)
    {
        currentState?.Exit();
        currentState = states[type];
        currentState.Enter();
    }

    public void Update()
    {
        currentState?.Execute();
    }
}