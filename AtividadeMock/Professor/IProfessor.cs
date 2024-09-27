using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Professor
{
    public interface IProfessor
    {
        Professor Busca(String nome);
    }
}