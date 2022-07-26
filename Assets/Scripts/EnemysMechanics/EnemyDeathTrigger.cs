using UnityEngine;

public class EnemyDeathTrigger : MonoBehaviour
{
    public GameObject enemy;
    // уничтожает объект если задели триггер(empty object) который находится сверху противника
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(enemy);
    }
}