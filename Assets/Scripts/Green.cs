using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : ColoredSphere
{
    // Start is called before the first frame update
    void Start()
    {
        color = Color.green;
        DisplayText("I Am Green");
    }

    public override void DisplayText(string text)
    {
        txtDisplay.text = text;
    }

    public override void DisplayText()
    {
        txtDisplay.text = "Grass Are Green";
        txtDisplay.color = color;
    }
}
