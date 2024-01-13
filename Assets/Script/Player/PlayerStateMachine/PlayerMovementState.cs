using UnityEngine;

namespace Script.Player.PlayerStateMachine
{
    public class PlayerMovementState : PlayerState
    {
        private static readonly int RunSpeed = Animator.StringToHash("RunSpeed");
        private float gravityValue = -9.81f;
        private float jumpHeight = 1;
        private float _rotSpeed = 5;
        public Vector3 _playerVelocity;
        private const string playerJumpAnimationString = "Jump";
        private const string playerDoubleJumpAnimationString = "DJump";
        public bool jumpPressed, dJump;

        public void CinematicOverride(string overrideState)
        {
            ChangeAnimationState(overrideState);
        }


        public PlayerMovementState(global::Player player, global::PlayerStateMachine playerStateMachine, bool jump) :
            base(player,
                playerStateMachine)
        {
        }

        public override void EnterState()
        {
            if (jumpPressed)
                Jump();
        }

        public override void ExitState()
        {
        }

        public override void FrameUpdate()
        {
            if (_player.isMovement)
            {
                if (_player._myController.isGrounded)
                {
                    jumpPressed = false;
                    dJump = false;
                    _playerVelocity.y = -0.5f;
                }

                Movement();
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Jump();
                }

                _playerVelocity.y += gravityValue * Time.deltaTime;
                _player._myController.Move(_playerVelocity * Time.deltaTime);
            }
            else
            {
                _player._playerAnimator.SetFloat(RunSpeed, 0);
            }
        }

        public void PlayerMovemetSound()
        {
           // print(_player._myController.isGrounded);
            //print(_player._myController.velocity.magnitude);
            if (_player._myController.isGrounded && _player._myController.velocity.magnitude > 2 &&
                !_player.playerSound.audioSource.isPlaying)
            {
                print("Soundİceri");
                _player.playerSound.audioSource.volume = Random.Range(.8f, 1f);
                _player.playerSound.audioSource.pitch = Random.Range(.8f, 1f);
                _player.playerSound.audioSource.clip = _player.playerSound.footStep;
                _player.playerSound.audioSource.Play();
            }

            if (!_player._myController.isGrounded || _player._myController.velocity.magnitude < 2)
            {
                _player.playerSound.audioSource.Stop();
            }
        }

        public void Jump()
        {
            if (_player._myController.isGrounded)
            {
                // if (GameManager.instance.gameState == GameState.Tutorial && GameManager.instance.tutorialCounter == 4)
                // {
                //     GameManager.instance.TutorialLoad();
                // }
                //_playerVelocity.y += Mathf.Sqrt(jumpHeight * -1.4f * gravityValue);
                _playerVelocity.y = 3;
                ChangeAnimationState(playerJumpAnimationString);
                //_playerVelocity.y += gravityValue * Time.deltaTime;
                _player._myController.Move(_playerVelocity * Time.deltaTime);
            }
            else if (!_player._myController.isGrounded && !dJump)
            {
                dJump = true;
                _playerVelocity.y = 4;
                ChangeAnimationState(playerDoubleJumpAnimationString);
                //_playerVelocity.y += Mathf.Sqrt(jumpHeight * -1.4f * gravityValue);
            }
        }

        public void Movement()
        {
            if (!global::Player.instance.tutorial)
            {
                _player.animSpeed = (Mathf.Abs(_player._fixedJoystick.Horizontal) +
                                     Mathf.Abs(_player._fixedJoystick.Vertical)) * _player.animValue;
                _player._myController.Move(PlayerDirection() * (Time.deltaTime * _player.speed));
                PlayerMovemetSound();
                _player._playerAnimator.SetFloat(RunSpeed, _player.animSpeed);
                _player.transform.GetChild(0).LookAt(_player.transform.GetChild(0).position +
                                                     new Vector3(_player._fixedJoystick.Horizontal, 0f,
                                                         _player._fixedJoystick.Vertical) *
                                                     (_player.rotSpeed * Time.deltaTime));
                if (PlayerDirection().magnitude > 0.5)
                {
                    _player.isWalk = true;
                    if (GameManager.instance.gameState == GameState.Tutorial)
                    {
                        if (GameManager.instance.tutorialCounter is 2 or 4)
                        {
                            GameManager.instance.TutorialLoad();
                        }
                    }
                }
                else
                {
                    _player.isWalk = false;
                }
            }
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