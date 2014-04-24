using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Globalization;

namespace PrintControl
{
    public class PrintPaginator : DocumentPaginator
    {
        private string m_Title;
        private IList<string> m_Details;
        private Size m_PageSize;
        public PrintPaginator(Size pageSize, string title, IList<string> details)
        {
            m_Title = title;
            m_Details = details;
            PageSize = pageSize;
        }

        public override DocumentPage GetPage(int pageNumber)
        {
            var page = new PrintPage(m_Title, m_Details);
            page.Measure(PageSize);
            page.Arrange(new Rect(new Point(0, 0), PageSize));
            return new DocumentPage(page);
        }


        public override bool IsPageCountValid
        {
            get { return true; }
        }

        public override int PageCount
        {
            get { return 1; }
        }
        public override Size PageSize
        {
            get { return m_PageSize; }
            set { m_PageSize = value; }
        }
        public override IDocumentPaginatorSource Source
        {
            get { return null; }
        }
    }
    public class PrintPage : UserControl
    {
        private const int PageMargin = 35;
        private const int TitilHeight = 25;
        private const int LineHeight = 23;

        private string Title;
        private IList<string> Details;
        public PrintPage(string title, IList<string> details)
        {
            Margin = new Thickness(PageMargin);
            Title = title;
            Details = details;
        }
        private FormattedText MakeTitleText(string text)
        {
            return new FormattedText(text, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, new Typeface("Tahoma"), 24, Brushes.Black);
        }
        private FormattedText MakeText(string text)
        {
            return new FormattedText(text, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, new Typeface("Tahoma"), 14, Brushes.Black);
        }
        protected override void OnRender(DrawingContext dc)
        {
            Point curPoint = new Point(0, 0);
            var title = MakeTitleText("禾木养生");
            curPoint.X = 50;// (this.Width - 2 * PageMargin - title.Width) / 2;
            curPoint.Y = 100;
            dc.DrawText(title, curPoint);

            curPoint.Y += TitilHeight;
            curPoint.X = 0;
            dc.DrawRectangle(Brushes.Black, null, new Rect(curPoint, new Point(500, 500)));

        }

    }
}

