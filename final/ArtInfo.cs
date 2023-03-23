using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace final
{
     class ArtInfo
    {
        string _name;
        string _date;
        string Artist;
        string _ArtStyle;

        public ArtInfo(string name, string date, string artist, string artStyle)
        {
            _name = name;
            _date = date;
            Artist = artist;
            _ArtStyle = artStyle;
        }

        public string Name { get => _name; set => _name = value; }
        public string Date { get => _date; set => _date = value; }
        public string Artist0 { get => Artist; set => Artist = value; }
        public string ArtStyle { get => _ArtStyle; set => _ArtStyle = value; }
       
    }
  
}
