using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake() // ������ ��! �ʱ�ȭ
    {
        Debug.Log("�ʱ�ȭ 1");
    }
    
    private void Start()  //Awake ����! �ʱ�ȭ
    {
        Debug.Log("�ʱ�ȭ 2");
    }

    // Update is called once per frame.

    private void FixedUpdate()   // �������� ���� - RigidBody������ ���� ������ ����. �׶��� ȣ���ϴ� �̺�Ʈ. ���������� �ִٸ�, ���� ���� �� Update�� �Ѿ.
    {

    }

    private void Update()   // �� ������ ȣ��. ������?
    {
        
    }


    private void LateUpdate()   // ��� ������Ʈ�� �� ���� ��! - �ð�, ���
    {
        
    }

    private void OnEnable()    
    {
        //�ش� ������Ʈ�� ������ ��!
        Debug.Log("����");
    }

    private void OnDisable()
    {
        //�ش� ������Ʈ�� ������ ��!
        Debug.Log("����");
    }


    float f;  // ����
    int i = 0; // ����+�Ҵ� (�ʱ�ȭ)
    f = 2;  // Ŭ���� �������� '�Ҵ縸'�� �Ұ�!
}
