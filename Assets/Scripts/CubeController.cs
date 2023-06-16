using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float x=20;
    private float PosZ;
    // Start is called before the first frame update
    void Start()
    {
        PosZ= CubeManager.spawnZ;
    }

    // Update is called once per frame
    void Update()
    {
        x = this.transform.position.x;
        x -=Time.deltaTime*10;
        this.gameObject.transform.position=new Vector3(x,CubeManager.spawnY,PosZ);    
    }
}
