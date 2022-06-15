
using UnityEngine;
namespace chia
{
    public class APIstatic : MonoBehaviour
    {
        private void Start()
        {
            #region 練習
            /*
            //取得靜態屬性
            //語法:
            //類別.靜態屬性名稱
            print("隨機值:" + Random.value);
            print("PI:" + Mathf.PI);
            print("無限大:" + Mathf.Infinity);

            //設定靜態屬性 set(Read Only 不能使用)
            //語法:
            //類別.靜態屬性名稱 指定 值
            Cursor.visible = false;//Cursor:指標
            Physics2D.gravity = new Vector2(0, -9.8f);
            Time.timeScale = 0f;
            //Physics2D:2D地心引力，Vector2(X軸,Y軸)
            float range = Random.Range(20.5f, 100.5f);
            print("隨機範圍" + range);

            int rangeInt = Random.Range(1, 3);//不包含3
            print("隨機整數1~2" + rangeInt);
            #endregion
            */
            #endregion

            #region C# 靜態屬性與方法練習 2022.06.13
            //取得所有攝影機數量
            int AllCameraNum = Camera.allCameras.Length;
            //取得應用程式的平台
            string application = Application.platform.ToString();
            //取得2D物理睡眠臨界值設定為 10
            Physics2D.timeToSleep=10;
            //時間大小設定為 0.5(慢動作)
            Time.fixedDeltaTime = 0.5f;
            //對 9.999 去小數點 (不限制去除方式)
            float f01=Mathf.Floor(9.999f);
            //取到小數第2位 
            double f02 = System.Math.Round(9.255, 2);
            double f03 = System.Math.Round(9.245, 2);


            print("所有攝影機數量"+ AllCameraNum);
            print("應用程式的平台" + application);
            print("取得2D物理睡眠臨界值" + Physics2D.timeToSleep);
            print("對 9.999 去小數點:" + f01);
            print("對 9.255 取到小數第2位 :" + f02);
            print("對 9.245 取到小數第2位 :" + f03);
            #endregion
        }
        private void Update()
        {
            //取得是否輸入任意鍵
            //bool getAnyKey =Input.anyKey;
            if (Input.anyKey)
            {
                print("A key or mouse click has been detected");
            }
            //取得遊戲經過時間
            float GameTime=Time.time;
            //print("<Color=yellow >遊戲時間:</Color >"+ GameTime);
           
           
        }
        
    }
}