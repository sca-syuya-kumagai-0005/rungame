using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamelaManager : MonoBehaviour
{
    private Vector3 playerPos;
    private float camelaPosY;
    private Transform Player;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.Find("Player").GetComponent<Transform>();
        camelaPosY=(float)playerPos.y;
        camelaPosY+=1;
        float camelaPosX=(float)playerPos.x;
        camelaPosX+=0.2f;
        playerPos = Player.transform.position;
        this.gameObject.transform.position=new Vector3(camelaPosX,camelaPosY,playerPos.z);

    }
}
