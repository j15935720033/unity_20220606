using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//控制畫布底下的TextMeshPro
using UnityEngine.SceneManagement;//引用場景API
namespace chia
{
    public class ManageFinal : MonoBehaviour
    {
        [SerializeField, Header("畫布")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("遊戲結束標題")]
        private TextMeshProUGUI textFinal;
        /// <summary>
        /// 遊戲結束標題的文字內容
        /// </summary>
        public string stringTitle;


        private void Start()
        {
            textFinal.text = stringTitle;

            //MonoBehaviour 類別API 可以直接使用名子呼叫
            InvokeRepeating("FadIn", 0,0.2f);//("方法名"，案開始後要間隔幾秒執行，執行頻率)
        }
        private void FadIn()
        {
            //透明度遞增
            groupFinal.alpha += 1;
            print("淡入");
            //如果 透明度>=1 就啟動互動與遮擋射線
            if (groupFinal.alpha>=1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
            }
            CancelInvoke("FadIn");
        }

        /// <summary>
        ///按鈕與程式溝通方式
        //1.定義公開方式
        //2.Button on click 設定此腳本公開方式
        /// </summary>
        public void Quit()
        {
            print("離開遊戲");
            //只在發布執行檔 電腦與手機裝置上使用
            Application.Quit();
        }
        /// <summary>
        /// 重新遊戲
        /// </summary>
        public void Replay()
        {
            SceneManager.LoadScene("場景");
        }
    }
}

