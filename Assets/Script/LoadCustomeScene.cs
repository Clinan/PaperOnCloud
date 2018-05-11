using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadCustomeScene : MonoBehaviour
{


    public string sceneName = "first";

    private Canvas optionCanvas;
    private Button okButton;
    private bool flag = true;

    void Start()
    {
        Debug.Log("start load");
        optionCanvas = gameObject.GetComponentInChildren<Canvas>();
        Button[] bs = optionCanvas.GetComponentsInChildren<Button>();
        foreach (Button b in bs)
        {
            if (b.gameObject.name.Equals("btn_ok"))
            {
                okButton = b;
            }

        }

        okButton.onClick.AddListener(OkOnClick);

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("update");
    }

    public void OkOnClick()
    {

        Debug.Log("ok");
        SceneManager.LoadScene(sceneName);


    }


}
