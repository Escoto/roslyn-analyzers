﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Roslyn.Diagnostics.Analyzers {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class RoslynDiagnosticsAnalyzersResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RoslynDiagnosticsAnalyzersResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Roslyn.Diagnostics.Analyzers.RoslynDiagnosticsAnalyzersResources", typeof(RoslynDiagnosticsAnalyzersResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All public types and members should be declared in PublicAPI.txt. This draws attention to API changes in the code reviews and source control history, and helps prevent breaking changes..
        /// </summary>
        internal static string AddPublicTypesAndMembersToTheDeclaredAPIDescription {
            get {
                return ResourceManager.GetString("AddPublicTypesAndMembersToTheDeclaredAPIDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add public types and members to the declared API.
        /// </summary>
        internal static string AddPublicTypesAndMembersToTheDeclaredAPIMessage {
            get {
                return ResourceManager.GetString("AddPublicTypesAndMembersToTheDeclaredAPIMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add public types and members to the declared API.
        /// </summary>
        internal static string AddPublicTypesAndMembersToTheDeclaredAPITitle {
            get {
                return ResourceManager.GetString("AddPublicTypesAndMembersToTheDeclaredAPITitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ApiDesign.
        /// </summary>
        internal static string CategoryApiDesign {
            get {
                return ResourceManager.GetString("CategoryApiDesign", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performance.
        /// </summary>
        internal static string CategoryPerformance {
            get {
                return ResourceManager.GetString("CategoryPerformance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reliability.
        /// </summary>
        internal static string CategoryReliability {
            get {
                return ResourceManager.GetString("CategoryReliability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage.
        /// </summary>
        internal static string CategoryUsage {
            get {
                return ResourceManager.GetString("CategoryUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accessing the Descriptor property of Diagnostic in compiler layer leads to unnecessary string allocations for fields of the descriptor that are not utilized in command line compilation. Hence, you should avoid accessing the Descriptor of the compiler diagnostics here. Instead you should directly access these properties off the Diagnostic type..
        /// </summary>
        internal static string DoNotInvokeDiagnosticDescriptorDescription {
            get {
                return ResourceManager.GetString("DoNotInvokeDiagnosticDescriptorDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not invoke Diagnostic.Descriptor.
        /// </summary>
        internal static string DoNotInvokeDiagnosticDescriptorMessage {
            get {
                return ResourceManager.GetString("DoNotInvokeDiagnosticDescriptorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not invoke Diagnostic.Descriptor.
        /// </summary>
        internal static string DoNotInvokeDiagnosticDescriptorTitle {
            get {
                return ResourceManager.GetString("DoNotInvokeDiagnosticDescriptorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #N/A.
        /// </summary>
        internal static string DoNotUseGenericCodeActionCreateToCreateCodeActionDescription {
            get {
                return ResourceManager.GetString("DoNotUseGenericCodeActionCreateToCreateCodeActionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not use generic CodeAction.Create to create CodeAction.
        /// </summary>
        internal static string DoNotUseGenericCodeActionCreateToCreateCodeActionMessage {
            get {
                return ResourceManager.GetString("DoNotUseGenericCodeActionCreateToCreateCodeActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not use generic CodeAction.Create to create CodeAction.
        /// </summary>
        internal static string DoNotUseGenericCodeActionCreateToCreateCodeActionTitle {
            get {
                return ResourceManager.GetString("DoNotUseGenericCodeActionCreateToCreateCodeActionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #N/A.
        /// </summary>
        internal static string InvokeTheCorrectPropertyToEnsureCorrectUseSiteDiagnosticsDescription {
            get {
                return ResourceManager.GetString("InvokeTheCorrectPropertyToEnsureCorrectUseSiteDiagnosticsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoke the correct property to ensure correct use site diagnostics..
        /// </summary>
        internal static string InvokeTheCorrectPropertyToEnsureCorrectUseSiteDiagnosticsMessage {
            get {
                return ResourceManager.GetString("InvokeTheCorrectPropertyToEnsureCorrectUseSiteDiagnosticsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoke the correct property to ensure correct use site diagnostics..
        /// </summary>
        internal static string InvokeTheCorrectPropertyToEnsureCorrectUseSiteDiagnosticsTitle {
            get {
                return ResourceManager.GetString("InvokeTheCorrectPropertyToEnsureCorrectUseSiteDiagnosticsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #N/A.
        /// </summary>
        internal static string OverrideObjectEqualsObjectWhenImplementingIequatableDescription {
            get {
                return ResourceManager.GetString("OverrideObjectEqualsObjectWhenImplementingIequatableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Override Object.Equals(object) when implementing Iequatable.
        /// </summary>
        internal static string OverrideObjectEqualsObjectWhenImplementingIequatableMessage {
            get {
                return ResourceManager.GetString("OverrideObjectEqualsObjectWhenImplementingIequatableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Override Object.Equals(object) when implementing Iequatable.
        /// </summary>
        internal static string OverrideObjectEqualsObjectWhenImplementingIequatableTitle {
            get {
                return ResourceManager.GetString("OverrideObjectEqualsObjectWhenImplementingIequatableTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When removing a public type or member the corresponding entry in PublicAPI.txt should also be removed. This draws attention to API changes in the code reviews and source control history, and helps prevent breaking changes..
        /// </summary>
        internal static string RemoveDeletedTypesAndMembersFromTheDeclaredAPIDescription {
            get {
                return ResourceManager.GetString("RemoveDeletedTypesAndMembersFromTheDeclaredAPIDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove deleted types and members from the declared API.
        /// </summary>
        internal static string RemoveDeletedTypesAndMembersFromTheDeclaredAPIMessage {
            get {
                return ResourceManager.GetString("RemoveDeletedTypesAndMembersFromTheDeclaredAPIMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove deleted types and members from the declared API.
        /// </summary>
        internal static string RemoveDeletedTypesAndMembersFromTheDeclaredAPITitle {
            get {
                return ResourceManager.GetString("RemoveDeletedTypesAndMembersFromTheDeclaredAPITitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compilation event queue is required to generate symbol declared events for all declared source symbols. Hence, every source symbol type or one of it&apos;s base types must generate a symbol declared event..
        /// </summary>
        internal static string SymbolDeclaredEventMustBeGeneratedForSourceSymbolsDescription {
            get {
                return ResourceManager.GetString("SymbolDeclaredEventMustBeGeneratedForSourceSymbolsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SymbolDeclaredEvent must be generated for source symbols.
        /// </summary>
        internal static string SymbolDeclaredEventMustBeGeneratedForSourceSymbolsMessage {
            get {
                return ResourceManager.GetString("SymbolDeclaredEventMustBeGeneratedForSourceSymbolsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SymbolDeclaredEvent must be generated for source symbols.
        /// </summary>
        internal static string SymbolDeclaredEventMustBeGeneratedForSourceSymbolsTitle {
            get {
                return ResourceManager.GetString("SymbolDeclaredEventMustBeGeneratedForSourceSymbolsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #N/A.
        /// </summary>
        internal static string TheContentsOfThePublicAPIFilesAreInvalidDescription {
            get {
                return ResourceManager.GetString("TheContentsOfThePublicAPIFilesAreInvalidDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The contents of the public API files are invalid.
        /// </summary>
        internal static string TheContentsOfThePublicAPIFilesAreInvalidMessage {
            get {
                return ResourceManager.GetString("TheContentsOfThePublicAPIFilesAreInvalidMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The contents of the public API files are invalid.
        /// </summary>
        internal static string TheContentsOfThePublicAPIFilesAreInvalidTitle {
            get {
                return ResourceManager.GetString("TheContentsOfThePublicAPIFilesAreInvalidTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #N/A.
        /// </summary>
        internal static string UseSpecializedCollectionsEmptyEnumerableDescription {
            get {
                return ResourceManager.GetString("UseSpecializedCollectionsEmptyEnumerableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use SpecializedCollections.EmptyEnumerable().
        /// </summary>
        internal static string UseSpecializedCollectionsEmptyEnumerableMessage {
            get {
                return ResourceManager.GetString("UseSpecializedCollectionsEmptyEnumerableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use SpecializedCollections.EmptyEnumerable().
        /// </summary>
        internal static string UseSpecializedCollectionsEmptyEnumerableTitle {
            get {
                return ResourceManager.GetString("UseSpecializedCollectionsEmptyEnumerableTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #N/A.
        /// </summary>
        internal static string UseSpecializedCollectionsSingletonEnumerableDescription {
            get {
                return ResourceManager.GetString("UseSpecializedCollectionsSingletonEnumerableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use SpecializedCollections.SingletonEnumerable().
        /// </summary>
        internal static string UseSpecializedCollectionsSingletonEnumerableMessage {
            get {
                return ResourceManager.GetString("UseSpecializedCollectionsSingletonEnumerableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use SpecializedCollections.SingletonEnumerable().
        /// </summary>
        internal static string UseSpecializedCollectionsSingletonEnumerableTitle {
            get {
                return ResourceManager.GetString("UseSpecializedCollectionsSingletonEnumerableTitle", resourceCulture);
            }
        }
    }
}