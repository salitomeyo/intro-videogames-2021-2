using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class AIConfig : ScriptableObject
{
    public AIStateID initialState = AIStateID.Idle;
    [Header("Detection")]
    public float detectionRange = 5;
    [Header("Moving")]
    public float pathfindingMinDistanceToRefresh = 1;
    public float pathfindingRefreshTime = 1;
    [Header("Attack")]
    public float attackRange = 1;
    public float attackDuration = 1;
}
