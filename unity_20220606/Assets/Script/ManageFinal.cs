using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//����e�����U��TextMeshPro
using UnityEngine.SceneManagement;//�ޥγ���API
namespace chia
{
    public class ManageFinal : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;
        /// <summary>
        /// �C���������D����r���e
        /// </summary>
        public string stringTitle;


        private void Start()
        {
            textFinal.text = stringTitle;

            //MonoBehaviour ���OAPI �i�H�����ϥΦW�l�I�s
            InvokeRepeating("FadIn", 0,0.2f);//("��k�W"�A�׶}�l��n���j�X�����A�����W�v)
        }
        private void FadIn()
        {
            //�z���׻��W
            groupFinal.alpha += 1;
            print("�H�J");
            //�p�G �z����>=1 �N�Ұʤ��ʻP�B�׮g�u
            if (groupFinal.alpha>=1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
            }
            CancelInvoke("FadIn");
        }

        /// <summary>
        ///���s�P�{�����q�覡
        //1.�w�q���}�覡
        //2.Button on click �]�w���}�����}�覡
        /// </summary>
        public void Quit()
        {
            print("���}�C��");
            //�u�b�o�������� �q���P����˸m�W�ϥ�
            Application.Quit();
        }
        /// <summary>
        /// ���s�C��
        /// </summary>
        public void Replay()
        {
            SceneManager.LoadScene("����");
        }
    }
}

