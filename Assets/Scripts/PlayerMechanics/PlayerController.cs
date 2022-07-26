using System;
using UnityEngine;

// тут короче управление игроком заебал
public class PlayerController : MonoBehaviour
{
    public float speed = 0.05f;
    public float jumpForce = 1f;
    private Rigidbody2D _player;
    public float maxSpeed;

    private bool _isGrounded;
    public Transform pos;
    public float checkRadius;
    public LayerMask isGround;

    private bool _spacePressed = false;
    private float _movement;
    
    void Start()
    {
        _player = GetComponent<Rigidbody2D>();
    }
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) _spacePressed = true;
        _movement = Input.GetAxis("Horizontal");
    }
    
    void FixedUpdate()
    {
        if (Math.Abs(_player.velocity.x) <= maxSpeed && _movement != 0)
        {
            _player.velocity = new Vector2(_movement * speed, _player.velocity.y);
        }

        _isGrounded = Physics2D.OverlapCircle(pos.position, checkRadius, isGround);
        
        if(_spacePressed && _isGrounded && _player.velocity.y <= maxSpeed)
        {
            _player.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            _spacePressed = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // try ro do this more effective

        if (collision.gameObject.layer == 7)
        {
            transform.parent = collision.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            transform.parent = null;
        }
    }
}
