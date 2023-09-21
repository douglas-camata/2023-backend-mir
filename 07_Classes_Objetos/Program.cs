using Sesi.Model;

class Program
{
    public static void Main()
    {
        //criando uma variavel aluno1 e instanciando da classe Aluno
        //Criando nosso objeto
        var aluno1 = new Aluno();
        aluno1.nome = "Douglas";
        aluno1.idade = 35;
        aluno1.turma = "2º EM";

        //Chamando o método da classe Aluno
        aluno1.Apresentar();

        Aluno aluno2 = new Aluno();
        aluno2.nome = "Ricardo";
        aluno2.idade = 33;
        aluno2.turma = "3º EM";

        aluno2.Apresentar();
        aluno2.AdicionarFaltas(10);
        aluno2.Apresentar();

        //Chamar método ResumoFaltas
        aluno2.ResumoFaltas();
    }
}