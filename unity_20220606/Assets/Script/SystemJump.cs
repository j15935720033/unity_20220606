using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemJump : MonoBehaviour
{
    #region  ���
    [SerializeField, Header("���D����"), Tooltip("�o�O���⪺�]�B����"), Range(0, 3000)]
    private float heightJump = 350;
    [SerializeField, Header("�ˬd�a�O�ؤo")]
    private Vector3 v3VheckGroundSize = new Vector3(3.4f, 0.27f, 1f);//Vector3.one���O��1,1,1
    [SerializeField, Header("�ˬd�a�O�첾")]
    private Vector3 v3VheckGroundoffset=new Vector3(0.16f, -2.74f, 0f);
    [SerializeField, Header("�ˬd�a�O�C��")]
    private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
    [SerializeField, Header("�ˬd�a�O�ϼh")]
    private LayerMask layerCheckGround;

    private Animator ani;
    private Rigidbody2D rig;
    private bool clickJump;
    private bool isGround;
    #endregion �ƥ�
    //ø�s�ϥ�
    //�b�s�边��ø�s���U�νu���B�Ϊ��ιϤ�(P.S:�C�������|�X�{)
    private void OnDrawGizmos()
    {
        //1.�M�w�C��
        Gizmos.color = colorCheckGround;
        //.2ø�s�ϥ�
        //transform.position ��e���󪺮y��
        Gizmos.DrawCube(transform.position+ v3VheckGroundoffset, v3VheckGroundSize);
    }

    private void Awake()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();

    }

    #region  �\��
    //�p�G���a���U�ť���N���W���D
    private void JummKey()
    {
        print("Jumpkey");
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("���D");
            clickJump = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            clickJump = false;
        }
    }
    //clickJump=true�ɵ��V�W���O�q
    private void JumpForce()
    {
        if (clickJump&&isGround)
        {
            rig.AddForce(new Vector2(0, heightJump));
            clickJump = false;
        }
        
    }
    /// <summary>
    /// �ˬd�O�_�I��a�O  �n��bupdate
    /// </summary>
    private void CheckGround()
    {
        //2D�I����=���z.�I�﫬�ϰ�(�����I,�ؤo,����,�ϼh)
        Collider2D hit = Physics2D.OverlapBox(transform.position + v3VheckGroundoffset, v3VheckGroundSize,0, layerCheckGround);
        //print("�I�쪺����:" + hit.name);
        //print("hit:" + hit);
        
        isGround = hit;//���F��N�Otrue
        /*if (hit != null)
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }*/
    }
    #endregion

    void Start()
    {

    }
    //�@���60��
    void Update()
    {
        JummKey();
        CheckGround();
    }
    //�@��T�w50��
    private void FixedUpdate()
    {
        JumpForce();
    }
}
