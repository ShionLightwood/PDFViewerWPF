using MoonPdfLib;
using MoonPdfLib.MuPdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace PDFViewer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Image myImage;
        MoonPdfPanel pdfPanel = new MoonPdfPanel();
        public MainWindow()
        {
            InitializeComponent();
            string path = @"C:\Users\Ruhl\Projekte\A17_FlightPlan.pdf";
            byte[] pdfBytes = File.ReadAllBytes(path);
            var source = new MemorySource(pdfBytes);
            moonPdfPanel.Open(source);
            var pdfsource = moonPdfPanel.CurrentSource;
            //foreach(var item in )

            //pdfPanel.Open(source);
        }
    }
}
