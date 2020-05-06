﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Threading.Tasks;
using Xunit;
using VerifyCS = Test.Utilities.CSharpCodeFixVerifier<
    Microsoft.CodeQuality.Analyzers.ApiDesignGuidelines.DoNotOverloadOperatorEqualsOnReferenceTypes,
    Microsoft.CodeAnalysis.Testing.EmptyCodeFixProvider>;
using VerifyVB = Test.Utilities.VisualBasicCodeFixVerifier<
    Microsoft.CodeQuality.Analyzers.ApiDesignGuidelines.DoNotOverloadOperatorEqualsOnReferenceTypes,
    Microsoft.CodeAnalysis.Testing.EmptyCodeFixProvider>;

namespace Microsoft.CodeQuality.Analyzers.ApiDesignGuidelines.UnitTests
{
    public class DoNotOverloadOperatorEqualsOnReferenceTypesTests
    {
        [Fact]
        public async Task OperatorEqual_ReferenceType_Diagnostic()
        {
            await VerifyCS.VerifyAnalyzerAsync(@"
public class C
{
    public static bool operator ==(C left, C right) => true;
    public static bool operator !=(C left, C right) => true;
}",
                VerifyCS.Diagnostic().WithSpan(4, 33, 4, 35).WithArguments("C"));

            await VerifyVB.VerifyAnalyzerAsync(@"
Public Class C
    Public Shared Operator =(ByVal left As C, ByVal right As C) As Boolean
        Return True
    End Operator

    Public Shared Operator <>(ByVal left As C, ByVal right As C) As Boolean
        Return True
    End Operator
End Class",
                VerifyVB.Diagnostic().WithSpan(3, 28, 3, 29).WithArguments("C"));
        }

