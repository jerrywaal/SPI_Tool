> **Created on Tue Mar 01 0900 2022 @author : Shunhua Hu - 山水比德产学研合作项目（参数化设计数字技术示范课程建设）**

# 9.Transform
## 9.1 Affine
### 9.1.1 Camera Obscura
利用小孔成像原理将物体进行变形翻转。

输入端 <span style = "color:indianred;background-color:lightgray">（Gemetry）</span> 拾取的物体以输入端 <span style = "color:indianred;background-color:lightgray">（Point）</span> 设定的镜像点利用小孔成像原理将物体根据输入端 <span style = "color:indianred;background-color:lightgray">（Factor）</span> 设定的缩放倍数进行变形翻转。

<a href=""><img src="imgs/appendix_component\9_1_Affine Camera Obscura.png" height="auto" width=600 title="caDesign"></a>


### 9.1.2 Scale
将物体在指定平面进行缩放。

输入端 <span style = "color:indianred;background-color:lightgray">（Gemetry）</span> 拾取的物体以输入端 <span style = "color:indianred;background-color:lightgray">（Point）</span> 设定的缩放中心将物体根据输入端 <span style = "color:indianred;background-color:lightgray">（Factor）</span> 设定的缩放比例进行缩放。

<a href=""><img src="imgs/appendix_component\9_1_Affine Scale1.png" height="auto" width=600 title="caDesign"></a>
<a href=""><img src="imgs/appendix_component\9_1_Affine Scale2.png" height="auto" width=600 title="caDesign"></a>

### 9.1.3 Scale NU
根据指定的缩放中心平面将物体进行 <span style = "color:indianred;background-color:lightgray">(X、Y、Z)</span> 三轴可控的缩放，其中三轴的方向就是指定平面 <span style = "color:indianred;background-color:lightgray">（plane）</span> 的三轴方向。

<a href=""><img src="imgs/appendix_component\9_1_Affine Scale NU.png" height="auto" width=600 title="caDesign"></a>

### 9.1.4 Shear
通过参照点和目标点决定的矢量方向来对物体进行倾斜变形。

输入端 <span style = "color:indianred;background-color:lightgray">（Gemetry）</span> 拾取要变形的物体，以输入端 <span style = "color:indianred;background-color:lightgray">（Base）</span> 为参考平面，根据输入端 <span style = "color:indianred;background-color:lightgray">（Grip）</span> 参考点 和输入端 <span style = "color:indianred;background-color:lightgray">（Target）</span> 目标点与参考平面中心点的距离作为变形比例，变形角度以参考点与参考平面的Z轴角度等值转化。

<a href=""><img src="imgs/appendix_component\9_1_Affine Shear.png" height="auto" width=600 title="caDesign"></a>

### 9.1.5 Shear Angle
根据输入围绕xy轴的绕转角度来对物体进行倾斜。

输入端 <span style = "color:indianred;background-color:lightgray">（Gemetry）</span> 拾取要变形的物体，以输入端 <span style = "color:indianred;background-color:lightgray">（Base）</span> 为参考平面，分别根据输入端 <span style = "color:indianred;background-color:lightgray">（Angle X）</span> 和输入端 <span style = "color:indianred;background-color:lightgray">（Angle Y）</span> 的角度进行倾斜变形。

<a href=""><img src="imgs/appendix_component\9_1_Affine Shear Angle1.png" height="auto" width=600 title="caDesign"></a>
<a href=""><img src="imgs/appendix_component\9_1_Affine Shear Angle2.png" height="auto" width=600 title="caDesign"></a>

### 9.1.6 Box Mapping
根据sou rce盒子和Target盒子之间的变形差距对物体进行变形。

<a href=""><img src="imgs/appendix_component\9_1_Affine Box Mapping.png" height="auto" width=600 title="caDesign"></a>

### 9.1.7 Orient Direction
参照两组矢量之间的变形变形来对吻体进行映射变形j可以看到韧体前后根据AB两组矢量的变化进行了相对应的缩放和旋转。

