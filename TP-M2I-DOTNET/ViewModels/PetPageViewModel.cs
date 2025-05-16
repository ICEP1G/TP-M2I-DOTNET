using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_M2I_DOTNET.DTOs;

namespace TP_M2I_DOTNET.ViewModels
{
    [QueryProperty(nameof(PetId), "PetId")]
    public class PetPageViewModel : INotifyPropertyChanged
    {
        #region NotifyChanges declaration
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Variables declaration
        private long petId;
        #endregion

        public PetPageViewModel()
        {
            
        }


        public long PetId
        {
            get { return petId; }
            set { petId = value; }
        }


    }
}
