> **Created on Thur. Mar 24 0900 2022 @author : Minghan Cen - 山水比德产学研合作项目（参数化设计数字技术示范课程建设）**
# 7. Mesh
在Grasshopper中操作网格时，可以通过 ***Display-Preview Mesh Edges*** 打开预览网格边缘功能，操作时对网格的结构更清晰。

<a href=""><img src="./imgs\appendix_component\7_Preview Mesh Edges1.png" height="auto" width=1000 title="caDesign"></a>

<a href=""><img src="./imgs\appendix_component\7_Preview Mesh Edges2.png" height="auto" width=1000 title="caDesign"></a>

## 7.1 Analysis
### 7.1.1 Deconstruct Mesh
将网格拆解成顶点、网格面、颜色ARGB值和法线向量4个属性供后续调用。  

<a href=""><img src="./imgs\appendix_component\7_1_Deconstruct Mesh.png" height="auto" width=1000 title="caDesign"></a>

### 7.1.2 Deconstruct Face
将网格面拆分，输出结果是面顶点在网格顶点的序号。  

<a href=""><img src="./imgs\appendix_component\7_1_Deconstruct Face.png" height="auto" width=1000 title="caDesign"></a>

### 7.1.3 Face Normals
求每一个网格面的中心点和以及面的法线向量。  

<a href=""><img src="./imgs\appendix_component\7_1_Face Normals.png" height="auto" width=1000 title="caDesign"></a>

### 7.1.4 Mesh Edges
提取网格的边线、内线和非歧异边（也称作非流形边）。非流行边缘指由2个或2个以上面共享的边，这种边缘会导致网格操作时出现问题，应该尽量避免。  

<a href=""><img src="./imgs\appendix_component\7_1_Mesh Edges.png" height="auto" width=1000 title="caDesign"></a>

### 7.1.5 Face Boundaries

将每一个面的边缘提取合并形成多段线。  

<a href=""><img src="./imgs\appendix_component\7_1_Face Boundaries.png" height="auto" width=1000 title="caDesign"></a>

### 7.1.6 Face Circles
生成三角网格的外接圆。  

<a href=""><img src="./imgs\appendix_component\7_1_Face Circles.png" height="auto" width=1000 title="caDesign"></a>

### 7.1.7 Mesh Inclusion
判断点是否在网格内，并返回布尔值。  

<a href=""><img src="./imgs\appendix_component\7_1_Mesh Inclusion.png" height="auto" width=1000 title="caDesign"></a>

### 7.1.8 Mesh Closest Point
生成输入点到网格最近的点，并输出最近点、投影到的面序号、最近点在的网格参数。  

<a href=""><img src="./imgs\appendix_component\7_1_Mesh Closest Point.png" height="auto" width=1000 title="caDesign"></a>

### 7.1.9 Mesh Eval 

与Evaluate Surface相似，输入网格与点的网格参数，输出最近点、点在对应面的发现向量、对应面的颜色RGB。

<a href=""><img src="./imgs\appendix_component\7_1_Mesh Eval.png" height="auto" width=1000 title="caDesign"></a>

## 7.2 Primitive
### 7.2.1 Construct Mesh
与Deconstruct Mesh相对，根据输入的顶点、面（面的规则）、颜色构建网格。  

<a href=""><img src="./imgs\appendix_component\7_2_Construct Mesh.png" height="auto" width=1000 title="caDesign"></a>

### 7.2.2 Mesh Colours
赋予网格颜色，本质是对网格顶点赋予颜色。  

<a href=""><img src="./imgs\appendix_component\7_2_Mesh Colour1.png" height="auto" width=1000 title="caDesign"></a>

<a href=""><img src="./imgs\appendix_component\7_2_Mesh Colour2.png" height="auto" width=1000 title="caDesign"></a>

### 7.2.3 Mesh Quad
与Deconstruct Face相对，根据4个顶点序号生成四边面。  

<a href=""><img src="./imgs\appendix_component\7_2_Mesh Quad.png" height="auto" width=1000 title="caDesign"></a>

### 7.2.4 Mesh Spray
网格喷枪，输入的网格根据参考点的位置赋予颜色，输入的颜色数量要与参考点数量一致，同时可以右击运算器改变着色模式。

Nearest(点最近网格区域着色)
<a href=""><img src="./imgs\appendix_component\7_2_Mesh Spray1.png" height="auto" width=1000 title="caDesign"></a>

Furthest(点最远网格区域着色)
<a href=""><img src="./imgs\appendix_component\7_2_Mesh Spray2.png" height="auto" width=1000 title="caDesign"></a>

线性混合
<a href=""><img src="./imgs\appendix_component\7_2_Mesh Spray3.png" height="auto" width=1000 title="caDesign"></a>

