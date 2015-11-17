/*
* MATLAB Compiler: 4.16 (R2011b)
* Date: Tue May 26 19:50:42 2015
* Arguments: "-B" "macro_default" "-W" "dotnet:bfilter,Bilateral,0.0,private" "-T"
* "link:lib" "-d" "D:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\bfilter\src" "-w" "enable:specified_file_mismatch" "-w"
* "enable:repeated_file" "-w" "enable:switch_ignored" "-w" "enable:missing_lib_sentinel"
* "-w" "enable:demo_license" "-v" "class{Bilateral:D:\Users\Forpatril\Documents\Visual
* Studio 2010\Projects\Diploma_cs\bfilter2.m,D:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\bilateral.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace bfilter
{

  /// <summary>
  /// The Bilateral class provides a CLS compliant, MWArray interface to the M-functions
  /// contained in the files:
  /// <newpara></newpara>
  /// D:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\bfilter2.m
  /// <newpara></newpara>
  /// D:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\bilateral.m
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
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Bilateral class.
    /// </summary>
    public Bilateral()
    {
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
    /// Provides a single output, 0-input MWArrayinterface to the bfilter2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray bfilter2()
    {
      return mcr.EvaluateFunction("bfilter2", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the bfilter2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray bfilter2(MWArray A)
    {
      return mcr.EvaluateFunction("bfilter2", A);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the bfilter2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray bfilter2(MWArray A, MWArray w)
    {
      return mcr.EvaluateFunction("bfilter2", A, w);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the bfilter2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <param name="sigma">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray bfilter2(MWArray A, MWArray w, MWArray sigma)
    {
      return mcr.EvaluateFunction("bfilter2", A, w, sigma);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the bfilter2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] bfilter2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "bfilter2", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the bfilter2 M-function.
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
    public MWArray[] bfilter2(int numArgsOut, MWArray A)
    {
      return mcr.EvaluateFunction(numArgsOut, "bfilter2", A);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the bfilter2 M-function.
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
    public MWArray[] bfilter2(int numArgsOut, MWArray A, MWArray w)
    {
      return mcr.EvaluateFunction(numArgsOut, "bfilter2", A, w);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the bfilter2 M-function.
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
    public MWArray[] bfilter2(int numArgsOut, MWArray A, MWArray w, MWArray sigma)
    {
      return mcr.EvaluateFunction(numArgsOut, "bfilter2", A, w, sigma);
    }


    /// <summary>
    /// Provides an interface for the bfilter2 function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Verify that the input image exists and is valid.
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void bfilter2(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("bfilter2", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the bilateral M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray bilateral()
    {
      return mcr.EvaluateFunction("bilateral", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the bilateral M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray bilateral(MWArray A)
    {
      return mcr.EvaluateFunction("bilateral", A);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the bilateral M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray bilateral(MWArray A, MWArray w)
    {
      return mcr.EvaluateFunction("bilateral", A, w);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the bilateral M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <param name="sigma">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray bilateral(MWArray A, MWArray w, MWArray sigma)
    {
      return mcr.EvaluateFunction("bilateral", A, w, sigma);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the bilateral M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] bilateral(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "bilateral", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the bilateral M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] bilateral(int numArgsOut, MWArray A)
    {
      return mcr.EvaluateFunction(numArgsOut, "bilateral", A);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the bilateral M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="A">Input argument #1</param>
    /// <param name="w">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] bilateral(int numArgsOut, MWArray A, MWArray w)
    {
      return mcr.EvaluateFunction(numArgsOut, "bilateral", A, w);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the bilateral M-function.
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
    public MWArray[] bilateral(int numArgsOut, MWArray A, MWArray w, MWArray sigma)
    {
      return mcr.EvaluateFunction(numArgsOut, "bilateral", A, w, sigma);
    }


    /// <summary>
    /// Provides an interface for the bilateral function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void bilateral(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("bilateral", numArgsOut, ref argsOut, argsIn);
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
