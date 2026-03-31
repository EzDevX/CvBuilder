using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;
using V = DocumentFormat.OpenXml.Vml;
using VW = DocumentFormat.OpenXml.Vml.Wordprocessing;

namespace CvBuilder
{
    class WORD
    {

        string WordFileName;

        public WORD(string NewWordFileName)
        {
            WordFileName = NewWordFileName;

            using (WordprocessingDocument NewWordFile = WordprocessingDocument.Create(NewWordFileName, WordprocessingDocumentType.Document))
            {
                MainDocumentPart MainPart = NewWordFile.AddMainDocumentPart();
                MainPart.Document = new Document(new Body());

                NewWordFile.MainDocumentPart.Document.Save();
            }
        }

        public enum enAlienment
        {
            enCenter = 1 , enRight = 2 , enLeft = 3
        }

        public  enum enMargin
        {
            enNarrow = 1 , enNormal = 2
        }

        public class csFontSettings
        {
            public bool Bold { get; set; }
            public bool Italic { get; set; }
            public bool Underline { get; set; }
            public int FontSize { get; set; }
            public enAlienment Alienment { get; set; }
            public string FontStyle { get; set; }


        }

        PageMargin NarrowMargin()
        {
            PageMargin MyNarrow = new PageMargin()
            {
                Top = 720,
                Bottom = 720,
                Left = 720,
                Right = 720

            };

            return MyNarrow;
        }

        PageMargin NormalMargin()
        {
            PageMargin MyNormal = new PageMargin()
            {
                Top = 1440,
                Bottom = 1440,
                Left = 1440,
                Right = 1440

            };

            return MyNormal;
        }

