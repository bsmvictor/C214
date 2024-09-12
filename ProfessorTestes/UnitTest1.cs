using Professor;
using Xunit;

namespace ProfessorTestes
{
    public class UnitTest1
    {
        private IProfessor _service;
        private BuscaProfessor _buscaProfessor;

        public UnitTest1()
        {
            _service = new TestesProfessor();
            _buscaProfessor = new BuscaProfessor(_service);
        }

        [Fact]
        public void Test1()
        {
            Professor.Professor professor1 = _buscaProfessor.buscaProfessor("Marcelo");
            Assert.NotNull(professor1);
        }
    }
}
