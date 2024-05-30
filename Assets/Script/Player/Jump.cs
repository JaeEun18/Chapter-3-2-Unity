using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce2 = 10f; // 캐릭터가 점프할 때 가해질 힘의 크기

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // 캐릭터에만 효과를 줌
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            Debug.Log("asv");
            if (rb != null)
            {
                rb.AddForce(Vector3.up * jumpForce2, ForceMode.Impulse); // 순간적인 힘을 가해 점프 효과를 줌
                Debug.Log("Jump!!!");
                Debug.Log("Jump!!!");
            }
        }
    }
}
