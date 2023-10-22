using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Halk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Nums _nums;
        public MainWindow()
        {
            InitializeComponent();
            _nums=new Nums();
            this.DataContext = _nums;
        }
    }

    class Nums : INotifyPropertyChanged
    {
        private float a = 0;
        private float b = 0;
        private float res = 0;
        public float A { get { return a; } set { a = value; onPropertyChanged("Resur"); } }
        public float B { get { return b; } set { b = value; onPropertyChanged("Resur"); } }
        public float Resur { get { return a+b; } set { res = value; } }

        public event PropertyChangedEventHandler? PropertyChanged;
        void onPropertyChanged(params string[] propertyNames)
        {
            PropertyChangedEventHandler? handler = PropertyChanged;
            if (handler != null)
            {
                foreach (var pn in propertyNames)
                {
                    handler(this, new PropertyChangedEventArgs(pn));
                }
            }
        }

    }
}
