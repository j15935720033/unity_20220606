
using UnityEngine;
namespace chia
{
    public class APIstatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1,1,1);
        private Vector3 b = new Vector3(22,22,22);
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
            //int AllCameraNum = Camera.allCameras.Length;
            //print("所有攝影機數量" + AllCameraNum);
            print("所有攝影機數量" + Camera.allCamerasCount);
            
            //取得應用程式的平台
            string application = Application.platform.ToString();
            print("應用程式的平台" + application);

            //取得3D物理睡眠臨界值設定為 10
            Physics.sleepThreshold = 10;
            print("3D睡眠臨界值" + Physics.sleepThreshold);

            //時間大小設定為 0.5(慢動作)
            //Time.fixedDeltaTime = 0.5f;//錯
            Time.timeScale = 0.5f;
            print("時間大小" + Time.timeScale);

            //對 9.999 去小數點 (不限制去除方式)
            float f01 = Mathf.Floor(9.999f);
            //取到小數第2位 
            double f02 = System.Math.Round(9.255, 2);
            double f03 = System.Math.Round(9.245, 2);
            
            print("對 9.999 去小數點:" + f01);
            print("對 9.255 取到小數第2位 :" + f02);//四舍六入五成双
            print("對 9.245 取到小數第2位 :" + f03);//取到第2位，第3位如果是5，會讓第2位便雙數

            //取得兩點的距離new Vector3(1, 1, 1) new Vector3(22, 22, 22)
            float distance = Vector3.Distance(a, b);
            print("取得兩點的距離" + distance);
            //開啟連結
            //Application.OpenURL("https://unity.com/");
            #endregion
        }
        private void Update()
        {
            #region
            print($"<color=yellow>Input.GetAxis:{Input.GetAxis("Horizontal")}</color>"); ;
            
            //print("是否按下任意鍵" + Input.anyKeyDown);
            //print("<color=yellow>遊戲總時間GameTime:</color>" +Time.time);
            //print("<color=yellow>遊戲每個場景開始時間timeSinceLevelLoad:</color>" + Time.timeSinceLevelLoad);
            //print("<color=red>是否按下空白鍵:"+Input.GetKeyDown(KeyCode.Space)+ "</color>");
            #endregion



        }

    }
}