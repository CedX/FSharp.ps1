namespace Belin.FSharp

open System.Management.Automation

/// Returns the version number of the `FSharp.Core` assembly.
[<Cmdlet(VerbsCommon.Get, "Version")>]
[<OutputType(typeof<SemanticVersion>)>]
type GetVersionCommand() =
  inherit Cmdlet()

  /// The assembly version.
  static let mutable version: SemanticVersion =
    let value = typeof<GetVersionCommand>.Assembly.GetName().Version
    SemanticVersion value

  /// Performs execution of this command.
  override this.ProcessRecord() = this.WriteObject version
