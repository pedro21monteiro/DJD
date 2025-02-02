using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BarSlide : MonoBehaviour
{
    public Slider sliderHP;
    public Slider sliderST;

    public void SetMaxHealth(int maxHealth)
    {
        sliderHP.maxValue = maxHealth;
        sliderHP.value = maxHealth;
    }
    public void SetCurrentHealth(int currenthealth)
    {
        sliderHP.value = currenthealth;
    }
    public void SetMaxStamina(int maxStamina)
    {
        sliderST.maxValue = maxStamina;
        sliderST.value = maxStamina;
    }
    public void SetCurrentStamina(int currentStamina)
    {
        sliderST.value = currentStamina;
    }
}
