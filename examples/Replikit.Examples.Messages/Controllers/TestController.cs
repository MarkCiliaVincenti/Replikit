using System.Text.Json;
using System.Text.Json.Serialization;
using Replikit.Abstractions.Messages.Models;
using Replikit.Core.Controllers;
using Replikit.Core.Controllers.Patterns;

namespace Replikit.Examples.Messages.Controllers;

public class TestController : Controller
{
    [Command("test attachments")]
    public OutMessage Test()
    {
        var message = JsonSerializer.Serialize(Message.Reply?.Attachments, new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = true
        });

        return OutMessage.FromCode(message);
    }

    [Command("id")]
    public OutMessage GetId()
    {
        if (Message.Reply is not null)
        {
            return OutMessage.FromText("Reply author id: " + Message.Reply.AccountId?.Identifier);
        }

        return OutMessage.FromText(Account.Id.Identifier);
    }
}
