using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class PlayerCondition : MonoBehaviour
{
    public UICondition uiCondition;
    Condition health { get { return uiCondition.health; } }
    void Update()
    {
        if (health.curValue == 0f)
        {
            Die();
        }
    }

    public void Die()
    {

    }
}
