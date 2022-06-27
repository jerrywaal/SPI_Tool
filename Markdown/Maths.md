> **Created on Tue Mar 01 0907 2022 @author : Minghan Cen - 山水比德产学研合作项目（参数化设计数字技术示范课程建设）**
# 2. Maths
## 2.1 Domain
### 2.1.1 Construct Domain
两个值形成数值区间，默认为0到1。  

<a href=""><img src="./imgs\appendix_component\2_1_Construct-Domain.png" height="auto" width=1000 title="caDesign"></a>

### 2.1.2 Deconstruct Domain
将区间分离成最大最小值。  

<a href=""><img src="./imgs\appendix_component\2_1_Deconstruct-Domain.png" height="auto" width=1000 title="caDesign"></a>

### 2.1.3 Bounds
将输入数据根据大小自动排列成区间，还可用于寻找一组数据的最大最小值。  

<a href=""><img src="./imgs\appendix_component\2_1_Bounds.png" height="auto" width=1000 title="caDesign"></a>

### 2.1.4 Consecutive Domains
将Numbers端输入的数据合并成数字区间，Additive端决定区间是否相加  

<a href=""><img src="./imgs\appendix_component\2_1_Consecutive-Domains.png" height="auto" width=1000 title="caDesign"></a>

### 2.1.5 Divide Domain
根据Count端输入的数字将一个区间等分成对应数量的区间  

<a href=""><img src="./imgs\appendix_component\2_1_Divide-Domain.png" height="auto" width=1000 title="caDesign"></a>

### 2.1.6 Find Domain
查询Number端输入数值所在给定区间（Domains端）并返回对应的编号（Index端）。  若数值不在输入区间内，则返回“-1”。  
Strict端决定输入数值能否等于极值，**True代表数值只能在区间内，False代表数值可以等于极值。**  
Neighbour端返回值代表有多少个区间数值小于输入数值，不管输入数值是否在区间内。  

<a href=""><img src="./imgs\appendix_component\2_1_Find-Domain.png" height="auto" width=1000 title="caDesign"></a>

### 2.1.7 Includes
判断一个输入数值（Value端），是否在指定区间内（Domain端），返回布尔值（Includes端）和数值与区间的差值（Deviation端），如果输入数值不在区间内，返回数值为输入数值与区间极值的差值。  

<a href=""><img src="./imgs\appendix_component\2_1_Includes.png" height="auto" width=1000 title="caDesign"></a>

### 2.1.8 Remap Numbers
根据给予参考目标区间（Target端），让输入区间（Source端）中的数据（Value端）重新映射（排布）。    

<a href=""><img src="./imgs\appendix_component\2_1_Remap-1.png" height="auto" width=1000 title="caDesign"></a>  
各种点、线、图像干扰是常见的用法。  
<a href=""><img src="./imgs\appendix_component\2_1_Remap-2.png" height="auto" width=1200 title="caDesign"></a>  

### 2.1.9 Construct Domain²
根据输入UV方向的极值或者区间来创建二维区间。  

<a href=""><img src="./imgs\appendix_component\2_1_Construct Domain².png" height="auto" width=1000 title="caDesign"></a>  

### 2.1.10 Deconstruct Domain²
拆分二维区间成4个数值或两个数字区间。  

<a href=""><img src="./imgs\appendix_component\2_1_Deconstruct Domain².png" height="auto" width=1000 title="caDesign"></a>

### 2.1.11 Bounds 2D
对于输入点整体所占区域给予XY范围区间。类似bounding box。  

<a href=""><img src="./imgs\appendix_component\2_1_Bounds 2D.png" height="auto" width=1000 title="caDesign"></a>

### 2.1.12 Divide Domain²
根据UV端输入的数字来等分二维区间，常用与配合isotrim对曲面进行重新划分。  

<a href=""><img src="./imgs\appendix_component\2_1_Deconstruct Domain².png" height="auto" width=1000 title="caDesign"></a>  


