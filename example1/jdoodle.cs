using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

class Program
{
  static void Main() {
    PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream("/myfiles/my.pdf", FileMode.Create, FileAccess.Write)));
    Document document = new Document(pdfDocument);
    
    String line = "Hello! Welcome to iTextPdf Git Test";
    document.Add(new Paragraph(line));
    document.Close();
  }
}
