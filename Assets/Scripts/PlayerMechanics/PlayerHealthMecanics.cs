using UnityEngine;

public class PlayerHealthMecanics : MonoBehaviour
{
    public int playerHealth;
    private bool _isDead;
    public GameObject spawnPoint;
    
    // смотрим на кол-во хп у игрока(изначально 3), если <= 0, то _isDead = true и респавним его по коордам spawnPoint

    void FixedUpdate()
    {
        if (playerHealth <= 0)
        {
            transform.position = spawnPoint.transform.position;
            playerHealth = 3;
        }
    }
}
