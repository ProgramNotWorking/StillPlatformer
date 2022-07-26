using UnityEngine;

public class EnemyDeathTrigger : MonoBehaviour
{
    public GameObject enemy;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(enemy);
    }
}