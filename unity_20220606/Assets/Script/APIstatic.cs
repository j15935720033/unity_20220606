
using UnityEngine;
namespace chia
{
    public class APIstatic : MonoBehaviour
    {
        private void Start()
        {
            #region 練習
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

            #region C# 靜態屬性與方法練習 2022.06.13
            //取得所有攝影機數量
            int AllCameraNum = Camera.allCameras.Length;
            //取得應用程式的平台
            string application = Application.platform.ToString();


            #endregion
        }
        private void Update()
        {
            
        }
    }
}