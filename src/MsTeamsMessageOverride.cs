using Soenneker.Messages.MsTeams;
using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;
using Soenneker.Utils.Environment;

namespace Soenneker.AutoFaker.Overrides.Messages.MsTeams;

/// <summary>
/// An AutoFaker (AutoBogus) override for the MsTeams Message
/// </summary>
public class MsTeamsMessageOverrideOverride : AutoFakerOverride<MsTeamsMessage>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as MsTeamsMessage)!;

        target.Channel = "notifications";
        target.Queue = "msteams";
        target.Sender = EnvironmentUtil.GetMachineName();
    }
}