输入端 <span style = "color:indianred;background-color:lightgray">（Point A）</span> 和输入端 <span style = "color:indianred;background-color:lightgray">（Point B）</span> 控制映射参考点。输入端 <span style = "color:indianred;background-color:lightgray">（Direction A）</span> 和输入端 <span style = "color:indianred;background-color:lightgray">（Direction B）</span> 控制映射比例和方向。
<a href=""><img src="imgs/appendix_component\9_1_Affine Orient Direction.png" height="auto" width=600 title="caDesign"></a>

### 9.1.8 Project
将物体投影到指定平面P。

<a href=""><img src="imgs/appendix_component\9_1_Affine Project.png" height="auto" width=600 title="caDesign"></a>

### 9.1.9 Project Along
将物体根据指定投影方向D投影到指定平面P。

<a href=""><img src="imgs/appendix_component\9_1_Affine Project Along.png" height="auto" width=600 title="caDesign"></a>

### 9.1.10 Rectangle Mapping
矩形映射，根据垣形之间的变形来对物体进行变形，因此只有二维的变形。

<a href=""><img src="imgs/appendix_component\9_1_Affine Rectangle Mapping.png" height="auto" width=600 title="caDesign"></a>

### 9.1.11 Triangle Mapping
三角形映射，根据三角形之间的变形来对物体进行变形，因此只有二维的变形。

输入端 <span style = "color:indianred;background-color:lightgray">（Source）</span> 和输入端 <span style = "color:indianred;background-color:lightgray">（Target）</span> 都是三角形。需要注意的输入端 <span style = "color:indianred;background-color:lightgray">（Source）</span> 的三角形的角点顺序和输入端 <span style = "color:indianred;background-color:lightgray">（Target）</span> 的三角形的角点顺序会影响映射方向，如图所示：

<a href=""><img src="imgs/appendix_component\9_1_Affine Triangle Mapping.png" height="auto" width=600 title="caDesign"></a>

## 9.2 Array
### 9.2.1 Curve Array
沿着曲线进行阵列。

输入端 <span style = "color:indianred;background-color:lightgray">（Curve）</span> 是阵列的参考线，输入端 <span style = "color:indianred;background-color:lightgray">（Count）</span> 为阵列数量，输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 是阵列数量之一，并作为阵列的起点。

<a href=""><img src="imgs/appendix_component\9_2_Array Curve Array.png" height="auto" width=600 title="caDesign"></a>

### 9.2.2 Linear Array
直线阵列。
输入端 <span style = "color:indianred;background-color:lightgray">（Direction）</span> 控制阵列方向和距离，输入端 <span style = "color:indianred;background-color:lightgray">（Count）</span> 为阵列数量，输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 是阵列数量之一，并作为阵列的起点。

<a href=""><img src="imgs/appendix_component\9_2_Array Linear Array.png" height="auto" width=600 title="caDesign"></a>

### 9.2.3 Polar Array
弧形阵列。

半径是输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 的中心点到输入端 <span style = "color:indianred;background-color:lightgray">（Plane）</span> 的中心点的距离，输入端 <span style = "color:indianred;background-color:lightgray">（Angle）</span> 是阵列角度范围，输入端 <span style = "color:indianred;background-color:lightgray">（Count）</span> 是阵列数量，并作为阵列角度范围的等分数量。

<a href=""><img src="imgs/appendix_component\9_2_Array Polar Array.png" height="auto" width=600 title="caDesign"></a>

### 9.2.4 Rectangular Array
矩形阵列。

根据输入端 <span style = "color:indianred;background-color:lightgray">（Cell）</span> 绘制的矩形的两条边控制阵列的方向和距离，输入端 <span style = "color:indianred;background-color:lightgray">（X Count）</span> 控制 X 轴阵列数量，输入端 <span style = "color:indianred;background-color:lightgray">（Y Count）</span> 控制 Y 轴阵列数量，输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 是要阵列的物体。

<a href=""><img src="imgs/appendix_component\9_2_Array Rectangular Array.png" height="auto" width=600 title="caDesign"></a>

### 9.2.5 Box Array
三维阵列。

