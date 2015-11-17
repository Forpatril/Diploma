/*
* MATLAB Compiler: 4.16 (R2011b)
* Date: Sun Jun 28 00:33:06 2015
* Arguments: "-B" "macro_default" "-W" "dotnet:imnoise,Noise,0.0,private" "-T" "link:lib"
* "-d" "C:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\imnoise\src"
* "-w" "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v" "class{Noise:C:\Users\Forpatril\Documents\Visual Studio
* 2010\Projects\Diploma_cs\noise.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace imnoise
{

  /// <summary>
  /// The Noise class provides a CLS compliant, MWArray interface to the M-functions
  /// contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Forpatril\Documents\Visual Studio 2010\Projects\Diploma_cs\noise.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Noise : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static Noise()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "imnoise.ctf";

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
    /// Constructs a new instance of the Noise class.
    /// </summary>
    public Noise()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Noise()
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
    /// Provides a single output, 0-input MWArrayinterface to the noise M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray noise()
    {
      return mcr.EvaluateFunction("noise", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the noise M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="type">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray noise(MWArray type)
    {
      return mcr.EvaluateFunction("noise", type);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the noise M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="type">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray noise(MWArray type, MWArray A)
    {
      return mcr.EvaluateFunction("noise", type, A);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the noise M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="type">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray noise(MWArray type, MWArray A, MWArray a)
    {
      return mcr.EvaluateFunction("noise", type, A, a);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the noise M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="type">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray noise(MWArray type, MWArray A, MWArray a, MWArray b)
    {
      return mcr.EvaluateFunction("noise", type, A, a, b);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the noise M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="type">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="print">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray noise(MWArray type, MWArray A, MWArray a, MWArray b, MWArray print)
    {
      return mcr.EvaluateFunction("noise", type, A, a, b, print);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the noise M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] noise(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "noise", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the noise M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="type">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] noise(int numArgsOut, MWArray type)
    {
      return mcr.EvaluateFunction(numArgsOut, "noise", type);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the noise M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="type">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] noise(int numArgsOut, MWArray type, MWArray A)
    {
      return mcr.EvaluateFunction(numArgsOut, "noise", type, A);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the noise M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="type">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] noise(int numArgsOut, MWArray type, MWArray A, MWArray a)
    {
      return mcr.EvaluateFunction(numArgsOut, "noise", type, A, a);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the noise M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="type">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] noise(int numArgsOut, MWArray type, MWArray A, MWArray a, MWArray b)
    {
      return mcr.EvaluateFunction(numArgsOut, "noise", type, A, a, b);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the noise M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="type">Input argument #1</param>
    /// <param name="A">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="print">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] noise(int numArgsOut, MWArray type, MWArray A, MWArray a, MWArray b, 
                     MWArray print)
    {
      return mcr.EvaluateFunction(numArgsOut, "noise", type, A, a, b, print);
    }


    /// <summary>
    /// Provides an interface for the noise function in which the input and output
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
    public void noise(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("noise", numArgsOut, ref argsOut, argsIn);
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
