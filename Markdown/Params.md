> **Created on Tue Mar 01 0900 2022 @author : Mumeng Yang & Minghan Cen - 山水比德产学研合作项目（参数化设计数字技术示范课程建设）**
> 
# 1.Params

## 1.1 Geometry
### 1.1.1 Point
在场景中拾取或绘制点.
<a href=""><img src="imgs\appendix_component\1_1_Point.png" height="auto" width=1000 title="caDesign"></a >

### 1.1.2 Vector
矢量是一种既有大小又有方向的量
<a href=""><img src="./imgs/appendix_component/1_1_Vector.png" height="auto" width=1000 title="caDesign"></a >

### 1.1.3 Circle 
圆，只能绘制，不能拾取现有的圆
<a href=""><img src="./imgs/appendix_component/1_1_Circle.png" height="auto" width=1000 title="caDesign"></a >

### 1.1.4 Circular Arc 
圆弧，只能绘制，不能拾取现有的圆弧
<a href=""><img src="imgs\appendix_component\1_1_Circular Arc.png" height="auto" width=1000 title="caDesign"></a >

### 1.1.5 Curve 
曲线，可拾取所有类型的线，包括直线，但不能绘制圆弧，也可用来快速提取曲面的边缘线


### 1.1.6 Line 
直线，只能绘制或接入其他输入端，不能拾取现有的直线
<a href=""><img src="imgs\appendix_component\1_1_Circular Arc.png" height="auto" width=1000 title="caDesign"></a >

### 1.1.7 Plane 
工作平面，可通过点击三个点自定义工作平面，不能拾取
<a href=""><img src="imgs\appendix_component\1_1_Plane.png" height="auto" width=1000 title="caDesign"></a >

### 1.1.8 Rectangle 
矩形，只能绘制，不可拾取现有矩形
<a href=""><img src="./imgs/appendix_component/1_1_Rectangle.png" height="auto" width=1000 title="caDesign"></a >

### 1.1.9 Box 
盒子，只能绘制，不能拾取现有的盒子
<a href=""><img src="./imgs/appendix_component/1_1_Box.png" height="auto" width=1000 title="caDesign"></a >

### 1.1.10 Brep
多重曲面，可以拾取曲面与多重曲面

### 1.1.11 Mesh
网格

### 1.1.12 Mesh Face 
网格面序

### 1.1.13 SubD
直接拾取Rhino中的SubD细分物件

### 1.1.14 Surface 
拾取单一曲面，若把平面曲线输入给Surface即可自动封面

### 1.1.14 Twisted Box 
输入扭曲立方体，可根据Box到Twisted Box的变化对物体进行变形

### 1.1.15 Field 
输入磁场。

### 1.1.16 Geometry 
输入几何体，可以拾取GH中几乎一切物件

### 1.1.17 Geometry Cache 
记录几何缓存，可先把GH中的物体Bake到Rhino中进行手动操作（除炸开、修剪分割等破坏物体整体性的操作），再重新拾取回GH中继续深化处理

### 1.1.18 Geometry Pipeline 
链接图层物件，在layer层输入图层名称，在Type里双击激活对应类型的输入数据即可输出对应几何体类型。但是目前只支持Point、Curve、Brep和mesh，其他例如文字、注释等都不能拾取，得依靠其他插件。

如果想选取子图层物件，则在母图层名后+冒号+子图层名。例：1:A
<a href=""><img src="./imgs\appendix_component\1_1_Geometry Pipeline1.png" height="auto" width=1000 title="caDesign"></a >
<a href=""><img src="./imgs\appendix_component\1_1_Geometry Pipeline2.png" height="auto" width=1000 title="caDesign"></a >



### 1.1.19 Group 
群组，不能拾取或绘制任何物件，仅可用来对电池组进行管理

### 1.1.20 Transform
变形，用来记录旋转、缩放、变形等一系列数据

# __________________________________
## 1.2 Primitive

### 1.2.1 Boolean
布尔值，True对应1，False对应0
<a href=""><img src="./imgs/appendix_component/1_2_Boolean.png" height="auto" width=1000 title="caDesign"></a >

### 1.2.2 Interger
整数，自带四舍五入功能
<a href=""><img src="./imgs/appendix_component/1_2_Interger.png" height="auto" width=1000 title="caDesign"></a >

