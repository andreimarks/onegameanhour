using System;
using System.IO;
using Bones.TextWriter;
using UnityEditor;
using UnityEngine;

public interface TODO_ITextWriterSerializer : ITextWriterSerializer
{
    void UpdateWithText(string text);
}

public class TextSerializer : TODO_ITextWriterSerializer
{
    private const string _FOLDER = "Journal";
    private const string _FILENAME = "journal.txt";

    private StreamWriter _streamWriter;

    private string _Directory
    {
        get
        {
            return Application.persistentDataPath +
                   Path.DirectorySeparatorChar +
                   _FOLDER;
        }
    }
    
    private string _FullPath
    {
        get
        {
            if (!Directory.Exists(_Directory))
            {
                Directory.CreateDirectory(_Directory);
            }
            
            return Application.persistentDataPath +
                   Path.DirectorySeparatorChar +
                   _FOLDER +
                   Path.DirectorySeparatorChar +
                   _FILENAME;
        } 
    }

    public TextSerializer()
    {
        _streamWriter = new StreamWriter(_FullPath, append: true);
        _streamWriter.Write(DateTime.Now);
        
#if UNITY_EDITOR
        // For Windows, eventually: https://answers.unity.com/questions/43422/how-to-implement-show-in-explorer.html
        // EditorUtility.RevealInFinder(_FullPath);
#endif
    }

    public void UpdateWithText(string text)
    {
        _streamWriter.Write(text);
        _streamWriter.Flush();
    }
}
