using Professor;

namespace ProfessorTestes
{
    public class UnitTest1
    {
        private IProfessor _service;
        private BuscaProfessor _buscaProfessor;

        [SetUp]
        public void Setup()
        {
            _service = new Professor.Professor();
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
