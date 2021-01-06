using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.Xml.Serialization;
using DungeonBuilder2.Properties;

namespace DungeonBuilder2
{
    public partial class Form1 : Form
    {
        private readonly Grid _grid;
        private List<BuildingComponent> _walls = new List<BuildingComponent>();
        private List<BuildingComponent> _doors = new List<BuildingComponent>();
        private List<BuildingComponent> _windows = new List<BuildingComponent>();
        private List<BuildingComponent> _rulers = new List<BuildingComponent>();
        private List<BuildingComponent> _lines = new List<BuildingComponent>();
        private List<BuildingComponent> _furniture = new List<BuildingComponent>();
        private Point _lastMousePos = Point.Empty;
        private Wall _tempWall;
        private Window _tempWindow;
        private List<Point> _polyWallPoints = new List<Point>();
        private List<Point> _rulerPoints = new List<Point>();
        private Point[] _tempLine;
        private Ruler _tempRuler;
        private Furniture _tempFurniture;
        private Mode _mode = Mode.BuildingWall;
        private int _currentRotate = 0;

        public Form1()
        {
            InitializeComponent();
            _grid = new Grid(Screen.PrimaryScreen.Bounds.Width - 160, Screen.PrimaryScreen.Bounds.Height - 75, 10, 2);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = _grid.BackBitmap;
            tbScale.Text = _grid.Scale.ToString();
            tbScaleMultiplier.Text = _grid.ScaleMultiplier.ToString();
            UpdateButtonStates(btWall);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            foreach (var wall in _walls)
            {
                Brush br = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Gainsboro, Color.Empty);
                e.Graphics.DrawPolygon(Pens.Gainsboro, wall.Corners);
                e.Graphics.FillPolygon(br, wall.Corners);
            }

            foreach (Door door in _doors)
            {
                e.Graphics.DrawLine(new Pen(Color.Gainsboro, 2), door.Corners[0], door.Corners[1]);
                e.Graphics.DrawLine(new Pen(Color.Gray, 2), door.Corners[0], door.Corners[2]);
                e.Graphics.DrawArc(Pens.Gray, door.Corners[0].X - door.Width, door.Corners[0].Y - door.Width, door.Width*2, door.Width*2, (int) -(180 / Math.PI * door.Corners[0].GetAngle(door.Corners[1])), 45);
            }
            
            foreach (Window window in _windows)
            {
                e.Graphics.DrawPolygon(Pens.Gainsboro, window.Corners);
                e.Graphics.DrawLine(Pens.Gainsboro, window.Corners[0].AvgPoint(window.Corners[3]), window.Corners[1].AvgPoint(window.Corners[2]));
            }
            
            foreach (Line line in _lines)
            {
                e.Graphics.DrawLine(Pens.Gainsboro, line.PointFrom, line.PointTo);
            }
            
            foreach (Ruler ruler in _rulers)
            {
                Point textPoint = ruler.Start.AvgPoint(ruler.End);
                GraphicsState graphicsState= e.Graphics.Save();
                e.Graphics.DrawLines(Pens.Gainsboro, new [] {ruler.Start, ruler.End});
                e.Graphics.FillEllipse(Brushes.Gainsboro, ruler.Start.X - 2, ruler.Start.Y - 2, 4, 4);
                e.Graphics.FillEllipse(Brushes.Gainsboro, ruler.End.X - 2, ruler.End.Y - 2, 4, 4);
                e.Graphics.RotateTransform((int) -(180 / Math.PI * ruler.Start.GetAngle(ruler.End)));
                e.Graphics.TranslateTransform(textPoint.X, textPoint.Y, MatrixOrder.Append);
                e.Graphics.DrawString(ruler.Length.ToString(), new Font(FontFamily.GenericMonospace, 10, FontStyle.Regular), Brushes.Gainsboro, 0, 0);
                e.Graphics.Restore(graphicsState);
            }
            
            foreach (Furniture furniture in _furniture)
                e.Graphics.DrawImage(furniture.FImage, furniture.Location.X, furniture.Location.Y, furniture.FImage.Width, furniture.FImage.Height);

            if(_tempWall != null)
                e.Graphics.DrawPolygon(Pens.Gainsboro, _tempWall.Corners);

            if (_tempWindow != null)
            {
                e.Graphics.DrawPolygon(Pens.Gainsboro, _tempWindow.Corners);
                e.Graphics.DrawLine(Pens.Gainsboro, _tempWindow.Corners[0].AvgPoint(_tempWindow.Corners[3]), _tempWindow.Corners[1].AvgPoint(_tempWindow.Corners[2]));
            }

