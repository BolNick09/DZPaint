using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Drawing2.FrmPaint;

namespace Drawing2
{
    public partial class FrmPaint : Form
    {

        public enum ShapeType
        {
            Line,
            Rectangle,
            Ellipse,
            Triangle
        }
        public abstract class Shape
        {
            public Point StartPoint { get; set; }
            public Point EndPoint { get; set; }
            public abstract void Draw(Graphics g, Point start, Point end);
            public abstract void UpdateEndPoint(Point location);
        }

        public class Line : Shape
        {
            private Point start;
            private Point end;

            public Line(Point start, Point end)
            {
                this.start = start;
                this.end = end;
            }

            public override void Draw(Graphics g, Point start, Point end)
            {
                g.DrawLine(Pens.Black, start, end);
            }
            public override void UpdateEndPoint(Point location)
            {
                end = location;
            }
        }

        public class Rectangle : Shape
        {

            private Point startPoint;
            private int width;
            private int height;
            public Rectangle(Point start, Point end)
            {
                startPoint = start;
                width = Math.Abs(end.X - start.X);
                height = Math.Abs(end.Y - start.Y);
            }

            public override void Draw(Graphics g, Point start, Point end)
            {
                int width = Math.Abs(end.X - start.X);
                int height = Math.Abs(end.Y - start.Y);
                g.DrawRectangle(Pens.Black, start.X, start.Y, width, height);
            }
            public override void UpdateEndPoint(Point location)
            {
                width = Math.Abs(location.X - startPoint.X);
                height = Math.Abs(location.Y - startPoint.Y);
            }
        }

        public class Ellipse : Shape
        {
            private Point startPoint;
            private Point endPoint;

            public Ellipse(Point startPoint, Point endPoint)
            {
                this.startPoint = startPoint;
                this.endPoint = endPoint;
            }

            public override void Draw(Graphics graphics, Point startPoint, Point endPoint)
            {
                int width = Math.Abs(endPoint.X - startPoint.X);
                int height = Math.Abs(endPoint.Y - startPoint.Y);
                graphics.DrawEllipse(Pens.Black, startPoint.X, startPoint.Y, width, height);
            }

            public override void UpdateEndPoint(Point location)
            {
                endPoint = location;
            }
        }

        public class Triangle : Shape
        {
            private Point startPoint;
            private Point endPoint;

            public Triangle(Point startPoint, Point endPoint)
            {
                this.startPoint = startPoint;
                this.endPoint = endPoint;
            }

            public override void Draw(Graphics graphics, Point startPoint, Point endPoint)
            {
                int width = Math.Abs(endPoint.X - startPoint.X);
                int height = Math.Abs(endPoint.Y - startPoint.Y);
                graphics.DrawPolygon(Pens.Black, new Point[] { startPoint, endPoint, new Point(startPoint.X + width / 2, startPoint.Y + height) });
            }
            public override void UpdateEndPoint(Point location)
            {
                endPoint = location;
            }
        }
        public class ShapeCollection : IEnumerable<Shape>
        {
            private List<Shape> shapes = new List<Shape>();
            public List<Point> startPoints = new List<Point>();
            public List<Point> endPoints = new List<Point>();

            public void AddShape(Shape shape, Point start, Point end)
            {
                shapes.Add(shape);
                startPoints.Add(start);
                endPoints.Add(end);
            }

            public void Draw(Graphics g)
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    shapes[i].Draw(g, startPoints[i], endPoints[i]);
                }
            }
            public void Clear()
            {
                shapes.Clear();
                startPoints.Clear();
                endPoints.Clear();
            }
            public IEnumerator<Shape> GetEnumerator()
            {
                return shapes.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
            public int GetCount()
            {
                return shapes.Count;
            }
            public Shape this[int index]
            {
                get { return shapes[index]; }
                set { shapes[index] = value; }
            }
        }

        private Shape CreateShape(ShapeType type, Point startPoint, Point endPoint)
        {
            switch (type)
            {
                case ShapeType.Line:
                return new Line(startPoint, endPoint);
                case ShapeType.Rectangle:
                return new Rectangle(startPoint, endPoint);
                case ShapeType.Ellipse:
                return new Ellipse(startPoint, endPoint);
                case ShapeType.Triangle:
                return new Triangle(startPoint, endPoint);
                default:
                throw new ArgumentException("Invalid shape type");
            }
        }

        ShapeCollection shapes;
        private Point startPoint;
        private ShapeType shapeType;
        private Shape shape;

        public FrmPaint()
        {
            InitializeComponent();
            shapes = new ShapeCollection();
        }


        private void FrmPaint_Load(object sender, EventArgs e)
        {

        }

        private void FrmPaint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                Point endPoint = e.Location;
                shape = CreateShape(shapeType, startPoint, endPoint);
            }
        }

        private void FrmPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && shape != null)
            {
                shape.UpdateEndPoint(e.Location);
                Invalidate();
            }
        }

        private void FrmPaint_MouseUp(object sender, MouseEventArgs e)
        {
            if (shape != null)
            {
                shape.Draw(CreateGraphics(), startPoint, e.Location);
                shapes.AddShape(shape, shape.StartPoint, shape.EndPoint);
                shape = null;
                label1.Text = "Shape Count: " + shapes.GetCount().ToString();
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Line;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Rectangle;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Ellipse;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            shapeType = ShapeType.Triangle;
        }

        private void FrmPaint_Paint(object sender, PaintEventArgs e)
        {
            if (shapes.GetCount() == 0)
                return;

            for (int i = 0; i < shapes.GetCount(); i++)
                shapes[i].Draw(e.Graphics, shapes.startPoints[i], shapes.endPoints[i]);

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            Invalidate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                for (int i = 0; i < shapes.GetCount(); i++)                
                    shapes[i].Draw(graphics, shapes.startPoints[i], shapes.endPoints[i]);
                
            }
            bitmap.Save("drawing.jpg", ImageFormat.Jpeg);
        }
    }
}
