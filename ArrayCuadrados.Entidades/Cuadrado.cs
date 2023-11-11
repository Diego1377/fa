namespace ArrayCuadrados.Entidades
{
    public class Cuadrado:ICloneable
    {
        private const int _CantidadLados = 4;
        private int _medidaLado;
        private TipoDeBorde tipoDeBorde;

        public TipoDeBorde TipoDeBorde
        {
            get { return tipoDeBorde; }
            set { tipoDeBorde = value; }
        }

        private ColorRelleno colorRelleno;

        public ColorRelleno ColorRelleno
        {
            get { return colorRelleno; }
            set { colorRelleno = value; }
        }


        public Cuadrado()
        {

        }
        public Cuadrado(int MedidaLado){

            _medidaLado = MedidaLado;
            //if (MedidaLado>0)
            //{


            //}
            //else
            //{
            //    throw new ArgumentException("Medida del lado no valida");
            //}
        }
        public bool Validar()
        {
            return _medidaLado > 0;
        }
        public int GetLado() => _medidaLado;
        public void SetLado(int medida)
        {
            if (medida > 0) 
            {
                _medidaLado = medida;
            }
            
        }

        public double GetPerimetro() => _CantidadLados * _medidaLado;
        public double GetSuperficie() =>Math.Pow(_medidaLado,2);

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}