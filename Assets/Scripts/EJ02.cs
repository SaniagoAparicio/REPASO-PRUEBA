using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2.Solicitar el ingreso del precio de 3 productos y un monto de dinero disponible.
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
//Luego indicar cuánto dinero sobra o falta.

public class EJ02 : MonoBehaviour
{

    public float product1;
    public float product2;
    public float product3;

    public float dinero;


    void Start()
    {
        //LE INSTRUIMOS AL USUARIO QUE INGRESE EL VALOR DE LOS 3 PRODUCTOS
        Debug.Log("Ingrese el precio a los 3 productos");

        //LE INSTRUIMOS AL USUARIO QUE INGRESE CON CUANTO DINERO TIENE DISPONIBLE
        Debug.Log("Con cuanto dinero cuenta usted?, ingreselo");

        //CREAMOS UNA VARIABLE QUE VALGA EL EQUIVALENTE A TODOS LOS PRODUCTOS 
        float producT = product1 + product2 + product3;

        //COMPROBAMOS SI EL DINERO SOBREPASA A TODOS LOS PRODUCTOS EN VALOR
        if (producT <= dinero)
        {
            //Informamos al Usuario el resultado
            Debug.Log("Usted es capaz de comprar los 3 productos");
        }

        //CREAMOS UNA VARIABLE QUE VALGA EL EQUIVALENTE AL RESTO DEL DINERO LUEGO DE COMPRAR TODOS LOS PRODUCTOS
        float excedente = dinero - producT;

       //COMPROBAMOS SI EXISTE UN "RESTITO"
        else if (excedente == 0)
        {
            //Informamos al Usuario el resultado
            Debug.Log("No le sobra dinero");
        }


        //COMPROBAMOS SI EL RESTO SOBREPASA A 0
        else if (excedente > 0)
        {
            //Informamos al Usuario el resultado
            Debug.Log("A usted le sobra $" + excedente);
        }

        //UNICA SITUACION POSIBLE
        else
        {
            //Informamos al Usuario que no le alcanza para comprar los 3 productos juntos
            Debug.Log("Usted NO es capaz de comprar los 3 productos");
        }

        

    }

   
    void Update()
    {
        
    }
}
