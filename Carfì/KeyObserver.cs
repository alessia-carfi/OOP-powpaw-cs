namespace PowPaw
{
    public class KeyObserver : IKeyObserver
    {
        private readonly Player _player;
        private readonly HashSet<ConsoleKey> _keys = new();
        public KeyObserver(Player player)
        {
            _player = player;
        }

        public void KeyPressed(ConsoleKey e)
        {
            _keys.Add(e);

            if (e == ConsoleKey.W)
            {
                _player.IsJumping = true;
            }
            if (e == ConsoleKey.A)
            {
                _player.IsMovingLeft = true;
            }
            if (e == ConsoleKey.D)
            {
                _player.IsMovingRight = true;
            }
            if (e == ConsoleKey.G)
            {
                _player.IsAttacking = true;
            }
            if (e == ConsoleKey.H)
            {
                _player.IsDodging = true;
            }
        }

        public void KeyReleased(ConsoleKey e)
        {
            _keys.Remove(e);

            if (e == ConsoleKey.W)
            {
                _player.IsJumping = false;
            }
            if (e == ConsoleKey.A)
            {
                _player.IsMovingLeft = false;
            }
            if (e == ConsoleKey.D)
            {
                _player.IsMovingRight = false;
            }
            if (e == ConsoleKey.G)
            {
                _player.IsAttacking = false;
            }
            if (e == ConsoleKey.H)
            {
                _player.IsDodging = false;
            }
        }
    }
}