using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public Collider2D door;
    public GameObject openDoorPosition;
    private Vector2 _doorPosition;
    public float openingSpeed;
    
    void Start()
    {
        _doorPosition = openDoorPosition.transform.position;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        OpenDoor();
    }

    private void OpenDoor()
    {
        door.transform.position = Vector2.MoveTowards(door.transform.position,
            _doorPosition, openingSpeed);
    }
}
