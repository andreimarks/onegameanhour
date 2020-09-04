using UnityEngine;
using UnityEngine.InputSystem;

namespace Bones.TextWriter
{
    public class TextWriter
    {
        public TextWriter()
        {
            Keyboard.current.onTextInput += OnTextInput;
        }

        private void OnTextInput(char charInput)
        {
            Debug.Log(charInput);
        }
    }
}
