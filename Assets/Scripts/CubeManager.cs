using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private PlayerController pc;
    private Vector3 spawnPos;
    public static float spawnY;
    [SerializeField]
    private bool spawnFlag;
    private bool Continue;
    private float spawnTime;
    private float ContinueTime;
    public static float spawnZ;
    [SerializeField]
    private GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!pc.GameOverFlag)
        {
            spawnTime+=Time.deltaTime;
            if(spawnTime>1&&!spawnFlag)
            {
                int rnd=Random.Range(1,2000);
                if(rnd==1)
                {
                    spawnFlag=true;
                    spawnTime = 0;
                }
            }
            if(spawnFlag)
            { 
                if(!Continue)
                { 
                    spawnY=0.5f;
                    spawnZ=Random.Range(-1,2)*3;
                    spawnPos = new Vector3(20, spawnY, spawnZ);
                    Continue=true;
                }
                if(Continue)
                {
                    int rnd=Random.Range(5,10);
                    for(int i=0;i<rnd;i++)
                    {
                        spawnPos=new Vector3 (20+i,spawnY,spawnZ);
                        Instantiate(cube,spawnPos,cube.transform.rotation);
                    }
                }
                Continue = false;
                spawnFlag = false;
            }
        }
    }
}