区域混合
<a href=""><img src="./imgs\appendix_component\7_2_Mesh Spray4.png" height="auto" width=1000 title="caDesign"></a>

整体混合
<a href=""><img src="./imgs\appendix_component\7_2_Mesh Spray5.png" height="auto" width=1000 title="caDesign"></a>

### 7.2.5 Mesh Triangle
根据3个顶点序号生成三角面。 

<a href=""><img src="./imgs\appendix_component\7_2_Mesh Triangle.png" height="auto" width=1000 title="caDesign"></a>

### 7.2.6 Mesh Box
输入基本box，根据XYZ输入端调整盒子三轴方向网格划分。  

<a href=""><img src="./imgs\appendix_component\7_2_Mesh Box.png" height="auto" width=1000 title="caDesign"></a>

### 7.2.7 Mesh Plane
输入边界，根据宽高输入端调整Plane两轴方向网格划分。  

<a href=""><img src="./imgs\appendix_component\7_2_Mesh Plane.png" height="auto" width=1000 title="caDesign"></a>

### 7.2.8 Mesh Sphere
输入参考平面与半径，UV输入端调整网格球体的网格划分。  

<a href=""><img src="./imgs\appendix_component\7_2_Mesh Sphere.png" height="auto" width=1000 title="caDesign"></a>

### 7.2.9 Mesh Sphere Ex
输入参考平面与半径绘制的拓扑网格球体，这个球体并不是标准球体，而是由六个面拼合而成，Count输入端为六个面统一的网格划分数量。

<a href=""><img src="./imgs\appendix_component\7_2_Mesh Sphere Ex1.png" height="auto" width=1000 title="caDesign"></a>

## 7.3 Triangulation
### 7.3.1 Convex Hull
基于输入平面，求点集最外围点的连线，输出三维的连线、基于平面的二维连线和连线点的索引值。  

<a href=""><img src="./imgs\appendix_component\7_3_Convex Hull.png" height="auto" width=1000 title="caDesign"></a>

<a href=""><img src="./imgs\appendix_component\7_3_Convex Hull2.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.2 Delaunay Edges
根据输入平面和点在平面上的投影关系，将点与最近点相连生成三角形连线。输出为点与点的拓扑关系（相连点的索引值）和生成的直线。 如图，三维的点阵相连是根据投影到XY平面后的关系判断连接。

<a href=""><img src="./imgs\appendix_component\7_3_Delaunay Edges.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.3 Delaunay Mesh
<p>和<span style = "color:indianred;background-color:lightgray">Delaunay Edges</span>类似，这里是直接输出网格。</p>

<a href=""><img src="./imgs\appendix_component\7_3_Delaunay Mesh.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.4 Substrate
生成*Jared Tarbell*的Substrate纹理，可以模拟概念性的城市规划划分、冰裂纹等图案。  

Count输入端控制生成线的数量；Angeles端控制整体生成图案的旋转角度（数值以弧度值计算）；Deviation控制每一根生成线旋转的角度（数值以弧度值计算）；Seed为随机种子。

<a href=""><img src="./imgs\appendix_component\7_3_Substrate1.png" height="auto" width=1000 title="caDesign"></a>

<a href=""><img src="./imgs\appendix_component\7_3_Substrate.gif" height="auto" width=1000 title="caDesign"></a>

### 7.3.5 Facet Dome
根据输入点和box范围，生成逼近点的球体并生成泰森多边形的几何变形面，保留输入box的部分，同时输出生成的球体。

 <a href=""><img src="./imgs\appendix_component\7_3_Facet Dome.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.6 Voronoi
根据输入点生成二维Vronoi网络，Radius输入端控制每个点生成多边形的半径，Boundary输入端是矩形边界，Plane输入端控制生成的平面。  

 <a href=""><img src="./imgs\appendix_component\7_3_Voroni.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.7 Voronoi 3D
<p>和<span style = "color:indianred;background-color:lightgray">Vronoi</span>相似，这里是根据输入的点集生成三维的网格体。</p>  

Points输入端是可以指定生成点的位置。  

 <a href=""><img src="./imgs\appendix_component\7_3_Voronoi3D.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.8 Voronoi Cell
根据Points端输入的点生成Voronoi三维网格，然后剔除Neighbours输入端点所在的网格体，如果将两者输入点集数据对调，会发现结果是互补的。  

<a href=""><img src="./imgs\appendix_component\7_3_Voronoi Cell.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.9 Voronoi Groups
根据两组输入点集生成两个二维Voronoi网格，第一个输出端是依据第一组输入点生成的二维Voronoi网格，第二个输出端是筛选出第二组网格完全包围的第一组网格。  

