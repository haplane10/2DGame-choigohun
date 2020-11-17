using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStat : MonoBehaviour
{
    public int HP = 100;
    public Slider hpSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int _damageValue)
    {
        HP -= _damageValue;
        hpSlider.value = HP;
    }
}
