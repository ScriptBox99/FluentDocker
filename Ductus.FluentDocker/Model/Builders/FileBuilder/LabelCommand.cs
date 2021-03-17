using Ductus.FluentDocker.Extensions;
using Ductus.FluentDocker.Model.Common;
using System.Linq;

namespace Ductus.FluentDocker.Model.Builders.FileBuilder
{
  public sealed class LabelCommand : ICommand
  {
    public LabelCommand(params TemplateString[] nameValue)
    {
      if (nameValue == null || 0 == nameValue.Length)
      {
        NameValue = new string[0];
      }
      else
      {
        NameValue = nameValue.WrapValue().ToArray();
      }
    }

    public string[] NameValue { get; internal set; }

    public override string ToString()
    {
      if (0 == NameValue.Length)
      {
        return "";
      }

      return $"LABEL {string.Join(" ", NameValue)}";
    }
  }
}
