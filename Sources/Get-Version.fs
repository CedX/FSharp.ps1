namespace Belin.FSharp

open System.Management.Automation

/// Returns the version number of the `FSharp.Core` assembly.
[<Cmdlet(VerbsCommon.Get, "Version", DefaultParameterSetName = "Default")>]
[<OutputType(typeof<string>, ParameterSetName = [| "Default" |]); OutputType(typeof<SemanticVersion>, ParameterSetName = [| "PassThru" |])>]
type GetVersionCommand() =
  inherit PSCmdlet()

  /// The assembly version.
  static let version = SemanticVersion (typeof<GetVersionCommand>.Assembly.GetName().Version)

  /// Value indicating whether to return a `[semver]` object.
  [<Parameter(ParameterSetName = "PassThru")>]
  member val PassThru = SwitchParameter false with get, set

  /// Performs execution of this command.
  override this.ProcessRecord () =
    this.WriteObject (if this.PassThru.IsPresent then version :> obj else $"FSharp.Core {version}")
