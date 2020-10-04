using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Bones.TextWriter;
using TMPro;

public class App : MonoBehaviour
{
    private void Start()
    {
        var wp = new WordProcessorUI();
        var tws = new TextSerializer();
        var tw  = new TODO_TextWriter(wp, tws);

        wp.MakeFullScreen();
        wp.SetTextAlignment(TextAlignmentOptions.TopLeft);
    }
}
