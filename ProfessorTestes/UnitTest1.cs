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
    public void testeBuscaProfessor1() {

        //Fiz a busca
        Professor.Professor professor1 = _buscaProfessor.buscaProfessor("Marcelo");
        Assert.NotNull(professor1);
    }

    [Fact]
     public void testeBuscaProfessor2() {

        //Fiz a busca
        Professor.Professor professor1 = _buscaProfessor.buscaProfessor("Chris");
        Assert.NotNull(professor1);
    }

    [Fact]
     public void testeBuscaProfessor3() {

        //Fiz a busca
        Professor.Professor professor1 = _buscaProfessor.buscaProfessor("Renzo");
        Assert.NotNull(professor1);
    }

    [Fact]
    public void testeBuscaProfessor4() {

        //Fiz a busca
        Professor.Professor professor4 = _buscaProfessor.buscaProfessor("Yvo");
        Assert.NotNull(professor4);
    }

    [Fact]
    public void testeBuscaProfessor5() {

        //Fiz a busca
        Professor.Professor professor5 = _buscaProfessor.buscaProfessor("Soned");
        Assert.NotNull(professor5);
    }

    [Fact]
    public void testeSala2NoPredio1() {

        Professor.Professor professor = _buscaProfessor.buscaProfessor("Marcelo");
        String predio = professor.GetPredio(int.Parse(professor.getSala()));
        Assert.Equal("1", predio);
    }

    [Fact]
    public void testeSala9NoPredio2() {

        Professor.Professor professor = _buscaProfessor.buscaProfessor("Chris");
        String predio = professor.GetPredio(int.Parse(professor.getSala()));
        Assert.Equal("2", predio);
    }

    [Fact]
    public void testeSala7NoPredio2() {

        Professor.Professor professor = _buscaProfessor.buscaProfessor("Renzo");
        String predio = professor.GetPredio(int.Parse(professor.getSala()));
        Assert.Equal("2", predio);
    }

    [Fact]
    public void testeSala14NoPredio3() {

        Professor.Professor professor = _buscaProfessor.buscaProfessor("Yvo");
        String predio = professor.GetPredio(int.Parse(professor.getSala()));
        Assert.Equal("3", predio);
    }

    [Fact]
    public void testeSala28NoPredio6() {

        Professor.Professor professor = _buscaProfessor.buscaProfessor("Soned");
        String predio = professor.GetPredio(int.Parse(professor.getSala()));
        Assert.Equal("6", predio);
    }

    [Fact]
    public void testeErroProfessor7() {

        //Fiz a busca
        Professor.Professor professor7 = _buscaProfessor.buscaProfessor("Pepe Passos");
        Assert.Null(professor7);
    }

    [Fact]
    public void testeErroProfessor10() {

        //Fiz a busca
        Professor.Professor professor10 = _buscaProfessor.buscaProfessor("Macimel");
        Assert.Null(professor10);
    }

    [Fact]
    public void testeErroProfessor12() {

        //Fiz a busca
        Professor.Professor professor12 = _buscaProfessor.buscaProfessor("Gabriel Alves");
        Assert.Null(professor12);
    }

    [Fact]
    public void testeErroProfessor15() {

        //Fiz a busca
        Professor.Professor professor12 = _buscaProfessor.buscaProfessor("Marcciello HOPV");
        Assert.Null(professor12);
    }

    [Fact]
    public void testeErroProfessor50() {

        //Fiz a busca
        Professor.Professor professor50 = _buscaProfessor.buscaProfessor("Dju Mota Djunior");
        Assert.Null(professor50);
    }


    [Fact]
    public void testeSala27NoPredio1() {

        Professor.Professor professor = _buscaProfessor.buscaProfessor("Soned");
        String predio = professor.GetPredio(int.Parse(professor.getSala()));
        Assert.NotEqual("1", predio);
    }

    [Fact]
    public void testeSala14NoPredio6() {

        Professor.Professor professor = _buscaProfessor.buscaProfessor("Yvo");
        String predio = professor.GetPredio(int.Parse(professor.getSala()));
        Assert.NotEqual("6", predio);
    }

    [Fact]
    public void testeSala7NoPredio4() {

        Professor.Professor professor = _buscaProfessor.buscaProfessor("Renzo");
        String predio = professor.GetPredio(int.Parse(professor.getSala()));
        Assert.NotEqual("4", predio);
    }

    [Fact]
    public void testeSala9NoPredio4() {

        Professor.Professor professor = _buscaProfessor.buscaProfessor("Chris");
        String predio = professor.GetPredio(int.Parse(professor.getSala()));
        Assert.NotEqual("4", predio);
    }

    [Fact]
    public void testeSala2NoPredio3() {

        Professor.Professor professor = _buscaProfessor.buscaProfessor("Marcelo");
        String predio = professor.GetPredio(int.Parse(professor.getSala()));
        Assert.NotEqual("3", predio);
    }

    }
}