根据输入端 <span style = "color:indianred;background-color:lightgray">（Cell）</span> 绘制的 Box 的长、宽、高控制阵列的方向和距离，输入端 <span style = "color:indianred;background-color:lightgray">（X Count）</span> 控制 X 轴阵列数量，输入端 <span style = "color:indianred;background-color:lightgray">（Y Count）</span> 控制 Y 轴阵列数量，输入端 <span style = "color:indianred;background-color:lightgray">（Z Count）</span> 控制 Z 轴阵列数量，输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 是要阵列的物体。

<a href=""><img src="imgs/appendix_component\9_2_Array Box Array.png" height="auto" width=600 title="caDesign"></a>

### 9.2.6 Kaleidoscope
万花筒复制。

在输入端 <span style = "color:indianred;background-color:lightgray">（Plane）</span> 指定的平面上以该平面的中心点为圆心，以中心点和输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 要阵列的物体的中心点的距离为半径进行圆弧阵列，输入端 <span style = "color:indianred;background-color:lightgray">（Segments）</span> 控制数量。

<a href=""><img src="imgs/appendix_component\9_2_Array Kaleidoscope.png" height="auto" width=600 title="caDesign"></a>

## 9.3 Euclidean
### 9.3.1 Mirror
根据指定平面将物体进行镜像。

输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 是要阵列的物体，输入端 <span style = "color:indianred;background-color:lightgray">（Plane）</span> 是指定的镜像平面。

<a href=""><img src="imgs/appendix_component\9_3_Euclidean Mirror.png" height="auto" width=600 title="caDesign"></a>

### 9.3.2 Move
根据指定向量移动物体。

根据输入端 <span style = "color:indianred;background-color:lightgray">（Motion）</span>
输入的向量的方向和长度移动物体。

<a href=""><img src="imgs/appendix_component\9_3_Euclidean Move.png" height="auto" width=600 title="caDesign"></a>

### 9.3.3 Move Away From
将物体沿着远离指定物体的方向进行移动。

输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 物体与输入端 <span style = "color:indianred;background-color:lightgray">（Emitter）</span> 物体的位置关系决定移动方向，移动距离由输入端 <span style = "color:indianred;background-color:lightgray">（Distance）</span> 控制。

<a href=""><img src="imgs/appendix_component\9_3_Euclidean Move Away From.png" height="auto" width=600 title="caDesign"></a>

### 9.3.4 Move To Plane
将物体移动到指定平面上。

输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 物体上到输入端 <span style = "color:indianred;background-color:lightgray">（Plane）</span> 平面最近点或最远点（当物体在平面的上方时取最近点，在平面下方时取最远点）作为移动到指定平面的基准点。输入端 <span style = "color:indianred;background-color:lightgray">（Above）</span> 和输入端 <span style = "color:indianred;background-color:lightgray">（Below）</span> 根据物体与平面的位置关系控制是否移动物体。

<a href=""><img src="imgs/appendix_component\9_3_Euclidean Move To Plane.png" height="auto" width=600 title="caDesign"></a>

### 9.3.5 Orient
将物体按物体与参考平面的位置关系移动到目标平面上。

输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 是要移动的物体，输入端 <span style = "color:indianred;background-color:lightgray">（Source）</span> 是参考平面，输入端 <span style = "color:indianred;background-color:lightgray">（Target）</span> 是目标平面。

<a href=""><img src="imgs/appendix_component\9_3_Euclidean Orient.png" height="auto" width=600 title="caDesign"></a>

### 9.3.6 Rotate
将物体在指定平面进行旋转。

输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 是要旋转的物体，输入端 <span style = "color:indianred;background-color:lightgray">（Angle）</span> 是旋转角度（注意：这里的旋转角度是弧度制），输入端 <span style = "color:indianred;background-color:lightgray">（Plane）</span> 是指定的旋转参考平面。

<a href=""><img src="imgs/appendix_component\9_3_Euclidean Rotate.png" height="auto" width=600 title="caDesign"></a>

### 9.3.7 Rotate 3D
将物体根据一个点和一个矢量方向形成的轴进行绕轴旋转。