            if (_tempRuler != null)
            {
                Point textPoint = _tempRuler.Start.AvgPoint(_tempRuler.End);
                GraphicsState graphicsState= e.Graphics.Save();
                e.Graphics.DrawLines(Pens.Gainsboro, new [] {_tempRuler.Start, _tempRuler.End});
                e.Graphics.FillEllipse(Brushes.Gainsboro, _tempRuler.Start.X - 2, _tempRuler.Start.Y - 2, 4, 4);
                e.Graphics.FillEllipse(Brushes.Gainsboro, _tempRuler.End.X - 2, _tempRuler.End.Y - 2, 4, 4);
                e.Graphics.RotateTransform((int) -(180 / Math.PI * _tempRuler.Start.GetAngle(_tempRuler.End)));
                e.Graphics.TranslateTransform(textPoint.X, textPoint.Y, MatrixOrder.Append);
                e.Graphics.DrawString(_tempRuler.Length.ToString(), new Font(FontFamily.GenericMonospace, 10, FontStyle.Regular), Brushes.Gainsboro, 0, 0);
                e.Graphics.Restore(graphicsState);
            }
            
            if(_tempFurniture != null)
                e.Graphics.DrawImage(_tempFurniture.FImage, _tempFurniture.Location.X, _tempFurniture.Location.Y, _tempFurniture.FImage.Width, _tempFurniture.FImage.Height);

            // Bitmap bm = Resources.Bed;
            // bm.RotateFlip(RotateFlipType.Rotate180FlipNone);
            // e.Graphics.DrawImage(bm, 50, 50, bm.Width, bm.Height);
            
            if (_polyWallPoints.Count >= 2)
            {
                e.Graphics.FillEllipse(Brushes.Orange, _polyWallPoints[0].X - 3, _polyWallPoints[0].Y - 3, 6, 6);
                e.Graphics.DrawLines(Pens.Gainsboro, _polyWallPoints.ToArray());
            }
            
            if(_rulerPoints.Count >= 2)
                e.Graphics.DrawLines(Pens.SteelBlue, _rulerPoints.ToArray());

