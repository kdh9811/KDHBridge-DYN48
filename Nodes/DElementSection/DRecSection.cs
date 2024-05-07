﻿using Autodesk.DesignScript.Geometry;
using KDHBridge_DYN48.Element.Section;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDHBridge_DYN48.Nodes.DElementSection
{
    public class DRecSection
    {
        private RecSection Section { get; }
        public List<Point> Vertices { get; }
        public Curve SectionCurve { get; }
        public Point Centeroid { get; }
        public Dictionary<string, double> Parameters { get; }
        public Dictionary<string, double> Properties { get; }

        public DRecSection(Plane sectionPlane, double width, double height)
        {
            Section = new RecSection(sectionPlane, width, height);
            Vertices = Section.Vertices;
            SectionCurve = Section.SectionCurve;
            Centeroid = Section.Centroid;
            Parameters = Section.SectionDimensions;
            Properties = Section.SectionProperties;
        }


    }
}
