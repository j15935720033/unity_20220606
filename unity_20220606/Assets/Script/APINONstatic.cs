using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace chia
{
    /// <summary>
    /// �D�R�AAPI
    /// �P�R�A�t�O�b��ݭn�@�ӹ��骫��
    /// ���骫��:�@�Ӧs�b������W���C������ Game Object
    /// </summary>
    public class APINONstatic : MonoBehaviour
    {

        //�D�R�A����
        //1.�w�q���A������欰���O
        //2.Unity�ݩʭ��O�����T�w����줣�O�ŭ�(none)
        //3.�ϥΫD�R�AAPI
        [SerializeField]
        private GameObject turtle;
        [SerializeField]
        private Transform StartPoint;

        private void Start()
        {
            //�D�R�A�ݩ�
            //1.���o
            //�y�k:
            //���W��.�D�ݩʤ�k
            print("�Ԫ��t���Ұʪ��A"+turtle.activeInHierarchy);
            print("�Ԫ��t���w�]�ϼh" + turtle.layer);
            print("�_�I���y��" + StartPoint.position);
            //2.�]�w
            //�y�k:
            //���W��.�D�R�A�ݩ� ���w ��
            //turtle.activeInHierarchy=false;(���~�A�]���߿W�ݩ�)
            turtle.tag = "Player";
            turtle.layer = 4;
            //StartPoint.position = new Vector3(0, 5, 0);
            //3.�ϥ� �D�R�A��k
            //�y�k:���W��.�D�R�A��k(�������޼�);
            turtle.SetActive(true);
        }
        private void Update()
        {
            StartPoint.Translate(1.5f,0,0);
            //StartPoint.Rotate(0, 0, 3.5f);
        }
    }
}