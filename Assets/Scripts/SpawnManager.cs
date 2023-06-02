using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject TreePrefab;
    private Vector3 spawnPos=new Vector3(25,0,0);
    [SerializeField]
    private float repeatRate;
    [SerializeField]
    private float startDelay;
    private PlayerController pc;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        pc =GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnObstacle()
    {
        if(!pc.GameOverFlag)
        { 
            Instantiate(TreePrefab, spawnPos, TreePrefab.transform.rotation);
        }
    }
}
