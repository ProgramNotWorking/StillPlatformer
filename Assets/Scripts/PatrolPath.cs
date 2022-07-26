using UnityEngine;

public class PatrolPath : MonoBehaviour
{
    public GameObject endSpot;
    public float speed;
    
    private Vector2 _startPosition;
    private Vector2 _endPosition;
    private bool _isToEnd = true;
    
    public float waitingTime;
    private float _timeWait;
    // true-> to endPosition
    // false -> to startPosition

    void Start()
    {
        _startPosition = transform.position;
        _endPosition = endSpot.transform.position;
        _timeWait = waitingTime;
    }
    
    void FixedUpdate()
    {
        if (_isToEnd)
        {
            if (_timeWait <= 0)
            {
                if (Vector2.Distance(transform.position, _endPosition) >= 0.2f)
                {
                    GoToEndPosition();
                }
                else
                {
                    _timeWait = waitingTime;
                    _isToEnd = false;
                }
            }
            else
            {
                _timeWait -= Time.deltaTime;
            }
        }

        if (!_isToEnd)
        {
            if (_timeWait <= 0)
            {
                if (Vector2.Distance(transform.position, _startPosition) >= 0.2f)
                {
                    GoToTheStartPosition();
                }
                else
                {
                    _timeWait = waitingTime;
                    _isToEnd = true;
                }
            }
            else
            {
                _timeWait -= Time.deltaTime;
            }
        }
    }

    private void GoToEndPosition()
    {
        transform.position = Vector2.MoveTowards(transform.position, _endPosition, speed);
    }

    private void GoToTheStartPosition()
    {
        transform.position = Vector2.MoveTowards(transform.position, _startPosition, speed);
    }
}