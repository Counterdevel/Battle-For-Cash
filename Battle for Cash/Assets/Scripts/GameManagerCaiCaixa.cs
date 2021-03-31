using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCaiCaixa : MonoBehaviour
{

    public GameObject PrefabCaixa;
    GameObject CaixaTimerComponents;
    private int index = 0;
    private int index1 = 0;

    public float[] position;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {

            int index = Random.Range(0, 9);
            int index1 = Random.Range(0, 9);

            Vector3 pos = new Vector3(position[index], 5, position[index1]);

            Debug.Log("X " + position[index]);
            Debug.Log("Z " + position[index1]);

            CaixaTimerComponents = Instantiate(PrefabCaixa, pos, Quaternion.identity);
            Destroy(CaixaTimerComponents.GetComponent<Rigidbody>(),5);
        }
    }
}
