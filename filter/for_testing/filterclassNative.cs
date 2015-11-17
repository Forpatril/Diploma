/*
* MATLAB Compiler: 5.1 (R2014a)
* Date: Mon Jun 01 18:44:16 2015
* Arguments: "-B" "macro_default" "-W" "dotnet:filter,filterclass,0.0,private" "-T"
* "link:lib" "-d" "C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\filter\for_testing" "-v" "C:\Users\Forpatril\Documents\Visual
* Studio 2010\Projects\Diploma_cs\filter.m" "C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\runDemo.m"
* "class{filterclass:C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\filter.m,C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\runDemo.m}" "-a" "C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\academy.jpg" "-a" "C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\bfilter2.m" "-a" "C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\bilateral.m" "-a" "C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\changeclass.m" "-a" "C:\Users\Forpatril\Documents\Visual
* Studio 2010\Projects\Diploma_cs\colorspace.m" "-a" "C:\Users\Forpatril\Documents\Visual
* Studio 2010\Projects\Diploma_cs\einstein.jpg" "-a" "C:\Users\Forpatril\Documents\Visual
* Studio 2010\Projects\Diploma_cs\high.m" "-a" "C:\Users\Forpatril\Documents\Visual
* Studio 2010\Projects\Diploma_cs\low.m" "-a" "C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\mandrill.jpg" "-a" "C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\spfilt.m" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace filterNative
{

  /// <summary>
  /// The filterclass class provides a CLS compliant, Object (native) interface to the
  /// MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\filter.m
  /// <newpara></newpara>
  /// C:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\runDemo.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class filterclass : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static filterclass()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "filter.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the filterclass class.
    /// </summary>
    public filterclass()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~filterclass()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the filter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object filter()
    {
      return mcr.EvaluateFunction("filter", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the filter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="image">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object filter(Object image)
    {
      return mcr.EvaluateFunction("filter", image);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the filter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="image">Input argument #1</param>
    /// <param name="type">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object filter(Object image, Object type)
    {
      return mcr.EvaluateFunction("filter", image, type);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the filter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="image">Input argument #1</param>
    /// <param name="type">Input argument #2</param>
    /// <param name="param">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object filter(Object image, Object type, Object param)
    {
      return mcr.EvaluateFunction("filter", image, type, param);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the filter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] filter(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "filter", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the filter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="image">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] filter(int numArgsOut, Object image)
    {
      return mcr.EvaluateFunction(numArgsOut, "filter", image);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the filter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="image">Input argument #1</param>
    /// <param name="type">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] filter(int numArgsOut, Object image, Object type)
    {
      return mcr.EvaluateFunction(numArgsOut, "filter", image, type);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the filter MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="image">Input argument #1</param>
    /// <param name="type">Input argument #2</param>
    /// <param name="param">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] filter(int numArgsOut, Object image, Object type, Object param)
    {
      return mcr.EvaluateFunction(numArgsOut, "filter", image, type, param);
    }


    /// <summary>
    /// Provides an interface for the filter function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("filter", 3, 2, 0)]
    protected void filter(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("filter", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the runDemo MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// RUNDEMO Illustrates the use of BFILTER2 and CARTOON.
    /// This demo shows typical usage for the bilateral 
    /// filter implemented by BFILTER2. The application
    /// of bilateral filtering to image abstraction is
    /// demonstrated by the CARTOON function.
    /// Douglas R. Lanman, Brown University, September 2006.
    /// dlanman@brown.edu, http://mesh.brown.edu/dlanman
    /// </remarks>
    ///
    public void runDemo()
    {
      mcr.EvaluateFunction(0, "runDemo", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the runDemo MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// RUNDEMO Illustrates the use of BFILTER2 and CARTOON.
    /// This demo shows typical usage for the bilateral 
    /// filter implemented by BFILTER2. The application
    /// of bilateral filtering to image abstraction is
    /// demonstrated by the CARTOON function.
    /// Douglas R. Lanman, Brown University, September 2006.
    /// dlanman@brown.edu, http://mesh.brown.edu/dlanman
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] runDemo(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "runDemo", new Object[]{});
    }


    /// <summary>
    /// Provides an interface for the runDemo function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// RUNDEMO Illustrates the use of BFILTER2 and CARTOON.
    /// This demo shows typical usage for the bilateral 
    /// filter implemented by BFILTER2. The application
    /// of bilateral filtering to image abstraction is
    /// demonstrated by the CARTOON function.
    /// Douglas R. Lanman, Brown University, September 2006.
    /// dlanman@brown.edu, http://mesh.brown.edu/dlanman
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("runDemo", 0, 0, 0)]
    protected void runDemo(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("runDemo", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}