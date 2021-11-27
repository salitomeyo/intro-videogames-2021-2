using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAgent : MonoBehaviour
{
    [SerializeField]
    private Transform _player;
    [SerializeField]
    private AIConfig _aiConfig;

    private MovableAgent _movableAgent;
    private AIStateMachine _stateMachine;
    private PathContainer _pathContainer;
    private IDamageable _damageableEntity;

    public Transform Target => _player;
    public AIConfig AIConfig => _aiConfig;
    public MovableAgent MovableAgent => _movableAgent;
    public AIStateMachine StateMachine => _stateMachine;
    public PathContainer PathContainer => _pathContainer;

    void Start()
    {
        _movableAgent = GetComponent<MovableAgent>();
        _pathContainer = GetComponent<PathContainer>();
        _damageableEntity = GetComponent<IDamageable>();
        
        _damageableEntity.OnDeath += OnDeath;
        
        _stateMachine = new AIStateMachine(this);
        _stateMachine.AddState(new AIIdleState());
        _stateMachine.AddState(new AIChaseTargetState());
        _stateMachine.AddState(new AIAttackState());
        _stateMachine.AddState(new AIPatrolState());
        
        _stateMachine.ChangeState(_aiConfig.initialState);
    }

    private void OnDestroy()
    {
        if (_damageableEntity != null)
        {
            _damageableEntity.OnDeath -= OnDeath;
        }
    }

    void Update()
    {
        if (_damageableEntity.IsDead)
        {
            return;
        }
        
        _stateMachine.Update();
    }
    
    public bool IsLookingTarget()
    {
        return true;
    }

    private void OnDeath()
    {
        Debug.LogError("Stop enemy systems....");

        _stateMachine.Stop();
        _movableAgent.Stop();
        
        gameObject.SetActive(false);
    }
}
