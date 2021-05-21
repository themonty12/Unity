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

    // CollisionEnter : 물리적 충돌이 시작할 때 호출되는 함수
    // Collision : 충돌 정보 클래스
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(0, 0, 0);

    }

    // CollisionExit : 물리적 충돌이 끝났을 때 호출되는 함수
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
    }

    // CollisionStay : 물리적 충돌이 일어나는 중 호출되는 함수
    private void OnCollisionStay(Collision collision)
    {

    }
    
}
