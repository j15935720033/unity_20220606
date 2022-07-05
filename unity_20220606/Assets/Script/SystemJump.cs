using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace chia
{


    public class SystemJump : MonoBehaviour
    {
        #region  資料
        [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跑步高度"), Range(0, 3000)]
        private float heightJump = 350;
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3VheckGroundSize = new Vector3(3.4f, 0.27f, 1f);//Vector3.one都是給1,1,1
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3VheckGroundoffset = new Vector3(0.16f, -2.74f, 0f);
        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGround;
        [SerializeField, Header("跳躍動畫參數")]
        private string nameJump = "開關跳躍";
        [SerializeField, Header("跳躍音效")]
        private AudioClip soundJump;//音樂片段WAV

        private Animator ani;
        private Rigidbody2D rig;
        private AudioSource aud;//播音樂
        //private GameObject tilemap;


        private int layer;
        private bool clickJump;
        private bool isGround;
        #endregion 事件

        #region unity方法

        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
            aud = GetComponent<AudioSource>();
            //tilemap = GameObject.Find("Tilemap");//取得tilemap
            //layer = LayerMask.NameToLayer("地板");//取得MaskLayer "地板"


            //tilemap.layer = LayerMask.NameToLayer("地板");
        }
        void Start()
        {

            //print(LayerMask.NameToLayer("地板"));
        }
        //一秒約60次
        void Update()
        {
            JummKey();
            CheckGround();
            UpdateAnimator();
        }
        //一秒固定50次
        private void FixedUpdate()
        {
            JumpForce();
        }
        //繪製圖示
        //在編輯器內繪製輔助用線條、形狀或圖片(P.S:遊戲內部會出現)
        private void OnDrawGizmos()
        {
            //1.決定顏色
            Gizmos.color = colorCheckGround;
            //.2繪製圖示
            //transform.position 當前物件的座標
            Gizmos.DrawCube(transform.position + v3VheckGroundoffset, v3VheckGroundSize);
        }
        #endregion
        #region  功能
        //如果玩家按下空白鍵就往上跳躍
        private void JummKey()
        {
            print("Jumpkey");

            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("跳躍");
                clickJump = true;
            }else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }
        //clickJump=true時給向上的力量
        private void JumpForce()
        {
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
                //音效來源，播放一次音效(音效片段,音量)
                aud.PlayOneShot(soundJump,Random.Range(0.7f,1.5f));
            }

        }
        /// <summary>
        /// 檢查是否碰到地板  要放在update
        /// </summary>
        private void CheckGround()
        {
            //2D碰撞器=物理.富改型區域(中心點,尺寸,角度,圖層)
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3VheckGroundoffset, v3VheckGroundSize,0, layerCheckGround);
            //Collider2D hit = Physics2D.OverlapBox(transform.position + v3VheckGroundoffset, v3VheckGroundSize, 0, layer);

           // print("碰到的物件:" + hit.name);
            //print("hit:" + hit);

            isGround = hit;//有東西就是true
            /*if (hit != null)
            {
                isGround = true;
            }
            else
            {
                isGround = false;
            }*/
        }
        private void UpdateAnimator()
        {
            ani.SetBool(nameJump,!isGround);
        }
        #endregion


    }
}