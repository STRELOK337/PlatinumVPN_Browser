using PlatinumVPN.ViewModels;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumVPN.Utilities
{
    public class MenuItem : ViewModelBase
    {
        //int _rotate;
        public int Id {  get; set; }
        public string Name { get; set; } = "";
        public string IconName { get; set; } = "";

        //public int Rotate { get => _rotate; set => this.RaiseAndSetIfChanged(ref _rotate, value); }
    }
}
