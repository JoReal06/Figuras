

using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Figuras_GEO

{
    // CLASE MADRE DE MADRE, JEFE DE JEFE
    public class Figura
    {
        protected double area;


        protected Figura(double Area)
        {
            area = Area;
        }

        public double Area
        {
            get
            {
                return area;
            }
            set { this.area = Area; }
        }

        public virtual string CalcularArea(double datos)
        {
            area = datos;
            return area.ToString("0.00");
        }
    }

    public class FiguraTri : Figura
    {
        protected double volumen;


        protected FiguraTri(double _volumen, double Area): base(Area)
        {
            volumen = _volumen;
            
        }

        public double Volumen
        {
            get { return volumen; }
            set { volumen = value; }
        }

        public virtual string CalcularVolu(double datos)
        {
            volumen = datos;
            return volumen.ToString("0.00");
        }

    }

    public class FiguraBidi : Figura
    {
        protected double perimetro;

        protected FiguraBidi(double Perimetro, double area): base(area)
        {
            perimetro = Perimetro;
        }

        public double Perimetro
        {
            get { return perimetro; }
            set { perimetro = value; }
        }

       public virtual string CalcularPerimetro(double a) {
            perimetro = a;
            return perimetro.ToString("0.00"); }
    }

    // CLASE CIRCULO
    public class Circulo : FiguraBidi
    {
        private double radio;

        public Circulo(double area, double Perimetro, double Radio) : base(area, Perimetro) {
            radio = Radio;

        }

        public string CalcularArea(double radio)
        {
            double Pi = 3.14159265359;
            radio= Pi * radio * radio;
            return base.CalcularArea(radio);
        }

        public override string CalcularPerimetro(double radio) 
        {
            double Pi = 3.14159265359;

            radio = 2 * Pi * radio;
            return base.CalcularPerimetro(radio);
        }
    }

    // CLASE CUADRADO
    public class Cuadrado : FiguraBidi
    {
        private double lado;

        public Cuadrado(double area, double Perimetro, double Lado): base (area,Perimetro)
        {
            lado = Lado;
        }

        public override string CalcularArea(double lado)
        {
            lado= lado * lado;
            return base.CalcularArea(lado);
        }

        public override string CalcularPerimetro(double lado)
        {
             lado =4 * lado;

            return base.CalcularPerimetro(lado);
        }
    }

    // CLASE TRIANGULO
    public class Triangulo : FiguraBidi
    {
        private double bases, altura;
        public Triangulo(double Area, double Perimetro , double Base , double Altura) : base(Area,Perimetro)
        {
            this.bases = Base;
            this.altura = Altura;
        }

        public string CalcularArea(double _base, double _altura)
        {
            string res = ((_base * _altura) / 2).ToString("0.00");
            return res;
        }

        public string CalcularPerimetro(double a, double b, double c)
        {

            string res = (a + b+ c).ToString("0.00");

          return res;   
        }
    }

    // CLASE ESFERA
    public class Esfera : FiguraTri
    {
        private double radio;


         public Esfera(double area, double Volumen, double Radio) : base(area, Volumen)
        {
            this.radio = Radio;
        }

        public string CalcularArea(double radio)
        {
            double Pi = 3.14159265359;
            radio = 4 * Pi * (radio * radio);
            return base.CalcularArea(radio);
        }

        public override string CalcularVolu(double radio) { 


            double Pi = 3.14159265359;
            radio = (4 / 3) * Pi * radio; 

            return base.CalcularVolu(radio);
        }
    }

    // CLASE CUBO
    public class Cubo : FiguraTri
    {
        private double lado;
        public Cubo(double area, double Volumen, double Lado) : base(area, Volumen)
        {
            this.lado =Lado;
        }

        public override string CalcularArea(double lado)
        {
            lado = 6 * (lado * lado);
            return base.CalcularArea(lado);
        }

        public override string CalcularVolu(double lado)
        {
            lado = lado* lado*lado;
            return base.CalcularVolu(lado);
        }

    }

    // CLASE TETRAEDRO
    public class Tetraedro : FiguraTri
    {
        private double areaTri;
        public Tetraedro(double Area, double Volumen, double AreaTri) : base(Area,Volumen)
        {
            this.areaTri = AreaTri;
        }

        public double AreaTri { get {return areaTri; } set { this.areaTri = AreaTri; } }

        public override string CalcularArea(double areaTri)
        {
            areaTri= 4 * areaTri;
            return base.CalcularArea(areaTri);
        }

        public string CalcularVolu(double b , double a)
        {
            double datos = (1 / 3) * b *a;
            return base.CalcularVolu(datos);
        }
    }



}