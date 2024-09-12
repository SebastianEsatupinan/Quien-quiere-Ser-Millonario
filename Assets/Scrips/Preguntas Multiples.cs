using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models
{
    [Serializable]
    public class PreguntasMultiples
    {
        private string pregunta;
        private string opc1;
        private string opc2;
        private string opc3;
        private string opc4;
        private string opcCorrecta;
        private string versiculo;
        private bool estado;
        public PreguntasMultiples()
        {
        }
        public PreguntasMultiples(string pregunta, string opc1, string opc2, string opc3, string opc4, string opcCorrecta, string versiculo, bool estado)
        {
            this.pregunta = pregunta;
            this.opc1 = opc1;
            this.opc2 = opc2;
            this.opc3 = opc3;
            this.opc4 = opc4;
            this.opcCorrecta = opcCorrecta;
            this.versiculo = versiculo;
            this.estado = estado;
        }

        public string Pregunta
        {
            get
            {
                return pregunta;
            }
            set
            {
                pregunta = value;
            }
        }

        public string Opc1
        {
            get
            {
                return opc1;
            }
            set
            {
                opc1 = value;
            }
        }
        public string Opc2
        {
            get
            {
                return opc2;
            }
            set
            {
                opc2 = value;
            }
        }

        public string Opc3
        {
            get
            {
                return opc3;
            }
            set
            {
                opc3 = value;
            }
        }
        public string Opc4
        {
            get
            {
                return opc4;
            }
            set
            {
                opc4 = value;
            }
        }
        public string OpcCorrecta
        {
            get
            {
                return opcCorrecta;
            }
            set
            {
                opcCorrecta = value;
            }
        }
        public string Versiculo
        {
            get
            {
                return versiculo;
            }
            set
            {
                versiculo = value;
            }
        }
        public bool Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }


    }
}
