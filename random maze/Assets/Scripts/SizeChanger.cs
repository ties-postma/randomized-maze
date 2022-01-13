using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SizeChanger : MonoBehaviour
{

    public MazeRenderer MyMazeRenderer;

    public Slider Width_Input;
    public Slider Height_Input;

    public MazeRenderer MyMazeRenderers;

    public Text WidthText;
    public Text HeightText;

    // Start is called before the first frame update
    void Update()
    {
        Width_Input.wholeNumbers = true;
        Height_Input.wholeNumbers = true;

        Adjustsize();
        valueChecker();
    }

    // Update is called once per frame
    void Adjustsize()
    {
        MyMazeRenderers.height = (int) Height_Input.value;
        MyMazeRenderers.width = (int) Width_Input.value;
    }

    void valueChecker()
    {
        WidthText.text = "  " + Width_Input.value;
        HeightText.text = "  " + Height_Input.value;
    }
}
