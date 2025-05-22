using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float padForce;
  
    private void OnCollisionEnter(Collision collision)
    {
        //상대의 rigidbody 가져옴
        Rigidbody _rigidbody = collision.gameObject.GetComponent<Rigidbody>();
        if (collision.gameObject == PlayerManager.Instance.Player.gameObject)
        {
            _rigidbody.AddForce(Vector3.up * padForce, ForceMode.Impulse);
        }
    }
}
