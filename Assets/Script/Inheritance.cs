using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dragon dragon = new Dragon();
        dragon.EnemyName = "Dragon";
        dragon.Attack();
        dragon.Fly();

        Snake snake = new Snake();
        snake.EnemyName = "Snake";
        snake.Move();
        snake.Attack();

        Fish fish = new Fish();
        fish.EnemyName = "Fish";
        fish.Swim();
        fish.Attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
