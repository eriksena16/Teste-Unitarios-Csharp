namespace MyProject
{
    public class User
    {
        public User(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public  bool MaiorDeIdade( User user)
        {
            if (user.Idade >= 18)
                return true;
            else
                return false;
        }
    }
}