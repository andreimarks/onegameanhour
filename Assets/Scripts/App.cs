using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Bones.TextWriter;
using TMPro;
using UnityEngine.InputSystem;

public class App : MonoBehaviour
{
    private void Start()
    {
        var input = new KeyboardInput();
        var ui = new AndreiJournalUI();
        var serializer = new TextSerializer();
        var tw  = new TextWriter(input, ui, serializer);

        ui.MakeFullScreen();
        ui.SetTextAlignment(TextAlignmentOptions.TopLeft);
    }
}