        [Fact]
        public async Task OperatorEqual_ValueType_NoDiagnostic()
        {
            await VerifyCS.VerifyAnalyzerAsync(@"
public struct C
{
    public static bool operator ==(C left, C right) => true;
    public static bool operator !=(C left, C right) => true;
}");

            await VerifyVB.VerifyAnalyzerAsync(@"
Public Structure C
    Public Shared Operator =(ByVal left As C, ByVal right As C) As Boolean
        Return True
    End Operator

    Public Shared Operator <>(ByVal left As C, ByVal right As C) As Boolean
        Return True
    End Operator
End Structure");
        }

        [Fact]
        public async Task OperatorEqualAndAdditionSubtraction_ReferenceType_Diagnostic()
        {
            // Doc states that if type behaves as a value-type and has addition/subtraction it might be safe.

            await VerifyCS.VerifyAnalyzerAsync(@"
public class C
{
    public static bool operator [|==|](C left, C right) => true;
    public static bool operator !=(C left, C right) => true;

    public static C operator +(C left, C right) => left;
    public static C operator -(C left, C right) => left;
}");

            await VerifyVB.VerifyAnalyzerAsync(@"
Public Class C
    Public Shared Operator [|=|](ByVal left As C, ByVal right As C) As Boolean
        Return True
    End Operator

    Public Shared Operator <>(ByVal left As C, ByVal right As C) As Boolean
        Return True
    End Operator

    Public Shared Operator +(ByVal left As C, ByVal right As C) As C
        Return left
    End Operator

    Public Shared Operator -(ByVal left As C, ByVal right As C) As C
        Return left
    End Operator
End Class");
        }

        [Theory]
        // General analyzer option
        [InlineData("public", "dotnet_code_quality.api_surface = public")]
        [InlineData("public", "dotnet_code_quality.api_surface = private, internal, public")]
        [InlineData("public", "dotnet_code_quality.api_surface = all")]
        [InlineData("protected", "dotnet_code_quality.api_surface = public")]
        [InlineData("protected", "dotnet_code_quality.api_surface = private, internal, public")]
        [InlineData("protected", "dotnet_code_quality.api_surface = all")]
        [InlineData("internal", "dotnet_code_quality.api_surface = internal")]
        [InlineData("internal", "dotnet_code_quality.api_surface = private, internal")]
        [InlineData("internal", "dotnet_code_quality.api_surface = all")]
        [InlineData("private", "dotnet_code_quality.api_surface = private")]
        [InlineData("private", "dotnet_code_quality.api_surface = private, public")]
        [InlineData("private", "dotnet_code_quality.api_surface = all")]
        // Specific analyzer option
        [InlineData("internal", "dotnet_code_quality.CA1046.api_surface = all")]
        [InlineData("internal", "dotnet_code_quality.Design.api_surface = all")]
        // General + Specific analyzer option
        [InlineData("internal", @"dotnet_code_quality.api_surface = private
                                  dotnet_code_quality.CA1046.api_surface = all")]
        // Case-insensitive analyzer option
        [InlineData("internal", "DOTNET_code_quality.CA1046.API_SURFACE = ALL")]
        // Invalid analyzer option ignored
        [InlineData("internal", @"dotnet_code_quality.api_surface = all
                                  dotnet_code_quality.CA1046.api_surface_2 = private")]
        public async Task CSharp_ApiSurfaceOption(string accessibility, string editorConfigText)
        {
            await new VerifyCS.Test
            {
                TestState =
                {
                    Sources =
                    {
                        $@"
public class OuterClass
{{
    {accessibility} class C
    {{
        public static bool operator [|==|](C left, C right) => true;
        public static bool operator !=(C left, C right) => true;
    }}
}}"
                    },
                    AdditionalFiles = { (".editorconfig", editorConfigText), },
                },
            }.RunAsync();
        }

        [Theory]
        // General analyzer option
        [InlineData("Public", "dotnet_code_quality.api_surface = Public")]
        [InlineData("Public", "dotnet_code_quality.api_surface = Private, Friend, Public")]
        [InlineData("Public", "dotnet_code_quality.api_surface = All")]
        [InlineData("Protected", "dotnet_code_quality.api_surface = Public")]
        [InlineData("Protected", "dotnet_code_quality.api_surface = Private, Friend, Public")]
        [InlineData("Protected", "dotnet_code_quality.api_surface = All")]
        [InlineData("Friend", "dotnet_code_quality.api_surface = Friend")]
        [InlineData("Friend", "dotnet_code_quality.api_surface = Private, Friend")]
        [InlineData("Friend", "dotnet_code_quality.api_surface = All")]
        [InlineData("Private", "dotnet_code_quality.api_surface = Private")]
        [InlineData("Private", "dotnet_code_quality.api_surface = Private, Public")]
        [InlineData("Private", "dotnet_code_quality.api_surface = All")]
        // Specific analyzer option
        [InlineData("Friend", "dotnet_code_quality.CA1046.api_surface = All")]
        [InlineData("Friend", "dotnet_code_quality.Design.api_surface = All")]
        // General + Specific analyzer option
        [InlineData("Friend", @"dotnet_code_quality.api_surface = Private
                                dotnet_code_quality.CA1046.api_surface = All")]
        // Case-insensitive analyzer option
        [InlineData("Friend", "DOTNET_code_quality.CA1046.API_SURFACE = ALL")]
        // Invalid analyzer option ignored
        [InlineData("Friend", @"dotnet_code_quality.api_surface = All
                                dotnet_code_quality.CA1046.api_surface_2 = Private")]
        public async Task VisualBasic_ApiSurfaceOption(string accessibility, string editorConfigText)
        {
            await new VerifyVB.Test
            {
                TestState =
                {
                    Sources =
                    {
                        $@"
Public Class OuterClass
    {accessibility} Class C
        Public Shared Operator [|=|](ByVal left As C, ByVal right As C) As Boolean
            Return True
        End Operator

        Public Shared Operator <>(ByVal left As C, ByVal right As C) As Boolean
            Return True
        End Operator
    End Class
End Class"
                    },
                    AdditionalFiles = { (".editorconfig", editorConfigText), },
                },
            }.RunAsync();
        }

        [Fact]
        public async Task OperatorEqual_InternalReferenceType_NoDiagnostic()
        {
            await VerifyCS.VerifyAnalyzerAsync(@"
internal class C
{
    public static bool operator ==(C left, C right) => true;
    public static bool operator !=(C left, C right) => true;
}");

            await VerifyVB.VerifyAnalyzerAsync(@"
Friend Class C
    Public Shared Operator =(ByVal left As C, ByVal right As C) As Boolean
        Return True
    End Operator

    Public Shared Operator <>(ByVal left As C, ByVal right As C) As Boolean
        Return True
    End Operator
End Class");
        }

        [Fact]
        public async Task OperatorEqual_IEquatable_NoDiagnostic()
        {
            await VerifyCS.VerifyAnalyzerAsync(@"
using System;
public class C : IEquatable<C>
{
    public bool Equals(C other) => true;
    public static bool operator ==(C left, C right) => true;
    public static bool operator !=(C left, C right) => true;
}");

            await VerifyVB.VerifyAnalyzerAsync(@"
Imports System
Public Class C
    Implements IEquatable(Of C)

    Public Function Equals(ByVal other As C) As Boolean Implements IEquatable(Of C).Equals
        Return True
    End Function

    Public Shared Operator =(ByVal left As C, ByVal right As C) As Boolean
        Return True
    End Operator

    Public Shared Operator <>(ByVal left As C, ByVal right As C) As Boolean
        Return True
    End Operator
End Class");
        }
    }
}
