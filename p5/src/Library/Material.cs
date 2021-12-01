using System;

namespace Ucu.Poo.Defense
{
    public class Material
    {
        public string Name { get; set; }

        public MaterialType Type { get; set; }

        public Material(string name, MaterialType type)
        {
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Determina cuándo este material es igual a otro que se recibe como parámetro.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns><c>True</c> si este objeto es igual al que se recibe como parámetro; <c>False</c> en caso
        /// contrario.</returns>
        public bool Equals(object obj)
        {
            // Si el otro objeto es null no puede ser igual a este objeto que no es null; retornar False
            if (obj == null)
            {
                return false;
            }

            bool result;
            try
            {
                Material typedObj = (Material)obj;
                result = this.Type.Equals(typedObj.Type) &&
                    this.Name.Equals(typedObj.Name);
            }
            catch(InvalidCastException)
            {
                result = false;
            }

            return result;
        }
    }
}