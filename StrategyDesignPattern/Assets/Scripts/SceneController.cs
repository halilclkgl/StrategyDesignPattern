using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public Character character;
  

    private void Start()
    {
        // Ba�lang��ta y�r�me algoritmas� atan�r
        IMovementStrategy walkStrategy = new WalkStrategy();
        character.SetMovementStrategy(walkStrategy);
    }

    private void Update()
    {
        // W tu�una bas�l�nca y�r�me algoritmas� atan�r
        if (Input.GetKeyDown(KeyCode.W))
        {
            IMovementStrategy walkStrategy = new WalkStrategy();
            character.SetMovementStrategy(walkStrategy);
       
        }

        // R tu�una bas�l�nca ko�ma algoritmas� atan�r
        if (Input.GetKeyDown(KeyCode.R))
        {
            IMovementStrategy runStrategy = new RunStrategy();
            character.SetMovementStrategy(runStrategy);
        }

        // F tu�una bas�l�nca u�ma algoritmas� atan�r
        if (Input.GetKeyDown(KeyCode.F))
        {
            IMovementStrategy flyStrategy = new FlyStrategy();
            character.SetMovementStrategy(flyStrategy);
        }

        // Space tu�una bas�l�nca karakter hareket eder
        if (Input.GetKeyDown(KeyCode.Space))
        {
            character.Move();
        }
    }
}
