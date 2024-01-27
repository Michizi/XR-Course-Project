using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightControlScript : MonoBehaviour
{
    public new Light light;
    public Color[] colors;
    private int currentIndex = 0;
    public InputActionReference action;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) => 
        {
            ChangeColor();
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeColor()
    {
        currentIndex = (currentIndex + 1) % colors.Length;
        light.color = colors[currentIndex];
    }
}
