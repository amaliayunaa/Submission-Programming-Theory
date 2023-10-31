using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : ColoredSphere
{
    // Start is called before the first frame update
    void Start()
    {
        color = Color.red;
        DisplayText("I am Red");
    }

    public override void DisplayText(string text)
    {
        txtDisplay.text = text;
    }

    public override void DisplayText()
    {
        txtDisplay.text = "Roses Are Red";
        txtDisplay.color = color;
    }
}
