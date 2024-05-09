# Creating a line chart with plot bands to explore global GNI per capita with income thresholds.
In this section, we'll use [Syncfusion's .NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) control to create a line chart with plot bands. This chart will help us explore global Gross National Income (GNI) per capita alongside income thresholds.

GNI represents the total income earned by a country's people and businesses. We will analyze GNI values from 2000 to 2018, categorized by country. This control is compatible with desktop platforms such as Windows and Mac, as well as mobile platforms like Android and iOS.

## PlotBand to Y-axis
Using [NumericalPlotBand](https://help.syncfusion.com/maui/cartesian-charts/plotband#numerical-plotband) to shade the **lower GNI, middle GNI, and upper GNI regions**, also added corresponding text. Created a plot band instance and added it to the [NumericalPlotBandCollection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPlotBandCollection.html). Using the [Start](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPlotBand.html#Syncfusion_Maui_Charts_NumericalPlotBand_Start) and [End](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPlotBand.html#Syncfusion_Maui_Charts_NumericalPlotBand_End) APIs, set the start and end positions of the shading region, and using [ChartPlotBandLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartPlotBandLabelStyle.html#properties), customized the text for the plot band.

## Troubleshooting:
**Path too long exception:**
If you encounter a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

![LineChartWithPlotBand](https://github.com/SyncfusionExamples/Creating--a-line-chart-with-plot-bands-to-explore-global-GNI-per-capita-with-income-thresholds/assets/102796134/de4de06b-aad5-40cf-91a3-9381bbf640d6)

If you'd like more information or a detailed guide, refer [Creating a line chart with plot bands to explore global GNI per capita with income thresholds blog]().
