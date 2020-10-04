using System;
using UnityEngine.InputSystem;

namespace Bones.TextWriter
{
    public class TODO_TextWriter
    {
        private ITextWriterUI _ui;
        private TODO_ITextWriterSerializer _serializer;

        public TODO_TextWriter(ITextWriterUI ui, 
                               TODO_ITextWriterSerializer serializer)
        {
            this._ui = ui;
            this._serializer = serializer;
            Keyboard.current.onTextInput += new Action<char>(this.OnTextInput);
        }

        private void OnTextInput(char character)
        {
            string newText = character.ToString();
            this._ui.UpdateWithText(newText);
            _serializer.UpdateWithText(newText);
        }
    }
}
