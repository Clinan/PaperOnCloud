using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadCustomeScene : MonoBehaviour
{


    public string sceneName = "first";

    public Canvas optionCanvas;
    public Button okButton;
    public Button cancelButton;
    public bool flag = true;

    // Use this for initialization
    void Start()
    {
        //DestroyObject(optionCanvas);

        //if (Application.platform == RuntimePlatform.Android)
        //{
        //    AndroidJavaClass jc = new AndroidJavaClass("com.quyue.paperoncloud.UnityActivity");
        //    AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("mActivity");
        //    string[] mObject = new string[2];
        //    bool result = jo.Call<bool>("showDialog", mObject);
        //    if (result)
        //    {
        //        SceneManager.LoadScene(sceneName);
           
        //    }
        //}
        //else
        //{

            optionCanvas = Instantiate(optionCanvas);
            Button[] bs = optionCanvas.GetComponentsInChildren<Button>();
            foreach (Button b in bs)
            {
                if (b.gameObject.name.Equals("btn_ok"))
                {
                    okButton = b;
                }
                if (b.gameObject.name.Equals("btn_cancel"))
                {
                    cancelButton = b;
                }

            }

        okButton.onClick.AddListener(OkOnClick);
        cancelButton.onClick.AddListener(CancelOnClick);
        //}
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("update");
    }

    public void OkOnClick()
    {
        
            Debug.Log("ok");
            optionCanvas.gameObject.SetActive(false);
            //DestroyImmediate(optionCanvas, true);
            //Component[] component = optionCanvas.GetComponentsInChildren<Component>();
            //foreach (Component c in component)
            //{
            //    DestroyImmediate(c, true);
            //}
            Scene first = SceneManager.GetSceneByName("first");
            SceneManager.UnloadSceneAsync(first);
            SceneManager.LoadScene(sceneName);
        
        
        
    }

    public void CancelOnClick()
    {

        optionCanvas.gameObject.SetActive(false);
    }


}