## 2.2 Matrix
> “在数学中，矩阵（Matrix）是一个按照长方阵列排列的复数或实数集合，最早来自于方程组的系数及常数所构成的方阵。这一概念由19世纪英国数学家凯利首先提出。”  
> 矩阵本质上是一个按照长方阵列排列的复数或实数集合


矩阵是高等数学的代数工具，在GH中应用得相对较少。
### 2.2.1 Construct Matrix
根据输入的行（Row端）列（Column端）以及输入的数值（Value端）创建一个矩阵。  
输入的数值数量要么是单个数值，要么是数量等于行列数相乘的一组数据。  

<a href=""><img src="./imgs\appendix_component\2_2_Construct-Matrix.png" height="auto" width=1000 title="caDesign"></a>
<a href=""><img src="./imgs\appendix_component\2_2_Construct-Matrix-3.png" height="auto" width=1000 title="caDesign"></a>  
<a href=""><img src="./imgs\appendix_component\2_2_Construct-Matrix-2.png" height="auto" width=1000 title="caDesign"></a>  

### 2.2.2 Deconstruct Matrix
拆分矩阵为对应的行列数值以及包含的数值。  

<a href=""><img src="./imgs\appendix_component\2_1_Deconstruct-Domain.png" height="auto" width=1000 title="caDesign"></a> 

### 2.2.3 Display Matrix
用于将矩阵可视化。右键可更改显示的小数位数。  

<a href=""><img src="./imgs\appendix_component\2_2_Matrix-Display.png" height="auto" width=1000 title="caDesign"></a> 

### 2.2.4 Invert Matrix
为输入矩阵输出反向矩阵变换  

<a href=""><img src="./imgs\appendix_component\2_2_Invert-Matrix.png" height="auto" width=1000 title="caDesign"></a>

### 2.2.5 Transpose Matrix
翻转矩阵行列数值，创建新的矩阵。  

<a href=""><img src="./imgs\appendix_component\2_2_Transpose-Matrix.png" height="auto" width=1000 title="caDesign"></a>

### 2.2.6 Swap Rows & Swap Columns
将输入A端索引值的行/列与B端输入索引值得行/列在矩阵中的位置替换。  

<a href=""><img src="./imgs\appendix_component\2_2_Swap-Rows & Coloumns.png" height="auto" width=1000 title="caDesign"></a>

## 2.3 Operator
### 2.3.1 Addition
可以放大运算器手动添加或减少输入个数。  

<a href=""><img src="./imgs\appendix_component\2_3_Addition.png" height="auto" width=1000 title="caDesign"></a>  

### 2.3.2 Subtraction
<a href=""><img src="./imgs\appendix_component\2_3_Subtraction.png" height="auto" width=1000 title="caDesign"></a> 

### 2.3.3 Multiplication
<a href=""><img src="./imgs\appendix_component\2_3_Multiplication.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.4 Division
<a href=""><img src="./imgs\appendix_component\2_3_Division.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.5 Negative
负值。
<a href=""><img src="./imgs\appendix_component\2_3_Negative.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.6 Power
次方运算，计算A端输入数值的B端输入数值的次方结果。
<a href=""><img src="./imgs\appendix_component\2_3_Subtraction.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.7 Absolute
绝对值。
<a href=""><img src="./imgs\appendix_component\2_3_Absolute.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.8 Factorial
阶乘。
<a href=""><img src="./imgs\appendix_component\2_3_Factorial.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.9 Integer Division
整数除法，本质是去除了余数。
<a href=""><img src="./imgs\appendix_component\2_3_Integer-Division.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.10 Modulus
余数。
<a href=""><img src="./imgs\appendix_component\2_3_Modulus.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.11 Mass Addition
数据叠加，会输出总的叠加值和阶段运算结果。  

<a href=""><img src="./imgs\appendix_component\2_3_Mass-Addition.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.12 Mass Multiplication
数据叠乘，会输出总的叠乘值和阶段运算结果。  

<a href=""><img src="./imgs\appendix_component\2_3_Mass-Multiplication.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.13 Relative Differences
相对差值，根据索引值，数据列表中的后一项减前一项。  