### 1.2.3 Number 
小数
<a href=""><img src="./imgs/appendix_component/1_2_Number.png" height="auto" width=1000 title="caDesign"></a >

### 1.2.4 Text
文本，可以输入文字，包含数字的文字可直接被其他运算器识别
<a href=""><img src="./imgs/appendix_component/1_2_Text.png" height="auto" width=1000 title="caDesign"></a >

### 1.2.5 Colour 
颜色，可点击右键设置RGB值
<a href=""><img src="./imgs/appendix_component/1_2_Colour.png" height="auto" width=1000 title="caDesign"></a >

### 1.2.6 Complex
复数（形如z=a+bi（a、b均为实数）的数）
<a href=""><img src="./imgs/appendix_component/1_2_Complex.png" height="auto" width=1000 title="caDesign"></a >

### 1.2.7 Culture
文化国家，存储了世界上所有国家，可点击右键按照国家、语言、区域等不同方式进行选择
<a href=""><img src="./imgs/appendix_component/1_2_Culture.png" height="auto" width=1000 title="caDesign"></a >

### 1.2.8 Domain
区间，可用来制定数值范围
<a href=""><img src="./imgs/appendix_component/1_2_Domain.png" height="auto" width=1000 title="caDesign"></a >

### 1.2.9 Domian²
输入二维区间，可用来制定2个数值范围，一般用于曲面。

### 1.2.10 Guid
全局唯一标识符，是一种由算法生成的唯一标识，通常表示成32个16进制数字组成的字符串，用于标识Rhino中任意的物件，每一个物件都有自己独有的标识，即使是复制的。
<a href=""><img src="./imgs/appendix_component/1_2_Guid.png" height="auto" width=1000 title="caDesign"></a >


### 1.2.11 Matrix
输入矩阵，“是一个按照长方阵列排列的复数或实数集合”

### 1.2.12 Time
时间，可用来存储日期、时分秒等时间数据
<a href=""><img src="./imgs/appendix_component/1_2_Time.png" height="auto" width=1000 title="caDesign"></a >

### 1.2.13 Data
数据，可存储所有的数据，但数据类型不清晰
<a href=""><img src="./imgs/appendix_component/1_2_Data.png" height="auto" width=1000 title="caDesign"></a >

### 1.2.14 Data Path
数据路径，存储数据结构路径名称，格式为{A;B;C}
<a href=""><img src="./imgs/appendix_component/1_2_Data_Path.png" height="auto" width=1000 title="caDesign"></a >

### 1.2.15 File Path 
文件路径，点击右键即可选择文件、路径或文件夹
<a href=""><img src="./imgs/appendix_component/1_2_File_Path.png" height="auto" width=1000 title="caDesign"></a >

### 1.2.16 Shader 
着色器，点击右键即可直接选取Rhino中默认存在的材质

# _________________________________ 
## 1.3 Input

### 1.3.1 Slider 
数据拉杆，用于输入数值
<a href=""><img src="./imgs/appendix_component/1_3_Number_Slider.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.2 Panel
便签，用于输入或者展示文字、数据等
<a href=""><img src="./imgs/appendix_component/1_3_Panel.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.3 Boolean Toggle 
布尔开关，用于输出True或者False的布尔值，双击可改变值
<a href=""><img src="./imgs/appendix_component/1_3_Boolean_Toggle.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.4 Button
布尔按钮，用于瞬时改变布尔值，点击切换，松开鼠标便还原
<a href=""><img src="./imgs/appendix_component/1_3_Button.gif" height="auto" width=1000 title="caDesign"></a >

### 1.3.5 Control Knob
控制旋钮，双击可编辑范围数值
<a href=""><img src="./imgs/appendix_component/1_3_Control_Knob.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.6 Digit Scroller 
数字卷轴，可直接拖动改变小数点位数与数值大小
<a href=""><img src="./imgs/appendix_component/1_3_Digit_ Scroller.gif" height="auto" width=1000 title="caDesign"></a >

### 1.3.7 MD Slider
多维滑块
<a href=""><img src="./imgs/appendix_component/1_3_MD_Slider.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.8 Value List
数据列表，可单击右键选edit，输入特定的表达式进行自由编辑与计算
<a href=""><img src="./imgs/appendix_component/1_3_Value_List.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.9 Calendar 
日历，可通过滑动年月日获取静态日期
<a href=""><img src="./imgs/appendix_component/1_3_Calendar.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.10 Clock
时钟，可通过修改分秒时来获取静态时间
<a href=""><img src="./imgs/appendix_component/1_3_Clock.gif" height="auto" width=1000 title="caDesign"></a >

