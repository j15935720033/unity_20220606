
using UnityEngine;//�ޥ�UnityEngine���R�W�Ŷ�
namespace action
{
    /*C# �q�Ź��ܦ�����ƥ�:
        1.�����W���C������Game Object �Ǧ���
        2.�N���}�����b�Ӫ����ܦ�����
     */
    /// <summary>
    /// �]�B�t��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {


        #region  ���:�O�s�t�λݭn�����
        //��� Field:�O�s���
        //�y�k:
        //�׹��� ��������� ���ۭq�W�� (���w �w�]��)

        //�׹���
        //���}:��ܦb���O�A���\��L���O�s�� public
        //�p�H:����ܦb���O�A�����\��L���O�s�� private(�ʸ�)

        //[] Attritube �ݩʡA�B�~�\��
        //serialize Field:�ǦC�����A�N�p�H�����ܦbunity Hub
        //Header:���D(�i�Τ���)
        //Tooltip:����(�i�Τ���)
        //Range:�d�� (�ȭ���ƭ�������ơAint float byte long)
        [SerializeField,Header("�]�B�t��"),Tooltip("�o�O���⪺�]�B�t��"),Range(0,100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("���D����"), Tooltip("�o�O���⪺�]�B����"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region  �\��:��@�Өt�Ϊ�������k

        #endregion

        #region  �ƥ�:�{���J�f
        //�}�l�ƥ�:����C���ɰ���@��
        //��l�Ƴ]�w�A�Ҧp:�^���p����}�l500��
        private void Start()
        {
            print("���o�A�U�w:D");//MonoBehavier����
        }
        #endregion
    }
}

