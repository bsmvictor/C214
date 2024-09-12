using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Professor;

namespace ProfessorTestes
{
    public class TestesProfessor : IProfessor
    {
        private List<Professor.Professor> professores;

        public TestesProfessor()
        {
            professores =
            [
                JsonConvert.DeserializeObject<Professor.Professor>(ProfMock.prof1),
                JsonConvert.DeserializeObject<Professor.Professor>(ProfMock.prof2),
                JsonConvert.DeserializeObject<Professor.Professor>(ProfMock.prof3),
                JsonConvert.DeserializeObject<Professor.Professor>(ProfMock.prof4),
                JsonConvert.DeserializeObject<Professor.Professor>(ProfMock.prof5)
            ];
        }

        public Professor.Professor Busca(string nomeProfessor)
        {
            foreach (Professor.Professor p in professores)
            {
                if (p.getnome().Equals(nomeProfessor, StringComparison.OrdinalIgnoreCase))
                {
                    return p;
                }
            }
            return null;
        }
    }
}