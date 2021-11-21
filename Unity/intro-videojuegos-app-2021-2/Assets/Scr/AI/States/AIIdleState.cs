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
        //TODO: Agregar timer para ir a Patrol
        
        //Si el player esta cerca -> Chase
        Vector3 targetDirection = agent.Target.position - agent.transform.position;
        if (targetDirection.magnitude > agent.AIConfig.detectionRange)
        {
            return;
        }
        
        //Si esta viendo al player
        if (agent.IsLookingTarget())
        {
            agent.StateMachine.ChangeState(AIStateID.ChaseTarget);
        }
    }

    public void Exit(AIAgent agent)
    {
    }
}
