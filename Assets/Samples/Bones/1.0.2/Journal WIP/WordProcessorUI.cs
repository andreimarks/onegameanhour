using TMPro;
using UnityEngine;

namespace Bones.TextWriter
{
    using System.Text;

    public class WordProcessorUI : ITextWriterUI
    {
        private StringBuilder _sb;
        private Canvas _canvas;
        private TextMeshProUGUI _mainText;

        public WordProcessorUI()
        {
            _sb = new StringBuilder();
            _mainText = CreateNewTextMesh();
        }

        private TextMeshProUGUI CreateNewTextMesh()
        {
            _canvas = new GameObject("Canvas").AddComponent<Canvas>();
            _canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            
            var gameObject = new GameObject("TextMeshPro");
            gameObject.transform.SetParent(_canvas.transform);
            var tmp = gameObject.AddComponent<TextMeshProUGUI>();
            tmp.alignment = TextAlignmentOptions.Center;

            return tmp;
        }

        public void MakeFullScreen()
        {
            //_mainText.    
            RectTransform rt = _mainText.rectTransform;
            rt.anchorMin = Vector2.zero;
            rt.anchorMax = Vector2.one;
            rt.anchoredPosition = Vector2.zero;
            rt.sizeDelta = Vector2.zero;
        }

        public void SetTextAlignment(TextAlignmentOptions alignment)
        {
            _mainText.alignment = alignment;
        }
        
        public void UpdateWithText(string newText)
        {
            _sb.Append(newText);
            _mainText.text = _sb.ToString();
        }
    }
}