输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 是要旋转的物体，输入端 <span style = "color:indianred;background-color:lightgray">（Angle）</span> 是旋转角度（注意：这里的旋转角度是弧度制），输入端 <span style = "color:indianred;background-color:lightgray">（Center）</span> 指定的点和输入端 <span style = "color:indianred;background-color:lightgray">（Axis）</span> 指定的向量组成了旋转轴。

<a href=""><img src="imgs/appendix_component\9_3_Euclidean Rotate 3D.png" height="auto" width=600 title="caDesign"></a>

### 9.3.8 Rotate Axis
将物体根据指定直线作为旋转轴进行旋转。注：该电池的旋转作用跟 <span style = "color:indianred;background-color:lightgray">（Rotate 3D）</span> 相同。

输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 是要旋转的物体，输入端 <span style = "color:indianred;background-color:lightgray">（Angle）</span> 是旋转角度（注意：这里的旋转角度是弧度制），输入端 <span style = "color:indianred;background-color:lightgray">（Axis）</span> 是指定的直线（既旋转轴）。

<a href=""><img src="imgs/appendix_component\9_3_Euclidean Rotate Axis.png" height="auto" width=600 title="caDesign"></a>

### 9.3.9 Rotate Direction
将物体从一个方向旋转到另一个方向。

输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 是要旋转的物体，输入端 <span style = "color:indianred;background-color:lightgray">（Center）</span> 是旋转的基准点，输入端 <span style = "color:indianred;background-color:lightgray">（From）</span> 是旋转参考方向，输入端 <span style = "color:indianred;background-color:lightgray">（To）</span> 是旋转目标方向。

<a href=""><img src="imgs/appendix_component\9_3_Euclidean Rotate Direction.png" height="auto" width=600 title="caDesign"></a>

## 9.4 Morph
### 9.4.1 Blend Box
提取两个面中的一部分得到两个新的面，然后再提取两个新面的4个角点，按一一对应的点序号把八个点用直线连接成体。注意：同一个新曲面的4个角点有可能共点，同时输出的 <span style = "color:indianred;background-color:lightgray">（wisted Box）</span> 是体，不是线。

<a href=""><img src="imgs/appendix_component\9_4_Morph Blend Box.png" height="auto" width=600 title="caDesign"></a>

### 9.4.2 Surface Box
根据曲面uv区间，提取对应曲面然后提取四个点直线连接挤出厚度H生成Twisted Box。注意这一步会进行曲化直操作，毕竟得到的是twist box，边都是直线。

<a href=""><img src="imgs/appendix_component\9_4_Morph Surface Box.png" height="auto" width=600 title="caDesign"></a>

### 9.4.3 Box Morph
将输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 输入的物体根据输入端 <span style = "color:indianred;background-color:lightgray">（Reference）</span> 输入的 <span style = "color:indianred;background-color:lightgray">（Box）</span> 和输入端 <span style = "color:indianred;background-color:lightgray">（Target）</span> 输入的形变关系进行映射，是一种曲面流动的方法。

<a href=""><img src="imgs/appendix_component\9_4_Morph Box Morph.png" height="auto" width=600 title="caDesign"></a>

### 9.4.4 Twisted Box
根据八个点生成扭转 <span style = "color:indianred;background-color:lightgray">（Box）</span> 。

注意：输入端的点前后四个点有对应关系，<span style = "color:indianred;background-color:lightgray">（A-E,B-F,C-G.D-H）</span> ，并以直线形式相连。

<a href=""><img src="imgs/appendix_component\9_4_Morph Twisted Box.png" height="auto" width=600 title="caDesign"></a>

### 9.4.5 Bend Deform
根据给定的圆弧对物体进行弯曲变形。

输入端 <span style = "color:indianred;background-color:lightgray">（Bending Arc）</span> 输入的圆弧的长度与输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 要变形的物体长度的比会影响变形范围。详见下图：

<a href=""><img src="imgs/appendix_component\9_4_Morph Bend Deform1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_4_Morph Bend Deform2.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_4_Morph Bend Deform3.png" height="auto" width=600 title="caDesign"></a>

