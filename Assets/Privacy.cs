using System.IO;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

public class Privacy : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshProUgui;

    void OnValidate()
    {
        _textMeshProUgui = GetComponent<TextMeshProUGUI>();
    }

    [Button]
    private void SetTextPri()
    {
        string path = "Assets/Privacy.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        _textMeshProUgui.text = (reader.ReadToEnd());
        reader.Close();
    }
    
    void Start()
    {
        SetTextPri();
    }
}