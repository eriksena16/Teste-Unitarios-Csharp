using MyProject;
using System;
using Xunit;

namespace MyProjectXunit
{
    public class UnitTest1
    {
        [Fact]
        public void UsuarioMaiorDeIdade()
        {
            var user = new User("Erik", 27);

            bool expected = true;

            var result = user.MaiorDeIdade(user);

            Assert.Equal(expected, result);


        }
        [Fact]
        public void UsuarioMenorDeIdade()
        {
            var user = new User("Eduardo", 1);

            bool expected = false;

            var result = user.MaiorDeIdade(user);

            Assert.Equal(expected, result);


        }
    }
}
