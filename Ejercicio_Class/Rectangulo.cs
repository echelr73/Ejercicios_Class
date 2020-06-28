using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Class
{
    class Rectangulo
    {
        #region atributos
        private double _base;
        private double _altura;
        #endregion
        #region consultas
        public double getBase()
        { return _base;   }
        public double getAltura()
        { return _altura; }
        public double Area()
        {
            return this._base * this._altura;  
        }
        public double Perimetro()
        {
            return (this._base * 2) + (this._altura*2);
        }
        #endregion
        #region comandos
        private void setBase(double valor)
        {
            if (valor > 0 && valor < 1000)
            {
                _base = valor; 
            }
        }
        private void setAltura(double valor)
        {
            if (valor > 0 && valor < 1000)
            {
                _altura = valor;
            }
        }
        #endregion
        #region constructores
        public Rectangulo(double _base, double _altura)
        {
            this._base = _base;
            this._altura = _altura;
        }
        #endregion


    }
}
