using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModernWPFListviewIssue
{
    public class ControllableLedModel : ViewModelBase
    {
        #region Private Fields
        private bool isSelected;
        private uint iD;
        private double positionX;
        private double positionY;
        private uint luminosity;
        //private ICommand toggleOnOffCommand; // not implemented in dummy project
        #endregion

        #region Public Properties
        public bool IsSelected
        {
            get { return isSelected; }
            set { SetProperty<bool>(ref isSelected, value); }
        }

        public uint ID
        {
            get { return iD; }
            set { SetProperty<uint>(ref iD, value); }
        }
        public double PositionX
        {
            get { return positionX; }
            set { SetProperty<double>(ref positionX, value); }
        }

        public double PositionY
        {
            get { return positionY; }
            set { SetProperty<double>(ref positionY, value); }
        }

        public uint Luminosity
        {
            get { return luminosity; }
            set { SetProperty<uint>(ref luminosity, value); }
        }
            #endregion

        #region Constructors
        public ControllableLedModel()
        {

        }

        public ControllableLedModel(double _positionX, double _positionY, uint _luminosity = 0)
        {
            PositionX = _positionX;
            PositionY = _positionY;
            Luminosity = _luminosity;
        }
        #endregion
    }
}
