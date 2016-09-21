using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using neftproject.Commands;
using neftproject.Models;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;

namespace neftproject.ViewModels
{
    class WellViewModel : ViewModelBase
    {
        public Well Well;
        
        public List<double> oilPressureList = new List<double>();
        public List<int> wellDepthList = new List<int>();
        public PointCollection MyPointCollection { get; set; }

        public WellViewModel (Well well)
        {
            this.Well = well;
            
        }
        



        public string wellName
        {
            get { return Well.wellName; }
            set
            {
                Well.wellName = value;
                OnPropertyChanged("wellName");
            }
        }    
        


        public int depth
        {
            get { return Well.depth; }
            set
            {
                Well.depth = value;
                OnPropertyChanged("depth");
            }
        }

        public int oilDensity
        {
            get { return Well.oilDensity; }
            set
            {
                Well.oilDensity = value;
                OnPropertyChanged("oilDensity");
            }
        }

        public int partStep
        {
            get { return Well.partStep; }
            set
            {
                Well.partStep = value;
                OnPropertyChanged("partStep");
            }
        }

        public double oilPressure
        {
            get { return Well.oilPressure; }
            set
            {
                Well.oilPressure = value;
                OnPropertyChanged("oilPressure");
            }
        }



        


        #region Commands

        #region Вычислить давления на глубинах

        private DelegateCommand getItemCommand;

        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null)
                {
                    getItemCommand = new DelegateCommand(calcAllOilPressure);
                }
                return getItemCommand;
            }
        }


        /// <summary>
        /// Рассчет давления столба на определенных глубинах с учетом количества шагов разбиения
        /// </summary>
        public void calcAllOilPressure()
        {
            
            MyPointCollection = new PointCollection();
            oilPressureList.Clear();
            wellDepthList.Clear();
            oilPressureList.Add(0);
            wellDepthList.Add(0);
            int stepdepth = 0;
            int sumStepDepth = 0;
            stepdepth = sumStepDepth = Well.depth / Well.partStep;

            while (sumStepDepth <= Well.depth + 10)
            {
                oilPressureList.Add(sumStepDepth * 10 * Well.oilDensity);
                wellDepthList.Add(sumStepDepth);
                sumStepDepth += stepdepth;
            }
            for (int i =0;i<Well.partStep+1;i++)
            {
                MyPointCollection.Add(new Point { Y = wellDepthList[i], X = oilPressureList[i] });
            }


        }

        #endregion
        
        #endregion






    }
}
