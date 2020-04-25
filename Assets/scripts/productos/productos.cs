using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class productos : ScriptableObject
{
    /*
     * productos:
     * clase padre de todos los productos que se crearan
     * 
     * parametros:
     *  nombre (string): nombre del producto
     *  descripcion (string): descripcion del producto
     *  precio (string): precio del producto
     */

    //nombre del producto
    public string nombre;

    //descripcion del producto
    public string descripcion;
    
    //precio del producto
    public string precio;


}
