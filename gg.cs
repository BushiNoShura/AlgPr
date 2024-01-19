using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gg : MonoBehaviour
{
    
    public int health = 10;
    public int level = 2;
    public float speed = 3;


    void Start()
    {
        health += level; // увеличение здоровья
        print(health); // вывод здоровья
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 0)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);//дв-ие вверх
        }
    }
}
