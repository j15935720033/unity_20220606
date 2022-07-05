using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerDead : MonoBehaviour
{
    [SerializeField, Header("目標名稱")]
    private string nameTarget = "忍者龜";
    [SerializeField, Header("結束管理器")]
    private chia.ManageFinal managerFinal;
    [SerializeField, Header("CM 攝影機控制物件")]
    private GameObject goCM;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        managerFinal.stringTitle = "挑戰失敗";
        managerFinal.enabled = true;
        goCM.SetActive(false);
    }
}
