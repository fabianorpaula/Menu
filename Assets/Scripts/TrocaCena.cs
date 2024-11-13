using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCena : MonoBehaviour
{
    

    public void ChamarCena()
    {

        SceneManager.LoadScene("Fase1");
    }

    public void ChamaFase(int numerofase)
    {

        SceneManager.LoadScene(numerofase);

        
    }

}
