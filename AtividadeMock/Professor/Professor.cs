using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Professor
{
    public class Professor
    {
        private string nome;
        private string horario;
        private string periodo;
        private string sala;

        public Professor(string nome, string horario, string periodo, string sala)
        {
            this.nome = nome;
            this.horario = horario;
            this.periodo = periodo;
            this.sala = sala;
        }

        public string getnome() {
            return nome;
        }

        public void setnome(string nome) {
            this.nome = nome;
        }

        public string getHorarioAtendimento(){
            return horario;
        }

        public void setHorarioAtendimento(string horario) {
            this.horario = horario;
        }

        public string getPeriodo() {
            return periodo;
        }

        public void setPeriodo(string periodo) {
            this.periodo = periodo;
        }

        public string getSala() {
            return sala;
        }

        public void setSala(string sala) {
            this.sala = sala;
        }

        public string GetPredio(int sala){
            if (sala >= 1 && sala <= 5)
                return "1";
            else if (sala >= 6 && sala <= 10)
                return "2";
            else
            return "3";
        }

    }
}