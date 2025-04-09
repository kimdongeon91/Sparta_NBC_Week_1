using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour
{
    int idx = 0;

    public SpriteRenderer front;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setting(int number)
    {
        idx = number;
        front.sprite = Resources.Load<Sprite>($"rtan{idx}");
    }
}
