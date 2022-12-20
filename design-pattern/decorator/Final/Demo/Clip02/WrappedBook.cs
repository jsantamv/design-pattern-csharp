using Demo.Common;

namespace Demo.Clip02
{
    /// <summary>
    /// Envuelve o encapsula el book
    /// para un mejor compartamiento
    /// 
    /// </summary>
    class WrappedBook : Book
    {
        public WrappedBook(Book other) : base(other)
        {
        }

        public override Size Dimensions =>
            base.Dimensions
                .Add(new Size(7 * Length.Millimeter, 7 * Length.Millimeter, 7 * Length.Millimeter));
    }
}