<a href=""><img src="./imgs\appendix_component\7_3_Voronoi Groups.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.10 Octree
八叉树算法的三维结构生成。
>八叉树（Octree）是一种用于描述三维空间的树状数据结构。八叉树的每个节点表示一个正方体的体积元素，每个节点有八个子节点，这八个子节点所表示的体积元素加在一起就等于父节点的体积。一般中心点作为节点的分叉中心。八叉树若不为空树的话，树中任一节点的子节点恰好只会有八个，或零个，也就是子节点不会有0与8以外的数目。  
那么，这要用来做什么？想象一个立方体，我们最少可以切成多少个相同等分的小立方体？答案就是8个。再想象我们有一个房间，房间里某个角落藏着一枚金币，我们想很快的把金币找出来，聪明的你会怎么做？我们可以把房间当成一个立方体，先切成八个小立方体，然后排除掉没有放任何东西的小立方体，再把有可能藏金币的小立方体继续切八等份….如此下去，平均在Log8(房间内的所有物品数)的时间内就可找到金币。因此，Octree就是用在3D空间中的场景管理，可以很快地知道物体在3D场景中的位置，或侦测与其它物体是否有碰撞以及是否在可视范围内。

><a href=""><img src="./imgs\appendix_component\7_3_Octree1.png" height="auto" width=1000 title="caDesign"></a>
>引用来源：https://www.cnblogs.com/Glucklichste/p/11505743.html

运算器根据输入的点集（Points输入端）和每个正方体容纳的点数量来生成细分的立方体。

<a href=""><img src="./imgs\appendix_component\7_3_Octree2.png" height="auto" width=1000 title="caDesign"></a>

<a href=""><img src="./imgs\appendix_component\7_3_Octree3.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.11 Proximity 2D
根据输入的半径大小（Radius输入端），寻找每一个输入点(Points输入端)在投影平面（Plane输入端）后每一个点附近指定数量（Group输入端）的合集，并分组输出连线和拓扑关系（索引值）。  

<a href=""><img src="./imgs\appendix_component\7_3_Proximity 2D.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.12 Proximity 3D
<p>和<span style = "color:indianred;background-color:lightgray">Proximity 3D</span>相似，这里是根据输入的点集生成三维的结构。</p> 

<a href=""><img src="./imgs\appendix_component\7_3_Proximity 3D.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.13 QuadTree
四叉树结构，<p>和<span style = "color:indianred;background-color:lightgray">Octree</span>相似，四叉树在二维上对包含点的矩形根据每个矩形要包含点的数量进行细分。</p>

<a href=""><img src="./imgs\appendix_component\7_3_QuadTree.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.14 MetaBall
元球，是计算机图形学中的N维物体，样子是有机的球体，当靠近的时候可以融合在一起形成一个连续的物体，常用与有机体的建模以及基本网格体的雕刻。  
GH中这个运算器是根据输入的点集（Points输入端），投影到指定平面（Plane输入端）后生成经过指定点（Point输入端）的曲线，曲线根据元球特有规律生成。  

<a href=""><img src="./imgs\appendix_component\7_3_MetaBall.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.15 MetaBall(t)
输入点集（Points），投影到指定平面（Plane输入端）后，根据输入的Threshould值控制线的大小，输入值与线的大小成反比。  

<a href=""><img src="./imgs\appendix_component\7_3_Metaball(t).gif" height="auto" width=1000 title="caDesign"></a>

### 7.3.16 MetaBall(t)Custom
可调控的参数更多，增加了Charge值的调控，这个大小和曲线间隔大小成正比。

<a href=""><img src="./imgs\appendix_component\7_3_Metaball(t) Custom.gif" height="auto" width=1000 title="caDesign"></a>

### 7.3.17 Quad Remesh & Setting
网格的四边形重构，增加网格的合理性。通过这个功能再将网格转换为subd再转换为nurbs可以实现模型的反向转化。  

<a href=""><img src="./imgs\appendix_component\7_3_Quad Remesh & Setting.png" height="auto" width=1000 title="caDesign"></a>

### 7.3.18 TriRemesh
用尽可能相似的三角形网格均匀重构输入的几何体.还可以输出重构网格的对偶网格，对偶的原理是把相邻三角形中心点连线，得到的正好是六边形或者五边形图案。  
>TriRemesh是官方做的十分强大的网格重构运算器，更多的应用可以参考官方推文：https://mp.weixin.qq.com/s/fybUJXBrGTw2145P6dvsrQ

<a href=""><img src="./imgs\appendix_component\7_3_TriRemesh.png" height="auto" width=1000 title="caDesign"></a>

<a href=""><img src="./imgs\appendix_component\7_3_TriRemesh2.png" height="auto" width=1000 title="caDesign"></a>

## 7.4 Util
### 7.4.1 Mesh Brep & Setting
将输入的Breps转换成网格，可以附加setting运算器来调整。很多时候用于Rhino与其他软件的协作。  
GH也根据特性，分为追求转化精细度和转化速度内置了封装好的setting运算器。

