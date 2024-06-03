using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoquitoScript : MonoBehaviour
{
    public GameObject[] colors;
    public int currentLightIndex =-1;
    int A = 0;
    int B = 0;
    int N = 0;
    int R = 0;
    int V = 0;
    int VidaUtil = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateNextLight() //Activa el siguiente elemento
    {
        currentLightIndex++; // Suma 1 al -1 para que arranque en 0

        if (currentLightIndex >= colors.Length) //Si el indice actual es mayor al ultimo indice
        {
            currentLightIndex = 0; // Si se pasa de indices, vuelve a cero
        }

        DeactivateAllLights(); // Desactiva todas las luces
        colors[currentLightIndex].SetActive(true); //Activa el nuevo indice
        if (currentLightIndex == 0)
        {
            A++;
            if (A > VidaUtil)
            {
                colors[currentLightIndex].SetActive(false);
            }
        }
        if (currentLightIndex == 1)
        {
            B++;
            if (B > VidaUtil)
            {
                colors[currentLightIndex].SetActive(false);
            }
        }
        if (currentLightIndex == 2)
        {
            N++;
            if (N > VidaUtil)
            {
                colors[currentLightIndex].SetActive(false);
            }
        }
        if (currentLightIndex == 3)
        {
            R++;
            if (R > VidaUtil)
            {
                colors[currentLightIndex].SetActive(false);
            }
        }
        if (currentLightIndex == 4)
        {
            V++;
            if (V > VidaUtil)
            {
                colors[currentLightIndex].SetActive(false);
            }
        }
    }

    public void ActivatePreviousLight() // Lo mismo que ActiveNextLight() pero para antras
    {
        currentLightIndex--;
        if (currentLightIndex < 0)
        {
            currentLightIndex = colors.Length - 1;
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
    }

    void DeactivateAllLights() //Desactivar todas las luces
    {
        /*
        foreach (GameObject g in colors) // Pasa por todos los elementos del array "colors"
        {
            g.SetActive(false); //Desactiva cada g en colors, es decir, cada elemnto
        }*/

        for (int i = 0; i < colors.Length; i++) //Recorre el array desde el 0 hasta el último
        {
            colors[i].SetActive(false); //Desactiva todas las luces
        }
    }

    public void ActivateRepeating(float t)
    {
        InvokeRepeating(nameof(ActivateNextLight),0,t); // Repite la función AcrivateNextLight() con la variable t
    }                                            // 0 por , t es el tiempo del intervalo
}
