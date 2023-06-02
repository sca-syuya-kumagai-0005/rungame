using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float jump;
    public float gravityModifier;
    public bool isOnGround=true;
    public  bool GameOverFlag=false;
    private Animator PlayerAnim;//�A�j���[�^�[
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        Physics.gravity*=gravityModifier;
        PlayerAnim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)&&isOnGround&&GameOverFlag)
        {
            rb.AddForce(Vector3.up*jump,ForceMode.Impulse);
            isOnGround=false;
            PlayerAnim.SetTrigger("Jump_trig");//�W�����v�g���K�[��ݒ�
            //�W�����v����A�j�����Đ�
        }
    }

    private void OnCollisionEnter(Collision collision)//�����ɂԂ����Ă����
    {
        if(collision.gameObject.CompareTag("Tree"))
        {
            GameOverFlag=true;
            PlayerAnim.SetBool("Death_b",true);
            PlayerAnim.SetInteger("DeathType_int",1);
            //SceneManager.LoadScene("Result");
        }
        else if(collision.gameObject.CompareTag("Ground"))
        { 
            isOnGround=true;
        }
    }
}