<a href=""><img src="./imgs\appendix_component\7_4_Mesh Brep & Setting.png" height="auto" width=1000 title="caDesign"></a>

<a href=""><img src="./imgs\appendix_component\7_4_Mesh Brep & Setting2.png" height="auto" width=1000 title="caDesign"></a>

<a href=""><img src="./imgs\appendix_component\7_4_Mesh Brep & Setting3.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.2 Mesh Surface
基于UV方向指定数量分隔网格。

<a href=""><img src="./imgs\appendix_component\7_4_Mesh Surface.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.3 Simple Mesh
创建简单网格面，底层逻辑是提取面四个顶点生成网格。

<a href=""><img src="./imgs\appendix_component\7_4_Simple Mesh.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.4 Blur Mesh
<p>模糊网格颜色，和<span style = "color:indianred;background-color:lightgray">Mesh Spray</span>效果相似，Iterlations输入端决定了迭代次数，次数越多越自然。</p>

<a href=""><img src="./imgs\appendix_component\7_4_Blur Mesh.png" height="auto" width=1000 title="caDesign"></a>

<a href=""><img src="./imgs\appendix_component\7_4_Blur Mesh2.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.5 Cull Faces
根据输入的pattern规律来剔除网格面。True剔除面，False保留面

<a href=""><img src="./imgs\appendix_component\7_4_Cull Faces.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.6 Cull Vertices

<p>和<span style = "color:indianred;background-color:lightgray">Cull Faces</span>相似，Shrink输入端控制四边网格是否转换成三角网格。</p>

<a href=""><img src="./imgs\appendix_component\7_4_Cull Vertices.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.7 Delete Faces
根据输入的面的索引值来删除网格中的面。  

<a href=""><img src="./imgs\appendix_component\7_4_Delete Faces.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.8 Delete Vertices
根据输入的点的索引值来删除网格中的顶点。

<a href=""><img src="./imgs\appendix_component\7_4_Delete Vertices.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.9 Disjoint Mesh & Mesh Join
拆分网格与合并网格，Mesh与nurbs不同，没有互相连接也可以合并成一个Mesh，因为网格实际上是记录点和面的拓扑信息，并不是记录的具体几何图形，但是合并以后可以加快显示速度减少计算机负担。  
如果是互相连接的Mesh，合并以后就无法拆分了。  

<a href=""><img src="./imgs\appendix_component\7_4_Disjoint Mesh & Mesh Join.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.10 Mesh Shadow
生成网格根据向量（Light输入端）在指定平面（Plane输入端）投影的轮廓线。  

<a href=""><img src="./imgs\appendix_component\7_4_Mesh Shadow.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.11 Mesh Split Plane
用一个参考平面来分割网格，上下部分单独输出。

<a href=""><img src="./imgs\appendix_component\7_4_Mesh Split Plane.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.12 Smooth Mesh
平滑网格。

<a href=""><img src="./imgs\appendix_component\7_4_Smooth Mesh.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.13 Align Vertices
根据输入的精度来对齐网格顶点。  

<a href=""><img src="./imgs\appendix_component\7_4_Align Vertices.gif" height="auto" width=1000 title="caDesign"></a>

### 7.4.14 Flip Mesh
翻转网格方向。

<a href=""><img src="./imgs\appendix_component\7_4_Flip Mesh.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.15 Unify Mesh
统一网格方向，并输出结果以及判断网格是否翻转的布尔值。  

<a href=""><img src="./imgs\appendix_component\7_4_Unify Mesh.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.16 Triangulate
网格四边面转换成三角面。  

<a href=""><img src="./imgs\appendix_component\7_4_Triangulate.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.17 Quadrangulate
网格三角面转换成四边面。  

<a href=""><img src="./imgs\appendix_component\7_4_Quadrangulate.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.18 Weld Mesh & Unweld Mesh

根据最小角度（Angle端），判断相邻顶点是否焊接/不焊接。 焊接网格的本质是是否剔除相接网格的顶点。  如图例，面的数量没有变化，在焊接/不焊接前后，顶点的数量变化了。

<a href=""><img src="./imgs\appendix_component\7_4_Weld Mesh & Unweld Mesh.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.19 Exposure
生成网格与给定向量的遮挡关系，输出为每个网格顶点的光照量和所有光照量的数值范围，的可用于生成光照情况。  

<a href=""><img src="./imgs\appendix_component\7_4_Exposure.png" height="auto" width=1000 title="caDesign"></a>

### 7.4.20 Occlusion
同样计算遮挡关系，运算器输出的是网格是否遮挡测试点的布尔值。  

<a href=""><img src="./imgs\appendix_component\7_4_Occlusion.png" height="auto" width=1000 title="caDesign"></a>