using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
[SerializeField]
private float speed;
    private PlayerController pc;
    private void Start()
    {
        pc=GameObject.Find("Player").GetComponent<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        if(!pc.GameOverFlag)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (this.gameObject.transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
