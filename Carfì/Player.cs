using System.Numerics;

namespace PowPaw
{
    public class Player : IPlayer
    {
        public enum PlayerState
        {
            IDLE,
            JUMP,
            DODGE,
            ATTACK,
            WALK_RIGHT,
            WALK_LEFT,
            HIT
        }

        private const int JUMP_SPEED = 8;
        private const int GRAVITY = 5;
        private const double WIDTH = 50;
        private const double HEIGHT = 80;

        private PlayerState _currentState;
        private Vector2 _position;
        private Vector2 _direction;
        private readonly int speed = 4;
        private double _width;
        private double _height;
        private readonly int _number;
        private bool _isJumping;
        private bool _isMovingLeft;
        private bool _isMovingRight;
        private bool _isAttacking;
        private bool _isDodging;
        private bool _canMove = true;

        public Player(Vector2 position, int number)
        {
            _position = position;
            _number = number;
            _width = WIDTH;
            _height = HEIGHT;
            _currentState = PlayerState.IDLE;
            _direction = new Vector2(0, 0);
        }

        public int Number => _number;
        public Vector2 Position => _position;
        public Vector2 Direction
        {
            get => _direction;
            set => _direction = value;
        }
        public double Width
        {
            get => _width;
            set => _width = value;
        }
        public double Height
        {
            get => _height;
            set => _height = value;
        }
        public PlayerState State
        {
            get => _currentState;
            set => _currentState = value;
        }

        public bool IsJumping { set => _isJumping = value; }

        public bool IsMovingLeft { set => _isMovingLeft = value; }

        public bool IsMovingRight { set => _isMovingRight = value; }

        public bool IsAttacking { set => _isAttacking = value; }

        public bool IsDodging { set => _isDodging = value; }

        private void MoveLeft()
        {
            _currentState = PlayerState.WALK_LEFT;
            _direction = new Vector2(_direction.X - 1, _direction.Y);
        }

        private void MoveRight()
        {
            _currentState = PlayerState.WALK_RIGHT;
            _direction = new Vector2(_direction.X + 1, _direction.Y);
        }

        private void Jump()
        {
            _currentState = PlayerState.JUMP;
            _direction = new Vector2(_direction.X, _direction.Y - 1);
        }

        private void Attack()
        {
            _currentState = PlayerState.ATTACK;
        }

        private void Dodge()
        {
            _canMove = false;
            _currentState = PlayerState.DODGE;
        }

        public void Idle()
        {
            _direction = new Vector2(0, 0);
        }

        public void Update()
        {
            Idle();

            if (_canMove)
            {
                if (_isJumping)
                {
                    Jump();
                }
                if (_isMovingLeft)
                {
                    MoveLeft();
                }
                if (_isMovingRight)
                {
                    MoveRight();
                }
                if (_isAttacking)
                {
                    Attack();
                }
                if (_isDodging)
                {
                    Dodge();
                }
            }

            _position = new Vector2(_direction.X * speed,
                  _direction.Y * (_isJumping ? JUMP_SPEED : GRAVITY));
        }
    }
}
