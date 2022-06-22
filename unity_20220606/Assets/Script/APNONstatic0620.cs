using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APNONstatic0620 : MonoBehaviour
{
    [SerializeField]
    private Camera camera;
    [SerializeField]
    private GameObject Sphere;
    [SerializeField]
    private GameObject Capsule;
    [SerializeField]
    private GameObject Cube;

    private SphereCollider SphereCollider;
    private Vector3 scaleChange;

    private Transform Transform_Capsule;
    private Transform Transform_Sphere;
    private Transform Transform_Cube;

    private Rigidbody Rigidbody3D_Capsule;

    

    // Start is called before the first frame update
    void Start()
    {

        //���o��v���`�� (Depth)
        print($"���o��v���`��:{camera.depth}");
        //���o�y��I�����b�|
        SphereCollider = Sphere.GetComponent<SphereCollider>();
        print($"���o�y��I�����b�|:{SphereCollider.radius}");

        //�s����v�����I���C����w���H���C��   https://blog.csdn.net/poda_/article/details/49780457
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        camera.backgroundColor = new Color(r, g, b);
        //�s���n��ؤo�אּ 3, 2, 1   https://docs.unity3d.com/ScriptReference/Transform-localScale.html
        Transform_Capsule = Capsule.GetComponent<Transform>();
        scaleChange = new Vector3(3f, 2f, 1f);
        Transform_Capsule.localScale = scaleChange;
    }

    // Update is called once per frame
    void Update()
    {
        //���ߤ���ݵ۲y�����
        Transform_Sphere = Sphere.GetComponent<Transform>();
        Transform_Cube = Cube.GetComponent<Transform>();
        Transform_Sphere.Rotate(0, 0, 6f);//�y�����
        Transform_Sphere.Translate(0.5f, 0, 0); 
        Transform_Cube.LookAt(Transform_Sphere);
        //�����n�驹�W���ͱ��O
        Rigidbody3D_Capsule = Capsule.GetComponent<Rigidbody>();
        Vector3 vector3 = new Vector3(0,5,0);
        Rigidbody3D_Capsule.AddForce(vector3);
    }
}
