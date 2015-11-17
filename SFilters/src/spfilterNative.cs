/*
* MATLAB Compiler: 4.16 (R2011b)
* Date: Mon May 25 15:09:33 2015
* Arguments: "-B" "macro_default" "-W" "dotnet:SFilters,spfilter,0.0,private" "-T"
* "link:lib" "-d" "D:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\SFilters\src" "-w" "enable:specified_file_mismatch" "-w"
* "enable:repeated_file" "-w" "enable:switch_ignored" "-w" "enable:missing_lib_sentinel"
* "-w" "enable:demo_license" "-v" "class{spfilter:D:\Users\Forpatril\Documents\Visual
* Studio 2010\Projects\Diploma_cs\spfilt.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace SFiltersNative
{

  /// <summary>
  /// The spfilter class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// D:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\spfilt.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class spfilter : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static spfilter()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "SFilters.ctf";

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
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the spfilter class.
    /// </summary>
    public spfilter()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~spfilter()
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
    /// Provides a single output, 0-input Objectinterface to the spfilt M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object spfilt()
    {
      return mcr.EvaluateFunction("spfilt", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the spfilt M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <param name="g">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object spfilt(Object g)
    {
      return mcr.EvaluateFunction("spfilt", g);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the spfilt M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <param name="g">Input argument #1</param>
    /// <param name="type">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object spfilt(Object g, Object type)
    {
      return mcr.EvaluateFunction("spfilt", g, type);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the spfilt M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <param name="g">Input argument #1</param>
    /// <param name="type">Input argument #2</param>
    /// <param name="m">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object spfilt(Object g, Object type, Object m)
    {
      return mcr.EvaluateFunction("spfilt", g, type, m);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the spfilt M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <param name="g">Input argument #1</param>
    /// <param name="type">Input argument #2</param>
    /// <param name="m">Input argument #3</param>
    /// <param name="n">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object spfilt(Object g, Object type, Object m, Object n)
    {
      return mcr.EvaluateFunction("spfilt", g, type, m, n);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the spfilt M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <param name="g">Input argument #1</param>
    /// <param name="type">Input argument #2</param>
    /// <param name="m">Input argument #3</param>
    /// <param name="n">Input argument #4</param>
    /// <param name="parameter">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object spfilt(Object g, Object type, Object m, Object n, Object parameter)
    {
      return mcr.EvaluateFunction("spfilt", g, type, m, n, parameter);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the spfilt M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] spfilt(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "spfilt", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the spfilt M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="g">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] spfilt(int numArgsOut, Object g)
    {
      return mcr.EvaluateFunction(numArgsOut, "spfilt", g);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the spfilt M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="g">Input argument #1</param>
    /// <param name="type">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] spfilt(int numArgsOut, Object g, Object type)
    {
      return mcr.EvaluateFunction(numArgsOut, "spfilt", g, type);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the spfilt M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="g">Input argument #1</param>
    /// <param name="type">Input argument #2</param>
    /// <param name="m">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] spfilt(int numArgsOut, Object g, Object type, Object m)
    {
      return mcr.EvaluateFunction(numArgsOut, "spfilt", g, type, m);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the spfilt M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="g">Input argument #1</param>
    /// <param name="type">Input argument #2</param>
    /// <param name="m">Input argument #3</param>
    /// <param name="n">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] spfilt(int numArgsOut, Object g, Object type, Object m, Object n)
    {
      return mcr.EvaluateFunction(numArgsOut, "spfilt", g, type, m, n);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the spfilt M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="g">Input argument #1</param>
    /// <param name="type">Input argument #2</param>
    /// <param name="m">Input argument #3</param>
    /// <param name="n">Input argument #4</param>
    /// <param name="parameter">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] spfilt(int numArgsOut, Object g, Object type, Object m, Object n, 
                     Object parameter)
    {
      return mcr.EvaluateFunction(numArgsOut, "spfilt", g, type, m, n, parameter);
    }


    /// <summary>
    /// Provides an interface for the spfilt function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// ---  
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("spfilt", 5, 2, 0)]
    protected void spfilt(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("spfilt", numArgsOut, ref argsOut, argsIn, varArgsIn);
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

    private bool disposed= false;

    #endregion Class Members
  }
}
