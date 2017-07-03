// <auto-generated />
namespace Microsoft.AspNetCore.Razor.Language
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Razor.Language.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Value cannot be null or an empty string.
        /// </summary>
        internal static string ArgumentCannotBeNullOrEmpty
        {
            get => GetString("ArgumentCannotBeNullOrEmpty");
        }

        /// <summary>
        /// Value cannot be null or an empty string.
        /// </summary>
        internal static string FormatArgumentCannotBeNullOrEmpty()
            => GetString("ArgumentCannotBeNullOrEmpty");

        /// <summary>
        /// The '{0}' feature requires a '{1}' provided by the '{2}'.
        /// </summary>
        internal static string FeatureDependencyMissing
        {
            get => GetString("FeatureDependencyMissing");
        }

        /// <summary>
        /// The '{0}' feature requires a '{1}' provided by the '{2}'.
        /// </summary>
        internal static string FormatFeatureDependencyMissing(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("FeatureDependencyMissing"), p0, p1, p2);

        /// <summary>
        /// Invalid tag helper directive look up text '{0}'. The correct look up text format is: "name, assemblyName".
        /// </summary>
        internal static string InvalidTagHelperLookupText
        {
            get => GetString("InvalidTagHelperLookupText");
        }

        /// <summary>
        /// Invalid tag helper directive look up text '{0}'. The correct look up text format is: "name, assemblyName".
        /// </summary>
        internal static string FormatInvalidTagHelperLookupText(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidTagHelperLookupText"), p0);

        /// <summary>
        /// Invalid tag helper directive '{0}' value. '{1}' is not allowed in prefix '{2}'.
        /// </summary>
        internal static string InvalidTagHelperPrefixValue
        {
            get => GetString("InvalidTagHelperPrefixValue");
        }

        /// <summary>
        /// Invalid tag helper directive '{0}' value. '{1}' is not allowed in prefix '{2}'.
        /// </summary>
        internal static string FormatInvalidTagHelperPrefixValue(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidTagHelperPrefixValue"), p0, p1, p2);

        /// <summary>
        /// The '{0}' operation is not valid when the builder is empty.
        /// </summary>
        internal static string IntermediateNodeBuilder_PopInvalid
        {
            get => GetString("IntermediateNodeBuilder_PopInvalid");
        }

        /// <summary>
        /// The '{0}' operation is not valid when the builder is empty.
        /// </summary>
        internal static string FormatIntermediateNodeBuilder_PopInvalid(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("IntermediateNodeBuilder_PopInvalid"), p0);

        /// <summary>
        /// The specified encoding '{0}' does not match the content's encoding '{1}'.
        /// </summary>
        internal static string MismatchedContentEncoding
        {
            get => GetString("MismatchedContentEncoding");
        }

        /// <summary>
        /// The specified encoding '{0}' does not match the content's encoding '{1}'.
        /// </summary>
        internal static string FormatMismatchedContentEncoding(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("MismatchedContentEncoding"), p0, p1);

        /// <summary>
        /// The '{0}' phase requires a '{1}' provided by the '{2}'.
        /// </summary>
        internal static string PhaseDependencyMissing
        {
            get => GetString("PhaseDependencyMissing");
        }

        /// <summary>
        /// The '{0}' phase requires a '{1}' provided by the '{2}'.
        /// </summary>
        internal static string FormatPhaseDependencyMissing(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("PhaseDependencyMissing"), p0, p1, p2);

        /// <summary>
        /// The phase must be initialized by setting the '{0}' property.
        /// </summary>
        internal static string PhaseMustBeInitialized
        {
            get => GetString("PhaseMustBeInitialized");
        }

        /// <summary>
        /// The phase must be initialized by setting the '{0}' property.
        /// </summary>
        internal static string FormatPhaseMustBeInitialized(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("PhaseMustBeInitialized"), p0);

        /// <summary>
        /// Tag helper directive assembly name cannot be null or empty.
        /// </summary>
        internal static string TagHelperAssemblyNameCannotBeEmptyOrNull
        {
            get => GetString("TagHelperAssemblyNameCannotBeEmptyOrNull");
        }

        /// <summary>
        /// Tag helper directive assembly name cannot be null or empty.
        /// </summary>
        internal static string FormatTagHelperAssemblyNameCannotBeEmptyOrNull()
            => GetString("TagHelperAssemblyNameCannotBeEmptyOrNull");

        /// <summary>
        /// Path must begin with a forward slash '/'.
        /// </summary>
        internal static string RazorProject_PathMustStartWithForwardSlash
        {
            get => GetString("RazorProject_PathMustStartWithForwardSlash");
        }

        /// <summary>
        /// Path must begin with a forward slash '/'.
        /// </summary>
        internal static string FormatRazorProject_PathMustStartWithForwardSlash()
            => GetString("RazorProject_PathMustStartWithForwardSlash");

        /// <summary>
        /// A non-optional directive token cannot follow an optional directive token.
        /// </summary>
        internal static string DirectiveDescriptor_InvalidNonOptionalToken
        {
            get => GetString("DirectiveDescriptor_InvalidNonOptionalToken");
        }

        /// <summary>
        /// A non-optional directive token cannot follow an optional directive token.
        /// </summary>
        internal static string FormatDirectiveDescriptor_InvalidNonOptionalToken()
            => GetString("DirectiveDescriptor_InvalidNonOptionalToken");

        /// <summary>
        /// The document of kind '{0}' does not have a '{1}'. The document classifier must set a value for '{2}'.
        /// </summary>
        internal static string DocumentMissingTarget
        {
            get => GetString("DocumentMissingTarget");
        }

        /// <summary>
        /// The document of kind '{0}' does not have a '{1}'. The document classifier must set a value for '{2}'.
        /// </summary>
        internal static string FormatDocumentMissingTarget(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("DocumentMissingTarget"), p0, p1, p2);

        /// <summary>
        /// The item '{0}' could not be found.
        /// </summary>
        internal static string RazorTemplateEngine_ItemCouldNotBeFound
        {
            get => GetString("RazorTemplateEngine_ItemCouldNotBeFound");
        }

        /// <summary>
        /// The item '{0}' could not be found.
        /// </summary>
        internal static string FormatRazorTemplateEngine_ItemCouldNotBeFound(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("RazorTemplateEngine_ItemCouldNotBeFound"), p0);

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with name '{2}' because the name contains a '{3}' character.
        /// </summary>
        internal static string TagHelper_InvalidBoundAttributeName
        {
            get => GetString("TagHelper_InvalidBoundAttributeName");
        }

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with name '{2}' because the name contains a '{3}' character.
        /// </summary>
        internal static string FormatTagHelper_InvalidBoundAttributeName(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidBoundAttributeName"), p0, p1, p2, p3);

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with name '{2}' because the name starts with '{3}'.
        /// </summary>
        internal static string TagHelper_InvalidBoundAttributeNameStartsWith
        {
            get => GetString("TagHelper_InvalidBoundAttributeNameStartsWith");
        }

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with name '{2}' because the name starts with '{3}'.
        /// </summary>
        internal static string FormatTagHelper_InvalidBoundAttributeNameStartsWith(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidBoundAttributeNameStartsWith"), p0, p1, p2, p3);

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with a null or empty name.
        /// </summary>
        internal static string TagHelper_InvalidBoundAttributeNullOrWhitespace
        {
            get => GetString("TagHelper_InvalidBoundAttributeNullOrWhitespace");
        }

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with a null or empty name.
        /// </summary>
        internal static string FormatTagHelper_InvalidBoundAttributeNullOrWhitespace(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidBoundAttributeNullOrWhitespace"), p0, p1);

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with prefix '{2}' because the prefix contains a '{3}' character.
        /// </summary>
        internal static string TagHelper_InvalidBoundAttributePrefix
        {
            get => GetString("TagHelper_InvalidBoundAttributePrefix");
        }

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with prefix '{2}' because the prefix contains a '{3}' character.
        /// </summary>
        internal static string FormatTagHelper_InvalidBoundAttributePrefix(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidBoundAttributePrefix"), p0, p1, p2, p3);

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with prefix '{2}' because the prefix starts with '{3}'.
        /// </summary>
        internal static string TagHelper_InvalidBoundAttributePrefixStartsWith
        {
            get => GetString("TagHelper_InvalidBoundAttributePrefixStartsWith");
        }

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with prefix '{2}' because the prefix starts with '{3}'.
        /// </summary>
        internal static string FormatTagHelper_InvalidBoundAttributePrefixStartsWith(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidBoundAttributePrefixStartsWith"), p0, p1, p2, p3);

        /// <summary>
        /// Invalid restricted child '{1}' for tag helper '{0}'. Tag helpers cannot restrict child elements that contain a '{2}' character.
        /// </summary>
        internal static string TagHelper_InvalidRestrictedChild
        {
            get => GetString("TagHelper_InvalidRestrictedChild");
        }

        /// <summary>
        /// Invalid restricted child '{1}' for tag helper '{0}'. Tag helpers cannot restrict child elements that contain a '{2}' character.
        /// </summary>
        internal static string FormatTagHelper_InvalidRestrictedChild(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidRestrictedChild"), p0, p1, p2);

        /// <summary>
        /// Invalid restricted child for tag helper '{0}'. Name cannot be null or whitespace.
        /// </summary>
        internal static string TagHelper_InvalidRestrictedChildNullOrWhitespace
        {
            get => GetString("TagHelper_InvalidRestrictedChildNullOrWhitespace");
        }

        /// <summary>
        /// Invalid restricted child for tag helper '{0}'. Name cannot be null or whitespace.
        /// </summary>
        internal static string FormatTagHelper_InvalidRestrictedChildNullOrWhitespace(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidRestrictedChildNullOrWhitespace"), p0);

        /// <summary>
        /// Tag helpers cannot target attribute name '{0}' because it contains a '{1}' character.
        /// </summary>
        internal static string TagHelper_InvalidTargetedAttributeName
        {
            get => GetString("TagHelper_InvalidTargetedAttributeName");
        }

        /// <summary>
        /// Tag helpers cannot target attribute name '{0}' because it contains a '{1}' character.
        /// </summary>
        internal static string FormatTagHelper_InvalidTargetedAttributeName(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidTargetedAttributeName"), p0, p1);

        /// <summary>
        /// Targeted attribute name cannot be null or whitespace.
        /// </summary>
        internal static string TagHelper_InvalidTargetedAttributeNameNullOrWhitespace
        {
            get => GetString("TagHelper_InvalidTargetedAttributeNameNullOrWhitespace");
        }

        /// <summary>
        /// Targeted attribute name cannot be null or whitespace.
        /// </summary>
        internal static string FormatTagHelper_InvalidTargetedAttributeNameNullOrWhitespace()
            => GetString("TagHelper_InvalidTargetedAttributeNameNullOrWhitespace");

        /// <summary>
        /// Tag helpers cannot target parent tag name '{0}' because it contains a '{1}' character.
        /// </summary>
        internal static string TagHelper_InvalidTargetedParentTagName
        {
            get => GetString("TagHelper_InvalidTargetedParentTagName");
        }

        /// <summary>
        /// Tag helpers cannot target parent tag name '{0}' because it contains a '{1}' character.
        /// </summary>
        internal static string FormatTagHelper_InvalidTargetedParentTagName(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidTargetedParentTagName"), p0, p1);

        /// <summary>
        /// Targeted parent tag name cannot be null or whitespace.
        /// </summary>
        internal static string TagHelper_InvalidTargetedParentTagNameNullOrWhitespace
        {
            get => GetString("TagHelper_InvalidTargetedParentTagNameNullOrWhitespace");
        }

        /// <summary>
        /// Targeted parent tag name cannot be null or whitespace.
        /// </summary>
        internal static string FormatTagHelper_InvalidTargetedParentTagNameNullOrWhitespace()
            => GetString("TagHelper_InvalidTargetedParentTagNameNullOrWhitespace");

        /// <summary>
        /// Tag helpers cannot target tag name '{0}' because it contains a '{1}' character.
        /// </summary>
        internal static string TagHelper_InvalidTargetedTagName
        {
            get => GetString("TagHelper_InvalidTargetedTagName");
        }

        /// <summary>
        /// Tag helpers cannot target tag name '{0}' because it contains a '{1}' character.
        /// </summary>
        internal static string FormatTagHelper_InvalidTargetedTagName(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidTargetedTagName"), p0, p1);

        /// <summary>
        /// Targeted tag name cannot be null or whitespace.
        /// </summary>
        internal static string TagHelper_InvalidTargetedTagNameNullOrWhitespace
        {
            get => GetString("TagHelper_InvalidTargetedTagNameNullOrWhitespace");
        }

        /// <summary>
        /// Targeted tag name cannot be null or whitespace.
        /// </summary>
        internal static string FormatTagHelper_InvalidTargetedTagNameNullOrWhitespace()
            => GetString("TagHelper_InvalidTargetedTagNameNullOrWhitespace");

        /// <summary>
        /// The node '{0}' is not the owner of change '{1}'.
        /// </summary>
        internal static string InvalidOperation_SpanIsNotChangeOwner
        {
            get => GetString("InvalidOperation_SpanIsNotChangeOwner");
        }

        /// <summary>
        /// The node '{0}' is not the owner of change '{1}'.
        /// </summary>
        internal static string FormatInvalidOperation_SpanIsNotChangeOwner(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidOperation_SpanIsNotChangeOwner"), p0, p1);

        /// <summary>
        /// Invalid directive keyword '{0}'. Directives must have a non-empty keyword that consists only of letters.
        /// </summary>
        internal static string DirectiveDescriptor_InvalidDirectiveKeyword
        {
            get => GetString("DirectiveDescriptor_InvalidDirectiveKeyword");
        }

        /// <summary>
        /// Invalid directive keyword '{0}'. Directives must have a non-empty keyword that consists only of letters.
        /// </summary>
        internal static string FormatDirectiveDescriptor_InvalidDirectiveKeyword(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DirectiveDescriptor_InvalidDirectiveKeyword"), p0);

        /// <summary>
        /// The feature must be initialized by setting the '{0}' property.
        /// </summary>
        internal static string FeatureMustBeInitialized
        {
            get => GetString("FeatureMustBeInitialized");
        }

        /// <summary>
        /// The feature must be initialized by setting the '{0}' property.
        /// </summary>
        internal static string FormatFeatureMustBeInitialized(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("FeatureMustBeInitialized"), p0);

        /// <summary>
        /// The document type '{0}' does not support the extension '{1}'.
        /// </summary>
        internal static string Diagnostic_CodeTarget_UnsupportedExtension
        {
            get => GetString("Diagnostic_CodeTarget_UnsupportedExtension");
        }

        /// <summary>
        /// The document type '{0}' does not support the extension '{1}'.
        /// </summary>
        internal static string FormatDiagnostic_CodeTarget_UnsupportedExtension(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("Diagnostic_CodeTarget_UnsupportedExtension"), p0, p1);

        /// <summary>
        /// The '{0}` directive must appear at the start of the line.
        /// </summary>
        internal static string DirectiveMustAppearAtStartOfLine
        {
            get => GetString("DirectiveMustAppearAtStartOfLine");
        }

        /// <summary>
        /// The '{0}` directive must appear at the start of the line.
        /// </summary>
        internal static string FormatDirectiveMustAppearAtStartOfLine(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DirectiveMustAppearAtStartOfLine"), p0);

        /// <summary>
        /// The '{0}' directives value(s) must be separated by whitespace.
        /// </summary>
        internal static string DirectiveTokensMustBeSeparatedByWhitespace
        {
            get => GetString("DirectiveTokensMustBeSeparatedByWhitespace");
        }

        /// <summary>
        /// The '{0}' directives value(s) must be separated by whitespace.
        /// </summary>
        internal static string FormatDirectiveTokensMustBeSeparatedByWhitespace(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DirectiveTokensMustBeSeparatedByWhitespace"), p0);

        /// <summary>
        /// The key must not be null.
        /// </summary>
        internal static string KeyMustNotBeNull
        {
            get => GetString("KeyMustNotBeNull");
        }

        /// <summary>
        /// The key must not be null.
        /// </summary>
        internal static string FormatKeyMustNotBeNull()
            => GetString("KeyMustNotBeNull");

        /// <summary>
        /// The reference is invalid. The node '{0}' could not be found as a child of '{1}'.
        /// </summary>
        internal static string IntermediateNodeReference_NodeNotFound
        {
            get => GetString("IntermediateNodeReference_NodeNotFound");
        }

        /// <summary>
        /// The reference is invalid. The node '{0}' could not be found as a child of '{1}'.
        /// </summary>
        internal static string FormatIntermediateNodeReference_NodeNotFound(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("IntermediateNodeReference_NodeNotFound"), p0, p1);

        /// <summary>
        /// The reference is invalid. References initialized with the default constructor cannot modify nodes.
        /// </summary>
        internal static string IntermediateNodeReference_NotInitialized
        {
            get => GetString("IntermediateNodeReference_NotInitialized");
        }

        /// <summary>
        /// The reference is invalid. References initialized with the default constructor cannot modify nodes.
        /// </summary>
        internal static string FormatIntermediateNodeReference_NotInitialized()
            => GetString("IntermediateNodeReference_NotInitialized");

        /// <summary>
        /// The node '{0}' has a read-only child collection and cannot be modified.
        /// </summary>
        internal static string IntermediateNodeReference_CollectionIsReadOnly
        {
            get => GetString("IntermediateNodeReference_CollectionIsReadOnly");
        }

        /// <summary>
        /// The node '{0}' has a read-only child collection and cannot be modified.
        /// </summary>
        internal static string FormatIntermediateNodeReference_CollectionIsReadOnly(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("IntermediateNodeReference_CollectionIsReadOnly"), p0);

        /// <summary>
        /// The '{0}' directive may only occur once per document.
        /// </summary>
        internal static string DuplicateDirective
        {
            get => GetString("DuplicateDirective");
        }

        /// <summary>
        /// The '{0}' directive may only occur once per document.
        /// </summary>
        internal static string FormatDuplicateDirective(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DuplicateDirective"), p0);

        /// <summary>
        /// The '{0}' directive must exist prior to markup or code.
        /// </summary>
        internal static string DirectiveMustExistBeforeMarkupOrCode
        {
            get => GetString("DirectiveMustExistBeforeMarkupOrCode");
        }

        /// <summary>
        /// The '{0}' directive must exist prior to markup or code.
        /// </summary>
        internal static string FormatDirectiveMustExistBeforeMarkupOrCode(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DirectiveMustExistBeforeMarkupOrCode"), p0);

        /// <summary>
        /// Block directive '{0}' cannot be imported.
        /// </summary>
        internal static string BlockDirectiveCannotBeImported
        {
            get => GetString("BlockDirectiveCannotBeImported");
        }

        /// <summary>
        /// Block directive '{0}' cannot be imported.
        /// </summary>
        internal static string FormatBlockDirectiveCannotBeImported(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("BlockDirectiveCannotBeImported"), p0);

        /// <summary>
        /// Unreachable code. This can happen when a new {0} is introduced.
        /// </summary>
        internal static string UnexpectedDirectiveKind
        {
            get => GetString("UnexpectedDirectiveKind");
        }

        /// <summary>
        /// Unreachable code. This can happen when a new {0} is introduced.
        /// </summary>
        internal static string FormatUnexpectedDirectiveKind(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("UnexpectedDirectiveKind"), p0);

        /// <summary>
        /// The '{0}' requires a '{1}' delegate to be set.
        /// </summary>
        internal static string RenderingContextRequiresDelegate
        {
            get => GetString("RenderingContextRequiresDelegate");
        }

        /// <summary>
        /// The '{0}' requires a '{1}' delegate to be set.
        /// </summary>
        internal static string FormatRenderingContextRequiresDelegate(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("RenderingContextRequiresDelegate"), p0, p1);

        /// <summary>
        /// The '{0}' node type can only be used as a direct child of a '{1}' node.
        /// </summary>
        internal static string IntermediateNodes_InvalidParentNode
        {
            get => GetString("IntermediateNodes_InvalidParentNode");
        }

        /// <summary>
        /// The '{0}' node type can only be used as a direct child of a '{1}' node.
        /// </summary>
        internal static string FormatIntermediateNodes_InvalidParentNode(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("IntermediateNodes_InvalidParentNode"), p0, p1);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
