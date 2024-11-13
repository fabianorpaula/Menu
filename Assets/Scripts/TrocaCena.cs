using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCena : MonoBehaviour
{
    

    public void ChamarCena()
    {
        //Chamar pelo nome por extenso
        SceneManager.LoadScene("Fase1");
    }

    public void ChamaFase(int numerofase)
    {
        //Chamar pela Ordem no Build
        SceneManager.LoadScene(numerofase);

        
    }

}
