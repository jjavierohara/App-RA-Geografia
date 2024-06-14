using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor; 
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // El método Update se llama una vez por cuadro
    void Update()
    {
        
    }

    // Método para cargar la escena del juego
    public void Escanear()
    {
        SceneManager.LoadScene("escaneame");
    }

    // Método para cargar la escena de instrucciones
    public void CargarInformacion(string Informacion)
    {
        SceneManager.LoadScene("informacion");
    }

     // Método para cargar la escena de estructura
    public void CargarContacto(string Contacto)
    {
        SceneManager.LoadScene("contacto");
    }

    // Método para salir del juego
    public void Salir()
    {
        Application.Quit();
    }

    //regresar al login
        public void regresar(string regresar)
    {
        SceneManager.LoadScene("inicio");
    }
}
