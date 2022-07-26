using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject player;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position = spawnPoint.transform.position;
    }
}
