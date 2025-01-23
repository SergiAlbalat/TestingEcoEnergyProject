using EcoEnergyProject;
namespace TestingEcoEnergyProject
{
    public class TestCrearSimulacio
    {
        [Fact]
        public void Test1()
        {
            int tipus = 1;
            double argument = 20;
            SistemaEnergia  resultat = MyMethods.CrearSimulacio(tipus, argument);
            Assert.Equal("Solar", resultat.GetTipus());
        }
        [Fact]
        public void Test2()
        {
            int tipus = 2;
            double argument = 20;
            SistemaEnergia resultat = MyMethods.CrearSimulacio(tipus, argument);
            Assert.Equal("Eolic", resultat.GetTipus());
        }
        [Fact]
        public void Test3()
        {
            int tipus = 3;
            double argument = 20;
            SistemaEnergia resultat = MyMethods.CrearSimulacio(tipus, argument);
            Assert.Equal("Hidro", resultat.GetTipus());
        }
        [Fact]
        public void Test4()
        {
            int tipus = 4;
            double argument = 20;
            Assert.Throws<ArgumentOutOfRangeException>(() => MyMethods.CrearSimulacio(tipus, argument));
        }
        [Fact]
        public void Test5()
        {
            int tipus = 0;
            double argument = 20;
            Assert.Throws<ArgumentOutOfRangeException>(() => MyMethods.CrearSimulacio(tipus, argument));
        }
    }
    public class TestNumDinsRang
    {
        [Fact]
        public void Test1()
        {
            int num = 3;
            int min = 1;
            int max = 5;
            bool result = MyMethods.NumDinsRang(num, min, max);
            Assert.True(result);
        }
        [Fact]
        public void Test2()
        {
            int num = 1;
            int min = 1;
            int max = 5;
            bool result = MyMethods.NumDinsRang(num, min, max);
            Assert.True(result);
        }
        [Fact]
        public void Test3()
        {
            int num = 5;
            int min = 1;
            int max = 5;
            bool result = MyMethods.NumDinsRang(num, min, max);
            Assert.True(result);
        }
        [Fact]
        public void Test4()
        {
            int num = 6;
            int min = 1;
            int max = 5;
            bool result = MyMethods.NumDinsRang(num, min, max);
            Assert.False(result);
        }
        [Fact]
        public void Test5()
        {
            int num = 0;
            int min = 1;
            int max = 5;
            bool result = MyMethods.NumDinsRang(num, min, max);
            Assert.False(result);
        }
    }
    public class TestComprovar
    {
        [Fact]
        public void Test1()
        {
            SistemaSolar solar = new SistemaSolar();
            double parametre = 1.1d;
            Assert.True(solar.ComprovarParametre(parametre));
        }
        [Fact]
        public void Test2()
        {
            SistemaSolar solar = new SistemaSolar();
            double parametre = 1d;
            Assert.False(solar.ComprovarParametre(parametre));
        }
        [Fact]
        public void Test3()
        {
            SistemaEolic eolic = new SistemaEolic();
            double parametre = 5.1d;
            Assert.True(eolic.ComprovarParametre(parametre));
        }
        [Fact]
        public void Test4()
        {
            SistemaEolic eolic = new SistemaEolic();
            double parametre = 5d;
            Assert.False(eolic.ComprovarParametre(parametre));
        }
        [Fact]
        public void Test5()
        {
            SistemaHidroelectric hidro = new SistemaHidroelectric();
            double parametre = 20d;
            Assert.True(hidro.ComprovarParametre(parametre));
        }
        [Fact]
        public void Test6()
        {
            SistemaHidroelectric hidro = new SistemaHidroelectric();
            double parametre = 19.9d;
            Assert.False(hidro.ComprovarParametre(parametre));
        }
    }
    public class TestCalcularEnergia
    {
        [Fact]
        public void Test1()
        {
            SistemaSolar simulacio = new SistemaSolar(20);
            Assert.Equal(30, simulacio.CalcularEnergia());
        }
        [Fact]
        public void Test2()
        {
            SistemaEolic simulacio = new SistemaEolic(20);
            Assert.Equal(1600, simulacio.CalcularEnergia());
        }
        [Fact]
        public void Test3()
        {
            SistemaHidroelectric simulacio = new SistemaHidroelectric(20);
            Assert.Equal(156.8, simulacio.CalcularEnergia());
        }
    }
}