using Professor;

namespace ProfessorTestes;

public class UnitTest1
{
     [SetUp]
    public void Setup()
    {
        _service = new ProfessorService();
    }
    IProfessor service;
    BuscaProfessor buscaProfessor;
    [Fact]
    public void Test1()
    {
        Professor professor1 = buscaProfessor.buscaProfessor("Marcelo");
        Assert.DoesNotMatch(professor1);
    }
}