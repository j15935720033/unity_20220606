using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerDead : MonoBehaviour
{
    [SerializeField, Header("�ؼЦW��")]
    private string nameTarget = "�Ԫ��t";
    [SerializeField, Header("�����޲z��")]
    private chia.ManageFinal managerFinal;
    [SerializeField, Header("CM ��v�������")]
    private GameObject goCM;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        managerFinal.stringTitle = "�D�ԥ���";
        managerFinal.enabled = true;
        goCM.SetActive(false);
    }
}
