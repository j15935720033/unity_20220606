using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �޲z�L��
/// </summary>
public class ManagerPass : MonoBehaviour
{
    [SerializeField, Header("�ؼЦW��")]
    private string nameTarget = "�Ԫ��t";
    [SerializeField, Header("�]�B�t��")]
    private chia.SystemRun run;
    [SerializeField, Header("���D�t��")]
    private chia.SystemJump jump;
    [SerializeField, Header("�����޲z��")]
    private chia.ManageFinal manageFinal;


    #region �䤤�@�Ӫ��󦳤Ŀ� is Trigger
    //2�Ӫ���I������@��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.name);
        if (collision.name.Contains(nameTarget))//�I���W�]�tnameTarget
        {
            run.enabled = false;//�����]�B�t��
            jump.enabled = false;//�������D�t��
            manageFinal.enabled = true;//�}�ҵ����޲z��
            manageFinal.stringTitle = "���ߧA�L��";
        }
    }
    //2�Ӫ���I�����}����@��
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    //��Ӫ���I�����|�ɫ������
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
    #endregion
    #region 2�ӭn�I�����󳣨S�Ŀ� is Trigger
    //2�Ӫ���I������@��
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    //2�Ӫ���I�����}����@��
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
    //��Ӫ���I�����|�ɫ������
    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }
    #endregion
}
