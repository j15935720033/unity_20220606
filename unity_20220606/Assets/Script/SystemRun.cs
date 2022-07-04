
using UnityEngine;//引用UnityEngine的命名空間
namespace chia
{
    /*C# 從藍圖變成實體事件:
        1.場景上的遊戲物件Game Object 灰色方塊
        2.將此腳本掛在該物件變成元件
     */
    /// <summary>
    /// 跑步系統
    /// </summary>
    public class SystemRun : MonoBehaviour
    {


        #region  資料:保存系統需要的資料
        //欄位 Field:保存資料
        //語法:
        //修飾詞 欄位資料類型 欄位自訂名稱 (指定 預設值)

        //修飾詞
        //公開:顯示在面板，允許其他類別存取 public
        //私人:不顯示在面板，不允許其他類別存取 private(封裝)

        //[] Attritube 屬性，額外功能
        //serialize Field:序列化欄位，將私人欄位顯示在unity Hub
        //Header:標題(可用中文)
        //Tooltip:提示(可用中文)
        //Range:範圍 (僅限於數值類型資料，int float byte long)
        [SerializeField,Header("跑步速度"),Tooltip("這是角色的跑步速度"),Range(0,100)]
        private float speedRun = 10f;
        [SerializeField]
        private float speed = 10;
        /*
        [SerializeField, Header("跳躍高度"), Tooltip("這是角色的跑步高度"), Range(0, 3000)]
        private float heightJump = 350;
        */
        private Animator ani;
        private Rigidbody2D rig;
        private Transform trans;
        #endregion

        #region  功能:實作該系統的複雜方法
        //方法 Method
        //語法
        //修飾詞 傳回資料型態 方法名稱(參數){程式}

        /// <summary>
        /// 跑步功能
        /// </summary>
        private void Run()
        {
            print("跑步中");
            rig.velocity = new Vector2(speedRun,rig.velocity.y);//設定加速度，rig.velocity.y-->rig中原本y軸的加速度
        }

        void run2()
        {
            //****************案左右健*******************//
            //float Horizontal_speed = Input.GetAxis("Horizontal");//-1~1
            float Horizontal_speed = Input.GetAxisRaw("Horizontal");//-1、0、1

            //****************人物加速度*******************//
            //rig.velocity = new Vector2(Horizontal_speed * speed * Time.deltaTime, rig.velocity.y);
            rig.velocity = new Vector2(Horizontal_speed * speed * Time.deltaTime, rig.velocity.y);
            //****************人物轉向*******************//
            if (Horizontal_speed > 0)
            {
                trans.localScale = new Vector2(1f, trans.localScale.y);//向左改变图像朝向左
            }
            else if (Horizontal_speed < 0)
            {
                trans.localScale = new Vector2(-1f, trans.localScale.y);//向左改变图像朝向左
            }
        }
        #endregion

        #region  事件:程式入口
        //喚醒事件:開始事件前執行一次，取得元件等等
        private void Awake()
        {
            //ani 指定 忍者龜身上的 Animator
            ani = GetComponent<Animator>();//泛型:<Animator>
            rig = ani.GetComponent<Rigidbody2D>();
            trans= ani.GetComponent<Transform>();
        }
        //開始事件:播放遊戲時執行一次
        //初始化設定，例如:英雄聯盟剛開始500元
        private void Start()
        {
            //print("哈囉，沃德:D");//MonoBehavier提供
        }
        //更新事件:每秒執行約60次，60FPS Frame per second
        private void Update()
        {
           print("<Color=yellow>遊戲更新中</Color>");
            //Run();
            run2();
        }
        //此元件被勾選一次執行一次
        private void OnEnable()
        {
            
        }
        //此元件被取消勾選一次執行一次
        private void OnDisable()
        {
            //加速度歸零
            rig.velocity = Vector3.zero;
        }
        #endregion
    }
}

