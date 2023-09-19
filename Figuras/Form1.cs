using Figuras_GEO;
using System.ComponentModel;

namespace Figuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Cargar tamaño al inicio del form
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_enviar.Enabled = false;

            txt_AlturaBi.Enabled = false;
            txt_BaseBI.Enabled = false;
            txt_Lado1Bi.Enabled = false;
            txt_RadioBI.Enabled = false;
            txt_lado2BI.Enabled = false;
            txt_lado3BI.Enabled = false;

            txt_ALturaTri.Enabled = false;
            txt_BaseTRi.Enabled = false;
            txt_RadioTRi.Enabled = false;
            txt_ladoTri.Enabled = false;

        }

        public void limpiar()
        {

            txt_ALturaTri.Text = "";
            txt_BaseTRi.Text = "";
            txt_RadioTRi.Text = "";
            txt_ladoTri.Text = "";

            txt_AlturaBi.Text = "";
            txt_BaseBI.Text = "";
            txt_Lado1Bi.Text = "";
            txt_RadioBI.Text = "";
        }




        public void mostrarAreaPer(string resA, string resP)
        {
            MessageBox.Show("El area es: " + resA + " y su perimetro es: " + resP);
        }

        public void mostrarAeaVol(string resA, string resv)
        {
            MessageBox.Show("El area es: " + resA + " y su volumen es: " + resv);
        }

        //Accion que puede pasar cuando se seleccione uno de los elementos de la combobox
        private void cmb_Figuras_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmb_Figuras.SelectedIndex;
            btn_enviar.Enabled = true;

            if (i == 0)
            {
                txt_AlturaBi.Enabled = false;
                txt_BaseBI.Enabled = false;
                txt_Lado1Bi.Enabled = false;
                txt_RadioBI.Enabled = true;
                txt_lado2BI.Enabled = false;
                txt_lado3BI.Enabled = false;

                txt_ALturaTri.Enabled = false;
                txt_BaseTRi.Enabled = false;
                txt_RadioTRi.Enabled = false;
                txt_ladoTri.Enabled = false;


            }
            else if (i == 1)
            {
                txt_AlturaBi.Enabled = false;
                txt_BaseBI.Enabled = false;
                txt_Lado1Bi.Enabled = true;
                txt_RadioBI.Enabled = false;
                txt_lado2BI.Enabled = false;
                txt_lado3BI.Enabled = false;

                txt_ALturaTri.Enabled = false;
                txt_BaseTRi.Enabled = false;
                txt_RadioTRi.Enabled = false;
                txt_ladoTri.Enabled = false;


            }
            else if (i == 2)
            {
                txt_AlturaBi.Enabled = true;
                txt_BaseBI.Enabled = true;
                txt_Lado1Bi.Enabled = true;
                txt_RadioBI.Enabled = false;
                txt_lado2BI.Enabled = true;
                txt_lado3BI.Enabled = true;

                txt_ALturaTri.Enabled = false;
                txt_BaseTRi.Enabled = false;
                txt_RadioTRi.Enabled = false;
                txt_ladoTri.Enabled = false;

            }
            else if (i == 3)
            {
                txt_AlturaBi.Enabled = false;
                txt_BaseBI.Enabled = false;
                txt_Lado1Bi.Enabled = false;
                txt_RadioBI.Enabled = false;
                txt_lado2BI.Enabled = false;
                txt_lado3BI.Enabled = false;

                txt_ALturaTri.Enabled = false;
                txt_BaseTRi.Enabled = false;
                txt_RadioTRi.Enabled = true;
                txt_ladoTri.Enabled = false;


            }
            else if (i == 4)
            {
                txt_AlturaBi.Enabled = false;
                txt_BaseBI.Enabled = false;
                txt_Lado1Bi.Enabled = false;
                txt_RadioBI.Enabled = false;
                txt_lado2BI.Enabled = false;
                txt_lado3BI.Enabled = false;

                txt_ALturaTri.Enabled = false;
                txt_BaseTRi.Enabled = false;
                txt_RadioTRi.Enabled = false;
                txt_ladoTri.Enabled = true;


            }
            else if (i == 5)
            {
                MessageBox.Show("Para poder sacar el area de un tetraedo, es necesario \n el area de una de las caras del triangulo");

                txt_AlturaBi.Enabled = false;
                txt_BaseBI.Enabled = false;
                txt_Lado1Bi.Enabled = false;
                txt_RadioBI.Enabled = false;
                txt_lado2BI.Enabled = false;
                txt_lado3BI.Enabled = false;

                txt_ALturaTri.Enabled = true;
                txt_BaseTRi.Enabled = true;
                txt_RadioTRi.Enabled = false;
                txt_ladoTri.Enabled = false;

            }
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            int ind = cmb_Figuras.SelectedIndex;



            if (ind == 0)
            {
                if (txt_RadioBI.Text == "")
                {
                    MessageBox.Show("Caja de texto vacia");
                    return;
                }
                double ra = double.Parse(txt_RadioBI.Text);

                Circulo cir = new Circulo(0, 0, ra);

                string area = cir.CalcularArea(ra);
                string peri = cir.CalcularPerimetro(ra);
                mostrarAreaPer(area, peri);
            }
            else if (ind == 1)
            {
                if (txt_Lado1Bi.Text == "")
                {
                    MessageBox.Show("Caja de texto vacia");
                    return;
                }
                double lado = double.Parse(txt_Lado1Bi.Text);

                Cuadrado cua = new Cuadrado(0, 0, lado);

                string area = cua.CalcularArea(lado);
                string peri = cua.CalcularPerimetro(lado);
                mostrarAreaPer(area, peri);
            }
            else if (ind == 2)
            {
                if (txt_AlturaBi.Text == "" || txt_BaseBI.Text == "" || txt_Lado1Bi.Text == "" || txt_lado2BI.Text == "" || txt_lado3BI.Text == "")
                {
                    MessageBox.Show("Caja de texto vacia");
                    return;
                }
                double bases = double.Parse(txt_BaseBI.Text);
                double altu = double.Parse(txt_AlturaBi.Text);
                double lado1 = double.Parse(txt_Lado1Bi.Text);
                double lado2 = double.Parse(txt_lado2BI.Text);
                double lado3 = double.Parse(txt_lado3BI.Text);

                Triangulo tri = new Triangulo(0, 0, bases, altu);

                string area = tri.CalcularArea(bases, altu);
                string peri = tri.CalcularPerimetro(lado1, lado2, lado3);
                mostrarAreaPer(area, peri);
            }
            else if (ind == 3)
            {
                if (txt_RadioTRi.Text == "")
                {
                    MessageBox.Show("Caja de texto vacia");
                    return;
                }
                double ra = double.Parse(txt_RadioTRi.Text);

                Esfera es = new Esfera(0, 0, ra);

                string area = es.CalcularArea(ra);
                string vol = es.CalcularVolu(ra);
                mostrarAeaVol(area, vol);

            }
            else if (ind == 4)
            {
                if (txt_ladoTri.Text == "")
                {
                    MessageBox.Show("Caja de texto vacia");
                    return;
                }
                double la = double.Parse(txt_ladoTri.Text);

                Cubo cu = new Cubo(0, 0, la);

                string area = cu.CalcularArea(la);
                string vol = cu.CalcularVolu(la);
                mostrarAeaVol(area, vol);

            }
            else if (ind == 5)
            {
                if (txt_BaseTRi.Text == "" || txt_ALturaTri.Text == "")
                {
                    MessageBox.Show("Caja de texto vacia");
                    return;
                }

                double bases = double.Parse(txt_BaseTRi.Text);
                double altu = double.Parse(txt_ALturaTri.Text);
                double area1 = (bases * altu) / 2;

                Tetraedro te = new Tetraedro(0, 0, area1);

                string area = te.CalcularArea(area1);
                string vol = te.CalcularVolu(bases, altu);
                mostrarAeaVol(area, vol);
            }
            limpiar();
        }

        private void txt_RadioBI_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;

            if (!(char.IsDigit(a) || a == '.' || a == ',' || a == '\b'))
            {
                e.Handled = true;
            }
        }
    }
}