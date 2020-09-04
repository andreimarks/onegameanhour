using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    void Start()
    {
        var textWriterUI = new TextWriterUI();
        var textWriter = new TextWriter(textWriterUI);        
    }
}
