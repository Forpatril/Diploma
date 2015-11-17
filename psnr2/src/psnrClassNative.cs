/*
* MATLAB Compiler: 4.16 (R2011b)
* Date: Tue Jun 02 12:42:41 2015
* Arguments: "-B" "macro_default" "-W" "dotnet:psnr2,psnrClass,0.0,private" "-T"
* "link:lib" "-d" "D:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\psnr2\src" "-w" "enable:specified_file_mismatch" "-w"
* "enable:repeated_file" "-w" "enable:switch_ignored" "-w" "enable:missing_lib_sentinel"
* "-w" "enable:demo_license" "-v" "class{psnrClass:D:\Users\Forpatril\Documents\Visual
* Studio 2010\Projects\Diploma_cs\psnr.m,D:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\psnr2.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace psnr2Native
{

  /// <summary>
  /// The psnrClass class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// D:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\psnr.m
  /// <newpara></newpara>
  /// D:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\psnr2.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class psnrClass : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static psnrClass()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "psnr2.ctf";

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
    /// Constructs a new instance of the psnrClass class.
    /// </summary>
    public psnrClass()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~psnrClass()
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
    /// Provides a single output, 0-input Objectinterface to the psnr M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PSNR (Peak Signal to noise ratio)
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object psnr()
    {
      return mcr.EvaluateFunction("psnr", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the psnr M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PSNR (Peak Signal to noise ratio)
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object psnr(Object A)
    {
      return mcr.EvaluateFunction("psnr", A);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the psnr M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PSNR (Peak Signal to noise ratio)
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object psnr(Object A, Object B)
    {
      return mcr.EvaluateFunction("psnr", A, B);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the psnr M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PSNR (Peak Signal to noise ratio)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] psnr(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "psnr", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the psnr M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PSNR (Peak Signal to noise ratio)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] psnr(int numArgsOut, Object A)
    {
      return mcr.EvaluateFunction(numArgsOut, "psnr", A);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the psnr M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// PSNR (Peak Signal to noise ratio)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <param name="B">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] psnr(int numArgsOut, Object A, Object B)
    {
      return mcr.EvaluateFunction(numArgsOut, "psnr", A, B);
    }


    /// <summary>
    /// Provides an interface for the psnr function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// PSNR (Peak Signal to noise ratio)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("psnr", 2, 1, 0)]
    protected void psnr(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("psnr", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the psnr2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object psnr2()
    {
      return mcr.EvaluateFunction("psnr2", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the psnr2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="g1">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object psnr2(Object g1)
    {
      return mcr.EvaluateFunction("psnr2", g1);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the psnr2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="g1">Input argument #1</param>
    /// <param name="g2">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object psnr2(Object g1, Object g2)
    {
      return mcr.EvaluateFunction("psnr2", g1, g2);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the psnr2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] psnr2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "psnr2", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the psnr2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="g1">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] psnr2(int numArgsOut, Object g1)
    {
      return mcr.EvaluateFunction(numArgsOut, "psnr2", g1);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the psnr2 M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="g1">Input argument #1</param>
    /// <param name="g2">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] psnr2(int numArgsOut, Object g1, Object g2)
    {
      return mcr.EvaluateFunction(numArgsOut, "psnr2", g1, g2);
    }


    /// <summary>
    /// Provides an interface for the psnr2 function in which the input and output
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
    [MATLABSignature("psnr2", 2, 1, 0)]
    protected void psnr2(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("psnr2", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
