using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void BisectionMethod_f_0_1_0001()
        {
            //================================== input
            double f(double x) => 3 * Math.Pow(x, 2) - 6 * x + 1;
            double a = 0;
            double b = 2;
            double eps = 0.001;
            double x_expected = 0.18310546875;
            double f_expected = 0.0019500255584716797;

            //================================== running
            double actual_x = Program.BisectionMethod(f, a, b, eps);
            double actual_f = f(actual_x);

            //================================== assert
            Assert.Equal(x_expected, actual_x);
            Assert.Equal(f_expected, actual_f);
        }
    }
}