### 1.3.11 Colour Picker 
颜色选择器，提供一个由色调H、饱和度S、明度V构成的三维空间
<a href=""><img src="./imgs/appendix_component/1_3_Color_Picker.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.12 Colour Swatch
颜色采样器，右键即可选取颜色
<a href=""><img src="./imgs/appendix_component/1_3_Color_Swatch.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.13 Colour Wheel 
色轮，一般用于可控的给予一个或多个随机颜色。输入端输入想要输出的颜色数量，然后根据自带的选项控制颜色的输出。

表盘上的Sat表示饱和度，Lum表示亮度，通过滑杆控制，越往右数值越高。  

<a href=""><img src="imgs\appendix_component\1_3_Colour Wheel.gif" height="auto" width=1000 title="caDesign"></a >

色轮还提供了色彩范围的数量，右击下滑菜单可以选择，从单色到四色。  

<a href=""><img src="imgs/appendix_component/1_3_Colour Wheel2.gif" height="auto" width=1000 title="caDesign"></a >

默认还提供3种颜色分布选取预设。

<a href=""><img src="imgs\appendix_component\1_3_Colour Wheel3.gif" height="auto" width=1000 title="caDesign"></a >


### 1.3.14 Gradient 
渐变色，先给定上下限，再给定区间内的数值，即可根据Parameter端输入的数值在范围内基于颜色。

<a href=""><img src="./imgs/appendix_component/1_3_Gradient.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.15 Graph Mapper 
图形映射器，通过对曲线的调整可以改变输入数值的变化趋势，实际上是描述了一个y=kx的构造函数，利用函数重新映射输入的值。
自带了11种函数的预设。

<a href=""><img src="./imgs/appendix_component/1_3_Graph Mapper.png" height="auto" width=1000 title="caDesign"></a >

<a href=""><img src="./imgs/appendix_component/1_3_Graph Mapper2.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.16 Image Sampler 
图像采集器，通过输入图片，根据预设可以读取图片的灰度通道、RGB通道、alpha通道、饱和度通道等然后输出相关的数据，常用与图像干扰。  

<a href=""><img src="./imgs/appendix_component/1_3_Image Sampler.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.17 Import PDB + Atom Data
导入蛋白质数据库文件（Protein Data Bank），蛋白质数据库是一个专门收录蛋白质及核酸的三维结构资料的数据库。这个数据库是开源的，相关文件可在 https://www.rcsb.org/3d-view/6SDC 中寻找。  

通过Atom Data运算器可以提取PDB文件里蛋白质的结构信息、温度等数据。

<a href=""><img src="./imgs\appendix_component\1_3_Import PDB + Atom Data.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.18 Image Resource
一个在GH界面预览图片的运算器，右击可以选择加载本地还是在线图片。

<a href=""><img src="./imgs\appendix_component\1_3_Image Resource1.png" height="auto" width=1000 title="caDesign"></a >

<a href=""><img src="./imgs\appendix_component\1_3_Image Resource2.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.19 Import 3DM
导入3DM文件，3DM文件为Rhino的模型文件格式。

### 1.3.20 Import Coordinates
可从没有多余字符的txt文件中导入坐标,xyz输入索引值可调整显示位置。

<a href=""><img src="./imgs\appendix_component\1_3_Import Coordinates.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.21 Import Image
以一个网格导入图像，图像的默认xy采样是图片自身的分辨率，若图像分辨率过高可能会导致软件卡顿。

<a href=""><img src="./imgs\appendix_component\1_3_Import Image.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.22 Import SHP
导入GIS的Shp文件,第一次导入的时候可能会出现报错：“未在本地计算机上注册"Microsoft.ACE.OLEDB.12.0"提供程序”,这是由于计算机没有安装数据读取插件引起的。可在微软官网 ***https://www.microsoft.com/en-us/download/details.aspx?id=54920*** 里下载

<a href=""><img src="./imgs\appendix_component\1_3_Import SHP.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.23 Object Details
物件详细信息，可以获得拾取物件的图层、名称、颜色等详细信息

