using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpriteChnager : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;

    public ShipScritableObject selectedSpriteAsset;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();      
        spriteRenderer.sprite = selectedSpriteAsset.shipSprite;
    }
}
