using ArrayCuadrados.Entidades;
using System.Reflection;

namespace ArrayCuadrados.Datos
{
    public class RepositorioDeCuadrados
    {
        private readonly string _archivo = Environment.CurrentDirectory + "\\Cuadrados.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "\\Cuadrados.bak";

        private List<Cuadrado> listaCuadrados;

        public RepositorioDeCuadrados()
        {
            listaCuadrados = new List<Cuadrado>();
            LeerDatos();
        }
        public List<Cuadrado> GetLista()
        {
            return listaCuadrados;
        }

        private void LeerDatos()
        {
            if (File.Exists(_archivo))
            {
                var lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    string lineaLeida = lector.ReadLine();
                    Cuadrado cuadrado = ConstruirCuadrado(lineaLeida);
                    listaCuadrados.Add(cuadrado);

                }
                lector.Close(); 
            }
        }
        public void Editar(Cuadrado cuadradoEnArchivo, Cuadrado cuadradoEditar)
        {
            using (var lector= new StreamReader(_archivo))
            {
                using (var escritorio=new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida=lector.ReadLine();
                        Cuadrado cuadrado = ConstruirCuadrado(lineaLeida);
                        if(cuadradoEnArchivo.GetLado() != cuadrado.GetLado())
                        {
                            escritorio.WriteLine(lineaLeida);
                        }
                        else
                        {
                            lineaLeida=ConstruirLinea(cuadradoEditar);
                            escritorio.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
        }

        private Cuadrado ConstruirCuadrado(string? lineaLeida)
        {
            var campos=lineaLeida.Split("|");
            int lado = int.Parse(campos[0]);
            Cuadrado c = new Cuadrado(lado);
            return c;
            
        }

        public void Agregar(Cuadrado cuadrado)
        {
            //using (var escritor = new StreamWriter(_archivo, true))
            //{
            //    string lineaEscribir = ConstruirLinea(cuadrado);
            //    escritor.WriteLine(lineaEscribir);
            //}

            //listaCuadrados.Add(cuadrado);

            var escritor = new StreamWriter(_archivo, true);

            string lineaEscribir = ConstruirLinea(cuadrado);
            escritor.WriteLine(lineaEscribir);
            escritor.Close();

            listaCuadrados.Add(cuadrado);
        }

        private string ConstruirLinea(Cuadrado cuadrado)
        {
            return $"{cuadrado.GetLado()}";
        }

        /// <summary>
        /// Metodo para informar la cantidad de datos del repo
        /// </summary>
        /// <returns></returns>
        public int GetCantidad(int valorFiltro=0)
        {
            if (valorFiltro>0)
            {
                return listaCuadrados.Count(c => c.GetLado() >= valorFiltro);
            }
            return listaCuadrados.Count;
        } 
        public void Borrar(Cuadrado cuadradoBorrar)
        {
            using (var lector=new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Cuadrado cuadradoLeido=ConstruirCuadrado(lineaLeida);
                        if (cuadradoBorrar.GetLado()==cuadradoLeido.GetLado())
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
            listaCuadrados.Remove(cuadradoBorrar);
        }

        public List<Cuadrado> Filtrar(int intValor)
        {
            return listaCuadrados
               .Where(c => c.GetLado() >= intValor)
               .ToList();
        }

        public List<Cuadrado> OrdenarAsc()
        {
            return listaCuadrados.OrderBy(c=> c.GetLado()).ToList();
        }

        public List<Cuadrado> OrdenarDesc()
        {
            return listaCuadrados.OrderByDescending(c => c.GetLado()).ToList();
        }

        public bool Existe(Cuadrado cuadrado)
        {
            listaCuadrados.Clear();
            LeerDatos();
            foreach (var itemCuadrado in listaCuadrados)
            {
                if (itemCuadrado.GetLado() == cuadrado.GetLado())
                {
                    return true;
                }
            }
            return false;
        }
    }
}