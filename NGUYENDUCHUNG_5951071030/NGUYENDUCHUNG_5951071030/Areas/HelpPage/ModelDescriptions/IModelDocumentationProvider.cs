using System;
using System.Reflection;

namespace NGUYENDUCHUNG_5951071030.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}