            if(_tempLine != null)
                if(_mode != Mode.MeasuringTape)
                    if(_mode != Mode.BuildingDoor)
                        e.Graphics.DrawLines(Pens.Gainsboro, _tempLine);
                    else
                    {
                        e.Graphics.DrawLines(new Pen(Color.Gainsboro, 2), _tempLine);
                    }
                else
                {
                    e.Graphics.DrawLines(Pens.SteelBlue, _tempLine);
                    double currentDistance = _tempLine[0].GetDistance(_tempLine[1]);
                    double distance = _rulerPoints[0].GetDistance(_rulerPoints.ToArray()) + currentDistance;
                    e.Graphics.DrawString($"{currentDistance:F}" + "cm / " + $"{distance:F}" + "cm",
                        new Font(FontFamily.GenericMonospace, 8, FontStyle.Bold), Brushes.LightSeaGreen,
                        (_tempLine[0].X + _tempLine[1].X) / 2, (_tempLine[0].Y + _tempLine[1].Y) / 2);
                }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (_mode)
            {
                case Mode.None:
                    BuildingComponent.SetMovable(_walls, ref _lastMousePos, e.Location);
                    BuildingComponent.SetMovable(_doors, ref _lastMousePos, e.Location);
                    BuildingComponent.SetMovable(_windows, ref _lastMousePos, e.Location);
                    break;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (_mode)
            {
                case Mode.None:
                    _lastMousePos = Point.Empty;
                    if (BuildingComponent.MovableComponent != null)
                        BuildingComponent.MovableComponent.Movable = false;
                    BuildingComponent.MovableComponent = null;
                    break;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            switch (_mode)
            {
                case Mode.BuildingWall:
                    if (_lastMousePos != Point.Empty)
                        _tempWall.End2 = _grid.PtToGridPoint(e.Location);
                    break;
                case Mode.BuildingPolyWall:
                case Mode.MeasuringTape:
                    if(_lastMousePos != Point.Empty)
                        _tempLine = new[] {_grid.PtToGridPoint(_lastMousePos), _grid.PtToGridPoint(e.Location)};
                    break;
                case Mode.None:
                    if (BuildingComponent.MovableComponent != null)
                    {
                        BuildingComponent.MovableComponent.Move(_grid.PtToGridPoint(e.Location).X - _grid.PtToGridPoint(_lastMousePos).X, _grid.PtToGridPoint(e.Location).Y - _grid.PtToGridPoint(_lastMousePos).Y);
                        _lastMousePos = e.Location;
                        pictureBox1.CreateGraphics().DrawString(BuildingComponent.MovableComponent.Corners[0].ToString(), new Font(FontFamily.GenericMonospace, 10, FontStyle.Regular), Brushes.Azure, 20, 20);
                    }
                    break;
                case Mode.BuildingDoor:
                case Mode.Line:
                    if(_lastMousePos != Point.Empty)
                        _tempLine = new[] {_grid.PtToGridPoint(_lastMousePos), _grid.PtToGridPoint(e.Location)};
                    break;
                case Mode.BuildingWindow:
                    if(_lastMousePos != Point.Empty)
                        _tempWindow.End2 = _grid.PtToGridPoint(e.Location);
                    break;
                case Mode.RulerMode:
                    if (_lastMousePos != Point.Empty)
                        _tempRuler.End = _grid.PtToGridPoint(e.Location);
                    break;
                case Mode.BuildingBed:
                case Mode.BuildingLamp:
                case Mode.BuildingSofa:
                case Mode.BuildingChair:
                case Mode.BuildingArmChair:
                    
                    _tempFurniture.Location = e.Location;
                    break;
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (_mode)
            {
                case Mode.BuildingWall:
                    _lastMousePos = e.Location;
                    if (e.Button == MouseButtons.Left)
                    {
                        if (_tempWall == null)
                        {
                            _tempWall = new Wall(_grid.PtToGridPoint(_lastMousePos), _grid.PtToGridPoint(e.Location), wallWidthTrack.Value);
                            return;
                        }
                        _walls.Add(_tempWall);
                    }
                    _tempWall = null;
                    _lastMousePos = Point.Empty;
                    break;
                case Mode.BuildingPolyWall:
                    _lastMousePos = e.Location;
                    if (e.Button == MouseButtons.Left)
                    {
                        if (_polyWallPoints.Count == 0)
                        {
                            _polyWallPoints.Add(_grid.PtToGridPoint(_lastMousePos));
                            return;
                        }

                        if (!_polyWallPoints[0].Equals(_grid.PtToGridPoint(e.Location)))
                        {
                            _polyWallPoints.Add(_grid.PtToGridPoint(e.Location));
                            return;
                        }
                        _walls.Add(new PolyWall(_polyWallPoints.ToArray()));
                    }
                    _tempLine = null;
                    _polyWallPoints = new List<Point>();
                    _lastMousePos = Point.Empty;
                    break;
                case Mode.MeasuringTape:
                    _lastMousePos = e.Location;
                    if (e.Button == MouseButtons.Left)
                    {
                        _rulerPoints.Add(_grid.PtToGridPoint(_lastMousePos));
                        return;
                    }
                    _tempLine = null;
                    _rulerPoints = new List<Point>();
                    _lastMousePos = Point.Empty;
                    break;
                case Mode.BuildingDoor:
                    if (e.Button == MouseButtons.Left)
                    {
                        if (_lastMousePos == Point.Empty)
                        {
                            _lastMousePos = e.Location;
                            return;
                        }
                        _doors.Add(new Door(_grid.PtToGridPoint(_lastMousePos), _grid.PtToGridPoint(e.Location)));
                    }
                    _tempLine = null;
                    _lastMousePos = Point.Empty;
                    break;
                case Mode.BuildingWindow:
                    _lastMousePos = e.Location;
                    if (e.Button == MouseButtons.Left)
                    {
                        if (_tempWindow == null)
                        {
                            _tempWindow = new Window(_grid.PtToGridPoint(_lastMousePos), _grid.PtToGridPoint(e.Location), wallWidthTrack.Value);
                            return;
                        }
                        _windows.Add(_tempWindow);
                    }
                    _tempWindow = null;
                    _lastMousePos = Point.Empty;
                    break;
                case Mode.Line:
                    if (e.Button == MouseButtons.Left)
                    {
                        if (_lastMousePos == Point.Empty)
                        {
                            _lastMousePos = e.Location;
                            return;
                        }
                        _lines.Add(new Line (_grid.PtToGridPoint(_lastMousePos), _grid.PtToGridPoint(e.Location)));
                    }
                    _tempLine = null;
                    _lastMousePos = Point.Empty;
                    break;
                case Mode.RulerMode:
                    _lastMousePos = e.Location;
                    if (e.Button == MouseButtons.Left)
                    {
                        if (_tempRuler == null)
                        {
                            _tempRuler = new Ruler(_grid.PtToGridPoint(_lastMousePos), _grid.PtToGridPoint(e.Location));
                            return;
                        }
                        _rulers.Add(_tempRuler);
                    }
                    _tempRuler = null;
                    _lastMousePos = Point.Empty;
                    break;
                case Mode.None:
                    if (e.Button == MouseButtons.Right)
                    {
                        foreach (var wall in _walls)
                            if (e.Location.IsInPolygon(wall.Corners))
                            {
                                _walls.Remove(wall);
                                break;
                            }
                        foreach (var window in _windows)
                            if (e.Location.IsInPolygon(window.Corners)){
                                _windows.Remove(window);      
                                break;
                            }
                        foreach (var door in _doors)
                            if (e.Location.IsInPolygon(door.Corners)){
                                _doors.Remove(door);
                                break;
                            }
                        foreach (Line line in _lines)
                            if (e.Location.IsNearLineApices(new[]{line.PointFrom, line.PointTo}, 5)){
                                _lines.Remove(line);      
                                break;
                            }
                        foreach (Ruler ruler in _rulers)
                            if (e.Location.IsNearLineApices(new [] {ruler.Start, ruler.End}, 5)){
                                _rulers.Remove(ruler);      
                                break;
                            }
                        foreach (Furniture furniture in _furniture)
                            if (e.Location.IsInPolygon(new []{furniture.Location, furniture.Location + new Size(furniture.FImage.Size.Width, 0), furniture.Location + furniture.FImage.Size, furniture.Location + new Size(0, furniture.FImage.Size.Height) })){
                                _furniture.Remove(furniture);
                                break;
                            }
                    }
                    break;
                case Mode.BuildingBed:
                    if (e.Button == MouseButtons.Left)
                    {
                        _furniture.Add(_tempFurniture);
                        _tempFurniture = new Furniture("Bed", (Image) Resources.ResourceManager.GetObject("Bed"),
                            e.Location, 0);
                    }
                    break;
                case Mode.BuildingLamp:
                    if (e.Button == MouseButtons.Left)
                    {
                        _furniture.Add(_tempFurniture);
                        _tempFurniture = new Furniture("Lamp", (Image) Resources.ResourceManager.GetObject("Lamp"),
                            e.Location, 0);
                    }
                    break;
                case Mode.BuildingSofa:
                    if (e.Button == MouseButtons.Left)
                    {
                        _furniture.Add(_tempFurniture);
                        _tempFurniture = new Furniture("Sofa", (Image) Resources.ResourceManager.GetObject("Sofa"),
                            e.Location, 0);
                    }
                    break;
                case Mode.BuildingChair:
                    if (e.Button == MouseButtons.Left)
                    {
                        _furniture.Add(_tempFurniture);
                        _tempFurniture = new Furniture("Chair", (Image) Resources.ResourceManager.GetObject("Chair"),
                            e.Location, 0);
                    }
                    break;
                case Mode.BuildingArmChair:
                    if (e.Button == MouseButtons.Left)
                    {
                        _furniture.Add(_tempFurniture);
                        _tempFurniture = new Furniture("ArmChair", (Image) Resources.ResourceManager.GetObject("ArmChair"),
                            e.Location, 0);
                    }
                    break;
            }
            pictureBox1.Invalidate();
        }

        private void labelScaleDown_Click(object sender, EventArgs e)
        {
            if (_grid.Scale == 5)
            {
                SystemSounds.Exclamation.Play();
                return;
            }

            _grid.Scale /= 2;
            pictureBox1.Image = _grid.BackBitmap;
            tbScale.Text = _grid.Scale.ToString();
        }

        private void labelScaleUp_Click(object sender, EventArgs e)
        {
            if (_grid.Scale == 40)
            {
                SystemSounds.Exclamation.Play();
                return;
            }
            _grid.Scale *= 2;
            pictureBox1.Image = _grid.BackBitmap;
            tbScale.Text = _grid.Scale.ToString();
        }

        private void labelMultiplierUp_Click(object sender, EventArgs e)
        {
            if (_grid.ScaleMultiplier == 4)
            {
                SystemSounds.Exclamation.Play();
                return;
            }
            _grid.ScaleMultiplier *= 2;
            pictureBox1.Image = _grid.BackBitmap;
            tbScaleMultiplier.Text = _grid.ScaleMultiplier.ToString();
        }

        private void labelMultiplierDown_Click(object sender, EventArgs e)
        {
            if (_grid.ScaleMultiplier == 1)
            {
                SystemSounds.Exclamation.Play();
                return;
            }
            _grid.ScaleMultiplier /= 2;
            pictureBox1.Image = _grid.BackBitmap;
            tbScaleMultiplier.Text = _grid.ScaleMultiplier.ToString();
        }

        private void wallWidthTrack_Scroll(object sender, EventArgs e)
        {
            wallWidthTrack.Value = (int)Math.Round((decimal)wallWidthTrack.Value / 5) * 5;
            labelWallWidth.Text = wallWidthTrack.Value.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            var gg = Graphics.FromImage(pictureBox1.Image);
            gg.SmoothingMode = SmoothingMode.HighQuality;
            foreach (var wall in _walls)
            {
                Brush br = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Gainsboro, Color.Empty);
                gg.DrawPolygon(Pens.Gainsboro, wall.Corners);
                gg.FillPolygon(br, wall.Corners);
            }
            
            foreach (Door door in _doors)
            {
                gg.DrawLine(new Pen(Color.Gainsboro, 2), door.Corners[0], door.Corners[1]);
                gg.DrawLine(new Pen(Color.Gray, 2), door.Corners[0], door.Corners[2]);
                gg.DrawArc(Pens.Gray, door.Corners[0].X - door.Width, door.Corners[0].Y - door.Width, door.Width*2, door.Width*2, (int) -(180 / Math.PI * door.Corners[0].GetAngle(door.Corners[1])), 45);
            }
            
            foreach (Window window in _windows)
            {
                gg.DrawPolygon(Pens.Gainsboro, window.Corners);
                gg.DrawLine(Pens.Gainsboro, window.Corners[0].AvgPoint(window.Corners[3]), window.Corners[1].AvgPoint(window.Corners[2]));
            }
            
            foreach (Line line in _lines)
            {
                gg.DrawLine(Pens.Gainsboro, line.PointFrom, line.PointTo);
            }
            
            foreach (Ruler ruler in _rulers)
            {
                Point textPoint = ruler.Start.AvgPoint(ruler.End);
                GraphicsState graphicsState= gg.Save();
                gg.DrawLines(Pens.Gainsboro, new [] {ruler.Start, ruler.End});
                gg.FillEllipse(Brushes.Gainsboro, ruler.Start.X - 2, ruler.Start.Y - 2, 4, 4);
                gg.FillEllipse(Brushes.Gainsboro, ruler.End.X - 2, ruler.End.Y - 2, 4, 4);
                gg.RotateTransform((int) - (180 / Math.PI * ruler.Start.GetAngle(ruler.End)));
                gg.TranslateTransform(textPoint.X, textPoint.Y, MatrixOrder.Append);
                gg.DrawString(ruler.Length.ToString(), new Font(FontFamily.GenericMonospace, 10, FontStyle.Regular), Brushes.Gainsboro, 0, 0);
                gg.Restore(graphicsState);
            }
            
            foreach (Furniture furniture in _furniture)
                gg.DrawImage(furniture.FImage, furniture.Location.X, furniture.Location.Y, furniture.FImage.Width, furniture.FImage.Height);

            pictureBox1.Image.Save(@"D:\F.png",ImageFormat.Png);
            Close();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void btMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btWall_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.BuildingWall;
        }

        private void btPolyWall_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.BuildingPolyWall;
        }

