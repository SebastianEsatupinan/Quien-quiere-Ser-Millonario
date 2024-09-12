using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.IO;
using Models;
public class ControllerJuego : MonoBehaviour
{
    public TMP_Text textoPreguntaM;
    public TMP_Text textoOp1;
    public TMP_Text textoOp2;
    public TMP_Text textoOp3;
    public TMP_Text textoOp4;

    public GameObject panelRespuestaCorrecta;
    public GameObject panelRespuestaIncorrecta;
    public GameObject panelNoPM;
    public GameObject bSP;
    int indice = 0;
    string preguintaLeida;
    public PreguntasMultiples objPM;
    List<PreguntasMultiples> listaPreguntasM = new List<PreguntasMultiples>();
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            StreamReader sr1 = new StreamReader("Assets/Resources/PreguntasRespuestas.txt");
            while ((preguintaLeida = sr1.ReadLine()) != null)
            {

                string[] partirPregunta = preguintaLeida.Split("-");
                listaPreguntasM.Add(new PreguntasMultiples(partirPregunta[0], partirPregunta[1],
                    partirPregunta[2], partirPregunta[3], partirPregunta[4], partirPregunta[5],
                    partirPregunta[6], false));
                //preguntas[i] = preguintaLeida;
                //Debug.Log(preguintaLeida);
            }
            Debug.Log("Cantidad de preguntas leidas " + listaPreguntasM.Count);
        }
        catch (Exception e)
        {
            Debug.LogError("ERRORRRR " + e.ToString());
        }
    }

    public void MostrarPregunta()
    {
        bSP.SetActive(false);
        if (indice <= listaPreguntasM.Count - 1)
        {
            objPM = listaPreguntasM[indice];
            indice++;
            textoPreguntaM.text = objPM.Pregunta;
            textoOp1.text = objPM.Opc1;
            textoOp2.text = objPM.Opc2;
            textoOp3.text = objPM.Opc3;
            textoOp4.text = objPM.Opc4;
        }
        else
        {
            panelNoPM.SetActive(true);


        }
    }

    public void Opcion1()
    {
        string respuestaCorrecta = objPM.OpcCorrecta;
        if (respuestaCorrecta.Equals(textoOp1.text))
        {
            panelRespuestaCorrecta.SetActive(true);
            bSP.SetActive(true);
        }
        else
        {
            panelRespuestaIncorrecta.SetActive(true);
        }

    }
    public void Opcion2()
    {
        string respuestaCorrecta = objPM.OpcCorrecta;
        if (respuestaCorrecta.Equals(textoOp2.text))
        {
            panelRespuestaCorrecta.SetActive(true);
            bSP.SetActive(true);

        }
        else
        {
            panelRespuestaIncorrecta.SetActive(true);
        }

    }
    public void Opcion3()
    {
        string respuestaCorrecta = objPM.OpcCorrecta;
        if (respuestaCorrecta.Equals(textoOp3.text))
        {
            panelRespuestaCorrecta.SetActive(true);
            bSP.SetActive(true);
        }
        else
        {
            panelRespuestaIncorrecta.SetActive(true);
        }

    }
    public void Opcion4()
    {
        string respuestaCorrecta = objPM.OpcCorrecta;
        if (respuestaCorrecta.Equals(textoOp4.text))
        {
            panelRespuestaCorrecta.SetActive(true);
            bSP.SetActive(true);
        }
        else
        {
            panelRespuestaIncorrecta.SetActive(true);
        }

    }
    // Update is called once per frame
    void Update()
    {

    }



}
