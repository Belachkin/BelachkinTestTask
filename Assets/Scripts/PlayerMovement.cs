using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private FixedJoystick _joystick;

    private Rigidbody2D _rb;
    private Vector2 _direction;


    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _direction = _joystick.Direction;
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _direction * _speed * Time.fixedDeltaTime);

        if(_direction.x > 0)
        {
            gameObject.transform.localScale = Vector3.one;
        }
        else if(_direction.x < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
