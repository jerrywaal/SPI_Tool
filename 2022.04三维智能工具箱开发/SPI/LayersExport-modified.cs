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
            pManager.AddTextParameter("LayerName", "LN", "Layers'Name", GH_ParamAccess.item, "SPI");
            pManager.AddColourParameter("LayerColour", "LC", "Layers'Colour", GH_ParamAccess.item, Color.FromArgb(255, 0, 0, 0));
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {

        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            List<GeometryBase> Objects = new List<GeometryBase>();
            bool Activate = false;
            string LayerName = "SPI";
            Color C = Color.FromArgb(255, 0, 0, 0);

            DA.GetDataList(0, Objects);
            DA.GetData(1, ref Activate);
            DA.GetData(2, ref LayerName);
            DA.GetData(3, ref C);

            if (Activate)
            {
                Rhino.RhinoDoc Doc = Rhino.RhinoDoc.ActiveDoc;

                foreach (Object obj in Objects)
                {
                    if (obj == null)
                    {
                        return;
                    }


                    Guid NewId = default;

                    var Layer = Doc.Layers.FindName(LayerName, RhinoMath.UnsetIntIndex);
                    if (Layer == null)
                    {
                        Doc.Layers.Add(LayerName, C);
                    }

                    int Layerindex = Doc.Layers.FindName(LayerName, RhinoMath.UnsetIntIndex).Index;

                    ObjectAttributes Att = new ObjectAttributes
                    {
                        Name = "",
                        LayerIndex = Layerindex
                    };

                    if (obj is GeometryBase)
                    {
                        GeometryBase GeoObj = obj as GeometryBase;

                        switch (GeoObj.ObjectType)
                        {
                            case Rhino.DocObjects.ObjectType.Brep:
                                NewId = Doc.Objects.AddBrep(obj as Brep, Att);
                                break;
                            case Rhino.DocObjects.ObjectType.Curve:
                                NewId = Doc.Objects.AddCurve(obj as Curve, Att);
                                break;
                            case Rhino.DocObjects.ObjectType.Point:
                                NewId = Doc.Objects.AddPoint((obj as Rhino.Geometry.Point).Location, Att);
                                break;
                            case Rhino.DocObjects.ObjectType.Surface:
                                NewId = Doc.Objects.AddSurface(obj as Surface, Att);
                                break;
                            case Rhino.DocObjects.ObjectType.Mesh:
                                NewId = Doc.Objects.AddMesh(obj as Mesh);
                                break;
                            case Rhino.DocObjects.ObjectType.Extrusion:
                                NewId = Doc.Objects.AddExtrusion(obj as Extrusion);
                                break;
                            case Rhino.DocObjects.ObjectType.PointSet:
                                NewId = Doc.Objects.AddPointCloud(obj as PointCloud, Att);
                                break;

                            default:
                                return;
                        }

                    }
                    else
                    {
                        Type ObjectType = obj.GetType();

                        if (ObjectType == typeof(Arc))
                        {
                            NewId = Doc.Objects.AddArc((Arc)obj, Att);
                        }
                        else if (ObjectType == typeof(Box))
                        {
                            NewId = Doc.Objects.AddBox((Box)obj, Att);
                        }
                        else if (ObjectType == typeof(Circle))
                        {
                            NewId = Doc.Objects.AddCircle((Circle)obj, Att);
                        }
                        else if (ObjectType == typeof(Ellipse))
                        {
                            NewId = Doc.Objects.AddEllipse((Ellipse)obj, Att);
                        }
                        else if (ObjectType == typeof(Polyline))
                        {
                            NewId = Doc.Objects.AddPolyline((Polyline)obj, Att);
                        }
                        else if (ObjectType == typeof(Sphere))
                        {
                            NewId = Doc.Objects.AddSphere((Sphere)obj, Att);
                        }
                        else if (ObjectType == typeof(Point3d))
                        {
                            NewId = Doc.Objects.AddPoint((Point3d)obj, Att);
                        }
                        else if (ObjectType == typeof(Line))
                        {
                            NewId = Doc.Objects.AddLine((Line)obj, Att);
                        }
                        else if (ObjectType == typeof(Vector3d))
                        {
                            
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