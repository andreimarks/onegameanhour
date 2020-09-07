using Bones.TextWriter;
using UnityEngine;

public class App : MonoBehaviour
{
    void Start()
    {
        var twui = new WordProcessorUI();
        var tw = new TextWriter(twui);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
