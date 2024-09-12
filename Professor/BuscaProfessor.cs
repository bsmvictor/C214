namespace Professor;

public class BuscaProfessor
{
    private IProfessor iProfessor;
    public BuscaProfessor(IProfessor iProfessor) {
        this.iProfessor = iProfessor;
    }

    public Professor buscaProfessor(String nomeProfessor) {
        return iProfessor.Busca(nomeProfessor);
    }
}
