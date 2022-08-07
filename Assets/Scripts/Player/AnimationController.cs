using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private string _speedParameterName = "Speed";
    private Vector2 _speedParameter;
    [SerializeField] private SpriteRenderer _playerSprite;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerSprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if (_speedParameter.x > 0 && _playerSprite.flipX)
        {
            _playerSprite.flipX = false;
        }
        if (_speedParameter.x < 0 && !_playerSprite.flipX)
        {
            _playerSprite.flipX = true;
        }
        _animator.SetFloat(_speedParameterName, Mathf.Abs( _speedParameter.x));
        
    }

    public void ChangeSpeedParameter(Vector2 speedValue)
    {
        _speedParameter.x = speedValue.x;
    }
    public void ChangeDirectionParameter(Vector3 direction)
    {
        
    }
}