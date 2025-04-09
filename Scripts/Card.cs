using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour
{
    public int idx = 0;

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
        if (GameManager.instance.firstCard == null)
        {
            GameManager.instance.firstCard = this;
        }
        else
        {
            GameManager.instance.secondCard = this;
            GameManager.instance.Matched();
        }
    }

    public void InvokeDestroyCard()
    {
        Invoke("DestroyCard", 0.3f);
    }

    public void DestroyCard()
    {
        Destroy(gameObject);
    }

    public void InvokeCloseCard()
    {
        Invoke("CloseCard", 0.5f);
    }

    public void CloseCard()
    {
        Anim.SetBool("isOpen", false);
        Front.SetActive(false);
        Back.SetActive(true);
    }
}
