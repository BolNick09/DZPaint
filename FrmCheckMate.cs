namespace Drawing2
{
    public partial class FrmCheckMate : Form
    {
        public FrmCheckMate()
        {
            InitializeComponent();
        }
        private bool isBoardDrawn = false;
        private void btnCheckMate_Click_1(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            const int rows = 8;
            const int cols = 8;
            const int startX = 8;
            const int startY = 8;
            const int cellSize = 8;
            if (!isBoardDrawn)
            {
                for (int i = startY; i < startY + rows; i++)
                {
                    for (int j = startX; j < startX + cols; j++)
                    {
                        var color = (i + j) % 2 == 0 ? Color.White : Color.Black;
                        var rect = new Rectangle(j * cellSize, i * cellSize, cellSize, cellSize);
                        var brush = new SolidBrush(color);
                        g.FillRectangle(brush, rect);
                    }
                }
                btnCheckMate.Text = "Очистить доску";
            }
            else
            {
                g.Clear(this.BackColor);
                btnCheckMate.Text = "Отрисовать доску";
            }
            isBoardDrawn = !isBoardDrawn;
        }
    }
}