        private void UpdateButtonStates(Button sender)
        {
            foreach (var control in panel3.Controls)
            {
                if (control is Button button && button != sender)
                    button.FlatAppearance.BorderColor = Color.White;
                else if (control == sender)
                    sender.FlatAppearance.BorderColor = Color.Turquoise;
            }

            _tempLine = null;
            _rulerPoints = new List<Point>();
            _polyWallPoints = new List<Point>();
            _lastMousePos = Point.Empty;
            _tempFurniture = null;
            _tempWall = null;
        }

        private void cbRuler_CheckedChanged(object sender, EventArgs e)
        {
            _grid.IsRulerVisible = cbRuler.Checked;
            _grid.UpdateBitmap();
            pictureBox1.Image = _grid.BackBitmap;
        }

        private void cbGrid_CheckedChanged(object sender, EventArgs e)
        {
            _grid.IsGridVisible = cbGrid.Checked;
            _grid.UpdateBitmap();
            pictureBox1.Image = _grid.BackBitmap;
        }

        private void cbPoints_CheckedChanged(object sender, EventArgs e)
        {
            _grid.IsPointsVisible = cbPoints.Checked;
            _grid.UpdateBitmap();
            pictureBox1.Image = _grid.BackBitmap;
        }

        private void btRuler_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.RulerMode;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.None;
        }

