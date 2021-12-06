using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private Color32 packagePickedColor = new Color32(0, 255 , 0, 255);
    [SerializeField] private Color32 noPackageColor = new Color32(0, 0 , 255, 255);
    
    private bool packagePicked;
    [SerializeField] private float delay = 1f;

    private SpriteRenderer spriteRenderer;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package"))
        {
            if (!packagePicked)
            {
                Debug.Log("Package picked!");
                packagePicked = true;
                Destroy(other.gameObject, delay);
                spriteRenderer.color = packagePickedColor;
            }
            else
            {
                Debug.Log("You already have a package!");
            }
        }
        else if (other.CompareTag("Customer") && packagePicked)
        {
            Debug.Log("Package delivered!");
            packagePicked = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
