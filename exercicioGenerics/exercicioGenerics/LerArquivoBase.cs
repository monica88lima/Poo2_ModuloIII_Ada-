using OfficeOpenXml;

namespace exercicioGenerics
{
    public class LerArquivoBase
    {
        public static List<Dicionario> ReadXls()
        {
            var response = new List<Dicionario>();

            FileInfo existingFile = new FileInfo(fileName: "C:\\Users\\rishi\\source\\repos\\Poo2_ModuloIII_Ada-\\exercicioGenerics dicionario.xlsx");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[PositionID: 0];
                int rowCount = worksheet.Dimension.End.Row;

                for (int row = 2; row < rowCount; row++)
                {
                    var dic = new Dicionario();
                    dic.Referencia = worksheet.Cells[row, Col: 1].Value.ToString();
                    dic.Definicao = worksheet.Cells[row, Col: 2].Value.ToString();

                    response.Add(dic);
                }
            }
            return response;

        }
    }
}