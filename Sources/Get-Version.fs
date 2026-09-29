namespace Belin.FSharp

open System.Management.Automation

/// Returns the version number of the `FSharp.Core` assembly.
[<Cmdlet(VerbsCommon.Get, "Version")>]
[<OutputType(typeof<SemanticVersion>)>]
type GetVersionCommand() =
  inherit Cmdlet()

  /// The assembly version.
  static let mutable Version: SemanticVersion =
    let version = typeof<GetVersionCommand>.Assembly.GetName().Version |> nonNull
    SemanticVersion version

  /// Performs execution of this command.
  override this.ProcessRecord() = this.WriteObject Version
