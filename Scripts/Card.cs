using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour
{
    int idx = 0;

    public GameObject Front;
    public GameObject Back;

    public Animator Anim;

    public SpriteRenderer frontImage;

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
        frontImage.sprite = Resources.Load<Sprite>($"rtan{idx}");
    }

    public void OpenCard()
    {
        Anim.SetBool("isOpen", true);
        Front.SetActive(true);
        Back.SetActive(false);
    }
}