        private void btDoor_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.BuildingDoor;
        }

        private void btWindow_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.BuildingWindow;
        }

        private void btMeasuringTape_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.MeasuringTape;
        }

        private void btLine_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.Line;
        }

        private void brBed_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.BuildingBed;
            _tempFurniture = new Furniture("Bed", (Image)Resources.ResourceManager.GetObject("Bed"), new Point(0, 0), 0);
        }

        private void btLamp_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.BuildingLamp;
            _tempFurniture = new Furniture("Lamp", (Image)Resources.ResourceManager.GetObject("Lamp"), new Point(0, 0), 0);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<List<BuildingComponent>>));
            saveFileDialog1.Filter = "Xml files(*.xml)|*.xml";
            string fileName = String.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                fileName = saveFileDialog1.FileName;
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                List<List<BuildingComponent>> lists = new List<List<BuildingComponent>>();
                lists.Add(_walls);
                lists.Add(_doors);
                lists.Add(_windows);
                lists.Add(_rulers);
                lists.Add(_lines); 
                lists.Add(_furniture);
                formatter.Serialize(fs, lists);
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            List<List<BuildingComponent>> lists;
            XmlSerializer formatter = new XmlSerializer(typeof(List<List<BuildingComponent>>));
            openFileDialog1.Filter = "Xml files(*.xml)|*.xml";
            string fileName = String.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                fileName = openFileDialog1.FileName;
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                lists = (List<List<BuildingComponent>>)formatter.Deserialize(fs);
            }

            _walls = lists[0];
            _doors = lists[1];
            _windows = lists[2];
            _rulers = lists[3];
            _lines = lists[4];
            _furniture = lists[5];
            foreach (Furniture furniture in _furniture)
            {
                switch (furniture.FType)
                {
                    case "Bed":
                        furniture.FImage = (Image) Resources.ResourceManager.GetObject("Bed");
                        break;
                    case "Lamp":
                        furniture.FImage = (Image) Resources.ResourceManager.GetObject("Lamp");
                        break;
                    case "Sofa":
                        furniture.FImage = (Image) Resources.ResourceManager.GetObject("Sofa");
                        break;
                    case "Chair":
                        furniture.FImage = (Image) Resources.ResourceManager.GetObject("Chair");
                        break;
                    case "ArmChair":
                        furniture.FImage = (Image) Resources.ResourceManager.GetObject("ArmChair");
                        break;
                    default:
                        furniture.FImage = (Image) Resources.ResourceManager.GetObject("Lamp");
                        break;
                    
                }
                RotateImage();

                void RotateImage()
                {
                    RotateFlipType flipType;
                    switch (furniture.Rotation)
                    {
                        case 90:
                            flipType = RotateFlipType.Rotate90FlipNone;
                            break;
                        case 180:
                            flipType = RotateFlipType.Rotate180FlipNone;
                            break;
                        case 270:
                            flipType = RotateFlipType.Rotate270FlipNone;
                            break;
                        default:
                            flipType = RotateFlipType.RotateNoneFlipNone;
                            break;
                    }
                    furniture.FImage.RotateFlip(flipType);
                }
            }
            pictureBox1.Invalidate();
        }

        private void btSofa_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.BuildingSofa;
            _tempFurniture = new Furniture("Sofa", (Image)Resources.ResourceManager.GetObject("Sofa"), new Point(0, 0), 0);
        }

        private void btChair_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.BuildingChair;
            _tempFurniture = new Furniture("Chair", (Image)Resources.ResourceManager.GetObject("Chair"), new Point(0, 0), 0);
        }

        private void btArmChair_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(sender as Button);
            _mode = Mode.BuildingArmChair;
            _tempFurniture = new Furniture("ArmChair", (Image)Resources.ResourceManager.GetObject("ArmChair"), new Point(0, 0), 0);
        }

        private void OnMouseWheelEvent(object sender, MouseEventArgs e)
        {
            _tempFurniture.Rotation += 90;
            _tempFurniture.Rotation %= 360;
            _tempFurniture?.FImage.RotateFlip(RotateFlipType.Rotate90FlipNone);

        }


    }
}