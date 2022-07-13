using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace chia
{
    /// <summary>
    /// 非靜態API
    /// 與靜態差別在於需要一個實體物件
    /// 實體物件:一個存在於場景上的遊戲物件 Game Object
    /// </summary>
    public class APINONstatic : MonoBehaviour
    {

        //非靜態物件
        //1.定義欄位，資料類行為類別
        //2.Unity屬性面板必須確定該欄位不是空值(none)
        //3.使用非靜態API
        [SerializeField]
        private GameObject turtle;
        [SerializeField]
        private Transform StartPoint;

        private void Start()
        {
            //非靜態屬性
            //1.取得
            //語法:
            //欄位名稱.非屬性方法
            print("忍者龜的啟動狀態"+turtle.activeInHierarchy);
            print("忍者龜的預設圖層" + turtle.layer);
            print("起點的座標" + StartPoint.position);
            //2.設定
            //語法:
            //欄位名稱.非靜態屬性 指定 值
            //turtle.activeInHierarchy=false;(錯誤，因為唯獨屬性)
            turtle.tag = "Player";
            turtle.layer = 4;
            //StartPoint.position = new Vector3(0, 5, 0);
            //3.使用 非靜態方法
            //語法:欄位名稱.非靜態方法(對應的引數);
            turtle.SetActive(true);
        }
        private void Update()
        {
            StartPoint.Translate(1.5f,0,0);//移動
            StartPoint.Rotate(0, 0, 3.5f);//旋轉
        }
    }
}