using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ColoredSphere : MonoBehaviour
{
    string _displayText;
    Color _color;
    public Text txtDisplay;

    public string displayText { get { return _displayText; } set { _displayText = value; } }
    public Color color { get { return _color; } set { _color = value; } }

    public abstract void DisplayText();
    public abstract void DisplayText(string text);

    private void OnMouseUp()
    {
        DisplayText();
    }
}
