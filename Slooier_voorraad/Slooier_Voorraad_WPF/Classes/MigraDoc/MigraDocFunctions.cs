using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.Rendering;
using System.Diagnostics;


// Website: http://www.pdfsharp.net/wiki/HelloMigraDoc-sample.ashx


namespace Slooier_voorraad.Classes.MigraDoc
{
	class MigraDocFunctions
	{
		public static void MigraDocBeginning()
		{
			// Create a MigraDoc document
			Document document = CreateDocument();

			PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
			renderer.Document = document;

			renderer.RenderDocument();

			// save the document
			string filename = "Slooijer_BestelFormulier.pdf";
			renderer.PdfDocument.Save(filename);
			Process.Start(filename);
		}

		public static Document CreateDocument()
		{
			Document document = new Document();
			document.Info.Title = "Hello, MigraDoc";
			document.Info.Subject = "Demonstrates an excerpt of the capabilities of MigraDoc.";
			document.Info.Author = "Menno Bordes";
			DefineStyles(document);

			DefineCover(document);

			return document;
		}

		public static void DefineStyles(Document document)
		{
			// Get the predefined style Normal
			Style style = document.Styles["Normal"];
			style.Font.Name = "Times New Roman";

			style = document.Styles["Heading1"];

			style.Font.Name = "Tahoma";
			style.Font.Size = 14;
			style.Font.Bold = true;
			style.Font.Color = Colors.DarkBlue;
			style.ParagraphFormat.PageBreakBefore = true;
			style.ParagraphFormat.SpaceAfter = 6;

			style = document.Styles["Heading2"];
			style.Font.Size = 12;
			style.Font.Bold = true;
			style.ParagraphFormat.PageBreakBefore = false;
			style.ParagraphFormat.SpaceBefore = 6;
			style.ParagraphFormat.SpaceAfter = 6;

			style = document.Styles["Heading3"];
			style.Font.Size = 10;
			style.Font.Bold = true;
			style.Font.Italic = true;
			style.ParagraphFormat.SpaceBefore = 6;
			style.ParagraphFormat.SpaceAfter = 3;

			style = document.Styles[StyleNames.Header];
			style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

			style = document.Styles[StyleNames.Footer];
			style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

			// Create a new style called TextBox based on style Normal
			style = document.Styles.AddStyle("TextBox", "Normal");
			style.ParagraphFormat.Alignment = ParagraphAlignment.Justify;
			style.ParagraphFormat.Borders.Width = 2.5;
			style.ParagraphFormat.Borders.Distance = "3pt";
			style.ParagraphFormat.Shading.Color = Colors.SkyBlue;

			// Create a new style called TOC based on style Normal
			style = document.Styles.AddStyle("TOC", "Normal");
			style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right, TabLeader.Dots);
			style.ParagraphFormat.Font.Color = Colors.Blue;

		}

		public static void DefineCover(Document document)
		{
			Section section = document.AddSection();

			Paragraph paragraph = section.AddParagraph();
			paragraph.Format.SpaceAfter = "3cm";

			Image image = section.AddImage("../../Images/slooijer.jpg");
			image.Width = "10cm";

			paragraph = section.AddParagraph("A sample document that demonstrates the\ncapabilities of MigraDoc");
			paragraph.Format.Font.Size = 16;
			paragraph.Format.Font.Color = Colors.DarkRed;
			paragraph.Format.SpaceBefore = "8cm";
			paragraph.Format.SpaceAfter = "3cm";

			paragraph = section.AddParagraph("Rendering date: ");
			paragraph.AddDateField();
		}
	}
}
