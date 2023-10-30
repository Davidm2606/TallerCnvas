using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void IrAJuego()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void IrOpcioneso()
    {
        SceneManager.LoadScene("OptionScene");
    }

    public void IrExit()
    {
        SceneManager.LoadScene("ExitScene");
    }

    public void NoExit()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitOp()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
