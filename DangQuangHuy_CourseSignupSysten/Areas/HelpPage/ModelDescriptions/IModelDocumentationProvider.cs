using System;
using System.Reflection;

namespace DangQuangHuy_CourseSignupSysten.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}