<a href=""><img src="./imgs\appendix_component\2_3_Relative-Diferences.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.14 Equality
判断两个输入端的数值是否相等，然后输出布尔值。  

<a href=""><img src="./imgs\appendix_component\2_3_Equality.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.15 Similarity
根据容差的百分比（Threshould端）判断两个输入数值是否相似，输出为布尔值（Similarity端）和差值（Absolute difference端）。  
如图，就是47%的容差值，输出为Ture，差值为5。  

<a href=""><img src="./imgs\appendix_component\2_3_Similarity.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.16 Larger Than
判断第一个输入值是否大于或大于等于第二个输入值，输出为布尔值。  

<a href=""><img src="./imgs\appendix_component\2_3_Larger-than.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.17 Smaller Than
判断第一个输入值是否小于或小于等于第二个输入值，输出为布尔值。  

<a href=""><img src="./imgs\appendix_component\2_3_Smaller-than.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.18 Gate And
计算机语言中，True代表1，False代表0。  

Gate And则是“与门”的可视化运算器，放大可以手动增减输入端数量，与门作用为判断所有输入的布尔值，输出为布尔值。若均为True，则返回True，若有任意数量的False，则输出为False。  

<a href=""><img src="./imgs\appendix_component\2_3_Gate-And.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.19 Gate Not
“非门”可视化运算器。反转输入的布尔值。  

<a href=""><img src="./imgs\appendix_component\2_3_Gate-Not.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.20 Gate Or
“或门”可视化运算器。只要输入的布尔值有True，输出的判断布尔值既是True。放大可以手动增减输入端数量 。  

<a href=""><img src="./imgs\appendix_component\2_3_Gate-Or.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.21 Gate Xor
“异或门”可视化运算器。判断输入的布尔值是否不一致，若不一致则输出True，若一致则输出False。  

<a href=""><img src="./imgs\appendix_component\2_3_Gate-Xor.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.22 Gate Majority
“三输入多与门”可视化运算器。当大于等于两个输入端为True时，输出判定为True,否则均输出为False。  

<a href=""><img src="./imgs\appendix_component\2_3_Gate-Majority.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.23 Gate Nand
“与非门”可视化运算器。“与门”+“非门”若输入的布尔值有任意数量的False，输出为True，否则输出为False。  

<a href=""><img src="./imgs\appendix_component\2_3_Gate-Nand.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.24 Gate Nor
“或非门”可视化运算器。“或门”+“非门”  

<a href=""><img src="./imgs\appendix_component\2_3_Gate-Nor.png" height="auto" width=1000 title="caDesign"></a>

### 2.3.25 Gate Xnor
“或非门”可视化运算器。当输入的布尔值一致时，输出True,否则输出为False。  

<a href=""><img src="./imgs\appendix_component\2_3_Gate-Xnor.png" height="auto" width=1000 title="caDesign"></a>

## 2.4 Polynomials
### 2.4.1 Cube & Cube Root
立方&立方根计算。  

<a href=""><img src="./imgs\appendix_component\2_4_Cube.png" height="auto" width=1000 title="caDesign"></a>

### 2.4.2 Square & Square Root
平方&平方根计算  

<a href=""><img src="./imgs\appendix_component\2_4_Square.png" height="auto" width=1000 title="caDesign"></a>

### 2.4.3 Square & Square Root
倒数,例如例图5的倒数就是0.2。  

<a href=""><img src="./imgs\appendix_component\2_4_One-Over-X.png" height="auto" width=1000 title="caDesign"></a>

### 2.4.4 Power of 10
幂，输入数值为对应10的次方计算。  

<a href=""><img src="./imgs\appendix_component\2_4_Power-of-10.png" height="auto" width=1000 title="caDesign"></a>

### 2.4.5 Power of 2
输入数值对应2的次方计算。  

<a href=""><img src="./imgs\appendix_component\2_4_Power-of-2.png" height="auto" width=1000 title="caDesign"></a>

### 2.4.5 Power of e
输入数值对应e常量的次方计算。  