### 9.4.6 Flow
沿曲线流动。

输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 是要流动的物体，以输入端 <span style = "color:indianred;background-color:lightgray">（Base）</span> 的曲线和流动物体的位置关系为基准，把物体流动到输入端 <span style = "color:indianred;background-color:lightgray">（Target）</span> 的曲线上，输入端 <span style = "color:indianred;background-color:lightgray">（Stretch）</span> 控制是否延展变形。

<a href=""><img src="imgs/appendix_component\9_4_Morph Flow1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_4_Morph Flow2.png" height="auto" width=600 title="caDesign"></a>

### 9.4.7 Maelstrom
对物体进行绕转。

<a href=""><img src="imgs/appendix_component\9_4_Morph Maelstrom.png" height="auto" width=600 title="caDesign"></a>

### 9.4.8 Mirror Curve
根据曲线对物体进行镜像。

<a href=""><img src="imgs/appendix_component\9_4_Morph Mirror Curve1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_4_Morph Mirror Curve2.png" height="auto" width=600 title="caDesign"></a>

### 9.4.9 Mirror Surface
基于曲面对物体进行镜像并变形。

<a href=""><img src="imgs/appendix_component\9_4_Morph Mirror Surface.png" height="auto" width=600 title="caDesign"></a>

### 9.4.10 Splop
定位物件至曲面

注意：输入端 <span style = "color:indianred;background-color:lightgray">（Surface）</span> 输入的曲面的法线方向会影响输入端 <span style = "color:indianred;background-color:lightgray">（Geometry）</span> 输入的物体的定位方向。

<a href=""><img src="imgs/appendix_component\9_4_Morph Splop.png" height="auto" width=600 title="caDesign"></a>

### 9.4.11 Sporph
物体在曲面间流动变形。

输入端 <span style = "color:indianred;background-color:lightgray">（Parameter）</span> 控制曲面流动的起点位置。输入端 <span style = "color:indianred;background-color:lightgray">（Rigid）</span> 控制是否刚性流动。

注意：通过修改输入端 <span style = "color:indianred;background-color:lightgray">（Target）</span> 输入的目标曲面的U、V方向可实现流动方向的变化。

<a href=""><img src="imgs/appendix_component\9_4_Morph Sporph1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_4_Morph Sporph2.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_4_Morph Sporph3.png" height="auto" width=600 title="caDesign"></a>

### 9.4.12 Stretch
物体在指定区域进行轴向缩放变形。

输入端 <span style = "color:indianred;background-color:lightgray">（Axis）</span> 输入的直线控制物体缩放的起始位置和缩放方向，同时直线长度与输入端 <span style = "color:indianred;background-color:lightgray">（Length）</span> 输入的长度之比是缩放比例。

<a href=""><img src="imgs/appendix_component\9_4_Morph Stretch.png" height="auto" width=600 title="caDesign"></a>

### 9.4.13 Surface Morph
物体在曲面间流动变形。

注意：输入端 <span style = "color:indianred;background-color:lightgray">（Reference）</span> 输入的是 <span style = "color:indianred;background-color:lightgray">（Box）</span> 。这也是改电池与电池<span style = "color:indianred;background-color:lightgray">（Sporph）</span> 的主要区别之处。

<a href=""><img src="imgs/appendix_component\9_4_Morph Surface Morph1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_4_Morph Surface Morph2.png" height="auto" width=600 title="caDesign"></a>

### 9.4.14 Taper
对物体进行锥状化变形。

输入端 <span style = "color:indianred;background-color:lightgray">（Start）</span> 和输入端 <span style = "color:indianred;background-color:lightgray">（End）</span> 的比之控制物体的变形起止范围。输入端 <span style = "color:indianred;background-color:lightgray">（Infinite）</span> 控制变形的方式，具体区别如下图：

<a href=""><img src="imgs/appendix_component\9_4_Morph Taper1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_4_Morph Taper2.png" height="auto" width=600 title="caDesign"></a>

### 9.4.15 Twist
根据角度和控制轴对物体扭转。

