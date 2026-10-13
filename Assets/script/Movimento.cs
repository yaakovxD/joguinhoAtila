using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade = 5f;

    public GameObject meuBarco;

    void Update()
    {
        meuBarco = GameObject.Find("barco1");
        float movimento = 0f;

        if (meuBarco)
        {
            // Barco 1: W sobe e S desce
            if (Input.GetKey(KeyCode.W))
                movimento = 1f;

            if (Input.GetKey(KeyCode.S))
                movimento = -1f;
        }
        else
        {
            // Barco 2: seta para cima e para baixo
            if (Input.GetKey(KeyCode.UpArrow))
                movimento = 1f;

            if (Input.GetKey(KeyCode.DownArrow))
                movimento = -1f;
        }

        transform.Translate(
            Vector3.up * movimento * velocidade * Time.deltaTime,
            Space.World
        );

        // Impede que o barco saia da tela
        Vector3 posicao = transform.position;
        posicao.y = Mathf.Clamp(posicao.y, -4f, 4f);
        transform.position = posicao;
    }
}



