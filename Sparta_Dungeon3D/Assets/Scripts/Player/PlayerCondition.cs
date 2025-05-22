using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class PlayerCondition : MonoBehaviour
{
    public UICondition uiCondition;

    public float boostAmount = 2f;
    public float duration = 5f;

    PlayerController controller;
    Condition health { get { return uiCondition.health; } }
    Condition stamina { get { return uiCondition.stamina; } }

    private void Start()
    {
        controller = GetComponent<PlayerController>();
    }
    void Update()
    {
        if (health.curValue == 0f)
        {
            Die();
        }
    }
    public void Heal(float amount)
    {
        health.Add(amount);
    }

    public void Recover(float amount)
    {
        stamina.Add(amount);
        controller.UseSpeedItem(boostAmount, duration);
    }

    public void Die()
    {

    }
}
