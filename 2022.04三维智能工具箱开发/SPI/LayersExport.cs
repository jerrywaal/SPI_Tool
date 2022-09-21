using System;
using System.Collections;
using System.Collections.Generic;

using Rhino;
using Rhino.DocObjects;
using Rhino.Geometry;
using Grasshopper;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Data;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using Rhino.Collections;
using GH_IO;
using GH_IO.Serialization;


namespace SPI
{
    public class LayersExport : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the MyComponent1 class.
        /// </summary>
        public LayersExport()
          : base("Layer Object Export", "LOE",
              "Bake objects with layers into Rhino Document",
              "SPI", "Tool")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddGeometryParameter("Objects", "OBJ", "Objects to bake", GH_ParamAccess.list);
            pManager.AddBooleanParameter("Activate", "A", "true to bake", GH_ParamAccess.item, false);
            pManager.AddTextParameter("LayerName", "LN", "Layers'Name", GH_ParamAccess.item,"SPI");
            pManager.AddColourParameter("LayerColour", "LC", "Layers'Colour", GH_ParamAccess.item, Color.FromArgb(255, 0, 0, 0));
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddBooleanParameter("B", "BB", "b", GH_ParamAccess.item);
            pManager.AddTextParameter("C", "CC", "b", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            bool Activate = false;
            string LayerName = "SPI";
            Color C = Color.FromArgb(255, 255, 255, 255);
            List<Object> OBJ = new List<object>();

            DA.GetDataList(0, OBJ);
            DA.GetData(1, ref Activate);
            DA.GetData(2, ref LayerName);
            DA.GetData(3, ref C);

            
            if (Activate)
            {
                //int groupIndex = -1;
                Rhino.RhinoDoc Doc = Rhino.RhinoDoc.ActiveDoc;

  

                var layer = Doc.Layers.FindName(LayerName, RhinoMath.UnsetIntIndex);
                if (layer == null)
                {
                    Doc.Layers.Add(LayerName, C);
                }

                int layerIndex = Doc.Layers.FindName(LayerName, RhinoMath.UnsetIntIndex).Index;
                //set attributes
                Rhino.DocObjects.ObjectAttributes att = new Rhino.DocObjects.ObjectAttributes
                {
                    Name = "",
                    LayerIndex = layerIndex
                };

                //bake with attrbutes
                //RhinoDocument.Objects.Add(obj, att);

                foreach (System.Object obj in OBJ)
                {
                    Guid id;
                    if (obj is GeometryBase)
                    {
                        GeometryBase GeoObj = obj as GeometryBase;

                        switch (GeoObj.ObjectType)
                        {
                            case Rhino.DocObjects.ObjectType.Brep:
                                id = Doc.Objects.AddBrep(obj as Brep, att);
                                break;
                            case Rhino.DocObjects.ObjectType.Curve:
                                id = Doc.Objects.AddCurve(obj as Curve, att);
                                break;
                            case Rhino.DocObjects.ObjectType.Point:
                                id = Doc.Objects.AddPoint((obj as Rhino.Geometry.Point).Location, att);
                                break;
                            case Rhino.DocObjects.ObjectType.Surface:
                                id = Doc.Objects.AddSurface(obj as Surface, att);
                                break;
                            /* case Rhino.DocObjects.ObjectType.SubD:
                                 id = Doc.Objects.AddSubD(obj as SubD, att);
                                 break;*/
                            case Rhino.DocObjects.ObjectType.Mesh:
                                id = Doc.Objects.AddMesh(obj as Mesh);
                                break;
                            case Rhino.DocObjects.ObjectType.Extrusion:
                                id = Doc.Objects.AddExtrusion(obj as Extrusion);
                                break;
                            case Rhino.DocObjects.ObjectType.PointSet:
                                id = Doc.Objects.AddPointCloud(obj as PointCloud, att);
                                break;
                            default:
                                //Print("unknown " + obj.GetType().FullName + "to deal with");
                                return;
                        }

                        bool B = obj is GeometryBase;
                        string D = GeoObj.ObjectType.ToString();
                        DA.SetData(0, B);
                        DA.SetData(1, D);
                    }

                    else
                    {
                        Type ObjectType = obj.GetType();

                        if (ObjectType == typeof(Arc))
                        {
                            id = Doc.Objects.AddArc((Arc)obj, att);
                        }
                        else if (ObjectType == typeof(Box))
                        {
                            id = Doc.Objects.AddBox((Box)obj, att);
                        }
                        else if (ObjectType == typeof(Circle))
                        {
                            id = Doc.Objects.AddCircle((Circle)obj, att);
                        }
                        else if (ObjectType == typeof(Ellipse))
                        {
                            id = Doc.Objects.AddEllipse((Ellipse)obj, att);
                        }
                        else if (ObjectType == typeof(Polyline))
                        {
                            id = Doc.Objects.AddPolyline((Polyline)obj, att);
                        }
                        else if (ObjectType == typeof(Sphere))
                        {
                            id = Doc.Objects.AddSphere((Sphere)obj, att);
                        }
                        else if (ObjectType == typeof(Point3d))
                        {
                            id = Doc.Objects.AddPoint((Point3d)obj, att);
                        }
                        else if (ObjectType == typeof(Line))
                        {
                            id = Doc.Objects.AddLine((Line)obj, att);
                        }
                        else if (ObjectType == typeof(Vector3d))
                        {
                            //Print("Cannot bake vectors");
                            return;
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("04180B07-D9B4-40B6-AEED-0996E79B9EB7"); }
        }
    }
}