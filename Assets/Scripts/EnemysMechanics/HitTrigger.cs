using UnityEngine;

public class HitTrigger : MonoBehaviour
{
    public PlayerHealthMecanics playerHealthMecanics; 
    // ссылаемся на кол-во хп(так же из другого скрипта)
    private int _minusHealthPerHit = 1;
    private bool _isTakenDamage = false;
    private float _timeForDamage = 2.5f;

    private void FixedUpdate()
    {
        // if (_isTakenDamage)
        // {
        //     _timeForDamage = 2.5f;
        // }
        if (!_isTakenDamage)
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
            // вычитаем из текущего хп 1 если задели триггер противника(котoрый сбоку и снизу)
        }
        else
        {
            _isTakenDamage = true;
            _timeForDamage = 2.5f;
        }
    }
}
