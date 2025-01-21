using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class colourChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            spriteRenderer.color = Random.ColorHSV();
        }
    }
    void OnMouseOver() {
        spriteRenderer.color = Color.red;
    }
}