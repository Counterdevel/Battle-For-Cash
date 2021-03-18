using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] GameObject panelexit;
    public CanvasGroup background;
    public Transform box;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                if (panelexit)
                {
                    panelexit.SetActive(true);
                    Open();
                }
            }
        }
    }

    public void OnClickYesOrNo(int choice)
    {
        if(choice == 1)
        {
            Application.Quit();
        }
        Close();
    }
    public void Open()
    {
        background.alpha = 0;
        background.LeanAlpha(1, 0.5f);

        box.localPosition = new Vector2(0, -Screen.height);
        box.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
    }
    public void Close()
    {
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo().setOnComplete(OnComplete);
    }

    void OnComplete()
    {
        panelexit.SetActive(false);
    }
}
