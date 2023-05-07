using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private IMovementStrategy movementStrategy;

    public void SetMovementStrategy(IMovementStrategy strategy)
    {
       
        movementStrategy = strategy;
    }

    public void Move()
    {
      
        if (movementStrategy != null)
        {
            movementStrategy.Move();
        }
    }
}
