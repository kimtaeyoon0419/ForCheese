using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecluod : MonoBehaviour
{
    Rigidbody2D rb;
    public float movespeed;
    public GameObject obj;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-movespeed, rb.velocity.y);
    }
    private void OnBecameInvisible()
    {
        obj.transform.position = new Vector3(11.27f, 3.45f, 0f);
    }

}
