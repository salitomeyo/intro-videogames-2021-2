using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class AIConfig : ScriptableObject
{
    public float detectRange = 5;
    public float pathfindingRefreshTime = 1;
    public float attackRange = 1;
    public float attackDuration = 1;
}
