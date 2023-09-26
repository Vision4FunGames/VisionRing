using UnityEngine;

namespace Script.Player.PlayerStateMachine
{
    public class PlayerMovementState : PlayerState
    {
        private static readonly int RunSpeed = Animator.StringToHash("RunSpeed");
        private float gravityValue = -9.81f;
        private float jumpHeight = 2;
        public Vector3 _playerVelocity;
        private const string playerJumpAnimationString = "Jump";
        public PlayerMovementState(global::Player player, global::PlayerStateMachine playerStateMachine) : base(player, playerStateMachine)
        {
            
        }

        public override void EnterState()
        {
            _player.uiManager.JumpBtn.onClick.AddListener(Jump);
            Debug.Log("StateGirdi");
        }

        public override void ExitState()
        {
            _player.uiManager.JumpBtn.onClick.RemoveListener(Jump);
        }

        public override void FrameUpdate()
        {
            if (_player._myController.isGrounded)
            {
                _playerVelocity.y = -0.5f;
            }
            Movement();
            if (_player._myController.isGrounded && Input.GetKeyDown(KeyCode.A))
            {
                Jump();
            }
            _playerVelocity.y += gravityValue * Time.deltaTime;
            _player._myController.Move(_playerVelocity * Time.deltaTime);
        }

        public void Jump()
        {
            if (_player._myController.isGrounded)
            {
                _playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
                ChangeAnimationState(playerJumpAnimationString);
                _playerVelocity.y += gravityValue * Time.deltaTime;
                _player._myController.Move(_playerVelocity * Time.deltaTime);
            }
        }

        public void Movement()
        {
            _player._myController.Move(PlayerDirection() * (Time.deltaTime * _player.speed));
            _player._playerAnimator.SetFloat(RunSpeed,
                Mathf.Abs(_player._fixedJoystick.Horizontal) + Mathf.Abs(_player._fixedJoystick.Vertical));
            _player.transform.GetChild(0).LookAt(_player.transform.GetChild(0).position +
                                                 new Vector3(_player._fixedJoystick.Horizontal, 0f,
                                                     _player._fixedJoystick.Vertical) *
                                                 (_player.speed * Time.deltaTime));
        }

        public override void ChangeAnimationState(string newAnim)
        {
            _player._playerAnimator.Play(newAnim);
        }

        Vector3 PlayerDirection()
        {
            return new Vector3(_player._fixedJoystick.Horizontal, _playerVelocity.y,
                _player._fixedJoystick.Vertical);
        }
        public override void PhysicUpdate()
        {
            base.PhysicUpdate();
        }

        public override void AnimationTriggerEvent(global::Player.AnimationTriggerType triggerType)
        {
            base.AnimationTriggerEvent(triggerType);
        }
    }
}