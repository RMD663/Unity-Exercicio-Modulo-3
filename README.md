# Unity-Exercicio-Modulo-2

Codigo da Atividade
``` C#
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CubeScript : MonoBehaviour
{

    private string _name = "Ryan";
    private int _steps = 0;

    [SerializeField] int health = 0;

    void Start()
    {
        Debug.Log(health);
    }

    void Update()
    {
        PressedKey();
    }

    void PressedKey()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            health += 1;
            Debug.Log("Current health: " + health);
        }
    }
}

```
