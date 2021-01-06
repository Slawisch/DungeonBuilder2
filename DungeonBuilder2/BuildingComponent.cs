using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DungeonBuilder2
{
    [XmlInclude(typeof(Wall))]
    [XmlInclude(typeof(Door))]
    [XmlInclude(typeof(Window))]
    [XmlInclude(typeof(PolyWall))]
    [XmlInclude(typeof(Line))]
    [XmlInclude(typeof(Ruler))]
    [XmlInclude(typeof(Furniture))]
    [Serializable]
    public abstract class BuildingComponent
    {
        public Point[] Corners;
        public bool Movable { get; set; }
        public static BuildingComponent MovableComponent;
        protected abstract void UpdatePosition();
        public abstract void Move(int cx, int cy);
        
        public static void SetMovable(List<BuildingComponent> components, ref Point _lastMousePos, Point location)
        {
            foreach (var component in components)
            {
                if (location.IsInPolygon(component.Corners))
                {
                    if (BuildingComponent.MovableComponent != null)
                        BuildingComponent.MovableComponent.Movable = false;
                    component.Movable = true;
                    BuildingComponent.MovableComponent = component;
                    _lastMousePos = location;
                    break;
                }
            }
        }
    }
}