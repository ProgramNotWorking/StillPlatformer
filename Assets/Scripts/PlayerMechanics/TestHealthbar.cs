using UnityEngine;

public class TestHealthbar : MonoBehaviour
{
    public PlayerHealthMecanics playerHealth;
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;

    void FixedUpdate()
    {
        if (playerHealth.playerHealth == 2)
        {
            health3.transform.Translate(Vector2.down * Time.deltaTime);
        }
        else if (playerHealth.playerHealth == 1)
        {
            health2.transform.Translate(Vector2.down * Time.deltaTime);
        }
        else if (playerHealth.playerHealth == 0)
        {
            health1.transform.Translate(Vector2.down * Time.deltaTime);
        }
    }
}
