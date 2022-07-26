using UnityEngine;

public class HitTrigger : MonoBehaviour
{
    public PlayerHealthMecanics playerHealthMecanics;
    private int _minusHealthPerHit = 1;
    private bool _isTakenDamage;
    private float _timeForDamage = 2.5f;

    private void FixedUpdate()
    {
        if (_isTakenDamage)
        {
            _timeForDamage = 2.5f;
        }
        else
        {
            _timeForDamage -= Time.deltaTime;
        }

        if (_timeForDamage <= 0)
        {
            _isTakenDamage = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!_isTakenDamage)
        {
            playerHealthMecanics.playerHealth -= _minusHealthPerHit;
        }
        else
        {
            _isTakenDamage = true;
        }
    }
}
