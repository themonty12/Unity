using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // CollisionEnter : ������ �浹�� ������ �� ȣ��Ǵ� �Լ�
    // Collision : �浹 ���� Ŭ����
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(0, 0, 0);

    }

    // CollisionExit : ������ �浹�� ������ �� ȣ��Ǵ� �Լ�
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
    }

    // CollisionStay : ������ �浹�� �Ͼ�� �� ȣ��Ǵ� �Լ�
    private void OnCollisionStay(Collision collision)
    {

    }
    
}
