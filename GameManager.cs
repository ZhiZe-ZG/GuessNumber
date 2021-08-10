using Microsoft.Xna.Framework.Input;

namespace GuessNumber
{
    public class GameManager
    {
        private GuessNumberGame _game = new GuessNumberGame();
        private string _inputBuffer = "";
        private bool[] _keyPressState = new bool[11] { false, false, false, false, false, false, false, false, false, false, false };
        private bool _waitingInput = true;

        public GameManager()
        {
        }
        public void Update(KeyboardState keyboardState, out string hintText, out string inputText)
        {
            // check number keys 
            if (keyboardState.IsKeyDown(Keys.D0))
            {
                _keyPressState[0] = true;
            }
            if (keyboardState.IsKeyDown(Keys.D1))
            {
                _keyPressState[1] = true;
            }
            if (keyboardState.IsKeyDown(Keys.D2))
            {
                _keyPressState[2] = true;
            }
            if (keyboardState.IsKeyDown(Keys.D3))
            {
                _keyPressState[3] = true;
            }
            if (keyboardState.IsKeyDown(Keys.D4))
            {
                _keyPressState[4] = true;
            }
            if (keyboardState.IsKeyDown(Keys.D5))
            {
                _keyPressState[5] = true;
            }
            if (keyboardState.IsKeyDown(Keys.D6) )
            {
                _keyPressState[6] = true;
            }
            if (keyboardState.IsKeyDown(Keys.D7))
            {
                _keyPressState[7] = true;
            }
            if (keyboardState.IsKeyDown(Keys.D8))
            {
                _keyPressState[8] = true;
            }
            if (keyboardState.IsKeyDown(Keys.D9))
            {
                _keyPressState[9] = true;
            }
            if (keyboardState.IsKeyDown(Keys.Back))
            {
                _keyPressState[10] = true;
            }
            // excute at key up
            // check number keys 
            if (keyboardState.IsKeyUp(Keys.D0))
            {
                if (_keyPressState[0])
                {
                    _keyPressState[0] = false;
                    _inputBuffer = _inputBuffer + "0";
                }
            }
            if (keyboardState.IsKeyUp(Keys.D1))
            {
                if (_keyPressState[1])
                {
                    _keyPressState[1] = false;
                    _inputBuffer = _inputBuffer + "1";
                }
            }
            if (keyboardState.IsKeyUp(Keys.D2))
            {
                if (_keyPressState[2])
                {
                    _keyPressState[2] = false;
                    _inputBuffer = _inputBuffer + "2";
                }
            }
            if (keyboardState.IsKeyUp(Keys.D3))
            {
                if (_keyPressState[3])
                {
                    _keyPressState[3] = false;
                    _inputBuffer = _inputBuffer + "3";
                }
            }
            if (keyboardState.IsKeyUp(Keys.D4))
            {
                if (_keyPressState[4])
                {
                    _keyPressState[4] = false;
                    _inputBuffer = _inputBuffer + "4";
                }
            }
            if (keyboardState.IsKeyUp(Keys.D5))
            {
                if (_keyPressState[5])
                {
                    _keyPressState[5] = false;
                    _inputBuffer = _inputBuffer + "5";
                }
            }
            if (keyboardState.IsKeyUp(Keys.D6))
            {
                if (_keyPressState[6])
                {
                    _keyPressState[6] = false;
                    _inputBuffer = _inputBuffer + "6";
                }
            }
            if (keyboardState.IsKeyUp(Keys.D7))
            {
                if (_keyPressState[7])
                {
                    _keyPressState[7] = false;
                    _inputBuffer = _inputBuffer + "7";
                }
            }
            if (keyboardState.IsKeyUp(Keys.D8))
            {
                if (_keyPressState[8])
                {
                    _keyPressState[8] = false;
                    _inputBuffer = _inputBuffer + "8";
                }
            }
            if (keyboardState.IsKeyUp(Keys.D9))
            {
                if (_keyPressState[9])
                {
                    _keyPressState[9] = false;
                    _inputBuffer = _inputBuffer + "9";
                }
            }
            if (keyboardState.IsKeyUp(Keys.Back))
            {
                if (_keyPressState[10])
                {
                    _keyPressState[10] = false;
                    if (_inputBuffer.Length > 0)
                    {
                        _inputBuffer = _inputBuffer.Remove(_inputBuffer.Length - 1);
                    }
                }
            }
            inputText = _inputBuffer;
            hintText = "Welcome";
        }




    }
}