        Drawing AddImageInline(string ImageID, int WidthInCm, int HightInCm)
        {
            long cxWidth = WidthInCm * 360000;
            long cyHight = HightInCm * 360000;

            Drawing MyDrawing =
                new Drawing(
                    new DW.Inline(
                        new DW.Extent() { Cx = cxWidth, Cy = cyHight },
                        new DW.DocProperties() { Id = 0, Name = "PersonlPhoto" },
                        new DW.NonVisualGraphicFrameDrawingProperties(new A.GraphicFrameLocks() { NoChangeAspect = true }),
                        new A.Graphic(
                            new A.GraphicData(
                                new PIC.Picture(
                                    new PIC.NonVisualPictureProperties(
                                        new PIC.NonVisualDrawingProperties() { Id = 0, Name = "PersonalPhoto" },
                                        new PIC.NonVisualPictureDrawingProperties()
                                        ),
                                    new PIC.BlipFill(
                                        new A.Blip() { Embed = ImageID },
                                        new A.Stretch()
                                    ),
                                    new PIC.ShapeProperties(
                                        new A.Transform2D(new A.Offset() { X = 0, Y = 0 }, new A.Extents() { Cx = cxWidth, Cy = cyHight }),
                                        new A.PresetGeometry(new A.AdjustValueList()) { Preset = A.ShapeTypeValues.Rectangle }
                                    )
                   /*Picture*/)
        /*Graphic Data*/   )
                            { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" }
       /*Graphic*/      )
      /*Inline*/    )
     /*Drawing*/);

            return MyDrawing;
        }

        JustificationValues SetAlienment (enAlienment Alienment)
        {
            switch (Alienment)
            {
                case enAlienment.enCenter:
                    return JustificationValues.Center;

                case enAlienment.enLeft:
                    return JustificationValues.Left;

                case enAlienment.enRight:
                    return JustificationValues.Right;

                default:
                    return JustificationValues.Left;
            }
        }

        public void AddTextLine(string Text , csFontSettings FontSettings)
        {
            using (WordprocessingDocument MyWordFile = WordprocessingDocument.Open(WordFileName , true))
            {

                Paragraph MyParagraph = new Paragraph();

                ParagraphProperties MyParagraphProps = new ParagraphProperties();
                MyParagraphProps.Justification = new Justification() { Val = SetAlienment(FontSettings.Alienment) };

                MyParagraph.Append(MyParagraphProps);

                Run MyRun = new Run();
                RunProperties MyRunProps = new RunProperties();

                MyRunProps.RunFonts = new RunFonts() { Ascii = FontSettings.FontStyle };
                MyRunProps.FontSize = new FontSize() { Val = (FontSettings.FontSize * 2).ToString() };

                if (FontSettings.Bold)
                {
                    MyRunProps.Bold = new Bold();
                }
                if (FontSettings.Italic)
                {
                    MyRunProps.Italic = new Italic();
                }
                if (FontSettings.Underline)
                {
                    MyRunProps.Underline = new Underline() { Val = UnderlineValues.Single };
                }

                MyRun.Append(MyRunProps);
                MyRun.Append(new Text(Text) { Space = SpaceProcessingModeValues.Preserve });

                MyParagraph.Append(MyRun);

                MyWordFile.MainDocumentPart.Document.Body.Append(MyParagraph);

                MyWordFile.MainDocumentPart.Document.Save();

            }




        }

        public void AddPictureLine(Image Photo , int WidthInCm, int HightInCm)
        {
            using (WordprocessingDocument MyWordFile = WordprocessingDocument.Open(WordFileName, true))
            {

                ImagePart MyImagePart = MyWordFile.MainDocumentPart.AddImagePart(ImagePartType.Png);

                using (MemoryStream ms = new MemoryStream())
                {
                    Photo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.Seek(0, SeekOrigin.Begin);
                    MyImagePart.FeedData(ms);
                }

                string ImageID = MyWordFile.MainDocumentPart.GetIdOfPart(MyImagePart);

                MyWordFile.MainDocumentPart.Document.Body.Append(new Paragraph(new Run(AddImageInline(ImageID, WidthInCm, HightInCm))));
                MyWordFile.MainDocumentPart.Document.Save();

            }



        }

        public void AddText(string Text, csFontSettings FontSettings)
        {
            using (WordprocessingDocument MyWordFile = WordprocessingDocument.Open(WordFileName, true))
            {

                List<Paragraph> AllParagraphs = MyWordFile.MainDocumentPart.Document.Body.Elements<DocumentFormat.OpenXml.Wordprocessing.Paragraph>().ToList();
                int Count = AllParagraphs.Count;


                ParagraphProperties MyParagraphProps = new ParagraphProperties();
                MyParagraphProps.Justification = new Justification() { Val = SetAlienment(FontSettings.Alienment) };



                Run MyRun = new Run();
                RunProperties MyRunProps = new RunProperties();

                MyRunProps.RunFonts = new RunFonts() { Ascii = FontSettings.FontStyle };
                MyRunProps.FontSize = new FontSize() { Val = (FontSettings.FontSize * 2).ToString() };

                if (FontSettings.Bold)
                {
                    MyRunProps.Bold = new Bold();
                }
                if (FontSettings.Italic)
                {
                    MyRunProps.Italic = new Italic();
                }
                if (FontSettings.Underline)
                {
                    MyRunProps.Underline = new Underline() { Val = UnderlineValues.Single };
                }

                MyRun.Append(MyRunProps);
                MyRun.Append(new Text(" " + Text) { Space = SpaceProcessingModeValues.Preserve });

                if(Count == 0)
                {
                    Paragraph OneParagraph = new Paragraph();
                    OneParagraph.Append(MyParagraphProps);
                    OneParagraph.Append(MyRun);
                    MyWordFile.MainDocumentPart.Document.Body.Append(OneParagraph);
                    MyWordFile.MainDocumentPart.Document.Save();
                }
                else
                {
                    Paragraph LastParagraph = AllParagraphs[Count - 1];
                    LastParagraph.Append(MyRun);
                    MyWordFile.MainDocumentPart.Document.Save();
                }
                

            }
        }

        public void AddPicture(Image Photo, int WidthInCm, int HightInCm)
        {
            using (WordprocessingDocument MyWordFile = WordprocessingDocument.Open(WordFileName, true))
            {

                ImagePart MyImagePart = MyWordFile.MainDocumentPart.AddImagePart(ImagePartType.Png);

                using (MemoryStream ms = new MemoryStream())
                {
                    Photo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.Seek(0, SeekOrigin.Begin);
                    MyImagePart.FeedData(ms);
                }

                string ImageID = MyWordFile.MainDocumentPart.GetIdOfPart(MyImagePart);

                List<Paragraph> AllParagraphs = MyWordFile.MainDocumentPart.Document.Body.Elements<Paragraph>().ToList();
                int Count = AllParagraphs.Count;

                Run MyRun = new Run();

                MyRun.Append(AddImageInline(ImageID, WidthInCm, HightInCm));

                if (Count == 0)
                {
                    Paragraph NewParagraph = new Paragraph();
                    NewParagraph.Append(MyRun);
                    MyWordFile.MainDocumentPart.Document.Body.Append(NewParagraph);
                    MyWordFile.MainDocumentPart.Document.Save();
                }
                else
                {
                    Paragraph LastParagraph = AllParagraphs[Count - 1];
                    LastParagraph.Append(MyRun);
                    MyWordFile.MainDocumentPart.Document.Save();
                }

            }
        }

        public void AddTextBoxLine(string Text, csFontSettings FontSettings ,double WidthInCm, double HightInCm)
        {
            using (WordprocessingDocument MyWordFile = WordprocessingDocument.Open(WordFileName, true))
            {
                double Pthight = HightInCm * 37.8;
                double PtWidth = WidthInCm * 37.8;

                ParagraphProperties MyParagraphProps = new ParagraphProperties();
                MyParagraphProps.Justification = new Justification() { Val = SetAlienment(FontSettings.Alienment) };

                RunProperties MyRunProps = new RunProperties();
          
                MyRunProps.RunFonts = new RunFonts() { Ascii = FontSettings.FontStyle };
                MyRunProps.FontSize = new FontSize() { Val = (FontSettings.FontSize * 2).ToString() };

                if (FontSettings.Bold)
                {
                    MyRunProps.Bold = new Bold();
                }
                if (FontSettings.Italic)
                {
                    MyRunProps.Italic = new Italic();
                }
                if (FontSettings.Underline)
                {
                    MyRunProps.Underline = new Underline() { Val = UnderlineValues.Single };
                }

                Run MyRun = new Run();
                Paragraph MyParagraph = new Paragraph();

                MyRun.Append(MyRunProps);
                MyParagraph.Append(MyParagraphProps);

                MyRun.Append(new Text(Text) { Space = SpaceProcessingModeValues.Preserve });
                MyParagraph.Append(MyRun);

                var Shape = new V.Shape()
                {
                    Id = "TextBox1",
                    Style = $"width:{PtWidth};height:{Pthight};v-text-anchor:middle",
                    Type = "#_x0000_t202",
                    Filled = false,
                    Stroked = false

                };

                var MyTextBox = new V.TextBox(new TextBoxContent(MyParagraph));

                Shape.Append(MyTextBox);

                var Pict = new Picture();
                Pict.Append(Shape);

                MyWordFile.MainDocumentPart.Document.Body.Append(new Paragraph(new Run(Pict)));
                MyWordFile.MainDocumentPart.Document.Save();


            }
        }
    
        public void AddTextBox(string Text, csFontSettings FontSettings , double WidthInCm, double HightInCm)
        {
            using (WordprocessingDocument MyWordFile = WordprocessingDocument.Open(WordFileName, true))
            {

                double Pthight = HightInCm * 37.8;
                double PtWidth = WidthInCm * 37.8;

                List<Paragraph> AllParagraphs = MyWordFile.MainDocumentPart.Document.Body.Elements<DocumentFormat.OpenXml.Wordprocessing.Paragraph>().ToList();
                int Count = AllParagraphs.Count;


                ParagraphProperties MyParagraphProps = new ParagraphProperties();
                MyParagraphProps.Justification = new Justification() { Val = SetAlienment(FontSettings.Alienment) };

                RunProperties MyRunProps = new RunProperties();



                MyRunProps.RunFonts = new RunFonts() { Ascii = FontSettings.FontStyle };
                MyRunProps.FontSize = new FontSize() { Val = (FontSettings.FontSize * 2).ToString() };

                if (FontSettings.Bold)
                {
                    MyRunProps.Bold = new Bold();
                }
                if (FontSettings.Italic)
                {
                    MyRunProps.Italic = new Italic();
                }
                if (FontSettings.Underline)
                {
                    MyRunProps.Underline = new Underline() { Val = UnderlineValues.Single };
                }

                Run MyRun = new Run();
                Paragraph MyParagraph = new Paragraph();

                MyRun.Append(MyRunProps);
                MyParagraph.Append(MyParagraphProps);

                MyRun.Append(new Text(Text) { Space = SpaceProcessingModeValues.Preserve });
                MyParagraph.Append(MyRun);

                var Shape = new V.Shape()
                {
                    Id = "TextBox1",
                    Style = $"width:{PtWidth};height:{Pthight};v-text-anchor:middle",
                    Type = "#_x0000_t202",
                    Filled = false,
                    Stroked = false

                };


                var MyTextBox = new V.TextBox(new TextBoxContent(MyParagraph));

                Shape.Append(MyTextBox);

                var Pict = new Picture();
                Pict.Append(Shape);


                if (Count == 0)
                {
                    Paragraph OneParagraph = new Paragraph();
                    OneParagraph.Append(new Run(Pict));
                    MyWordFile.MainDocumentPart.Document.Body.Append(OneParagraph);
                    MyWordFile.MainDocumentPart.Document.Save();
                }
                else
                {
                    Paragraph LastParagraph = AllParagraphs[Count - 1];
                    LastParagraph.Append(new Run(Pict));

                    MyWordFile.MainDocumentPart.Document.Save();
                }


                }

            }

        public void RemoveProofing()
        {
            using (WordprocessingDocument MyWordFile = WordprocessingDocument.Open(WordFileName, true))
            {

                DocumentSettingsPart SettingsPart = MyWordFile.MainDocumentPart.AddNewPart<DocumentSettingsPart>();
                SettingsPart.Settings = new Settings(
                    new HideGrammaticalErrors(),
                    new HideSpellingErrors()
                    );

                SettingsPart.Settings.Save();

                MyWordFile.MainDocumentPart.Document.Save();

            }

        }

        public void ChangeMargin(enMargin Margin)
        {

            SectionProperties MyProps = new SectionProperties();

            switch (Margin)
            {
                case enMargin.enNarrow:
                    MyProps.Append(NarrowMargin());
                    break;

                case enMargin.enNormal:
                    MyProps.Append(NormalMargin());
                    break;

                default:
                    MyProps.Append(NormalMargin());
                    break;


            }

            using (WordprocessingDocument MyWordFile = WordprocessingDocument.Open(WordFileName, true))
            {

                MyWordFile.MainDocumentPart.Document.Body.Append(MyProps);

                MyWordFile.MainDocumentPart.Document.Save();

            }

        }



    }
}
