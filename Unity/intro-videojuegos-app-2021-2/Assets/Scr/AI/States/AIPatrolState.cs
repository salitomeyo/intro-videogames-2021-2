public class AIPatrolState : AIState
{
    public AIStateID GetID()
    {
        return AIStateID.Patrol;
    }

    public void Enter(AIAgent agent)
    {
    }

    public void Update(AIAgent agent)
    {
    }

    public void Exit(AIAgent agent)
    {
        agent.MovableAgent.Stop();
    }
}
