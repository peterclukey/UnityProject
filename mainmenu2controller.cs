using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu2controller : MonoBehaviour
{

    public void NormalLevelButton()
    {
        SceneManager.LoadScene("SampleScene2");
    }
    public void EasyLevelButton()
    {
        SceneManager.LoadScene("EasyScene2");
    }
    public void Back()
    {
        SceneManager.LoadScene("CharacterSelectionMenu");
    }
}
