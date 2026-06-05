using System;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    byte health = 5;
    [SerializeField] float speed = 2.0f;

    [SerializeField] Color color;

    [SerializeField] GameObject capsule;

    private Renderer capsuleMaterial;

    private PlayerInput playerInput;


    private void Awake()
    {
        playerInput = new PlayerInput();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (capsule != null)
        {
            capsuleMaterial = capsule.GetComponent<Renderer>();
            RandomColor();

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
        }
    }

    private void RandomColor()
    {
        UnityEngine.Random.InitState((int)Mouse.current.position.ReadValue().x);

        Color randomColor = UnityEngine.Random.ColorHSV();
        
        
        capsuleMaterial.material.color = randomColor;
        
    }
}
