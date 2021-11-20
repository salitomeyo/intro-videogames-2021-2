using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIIdleState : AIState
{
    public AIStateID GetID()
    {
        return AIStateID.Idle;
    }

    public void Enter(AIAgent agent)
    {
    }

    public void Update(AIAgent agent)
    {
        //Si el player esta cerca -> Chase
        Vector3 targetDirection = agent.Target.position - agent.transform.position;
        if (targetDirection.magnitude > agent.AIConfig.detectRange)
        {
            return;
        }
        

        // State --> Chase
        agent.StateMachine.ChangeState(AIStateID.ChaseTarget);
    }

    public void Exit(AIAgent agent)
    {
    }
}
