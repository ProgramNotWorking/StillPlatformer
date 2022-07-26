using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public PlayerHealthMecanics playerHealth;
    // ссылаемся на кол-во хп у игрока в данный момент(из скрипта playerHealth)

    private void OnTriggerEnter2D(Collider2D other)
    {
        playerHealth.playerHealth -= 3;
    }
}
