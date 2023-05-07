using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public Character character;
  

    private void Start()
    {
        // Baþlangýçta yürüme algoritmasý atanýr
        IMovementStrategy walkStrategy = new WalkStrategy();
        character.SetMovementStrategy(walkStrategy);
    }

    private void Update()
    {
        // W tuþuna basýlýnca yürüme algoritmasý atanýr
        if (Input.GetKeyDown(KeyCode.W))
        {
            IMovementStrategy walkStrategy = new WalkStrategy();
            character.SetMovementStrategy(walkStrategy);
       
        }

        // R tuþuna basýlýnca koþma algoritmasý atanýr
        if (Input.GetKeyDown(KeyCode.R))
        {
            IMovementStrategy runStrategy = new RunStrategy();
            character.SetMovementStrategy(runStrategy);
        }

        // F tuþuna basýlýnca uçma algoritmasý atanýr
        if (Input.GetKeyDown(KeyCode.F))
        {
            IMovementStrategy flyStrategy = new FlyStrategy();
            character.SetMovementStrategy(flyStrategy);
        }

        // Space tuþuna basýlýnca karakter hareket eder
        if (Input.GetKeyDown(KeyCode.Space))
        {
            character.Move();
        }
    }
}
