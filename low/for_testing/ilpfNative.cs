/*
* MATLAB Compiler: 5.1 (R2014a)
* Date: Mon Jun 01 18:42:27 2015
* Arguments: "-B" "macro_default" "-W" "dotnet:low,ilpf,0.0,private" "-T" "link:lib" "-d"
* "C:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\low\for_testing"
* "-v" "C:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\low.m"
* "class{ilpf:C:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\low.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace lowNative
{

  /// <summary>
  /// The ilpf class provides a CLS compliant, Object (native) interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\low.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class ilpf : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static ilpf()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "low.ctf";

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
    /// Constructs a new instance of the ilpf class.
    /// </summary>
    public ilpf()
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
    ~ilpf()
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
    /// Provides a single output, 0-input Objectinterface to the low MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// F = fft2(J, PQ(1), PQ(2));
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object low()
    {
      return mcr.EvaluateFunction("low", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the low MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// F = fft2(J, PQ(1), PQ(2));
    /// </remarks>
    /// <param name="J">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object low(Object J)
    {
      return mcr.EvaluateFunction("low", J);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the low MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// F = fft2(J, PQ(1), PQ(2));
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] low(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "low", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the low MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// F = fft2(J, PQ(1), PQ(2));
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="J">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] low(int numArgsOut, Object J)
    {
      return mcr.EvaluateFunction(numArgsOut, "low", J);
    }


    /// <summary>
    /// Provides an interface for the low function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// F = fft2(J, PQ(1), PQ(2));
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("low", 1, 2, 0)]
    protected void low(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("low", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
