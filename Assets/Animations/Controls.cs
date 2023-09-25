using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class Controls : MonoBehaviour
{
    public Button button;
    public Toggle toggle1;
    public Toggle toggle2;
    public InputField inputField;
    public Slider slider;

    public GameObject prefab;
    public RectTransform content;

    public void OnClickButton()
    {
        Debug.Log("OnClickButton");
        var button = Instantiate(prefab, content);
    }

    public void OnClickToggle1(bool toggle)
    {
        Debug.Log($"OnClickToggle1({toggle})");
        Destroy(content.GetChild(content.childCount - 1).gameObject);
    }

    public void OnClickToggle2(bool toggle)
    {
        Debug.Log($"OnClickToggle2({toggle})");
        for(int i =0; i<content.childCount; ++i)
        {
            Destroy(content.GetChild(i).gameObject);
        }
    }

    public void OnEndEdit(string input)
    {
        Debug.Log($"OnEndEdit({input})");
    }

    public void OnSlider(float value)
    {
        Debug.Log($"OnSlider({value})");
    }

    public void Start()
    {
        button.onClick.AddListener( () => Debug.Log("clicked") );
    }
}
