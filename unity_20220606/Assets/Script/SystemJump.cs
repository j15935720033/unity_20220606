using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemJump : MonoBehaviour
{
    #region  ���
    [SerializeField, Header("���D����"), Tooltip("�o�O���⪺�]�B����"), Range(0, 3000)]
    private float heightJump = 350;

    private Animator ani;
    private Rigidbody2D rig;
    private bool clickJump;
    #endregion �ƥ�

    private void Awake()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();

    }

    #region  �\��
    //�p�G���a���U�ť���N���W���D
    private void JummKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("���D");
            clickJump = true;
        }
    }
    //clickJump=true�ɵ��V�W���O�q
    private void JumpForce()
    {
        if (clickJump)
        {
            rig.AddForce(new Vector2(0, heightJump));
            clickJump = false;
        }
    }
    #endregion

    void Start()
    {

    }
    //�@���60��
    void Update()
    {
        JummKey();
    }
    //�@��T�w50��
    private void FixedUpdate()
    {
        JumpForce();
    }
}