<a href=""><img src="./imgs\appendix_component\2_4_Power-of-e.png" height="auto" width=1000 title="caDesign"></a>

### 2.4.6 Log N & Logarithm & Natrue Logarithm
对数计算。看运算器图标可知，Log N是求特定基数（Base端）的对数，log为基数为10的对数，ln为求自然对数。  
这三个运算器使用较少。  

<a href=""><img src="./imgs\appendix_component\2_4_Log.png" height="auto" width=1000 title="caDesign"></a>

## 2.5 Script
### 2.5.1 Evaluate
可以输入表达式来对数据进行处理，放大运算器可以手动增减输入端数量，右击输入端可以更改名字。  
也可以右击运算器进入editor手动输入表达式。  

<a href=""><img src="./imgs\appendix_component\2_5_Evaluate-1.png" height="auto" width=1000 title="caDesign"></a>

<a href=""><img src="./imgs\appendix_component\2_5_Evaluate-2.png" height="auto" width=1000 title="caDesign"></a>

### 2.5.2 Expression
由运算器名字可知，是一个同样来书写表达式进行数据处理的运算器。

<a href=""><img src="./imgs\appendix_component\2_5_Expression.png" height="auto" width=1000 title="caDesign"></a>

### 2.5.3 C# Script & Pthon Script & VB Script
GH提供了这三种语言的内置编辑运算器，GH自带的运算器并不能完全满足所有的使用，这里就给予了使用者二次开发的环境。  
相比在类似vs的编译平台中编辑，GH的内置编辑器已经把开发环境配置好，同时和其他运算器使用一样，可以即时地观察代码编译效果和即时调整。  

<a href=""><img src="./imgs\appendix_component\2_5_Script.png" height="auto" width=1000 title="caDesign"></a>

## 2.6 Time
### 2.6.1 Construct Date
自定义日期和时间，右击运算器可以根据当前系统时间设置当前日期和时间。  

<a href=""><img src="./imgs\appendix_component\2_6_Construct-Date.png" height="auto" width=1000 title="caDesign"></a>

### 2.6.2 Construct Exotic Date
根据选择不同国家的历法，输入公历创建农历。

<a href=""><img src="./imgs\appendix_component\2_6_Construct-Exotic-Date.png" height="auto" width=1000 title="caDesign"></a>

### 2.6.3 Construct Smooth Time
创建一段时间。  

<a href=""><img src="./imgs\appendix_component\2_6_Construct-Smooth-Time.png" height="auto" width=1000 title="caDesign"></a>

### 2.6.4 Construct Time
创建具体时间。    

<a href=""><img src="./imgs\appendix_component\2_6_Construct-Time.png" height="auto" width=1000 title="caDesign"></a>

### 2.6.5 Deconstruct Date
拆分时间。  

<a href=""><img src="./imgs\appendix_component\2_6_Deconstruct-Date.png" height="auto" width=1000 title="caDesign"></a>

### 2.6.6 Combine Date & Time
合并日期与时间。  

<a href=""><img src="./imgs\appendix_component\2_6_Combine-Date & Time.png" height="auto" width=1000 title="caDesign"></a>

### 2.6.7 Date-Range
根据输入的数值（Count端）等分时间。  

<a href=""><img src="./imgs\appendix_component\2_6_Date-Range.png" height="auto" width=1000 title="caDesign"></a>

### 2.6.8 Interpolate Date
计算日期的运算器，规则为： Date A + Interpolation端的输入值*Date B - Date A的差值。  
如图例，Date B-Date A=1:00:00; 1:00:00(Date A)+1/2/3 * 1:00：00（差值）= 2/3/4：00:00。  

<a href=""><img src="./imgs\appendix_component\2_6_Interpolate-Date.png" height="auto" width=1000 title="caDesign"></a>

## 2.7 Trig
### 2.7.1 Sine & Cosine & Tangent
经典的三角函数,正弦、余弦和正切函数。  

