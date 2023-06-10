using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum State { Run, Hit }
    public int LineNumber = 2;
    readonly Collider2D player;
    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {

    }

    void Update()
    {
        Move();
        
    }
    private void Move()
    {
        transform.position = new Vector2(transform.position.x, GameManager.instance.LinePosition[LineNumber]);

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (GameManager.instance.LinePosition.Count - 1 > LineNumber)
                LineNumber++;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (0 < LineNumber)
                LineNumber--;
        }
    }
    void OnTriggerEnter2D(Collider2D o)
    {
        if (o.gameObject.tag == "enemy")
        {
            ChangeAnim(State.Hit);
            Time.timeScale = 0;
        }
        if (o.gameObject.tag == "Cheese")
        {
            anim.SetTrigger("Eat");
            Destroy(o.gameObject);
        }
    }
    
        void ChangeAnim(State state)
        {
            anim.SetInteger("State", (int)state);
        }
    
}

