using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IStates
{
    StateType Type { get; }
    void Enter();
    void Execute();
    void Exit();
}