
using UnityEngine;
namespace chia
{
    public class APIstatic : MonoBehaviour
    {
        private void Start()
        {
            #region �m��
            /*
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
            */
            #endregion

            #region C# �R�A�ݩʻP��k�m�� 2022.06.13
            //���o�Ҧ���v���ƶq
            int AllCameraNum = Camera.allCameras.Length;
            //���o���ε{�������x
            string application = Application.platform.ToString();
            //���o2D���z�ίv�{�ɭȳ]�w�� 10
            Physics2D.timeToSleep=10;
            //�ɶ��j�p�]�w�� 0.5(�C�ʧ@)
            Time.fixedDeltaTime = 0.5f;
            //�� 9.999 �h�p���I (������h���覡)
            float f01=Mathf.Floor(9.999f);
            //����p�Ʋ�2�� 
            double f02 = System.Math.Round(9.255, 2);
            double f03 = System.Math.Round(9.245, 2);


            print("�Ҧ���v���ƶq"+ AllCameraNum);
            print("���ε{�������x" + application);
            print("���o2D���z�ίv�{�ɭ�" + Physics2D.timeToSleep);
            print("�� 9.999 �h�p���I:" + f01);
            print("�� 9.255 ����p�Ʋ�2�� :" + f02);
            print("�� 9.245 ����p�Ʋ�2�� :" + f03);
            #endregion
        }
        private void Update()
        {
            //���o�O�_��J���N��
            //bool getAnyKey =Input.anyKey;
            if (Input.anyKey)
            {
                print("A key or mouse click has been detected");
            }
            //���o�C���g�L�ɶ�
            float GameTime=Time.time;
            //print("<Color=yellow >�C���ɶ�:</Color >"+ GameTime);
           
           
        }
        
    }
}