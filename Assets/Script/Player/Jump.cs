using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce2 = 10f; // ĳ���Ͱ� ������ �� ������ ���� ũ��

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // ĳ���Ϳ��� ȿ���� ��
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            Debug.Log("asv");
            if (rb != null)
            {
                rb.AddForce(Vector3.up * jumpForce2, ForceMode.Impulse); // �������� ���� ���� ���� ȿ���� ��
                Debug.Log("Jump!!!");
                Debug.Log("Jump!!!");
            }
        }
    }
}