<a href=""><img src="./imgs\appendix_component\2_7_Sin & Cos & Tan.png" height="auto" width=1000 title="caDesign"></a>

### 2.7.2 Sinc
辛格函数。  
<a href=""><img src="./imgs\appendix_component\2_7_Sinc-1.png" height="auto" width=450 title="caDesign"></a>

<a href=""><img src="./imgs\appendix_component\2_7_Sinc-2.png" height="auto" width=1000 title="caDesign"></a>

### 2.7.3 ArcCosine & ArcSine & ArcTangent
反三角函数。  

<a href=""><img src="./imgs\appendix_component\2_7_ArcSin & Cos & Tan.png" height="auto" width=1000 title="caDesign"></a>

### 2.7.4 Secant & CoSecant & CoTangent
**Secant**:某直角三角形中，一个锐角的斜边与其邻边的比（即角A斜边比邻边）,叫做该锐角的正割，用 sec（角）表示。  
**CoSecant**：直角三角形某个锐角的斜边与对边的比，叫做该锐角的余割，用 csc（角）表示。  
**CoTangent**：某锐角的相邻直角边和对边的比，用cot表示。  

<a href=""><img src="./imgs\appendix_component\2_7_Secant & CoSecant & CoTangent.png" height="auto" width=1000 title="caDesign"></a>

### 2.7.5 Degrees & Radians
角度和弧度转换运算器。GH中涉及角度的默认为弧度，但是现在这些运算器都可以右击更改为Degrees计算。弧度等于 X*pi。  

<a href=""><img src="./imgs\appendix_component\2_7_Degrees & Radians.png" height="auto" width=1000 title="caDesign"></a>

### 2.7.7 Right Trigonometry
直角三角形生成运算器，输入满足形成直角三角形的数值，剩下的数值运算器会自动算出。角度输入端可调整为角度输入，但是角度的输出结果默认为弧度。若输入结果不满足运算器还会自动报错。

<a href=""><img src="./imgs\appendix_component\2_7_Right Trigonometry.png" height="auto" width=1000 title="caDesign"></a>

### 2.7.8 Triangle Trigonometry
任意三角形生成运算，输入输出规则和直角三角生成运算器相同。  

<a href=""><img src="./imgs\appendix_component\2_7_Triangle Trigonometry.png" height="auto" width=1000 title="caDesign"></a>

### 2.7.9 Centroid
计算三角形的重心，也就是三条边中线的交点。

<a href=""><img src="./imgs\appendix_component\2_7_Centroid.png" height="auto" width=1000 title="caDesign"></a>

### 2.7.10 Incentre
计算三角形的内心，即内切圆圆心，三个内角角平分线的交点。  

<a href=""><img src="./imgs\appendix_component\2_7_Incentre.png" height="auto" width=1000 title="caDesign"></a>

### 2.7.11 Circumcentre
计算三角形外接圆圆心，即三条边垂直平分线交点。  

<a href=""><img src="./imgs\appendix_component\2_7_Circumcentre.png" height="auto" width=1000 title="caDesign"></a>

### 2.7.12 Circumcentre
计算三角形垂心，即三条高线的交点。  

<a href=""><img src="./imgs\appendix_component\2_7_Orthocentre.png" height="auto" width=1000 title="caDesign"></a>

## 2.8 Util
### 2.8.1 Epsilon
第五个希腊字母，一般在数学用在极限领域，表示非常小。

<a href=""><img src="./imgs\appendix_component\2_8_Epsilon.png" height="auto" width=1000 title="caDesign"></a>

### 2.8.2 Golden Ration
著名的黄金比例，来源于贵金属比例的第一项。其比例与其倒数是一样的，1：1.618的倒数是0.618，而1.618:1与1:0.618是一样的

<a href=""><img src="./imgs\appendix_component\2_8_Golden Ratio.png" height="auto" width=1000 title="caDesign"></a>

### 2.8.3 Natural Logarithm & Pi
经典的自然常数和Pi。  

<a href=""><img src="./imgs\appendix_component\2_8_e & pi.png" height="auto" width=1000 title="caDesign"></a>

