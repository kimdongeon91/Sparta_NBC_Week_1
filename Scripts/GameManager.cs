using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timeTxt;

    float time = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0f)
        {
            time -= Time.deltaTime;
            timeTxt.text = time.ToString("N2");
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }
}
