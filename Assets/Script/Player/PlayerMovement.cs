using UnityEngine;

public class PlayerMovement : MonoBehaviour , IMovement
{
    public float speed;
    
    
    private Vector3 _playerVelocity;
    private FixedJoystick _fixedJoystick;
    private CharacterController _myController;
    

    private bool İsWalk { get;  set; }
    private void Awake()
    {
        _fixedJoystick = FindObjectOfType<FixedJoystick>();
        _myController = GetComponent<CharacterController>();
        İsWalk = true;
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        if (İsWalk)
            _myController.Move(PlayerDirection() * (Time.deltaTime * speed));
    }

    Vector3 PlayerDirection()
    {
        return new Vector3(_fixedJoystick.Horizontal, _playerVelocity.y, _fixedJoystick.Vertical);
    }
}