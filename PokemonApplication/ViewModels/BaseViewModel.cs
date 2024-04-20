﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApplication.ViewModels
{
    public partial class BaseViewModel: ObservableObject
    {
        public BaseViewModel()
        {
            
        }

        [ObservableProperty]
        bool isBusy;


        [ObservableProperty]
        string title;

        public bool IsNotBusy => !IsBusy;





    }




}
