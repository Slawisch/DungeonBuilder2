using System;
using System.Drawing;
using System.Xml.Serialization;

namespace DungeonBuilder2
{
    [XmlInclude(typeof(Bitmap))]
    [Serializable]
    public class Furniture : BuildingComponent

    {
        [XmlIgnore]
    public Image FImage { get; set; }
    public string FType { get; set; }
    public Point Location { get; set; }
    public int Rotation { get; set; }

    public Furniture()
    {
    }

    public Furniture(string type, Image img, Point ptLocation, int rotation)
    {
        FType = type;
        FImage = img;
        Location = ptLocation;
        Rotation = rotation;
    }

    public override void Move(int cx, int cy)
    {
    }

    protected override void UpdatePosition()
    {
    }
    
    }
}