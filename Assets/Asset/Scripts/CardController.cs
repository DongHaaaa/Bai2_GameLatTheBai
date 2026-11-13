using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    Button currentBtn;
    Animator animator;
    public Image icon;
    public int id;
    private GameObject gameManager;
    private void Awake()
    {
        animator = GetComponent<Animator>();  
        currentBtn = GetComponent<Button>();
        gameManager = GameObject.Find("GameManager");
        currentBtn.onClick.AddListener(delegate
        {
            if(gameManager.GetComponent<GameManager>().count < 2)
            {
                gameManager.GetComponent<GameManager>().CheckCard(id);
                animator.SetBool("isFlip", true);
            }
        });
    }
    public void InitCard(int _id, Sprite iconSprite)
    {
        id = _id;
        icon.sprite = iconSprite;
    }    
    void Update()
    {
        
    }
}
