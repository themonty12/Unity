using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 2.6f, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1.MoveTowards (�ܼ� ��� �̵�)
        //transform.position = Vector3.MoveTowards(transform.position, 
        //                                            target, 1f);

        // 2. SmoothDamp ( �̲��������� ���� �̵�)
        //Vector3 velo = Vector3.zero;

        //transform.position = Vector3.SmoothDamp(transform.position,
        //target, ref velo, 0.5f);

        // 3. Lerp(���� ����)
        //transform.position = Vector3.Lerp(transform.position,
        //                                            target, 0.1f);

        // 4. SLerp (���� ���� ����)
        //transform.position = Vector3.Slerp(transform.position,
        //                                            target, 0.05f);

        // 5. DeltaTime
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 0);
        transform.Translate(vec);
    }
}
