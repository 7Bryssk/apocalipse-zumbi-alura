﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo : MonoBehaviour
{
    public GameObject Jogador;
    public float Velocidade = 7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Vector3 direcao = Jogador.transform.position - transform.position;

        float distancia = Vector3.Distance(transform.position, Jogador.transform.position);

        if(distancia > 2.5)
        {
            GetComponent<Rigidbody>().MovePosition
            (GetComponent<Rigidbody>().position +
            (direcao.normalized * Velocidade * Time.deltaTime));

            Quaternion novaRotacao = Quaternion.LookRotation(direcao);
            GetComponent<Rigidbody>().MoveRotation(novaRotacao);
        }
    }
}
