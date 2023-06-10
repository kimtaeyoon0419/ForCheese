using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> ObjectPrefabs = new List<GameObject>();

    public float SpawnTime;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    void Update()
    {

    }
    IEnumerator Spawn()
    {
        SpawnTime = Random.Range(1, 6);
        yield return new WaitForSeconds(SpawnTime);
        int randomObj = Random.Range(0, ObjectPrefabs.Count);
        int randomLine = Random.Range(0, 4);
        Instantiate(ObjectPrefabs[Random.Range(0, ObjectPrefabs.Count)], new Vector2(11, GameManager.instance.cheesePosition[randomLine]), Quaternion.identity);
        StartCoroutine(Spawn());

    }
}