<a href=""><img src="imgs/appendix_component\9_4_Morph Twist1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_4_Morph Twist2.png" height="auto" width=600 title="caDesign"></a>

### 9.4.16 Map to Surface
曲线在曲面间流动。

<a href=""><img src="imgs/appendix_component\9_4_Morph Map to Surface.png" height="auto" width=600 title="caDesign"></a>

### 9.4.17 Point Deform
通过移动物体的控制点对物体进行变形。

注意：输入端 <span style = "color:indianred;background-color:lightgray">（Points）</span> 是物体的控制点。

<a href=""><img src="imgs/appendix_component\9_4_Morph Point Deform1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_4_Morph Point Deform2.png" height="auto" width=600 title="caDesign"></a>

### 9.4.18 Spatial Deform
通过控制点和矢量来对曲面进行变形。

注意：输入端 <span style = "color:indianred;background-color:lightgray">（Syntax）</span> 可是物体的控制点，也可以不是。但是变形效果比较突兀。

<a href=""><img src="imgs/appendix_component\9_4_Morph Spatial Deform1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_4_Morph Spatial Deform2.png" height="auto" width=600 title="caDesign"></a>

### 9.4.19 Spatial Deform (custom)
通过控制点和矢量来对曲面进行变形，和电池 <span style = "color:indianred;background-color:lightgray">（Spatial Deform）</span> 相比，增加了输入端 <span style = "color:indianred;background-color:lightgray">（Falloff）</span> ，但两个电池的变形效果类似。
<a href=""><img src="imgs/appendix_component\9_4_Morph Spatial Deform (custom).png" height="auto" width=600 title="caDesign"></a>

## 9.5 Util
### 9.5.1 Compound
将两种变形进行合并。

<a href=""><img src="imgs/appendix_component\9_5_Util Compound1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_5_Util Compound2.png" height="auto" width=600 title="caDesign"></a>

### 9.5.2 Split
将合并变形进行拆分。

<a href=""><img src="imgs/appendix_component\9_5_Util Split1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_5_Util Split2.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_5_Util Split3.png" height="auto" width=600 title="caDesign"></a>

### 9.5.3 Inverse Transform
将变形进行翻转。

<a href=""><img src="imgs/appendix_component\9_5_Util Inverse Transform1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_5_Util Inverse Transform2.png" height="auto" width=600 title="caDesign"></a>

### 9.5.4 Transform
将变形应用到物体。

<a href=""><img src="imgs/appendix_component\9_5_Util Transform1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_5_Util Transform2.png" height="auto" width=600 title="caDesign"></a>

### 9.5.5 Transform Matrix
变形信息矩阵表达。

<a href=""><img src="imgs/appendix_component\9_5_Util Transform Matrix.png" height="auto" width=600 title="caDesign"></a>

### 9.5.6 Group
将分组的所有数据构成群组数据，当作一个整体来运算处理。

<a href=""><img src="imgs/appendix_component\9_5_Util Group.png" height="auto" width=600 title="caDesign"></a>

### 9.5.7 Ungroup
群组数据取消群组，与电池组件 <span style = "color:indianred;background-color:lightgray">（Group）</span> 作用相反。

<a href=""><img src="imgs/appendix_component\9_5_Util Ungroup.png" height="auto" width=600 title="caDesign"></a>

### 9.5.8 Merge Group
将两个群组数据合并。

注意：合并的规则是以数据在单组数据中的同序号合并。

<a href=""><img src="imgs/appendix_component\9_5_Util Merge Group1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_5_Util Merge Group2.png" height="auto" width=600 title="caDesign"></a>

### 9.5.9 Split Group
以群组数据中单组数据的列表序号将群组数据一分为二。

注意：输入端 <span style = "color:indianred;background-color:lightgray">（Indices）</span> 输入的是列表，代表数据在组中的序号。

<a href=""><img src="imgs/appendix_component\9_5_Util Split Group1.png" height="auto" width=600 title="caDesign"></a>

<a href=""><img src="imgs/appendix_component\9_5_Util Split Group2.png" height="auto" width=600 title="caDesign"></a>