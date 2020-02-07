using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    float timer = 120f;
    TextMeshPro text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;

            string mins = (int)timer / 60 + ":";
            string seconds = (int)timer % 60 + ":";
            string milliseconds = (int)(timer * 100) % 100 + "";

            if (seconds.Length < 3)
            {
                seconds = "0" + seconds;
            }

            if (milliseconds.Length < 2)
            {
                milliseconds = "0" + milliseconds;
            }

            text.text = mins + seconds + milliseconds;
        }
        else
        {
            text.text = "TIME'S UP!";
        }
    }
}
