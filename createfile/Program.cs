using OfficeOpenXml;
using System.Text;

class Program
{
    static void Main()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        var file = new FileInfo(@"C:\Users\T630\Desktop\Maryam\Book1.xlsx");

        using (var package = new ExcelPackage(file))
        {
            var ws = package.Workbook.Worksheets[1];

            for (int r = 1; r <= ws.Dimension.End.Row; r++)
            {
                for (int c = 1; c <= ws.Dimension.End.Column; c++)
                {
                    Console.Write(ws.Cells[r, c].Text + " ");
                }
                Console.WriteLine();
            }
        }
    }
}