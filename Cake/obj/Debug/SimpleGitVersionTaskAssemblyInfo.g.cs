
// Automatically generated by SimpleGitVersionTask Working folder has non committed changes..
using System;
using System.Reflection;

[assembly: AssemblyVersion(@"0.0")]
[assembly: AssemblyFileVersion(@"0.0.0.0")]
[assembly: AssemblyInformationalVersion(@"Working folder has non committed changes. Sha:023691e8faa7bb026386d2bd07de4097f99aeeaf User:LUCASPC\lucas")]

[assembly: SimpleGitVersionInfo( @"Working folder has non committed changes.", "2016-03-23 09:40:19Z", "0.14.2" )]

/// <summary>
/// Automatically generated by SimpleGitVersionTask Working folder has non committed changes.. 
/// </summary>
class SimpleGitVersionInfoAttribute : Attribute
{
    public SimpleGitVersionInfoAttribute( string semVer, string buildTimeUtc, string sgvVersion )
    {
        SemVer = semVer;
        BuildTimeUtc = buildTimeUtc;
        SGVVersion = sgvVersion;
    }

    public readonly string SemVer;
    public readonly string BuildTimeUtc;
    public readonly string SGVVersion;
    
    public override string ToString()
    {
        return String.Format( "SemVer: {0}, BuildTimeUtc: {1}, SGVVersion: {2}", SemVer, BuildTimeUtc, SGVVersion );
    }
}
