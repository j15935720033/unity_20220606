using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemJump : MonoBehaviour
{
    #region  資料
    [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跑步高度"), Range(0, 3000)]
    private float heightJump = 350;

    private Animator ani;
    private Rigidbody2D rig;
    private bool clickJump;
    #endregion 事件

    private void Awake()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();

    }

    #region  功能
    //如果玩家按下空白鍵就往上跳躍
    private void JummKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("跳躍");
            clickJump = true;
        }
    }
    //clickJump=true時給向上的力量
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
    //一秒約60次
    void Update()
    {
        JummKey();
    }
    //一秒固定50次
    private void FixedUpdate()
    {
        JumpForce();
    }
}
