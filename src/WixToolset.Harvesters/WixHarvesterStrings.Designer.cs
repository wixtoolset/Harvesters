﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WixToolset.Harvesters {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class WixHarvesterStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WixHarvesterStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WixToolset.Harvesters.WixHarvesterStrings", typeof(WixHarvesterStrings).Assembly);
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
        ///   Looks up a localized string similar to Collection has {0} elements. Must have at least one..
        /// </summary>
        internal static string EXP_CollectionMustHaveAtLeastOneElement {
            get {
                return ResourceManager.GetString("EXP_CollectionMustHaveAtLeastOneElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Element must be a subclass of {0}, but was of type {1}..
        /// </summary>
        internal static string EXP_ElementIsSubclassOfDifferentType {
            get {
                return ResourceManager.GetString("EXP_ElementIsSubclassOfDifferentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Element of type {0} found in enumerator. Must be ChoiceItem or SequenceItem..
        /// </summary>
        internal static string EXP_ElementMustBeChoiceItemOrSequenceItem {
            get {
                return ResourceManager.GetString("EXP_ElementMustBeChoiceItemOrSequenceItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Element of type {0} is not valid for this collection..
        /// </summary>
        internal static string EXP_ElementOfTypeIsNotValidForThisCollection {
            get {
                return ResourceManager.GetString("EXP_ElementOfTypeIsNotValidForThisCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ISchemaElement with name {0} does not implement ICreateChildren..
        /// </summary>
        internal static string EXP_ISchemaElementDoesnotImplementICreateChildren {
            get {
                return ResourceManager.GetString("EXP_ISchemaElementDoesnotImplementICreateChildren", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ISchemaElement with name {0} does not implement ISetAttributes..
        /// </summary>
        internal static string EXP_ISchemaElementDoesnotImplementISetAttribute {
            get {
                return ResourceManager.GetString("EXP_ISchemaElementDoesnotImplementISetAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Merge table FileCompression column contains an invalid value &apos;{0}&apos;..
        /// </summary>
        internal static string EXP_MergeTableFileCompressionColumnContainsInvalidValue {
            get {
                return ResourceManager.GetString("EXP_MergeTableFileCompressionColumnContainsInvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple root elements found in file..
        /// </summary>
        internal static string EXP_MultipleRootElementsFoundInFile {
            get {
                return ResourceManager.GetString("EXP_MultipleRootElementsFoundInFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type {0} is not valid for this collection..
        /// </summary>
        internal static string EXP_TypeIsNotValidForThisCollection {
            get {
                return ResourceManager.GetString("EXP_TypeIsNotValidForThisCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XmlElement with name {0} does not have a corresponding ISchemaElement..
        /// </summary>
        internal static string EXP_XmlElementDoesnotHaveISchemaElement {
            get {
                return ResourceManager.GetString("EXP_XmlElementDoesnotHaveISchemaElement", resourceCulture);
            }
        }
    }
}
