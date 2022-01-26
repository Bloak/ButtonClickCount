using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text text;

    private int count = 0;

    private void Render()
    {
        text.text = "Count: " + count.ToString();
    }

    public void ButtonPressed()
    {
        count += 1;
        Render();
    }
}
