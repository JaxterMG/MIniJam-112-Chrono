using UnityEngine;

public class Movement
{
    private float _speed = 2;
    private Rigidbody2D _rigidbody2D;

    public Movement(float speed, Rigidbody2D rigidbody2D)
    {
        _speed = speed;
        _rigidbody2D = rigidbody2D;
    }

    public void Move(Vector2 direction)
    {
        _rigidbody2D.velocity = direction * _speed;
    }
}