using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheesespawn : MonoBehaviour
{
    Rigidbody2D rb;
    public float movespeed;
    public GameObject obj;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        rb.velocity = new Vector2(-movespeed, rb.velocity.y);//�������ٵ� ���ν�Ƽ���� ���� ���� ���Ͱ����� ����(�������� ���ϱ� -)
    }
    private void OnBecameInvisible()//������Ʈ�� ����ī�޶� ������ �������� �����ϴ� �Լ�
    {
        Destroy(gameObject);
    }
    
}
    