### 2.8.4 Extremes
对比求输入数据列表中数据的极值。放大运算器可以手动增减输入端数量。  

<a href=""><img src="./imgs\appendix_component\2_8_Extremes.png" height="auto" width=1000 title="caDesign"></a>

### 2.8.5 Maximum & Minimum
相当于Extremes电池的功能拆分。 

<a href=""><img src="./imgs\appendix_component\2_8_Max & Mini.png" height="auto" width=1000 title="caDesign"></a>

### 2.8.6 Round
Nearest端就是四舍五入，Floor端是最接近这个数的最小整数，Ceiling端是最接近这个数的整数。也可以直接用Integer运算器达到四舍五入取整的效果。  

<a href=""><img src="./imgs\appendix_component\2_8_Round-1.png" height="auto" width=1000 title="caDesign"></a>  

也可以用表达式来控制小数点。  

<a href=""><img src="./imgs\appendix_component\2_8_Round-2.png" height="auto" width=1000 title="caDesign"></a>  

### 2.8.7 Average
求平均，可以求平均数，也可以求中心点。  

<a href=""><img src="./imgs\appendix_component\2_8_Average-1.png" height="auto" width=1000 title="caDesign"></a>  

<a href=""><img src="./imgs\appendix_component\2_8_Average-2.png" height="auto" width=1000 title="caDesign"></a>  

### 2.8.8 Interpolate Data
根据输入的数据/点和参数值（Parameter端）来输出处于输入数据范围内的数值/点。  放大运算器还可以调整数据的插入类型。  

<a href=""><img src="./imgs\appendix_component\2_8_Interpolate Data-1.png" height="auto" width=1000 title="caDesign"></a>   

<a href=""><img src="./imgs\appendix_component\2_8_Interpolate Data-2.gif" height="auto" width=1000 title="caDesign"></a>   

<a href=""><img src="./imgs\appendix_component\2_8_Interpolate Data-3.gif" height="auto" width=1000 title="caDesign"></a>   

### 2.8.9 Truncate
计算机语法，用于将计数重置归零重新计算。  

<a href=""><img src="./imgs\appendix_component\2_8_Truncate.png" height="auto" width=1000 title="caDesign"></a> 

### 2.8.10 Blur Numbers
模糊数列，减少相邻数据的波动。  

<a href=""><img src="./imgs\appendix_component\2_8_Blur Numbers.png" height="auto" width=1000 title="caDesign"></a> 

### 2.8.11 Smooth Numbers
在选择的时间后，数据会平滑的变动，，右击运算器可以选则时间长短。  

<a href=""><img src="./imgs\appendix_component\2_8_Smooth Numbers.gif" height="auto" width=1000 title="caDesign"></a> 

### 2.8.12 Weighted Average
权重求平均值，输入的数据乘对应索引值输入的权重计算平均数，权重数总和要为1，如果不等于1则自动分配到0-1区间，等同与将其结果除比重的总和。  

<a href=""><img src="./imgs\appendix_component\2_8_Weighted Average.png" height="auto" width=1000 title="caDesign"></a> 

### 2.8.13 Complex
复数计算。 
 > Complex Argument 辐角：复数的模与辐角是复数三角形式表示的两个基本元素，复数所对应的向量长度称为复数的幅值，该向量与实轴正方向的夹角为复数的辐角。  

 > Complex Conjugate 共轭复数: 共轭复数，两个实部相等，虚部互为相反数的复数互为共轭复数(conjugate complex number)。  

 >Complex Component 复数模量： 复数模量可分别由不同受力情况进行测量:拉伸模量E*=E′+iE〃；剪切模量G*=G′+iG〃；体积压缩模量K*=K′+iK〃；纵向压缩模量L*=L′+iL〃。复数模量中的贮能模量(E′、G′、K′、L′)是和应变同相的稳态应力与应变值之比。  

 >来源百度百科

<a href=""><img src="./imgs\appendix_component\2_8_Complex.png" height="auto" width=1000 title="caDesign"></a> 