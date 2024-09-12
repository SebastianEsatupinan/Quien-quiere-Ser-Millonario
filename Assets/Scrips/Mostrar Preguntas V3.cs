
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.IO;
using Models;
using static UnityEngine.Rendering.DebugUI;

public class MostrarPreguntasV3 : MonoBehaviour
{
    public TMP_Text preguntaText;
    public TMP_Text textbotonA;
    public TMP_Text textbotonB;
    public TMP_Text textbotonC;
    public TMP_Text textbotonD;
    public GameObject panelPositivo;
    public GameObject panelNegativo;
    public GameObject panelNMP;


    public TMP_Text Versiculo;

    public GameObject botonSiguiente;
    public GameObject botonRepetir;

    // public int indice = 0;

    // Crea una lista con las Preguntas
    string preguntaLeida;
    List<PreguntasMultiples> listaPreguntasM = new List<PreguntasMultiples>();

    private List<int> preguntasMostradas = new List<int>();
    private System.Random randomGenerator = new System.Random();


    private PreguntasMultiples objMP;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            StreamReader sr1 = new StreamReader("Assets/Resources/PreguntasRespuestas.txt");
            while ((preguntaLeida = sr1.ReadLine()) != null)
            {
                // Separa Cada parte del archivo de texto por guiones(-)
                string[] partirPregunta = preguntaLeida.Split("-");
                listaPreguntasM.Add(new PreguntasMultiples(
                    partirPregunta[0],
                    partirPregunta[1],
                    partirPregunta[2],
                    partirPregunta[3],
                    partirPregunta[4],
                    partirPregunta[5],
                    partirPregunta[6],
                    false));
            }
            Debug.Log("Cantidad de Preguntas leidas " + listaPreguntasM.Count);
        }
        catch (Exception e)
        {
            Debug.Log("Error" + e.ToString());
        }

        MostrarPregunta();

    }

    public void MostrarPregunta()
    {
        if (preguntasMostradas.Count == listaPreguntasM.Count)
        {
            // Todas las preguntas se han mostrado, puedes hacer algo aquí
            return;
        }

        int indiceAleatorio;
        do
        {
            indiceAleatorio = randomGenerator.Next(0, listaPreguntasM.Count);
        }
        while (preguntasMostradas.Contains(indiceAleatorio));

        preguntasMostradas.Add(indiceAleatorio);
        objMP = listaPreguntasM[indiceAleatorio];

        preguntaText.text = objMP.Pregunta;
        textbotonA.text = objMP.Opc1;
        textbotonB.text = objMP.Opc2;
        textbotonC.text = objMP.Opc3;
        textbotonD.text = objMP.Opc4;
    }

    public void Opcion1()
    {
        string respuestaCorrecta = objMP.OpcCorrecta;
        if (respuestaCorrecta.Equals(textbotonA.text))
        {
            panelPositivo.SetActive(true);
        }
        else
        {
            panelNegativo.SetActive(true);
        }
    }

    public void Opcion2()
    {
        string respuestaCorrecta = objMP.OpcCorrecta;
        if (respuestaCorrecta.Equals(textbotonB.text))
        {
            panelPositivo.SetActive(true);
        }
        else
        {
            panelNegativo.SetActive(true);
        }
    }

    public void Opcion3()
    {
        string respuestaCorrecta = objMP.OpcCorrecta;
        if (respuestaCorrecta.Equals(textbotonC.text))
        {
            panelPositivo.SetActive(true);
        }
        else
        {
            panelNegativo.SetActive(true);
        }
    }

    public void Opcion4()
    {
        string respuestaCorrecta = objMP.OpcCorrecta;
        if (respuestaCorrecta.Equals(textbotonD.text))
        {
            panelPositivo.SetActive(true);
        }
        else
        {
            panelNegativo.SetActive(true);
        }
    }

    public void DesaparecerPanel()
    {
        panelNegativo.SetActive(false);
        panelPositivo.SetActive(false);
        panelNMP.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {

    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object other)
    {
        return base.Equals(other);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
