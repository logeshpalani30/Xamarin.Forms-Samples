using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace DesignTask2.Model
{
    public class TabDataCount : INotifyPropertyChanged
    {
        private int _badgeCaption;

        public int BadgeCaption
        {
            get { return _badgeCaption; }
            set
            {
                _badgeCaption = value; 
                OnPropertyChanged();
            }
        }

        private Color _badgeColor;

        public Color BadgeColor
        {
            get { return _badgeColor; }
            set
            {
                _badgeColor = value; 
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
