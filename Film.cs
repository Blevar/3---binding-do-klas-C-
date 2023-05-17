using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3___binding_do_klas_C_
{
    public enum Nosnik
    {
        VHS,
        DVD,
        BluRay
    }

    public class Film : INotifyPropertyChanged
    {
        private string tytul;
        private string rezyser;
        private string studio;        
        private Nosnik nosnikFilmu;
        private DateTime? dataWydania;        

        public string Tytul { 
            get => tytul;
            set
            {
                tytul = value;
                NotifyValueChange();
            }
        }
        public string Rezyser
        {
            get => rezyser;
            set
            {
                rezyser = value;
                NotifyValueChange();
            }
        }
        public string Studio
        {
            get => studio;
            set
            {
                studio = value;
                NotifyValueChange();
            }
        }
        
        public Nosnik Nosnik
        {
            get => nosnikFilmu;
            set
            {
                nosnikFilmu = value;
                NotifyValueChange();
            }
        }
        public DateTime? DataWydania
        {
            get => dataWydania;
            set
            {
                dataWydania = value;
                NotifyValueChange();
            }
        }

        private void NotifyValueChange([CallerMemberName] string valueName = "", HashSet<string> isDone = null)
        {
            if (isDone == null)
                isDone = new();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(valueName));

            isDone.Add(valueName);

            if (connectedValues.ContainsKey(valueName))
                foreach (string connectedValue in connectedValues[valueName])
                    if (isDone.Contains(connectedValue))
                        continue;
                    else
                        NotifyValueChange(connectedValue, isDone);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private static IDictionary<string, ICollection<string>>
        connectedValues = new Dictionary<string, ICollection<string>>()
        {
            ["Tytul"] = new string[] { "Info" },
            ["Rezyser"] = new string[] { "Info" },
            ["Studio"] = new string[] { "Info" },
            ["Nosnik"] = new string[] { "Info" },
            ["DataWydania"] = new string[] { "Info" }
        };


    }
}
