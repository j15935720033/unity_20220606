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

    private SphereCollider SphereCollider;
    private Transform Transform_Capsule;
    private Transform Transform_Sphere;
    private Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {

        //取得攝影機深度 (Depth)
        print($"取得攝影機深度:{camera.depth}");
        //取得球體碰撞器半徑
        SphereCollider = Sphere.GetComponent<SphereCollider>();
        print($"取得球體碰撞器半徑:{SphereCollider.radius}");

        //存放攝影機的背景顏色指定為隨機顏色   https://blog.csdn.net/poda_/article/details/49780457
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        camera.backgroundColor = new Color(r, g, b);
        //存放膠囊體尺寸改為 3, 2, 1   https://docs.unity3d.com/ScriptReference/Transform-localScale.html
        Transform_Capsule = Capsule.GetComponent<Transform>();
        scaleChange = new Vector3(3f, 2f, 1f);
        Transform_Capsule.localScale = scaleChange;
    }

    // Update is called once per frame
    void Update()
    {
        //讓立方體看著球體旋轉
        Transform_Sphere = Sphere.GetComponent<Transform>();
        Transform_Sphere.Rotate(0, 0, 3.5f);
    }
}
