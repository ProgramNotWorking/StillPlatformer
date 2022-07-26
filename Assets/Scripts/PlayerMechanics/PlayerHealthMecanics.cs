using UnityEngine;

public class PlayerHealthMecanics : MonoBehaviour
{
    public int playerHealth;
    private bool _isDead;
    public GameObject spawnPoint;

    void FixedUpdate()
    {
        if (playerHealth <= 0)
        {
            transform.position = spawnPoint.transform.position;
            playerHealth = 3;
        }
    }
}
