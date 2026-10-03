namespace Belin.FSharp

open System.Management.Automation

/// Returns the version number of the `FSharp.Core` assembly.
[<Cmdlet(VerbsCommon.Get, "Version"); OutputType(typeof<string>); OutputType(typeof<SemanticVersion>)>]
type GetVersionCommand() =
  inherit Cmdlet()

  /// The assembly version.
  static let version = SemanticVersion (typeof<GetVersionCommand>.Assembly.GetName().Version)

  /// Value indicating whether to return a `[semver]` object.
  [<Parameter>]
  member val PassThru = SwitchParameter false with get, set

  /// Performs execution of this command.
  override this.ProcessRecord () =
    this.WriteObject (if this.PassThru.IsPresent then version :> obj else $"FSharp.Core {version}")
