using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<float> LinePosition = new List<float>();
    public List<float> cheesePosition = new List<float>();
    public List<float> CatPosition = new List<float>();
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }


}
