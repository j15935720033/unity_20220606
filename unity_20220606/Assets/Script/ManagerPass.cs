using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 管理過關
/// </summary>
public class ManagerPass : MonoBehaviour
{
    [SerializeField, Header("目標名稱")]
    private string nameTarget = "忍者龜";
    [SerializeField, Header("跑步系統")]
    private chia.SystemRun run;
    [SerializeField, Header("跳躍系統")]
    private chia.SystemJump jump;
    [SerializeField, Header("結束管理器")]
    private chia.ManageFinal manageFinal;


    #region 其中一個物件有勾選 is Trigger
    //2個物件碰撞執行一次
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.name);
        if (collision.name.Contains(nameTarget))//碰撞名包含nameTarget
        {
            run.enabled = false;//關閉跑步系統
            jump.enabled = false;//關閉跳躍系統
            manageFinal.enabled = true;//開啟結束管理器
            manageFinal.stringTitle = "恭喜你過關";
        }
    }
    //2個物件碰撞離開執行一次
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    //兩個物件碰撞重疊時持續執行
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
    #endregion
    #region 2個要碰撞物件都沒勾選 is Trigger
    //2個物件碰撞執行一次
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    //2個物件碰撞離開執行一次
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
    //兩個物件碰撞重疊時持續執行
    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }
    #endregion
}
