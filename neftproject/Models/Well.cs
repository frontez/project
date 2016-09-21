using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace neftproject.Models
{
    class Well
    {
        
        /// <summary>
        /// Имя скважины
        /// </summary>
        public string wellName { get; set; } 

        /// <summary>
        /// Глубина скважины
        /// </summary>
        public int depth { get; set; } 

        /// <summary>
        /// Плотность нефти
        /// </summary>
        public int oilDensity { get; set; } 

        /// <summary>
        /// Количество шагов разбиения
        /// </summary>
        public int partStep { get; set; } 

        /// <summary>
        /// Давление столба нефти
        /// </summary>
        public double oilPressure 
        {
            get { return calcOilPressure(); }
            set { ;}
        }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="wellName"> Имя скважины </param>
        /// <param name="depth"> Глубина скважины </param>
        /// <param name="oilDensity"> Плотность нефти </param>
        /// <param name="partStep">Количество шагов разбиения </param>
        public Well(string wellName, int depth, int oilDensity, int partStep) 
        {
            this.wellName = wellName;
            this.depth = depth;
            this.oilDensity = oilDensity;
            this.partStep = partStep;
        }


        /// <summary>
        /// Вычислить давление столба нефти
        /// </summary>
        /// <returns></returns>
        public double calcOilPressure()  
        {
            return Convert.ToDouble(depth * oilDensity * 10);
        }


    }
}
