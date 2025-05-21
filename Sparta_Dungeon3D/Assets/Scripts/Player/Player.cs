using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;

    private void Awake()
    {
        //player정보에 접근 할 수 있게 할당
        PlayerManager.Instance.Player = this;
        controller = GetComponent<PlayerController>();
    }
}
