using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieHealth : MonoBehaviour
{

	public Slider Zslider;
	public Gradient gradient;
	public Image fill;

	public void SetMaxHealth(int health)
	{
		Zslider.maxValue = health;
		Zslider.value = health;
		//fill.color = gradient.Evaluate(health / maxHealth);

		fill.color = gradient.Evaluate(1f);
	}

    public void SetHealth(int health)
	{
		Zslider.value = health;

		fill.color = gradient.Evaluate(Zslider.normalizedValue);
	}

}