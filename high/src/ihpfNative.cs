/*
* MATLAB Compiler: 4.16 (R2011b)
* Date: Tue May 19 01:31:29 2015
* Arguments: "-B" "macro_default" "-W" "dotnet:high,ihpf,0.0,private" "-T" "link:lib"
* "-d" "D:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\high\src"
* "-w" "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v" "class{ihpf:D:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\high.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace highNative
{

  /// <summary>
  /// The ihpf class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// D:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\high.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class ihpf : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static ihpf()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "high.ctf";

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
    /// Constructs a new instance of the ihpf class.
    /// </summary>
    public ihpf()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~ihpf()
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
    /// Provides a single output, 0-input Objectinterface to the high M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// h = hpfilter('gaussian', pq(1), pq(2), d0);
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object high()
    {
      return mcr.EvaluateFunction("high", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the high M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// h = hpfilter('gaussian', pq(1), pq(2), d0);
    /// </remarks>
    /// <param name="J">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object high(Object J)
    {
      return mcr.EvaluateFunction("high", J);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the high M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// h = hpfilter('gaussian', pq(1), pq(2), d0);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] high(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "high", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the high M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// h = hpfilter('gaussian', pq(1), pq(2), d0);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="J">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] high(int numArgsOut, Object J)
    {
      return mcr.EvaluateFunction(numArgsOut, "high", J);
    }


    /// <summary>
    /// Provides an interface for the high function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// h = hpfilter('gaussian', pq(1), pq(2), d0);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("high", 1, 2, 0)]
    protected void high(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("high", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
