
using UnityEngine;
namespace chia
{
    public class APIstatic : MonoBehaviour
    {
        private void Start()
        {
            #region �m��
            //���o�R�A�ݩ�
            //�y�k:
            //���O.�R�A�ݩʦW��
            print("�H����:" + Random.value);
            print("PI:" + Mathf.PI);
            print("�L���j:" + Mathf.Infinity);

            //�]�w�R�A�ݩ� set(Read Only ����ϥ�)
            //�y�k:
            //���O.�R�A�ݩʦW�� ���w ��
            Cursor.visible = false;//Cursor:����
            Physics2D.gravity = new Vector2(0, -9.8f);
            Time.timeScale = 0f;
            //Physics2D:2D�a�ߤޤO�AVector2(X�b,Y�b)
            float range = Random.Range(20.5f, 100.5f);
            print("�H���d��" + range);

            int rangeInt = Random.Range(1, 3);//���]�t3
            print("�H�����1~2" + rangeInt);
            #endregion

            #region C# �R�A�ݩʻP��k�m�� 2022.06.13
            //���o�Ҧ���v���ƶq
            int AllCameraNum = Camera.allCameras.Length;
            //���o���ε{�������x
            string application = Application.platform.ToString();


            #endregion
        }
        private void Update()
        {
            
        }
    }
}