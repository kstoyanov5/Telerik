namespace _02.IfStatements
{
    using System;

    public class IfStatementRefactoringStartup
    {
        private const int MinX = 1;
        private const int MaxX = 5;
        private const int MinY = 2;
        private const int MaxY = 7;

        private bool cellIsVisited;

        public void ValidatePotatoCooking(Potato potato)
        {
            if (potato == null)
            {
                throw new ArgumentNullException("Potato cannot be null");
            }

            if (potato.HasBeenPeeled && potato.IsRotten)
            {
                throw new ArgumentException("Potato shouldn't be peeled and rotten");
            }

            this.Cook(potato);
        }

        public void MinorMaxCellVisit(int x, int y)
        {
            if (x >= MinX && (x <= MaxX && ((MaxY >= y && MinY <= y) && this.cellIsVisited)))
            {
                this.VisitCell();
            }
        }

        private void VisitCell()
        {
        }

        private void Cook(Potato potato)
        {
        }
    }
}
