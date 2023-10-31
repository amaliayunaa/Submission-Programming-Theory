using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : ColoredSphere
{
    // Start is called before the first frame update
    void Start()
    {
        color = Color.blue;
        DisplayText("I am Blue");
    }

    public override void DisplayText(string text)
    {
        txtDisplay.text = text;
    }

    public override void DisplayText()
    {
        txtDisplay.text = "Violets Are Blue";
        txtDisplay.color = color;
    }
}
