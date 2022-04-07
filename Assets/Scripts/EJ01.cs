using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1.Crea un programa que pida dos números al usuario y responda si son iguales o no lo son.

public class EJ01 : MonoBehaviour
{

    public int num1;
    public int num2;

 
    void Start()
    {
        //LE INSTRUIMOS AL USUARIO QUE INGRESE DOS VALORES PARA NUESTRAS VARIABLES
        Debug.Log("Ingrese dos valores al inspector");

        //COMPROBAMOS SI LAS DOS VARIABLES TIENEN EL MISMO VALOR
        if (num1 == num2)
        {
            //Informamos al usuario el resultado
            Debug.Log("Los dos valores ingresados son iguales");
        }

        //UNICO CASO POSIBLE ADEMAS DE LA IGUALIDAD
        else
        {
            //Informamos al usuario el unico resultado posible
            Debug.Log("Los dos valores ingresados NO son iguales");
        }
    }


    void Update()
    {
        
    }
}
