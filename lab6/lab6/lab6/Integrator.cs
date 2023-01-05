namespace lab6
{
    abstract public class Integrator
    {

        abstract public double Integrate(Equation eqn, double x1, double x2, int N);
        abstract override public string ToString();
    }
}