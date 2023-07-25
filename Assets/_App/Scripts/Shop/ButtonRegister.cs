using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonRegister : MonoBehaviour
{
    public int number;
    public TextMeshProUGUI TextMeshProUgui;
    public Button button;

    void OnValidate()
    {
        TextMeshProUgui = GetComponentInChildren<TextMeshProUGUI>();
        button = GetComponentInChildren<Button>();
    }

    void Start()
    {
        button.onClick.AddListener(Choose);

        SetTextDay();
    }



    private void Choose()
    {
        RegisterManager.Instance.OnPressDown(number);
    }
    
    private void SetTextDay()
    {
        switch (number)
        {
            case 1:
                TextMeshProUgui.SetText("Mua 1 ngày");
                break;
            case 2:
                TextMeshProUgui.SetText("Mua 7 ngày");
                break;
            case 3:
                TextMeshProUgui.SetText("Mua 30 ngày");
                break;
            case 4:
                TextMeshProUgui.SetText("Mua 90 ngày");
                break;
            case 5:
                TextMeshProUgui.SetText("Mua 180 ngày");
                break;
        }
    }
}