<a href=""><img src="./imgs\appendix_component\1_3_Object Detail.png" height="auto" width=1000 title="caDesign"></a >

### 1.3.24 Read File 
读取文件，把所有文件转换成txt后打开
<a href=""><img src="./imgs/appendix_component/1_3_Read_File.png" height="auto" width=1000 title="caDesign"></a >


# __________________________________
## 1.4 Util

### 1.4.2 Cherry Picker 
数据选择器，可在指定的数据结构里按序号选取数据
<a href=""><img src="./imgs/appendix_component/1_4_Cherry_Picker.png" height="auto" width=1000 title="caDesign"></a >

### 1.4.3 Jump 
视窗跳跃，双击后能从操作界面的一端跳到另外一端，适用于运算器较多的情况
<a href=""><img src="./imgs/appendix_component/1_4_Jump.gif" height="auto" width=1000 title="caDesign"></a >

### 1.4.4 Param Viewer 
数据结构查看器，可用文字或图形的方式表示数据结构的形态
<a href=""><img src="./imgs/appendix_component/1_4_Param_Viewer.png" height="auto" width=1000 title="caDesign"></a >

### 1.4.5 Scribble 
标注，可输入文字对电池组进行标注
<a href=""><img src="./imgs/appendix_component/1_4_Scribble.png" height="auto" width=1000 title="caDesign"></a >

### 1.4.6 Data Dam 
数据流控制器，可防止运算量过大导致的文件奔溃，缓解计算压力
一旦数据发生改变则会暂停传输数据，点击播放键可解除暂停状态
<a href=""><img src="./imgs/appendix_component/1_4_Data_Dam.gif" height="auto" width=1000 title="caDesign"></a >

### 1.4.7 Data Recorder 
数据记录器，点击左侧红球既可关闭或开启记录，右侧的X可删除现有记录
<a href=""><img src="./imgs/appendix_component/1_4_Data_Recorder.gif" height="auto" width=1000 title="caDesign"></a >

### 1.4.8 Relay 
中继运算器，避免线遮挡、相交带来的阻碍，可在连线上双击即可出现
<a href=""><img src="./imgs/appendix_component/1_4_Relay.gif" height="auto" width=1000 title="caDesign"></a >

### 1.4.9 Suifify 
简化数据结构,是Simplify Tree的加强版，一般用于单股数据的简化。

<a href=""><img src="./imgs\appendix_component\1_4_Suirify.png" height="auto" width=1000 title="caDesign"></a >

### 1.4.10 Timer/Trigger 
计时器，按照指定时间刷新
<a href=""><img src="./imgs/appendix_component/1_4_Trigger.gif" height="auto" width=1000 title="caDesign"></a >

### 1.4.11 Cluster Input & 1.4.12 Cluster Output 
算法打包的输入端和输出端

<a href=""><img src="./imgs\appendix_component\1_4_Cluster Input & Cluster Output.png" height="auto" width=1000 title="caDesign"></a >

### 1.4.12 Data Input & 1.4.14 Data Output 
数据输入与输出，可把GH中包含数据结构的数据作为文件形式输出，常用与协同工作流，这样对方就不需要完整的运算器组即可运行提供的数据。

<a href=""><img src="./imgs\appendix_component\1_4_Data Output & Data Input.gif" height="auto" width=1000 title="caDesign"></a >

### 1.4.13 Fitness Landscape 
适应度景观，可用来分析景观中的高度、坡度等，也可自动生成等高线。
但是效果一般，用得较少。


### 1.4.14 Galapagos 
遗传算法计算器
<blockquote>遗传算法最早是由美国的John holland根据大自然中生物进化规律而设计提出的，是模拟达尔文生物进化论的早期选择和遗传学机理的生物进化过程的计算模型。该算法利用计算机仿真运算，将问题的求解过程转换成类似生物进化中的染色体基因的交叉、变异等过程。<blockquote>
<a href=""><img src="./imgs/appendix_component/1_4_Galapagos.png" height="auto" width=1000 title="caDesign"></a >

### 1.4.15 Gene Pool
基因池，常和遗传算法配合使用
<a href=""><img src="./imgs/appendix_component/1_4_Genepool.png" height="auto" width=1000 title="caDesign"></a >

