using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Xps.Packaging;
using System.IO;
using System.Windows.Xps;
using System;


namespace HospitalDB
{
    
    public partial class PrintProtocol : Window
    {

        public Patient Patient { get; private set; }

        public PrintProtocol(Patient p)
        {
            InitializeComponent();

            Patient = p;

            this.DataContext = Patient;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (PageNum.SelectedIndex != 0)
            {

                Grid grid = new Grid();
                PrintDialog pDialog = new PrintDialog();




                switch (PageNum.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        grid = print1;
                        break;
                    case 2:
                        grid = print2;
                        break;

                }


                Nullable<Boolean> print = pDialog.ShowDialog();
                if (print == true)
                {
                    if (File.Exists("printPreview.xps"))
                    {
                        File.Delete("printPreview.xps");
                    }

                    XpsDocument xpsDocument = new XpsDocument("printPreview.xps", FileAccess.ReadWrite);
                    XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(xpsDocument);
                    // имя Gridа x:Name="printA"

                    writer.Write(grid);
                    FixedDocumentSequence fixedDocSeq = xpsDocument.GetFixedDocumentSequence();
                    xpsDocument.Close();
                    pDialog.PrintDocument(fixedDocSeq.DocumentPaginator, "Test print");

                }

            }


        }

    }

    
}
