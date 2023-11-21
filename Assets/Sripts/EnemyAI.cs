using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [Header("怪物代理器")]
    public NavMeshAgent agent;
    [Header("玩家物件")]
    public Transform player;

    private void Update()
    {
        //怪物代理器.設定目的地(玩家的座標)
        agent.SetDestination(player.position);

    }
}
