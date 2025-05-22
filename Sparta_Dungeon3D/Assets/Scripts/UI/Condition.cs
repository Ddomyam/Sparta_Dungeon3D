using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public float curValue;
    public float startValue;
    public float maxValue;
    public float passiveValue;
    public Image uiBar;

    private void Start()
    {
        curValue = startValue;
    }
    private void Update()
    {
        //UI 업데이트
        uiBar.fillAmount = GetPercentage();

    }

    //0과 1사이의 값, 즉 퍼센트를 계산하기 위해 최대값을 현재값으로 나눔.
    float GetPercentage()
    {
        return curValue / maxValue;
    }

    public void Add(float value)
    {
        //더 작은 값을 반환함.
        curValue = Mathf.Min(curValue + value, maxValue);
    }

    public void Subtract(float value)
    {
        curValue = Mathf.Max(curValue - value, 0);
    }
}
