# ILNumerics Ultimate VS 
This package is part of [ILNumerics Ultimate VS](https://ilnumerics.net) - a powerful framework for technical application development on .NET. 
ILNumerics provides packages for the convenient authoring of: 
- Fast numerical algorithms in Matlab(R) and numpy style
    - Efficient n-d array classes: [ILNumerics.Computing](https://www.nuget.org/packages/ILNumerics.Computing) ([online docu](https://ilnumerics.net/docs-core.html))
    - Large selection of fundamental, [mathematical array functions](https://ilnumerics.net/apidoc/?topic=html/Methods_T_ILNumerics_ILMath.htm)
- Toolboxes for 
    - Interpolation: [ILNumerics.Toolboxes.Interpolation](https://www.nuget.org/packages/ILNumerics.Toolboxes.Interpolation) ([online docu](https://ilnumerics.net/ilnumerics-interpolation-toolbox.html#))  
    - Optimization: [ILNumerics.Toolboxes.Optimization](https://www.nuget.org/packages/ILNumerics.Toolboxes.Optimization) ([online docu](https://ilnumerics.net/ilnumerics-optimization-toolbox.html))
    - Statistics: [ILNumerics.Toolboxes.Statistics](https://www.nuget.org/packages/ILNumerics.Toolboxes.Statistics) ([online docu](https://ilnumerics.net/ilnumerics-statistics-toolbox.html))
    - HDF5: [ILNumerics.IO.HDF5](https://www.nuget.org/packages/ILNumerics.IO.HDF5) ([online docu](https://ilnumerics.net/hdf5-interface.html))
- Flexible, good looking, fast and robust 2D and 3D visualizations.
    + ILNumerics Visualization Engine: [ILNumerics.Drawing](https://www.nuget.org/packages/ILNumerics.Drawing): ([online docu](https://ilnumerics.net/Visualization-API.html))
        - Scene graph based rendering of line-, scatter-, XY-, contour-, surface plots. 
        - Compose complex scenes built of simple point-, lines-, and triangle-shapes. 
        - Output to common image formats and SVG.
    + Windows Forms Controls: [ILNumerics.Drawing.Platforms](https://www.nuget.org/packages/ILNumerics.Drawing.Platforms)
        - Interactivity on Windows.Forms: ILNumerics.Drawing.Panel 
        - Hardware acceleration (OpenGL) 
        - Fully featured GDI+ fallback.
    - ILNumerics Drawing Extensions: [ILNumerics.Toolboxes.Drawing2](https://www.nuget.org/packages/ILNumerics.Toolboxes.Drawing2)
        - [Bar-](https://ilnumerics.net/bar-plots.html), [spline-](https://ilnumerics.net/spline-interpolated-lines.html), region-, error-, candlestick-, fill area-, stacked area-, box plots.
        - More and [faster](https://ilnumerics.net/interactive-fast-surface-visualization.html) surfaces, [smooth surface](https://ilnumerics.net/scattered-data-smooth-surface.html). 
- Visual Studio Tools: get the free [Array Visualizer](https://ilnumerics.net/visualstudio-extension.html) from [MS Marketplace](https://marketplace.visualstudio.com/items?itemName=ILNumericsGmbH.ilnumericsVS600)

### Compatibility
ILNumerics is compatible with all .NET runtimes since .NET Framework 4.6.1., including .NET Core, .NET 5.0, .NET 6.0. 

We've invested great effort to translate and keep up to date the quasi standard algorithms for all computational routines, including [linear algebra](https://netlib.org/lapack), [FFT](https://www2.cisl.ucar.edu/resources/legacy/fft5) and [optimization](https://netlib.org/minpack/index.html) methods. These _purely managed_ implementations are the first to bring professional robustness and precision to .NET. Hence, ILNumerics runs efficiently on any platform supported by .NET! Optionally, native libraries can be used to replace the managed default implementation. For the Windows platform, such native, optimized libraries are provided, too.

### Performance 
ILNumerics apps are typically much faster than alternatives: faster to implement and faster during execution. With ILNumerics the size of your data is not [limited](https://docs.microsoft.com/en-us/dotnet/framework/configure-apps/file-schema/runtime/gcallowverylargeobjects-element) by the managed heap. ILNumerics n-dimensional Array&lt;T> bridges the gap from high-level mathematical expressions down to native memory robustly, efficiently, and transparently. It allows to connect your data to any 3rd party without hassle. Further, it is able to host your data on any computational resource found, including CPUs and GPUs - key for [heterogeneous, parallel computing](https://ilnumerics.net/blog/ilnumerics-comes-next). 

### ILNumerics.Toolboxes.Drawing2 
This package implements extensions to the [Visualization Engine](https://www.nuget.org/packages/ILNumerics.Drawing). It adds 
more plot types, faster [surfaces](https://ilnumerics.net/interactive-fast-surface-visualization.html) and more high-level features (as [smooth surfaces](https://ilnumerics.net/scattered-data-smooth-surface.html)) to your visualizations. The types in this modules
can be used for [general visualizations](https://www.nuget.org/packages/ILNumerics.Drawing) and plots as well as for interactive apps, based on Windows.Forms and [ILNumerics.Drawing.Platforms](https://www.nuget.org/packages/ILNumerics.Drawing.Platforms).

### General Preparation
- install the [ILNumerics Visual Studio extension](https://marketplace.visualstudio.com/items?itemName=ILNumericsGmbH.ilnumericsVS600)
- download your [trial license](https://ilnumerics.net/download.html).
- [activate your seat](https://ilnumerics.net/license-activation.html).

### Quick Start (Visualization Engine)
- reference the [Drawing2](https://www.nuget.org/packages/ILNumerics.Toolboxes.Drawing2) package in your project. 
- start with a new console application (C#)
- include the following code into your Program.Main() method (C#). It creates random [data](https://ilnumerics.net/Arrays.html), a new scene, use the data to add a new [FillArea](https://ilnumerics.net/fillareaplot.html) plot and renders the plot to a bitmap image ([offscreen rendering](https://ilnumerics.net/offscreen-rendering.html)). 

        static void Main(string[] args) {
            // create a new scene, with a bar plot of random data 
            var scene = new Scene();
            // create some data
            Array<double> A = arange<double>(1, 10).T.Concat(rand(1, 10), 0);
            // create a fill area plot
            var plot = new FillArea(A, fillColor: System.Drawing.Color.LightGray); 
            // add the plot to the scene 
            scene.Add(new PlotCube(twoDMode: false) { plot });

            // add-on: access the line inside the plot and configure its width.
            // Lines in ILNumerics.Drawing are mostly Lines objects - capable for rendering many lines efficiently.
            var lineplot = plot.First<Lines>();
            lineplot.Width = 3;
            lineplot.DashStyle = DashStyle.Dotted; 

            // signal that your scene is ready for rendering
            scene.Configure();
            
            // (offscreen) render the scene to a bitmap, using GDIDriver
            var gdi = new GDIDriver(1000, 1000, scene);
            gdi.Render();
            gdi.BackBuffer.Bitmap.Save("image.png");
        }

- Hit F5 and find the result in your /bin/Debug/ folder: image.png
- Read the [beginners guide](https://ilnumerics.net/visualization-basics.html) and start implementing your own scenes! 

### Documentation
- https://ilnumerics.net/extended-drawing2-toolbox.html

### Examples 
[ILNumerics example collection](https://ilnumerics.net/examples.html)
