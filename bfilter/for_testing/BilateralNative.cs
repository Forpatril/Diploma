/*
* MATLAB Compiler: 5.1 (R2014a)
* Date: Mon Jun 01 18:45:02 2015
* Arguments: "-B" "macro_default" "-W" "dotnet:bfilter,Bilateral,0.0,private" "-T"
* "link:lib" "-d" "C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\bfilter\for_testing" "-v" "C:\Users\Forpatril\Documents\Visual
* Studio 2010\Projects\Diploma_cs\bfilter2.m" "C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\bilateral.m"
* "class{Bilateral:C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\bfilter2.m,C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\bilateral.m}" "-a" "C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\colorspace.m" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace bfilterNative
{

  /// <summary>
  /// The Bilateral class provides a CLS compliant, Object (native) interface to the
  /// MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\bfilter2.m
  /// <newpara></newpara>
  /// C:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\bilateral.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Bilateral : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static Bilateral()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "bfilter.ctf";

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
    /// Constructs a new instance of the Bilateral class.
    /// </summary>
    public Bilateral()
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
    ~Bilateral()
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
    /// Provides a single output, 0-input Objectinterface to the bfilter2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object bfilter2()
    {
      return mcr.EvaluateFunction("bfilter2", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the bfilter2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object bfilter2(Object A)
    {
      return mcr.EvaluateFunction("bfilter2", A);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the bfilter2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object bfilter2(Object A, Object w)
    {
      return mcr.EvaluateFunction("bfilter2", A, w);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the bfilter2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <param name="sigma">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object bfilter2(Object A, Object w, Object sigma)
    {
      return mcr.EvaluateFunction("bfilter2", A, w, sigma);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the bfilter2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] bfilter2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "bfilter2", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the bfilter2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] bfilter2(int numArgsOut, Object A)
    {
      return mcr.EvaluateFunction(numArgsOut, "bfilter2", A);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the bfilter2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] bfilter2(int numArgsOut, Object A, Object w)
    {
      return mcr.EvaluateFunction(numArgsOut, "bfilter2", A, w);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the bfilter2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <param name="sigma">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] bfilter2(int numArgsOut, Object A, Object w, Object sigma)
    {
      return mcr.EvaluateFunction(numArgsOut, "bfilter2", A, w, sigma);
    }


    /// <summary>
    /// Provides an interface for the bfilter2 function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("bfilter2", 3, 2, 0)]
    protected void bfilter2(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("bfilter2", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the bilateral MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object bilateral()
    {
      return mcr.EvaluateFunction("bilateral", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the bilateral MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object bilateral(Object A)
    {
      return mcr.EvaluateFunction("bilateral", A);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the bilateral MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object bilateral(Object A, Object w)
    {
      return mcr.EvaluateFunction("bilateral", A, w);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the bilateral MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <param name="sigma">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object bilateral(Object A, Object w, Object sigma)
    {
      return mcr.EvaluateFunction("bilateral", A, w, sigma);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the bilateral MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] bilateral(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "bilateral", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the bilateral MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] bilateral(int numArgsOut, Object A)
    {
      return mcr.EvaluateFunction(numArgsOut, "bilateral", A);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the bilateral MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] bilateral(int numArgsOut, Object A, Object w)
    {
      return mcr.EvaluateFunction(numArgsOut, "bilateral", A, w);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the bilateral MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <param name="sigma">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] bilateral(int numArgsOut, Object A, Object w, Object sigma)
    {
      return mcr.EvaluateFunction(numArgsOut, "bilateral", A, w, sigma);
    }


    /// <summary>
    /// Provides an interface for the bilateral function in which the input and output
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
    [MATLABSignature("bilateral", 3, 2, 0)]
    protected void bilateral(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("bilateral", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
