using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Tutorialbtn : MonoBehaviour
{
    public Button img;
    private Animator animator;
    private bool hasPlayed = false;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!hasPlayed)
        {
            img.animator.SetTrigger("Play");
            hasPlayed = true;
        }




    }
}

