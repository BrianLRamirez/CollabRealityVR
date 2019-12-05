using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedTilingPablo : MonoBehaviour
{
    public float tileScale = 4.0f;
    // Use this for initialization
    void Start()
    {
        GetComponent<Renderer>().sharedMaterial.mainTextureScale = new Vector2(transform.localScale.x * tileScale, transform.localScale.y * tileScale);
    }
}
