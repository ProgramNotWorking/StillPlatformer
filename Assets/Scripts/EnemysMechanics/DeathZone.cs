using Unity.VisualScripting;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public PlayerHealthMecanics playerHealth;

    private void OnTriggerEnter2D(Collider2D other)
    {
        playerHealth.playerHealth -= 3;
    }
}
