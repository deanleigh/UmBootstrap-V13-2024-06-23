//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.6.1+82eae48
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
    // Mixin Content Type with alias "featureComponentImage"
    /// <summary>Feature Component - Image</summary>
    public partial interface IFeatureComponentImage : IPublishedElement
    {
        /// <summary>Image</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [global::System.Diagnostics.CodeAnalysis.MaybeNull]
        global::Umbraco.Cms.Core.Models.MediaWithCrops Image { get; }
    }

    /// <summary>Feature Component - Image</summary>
    [PublishedModel("featureComponentImage")]
    public partial class FeatureComponentImage : PublishedElementModel, IFeatureComponentImage
    {
        // helpers
#pragma warning disable 0109 // new is redundant
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        public new const string ModelTypeAlias = "featureComponentImage";
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        public new const PublishedItemType ModelItemType = PublishedItemType.Content;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
        public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
            => PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
        public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<FeatureComponentImage, TValue>> selector)
            => PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

        private IPublishedValueFallback _publishedValueFallback;

        // ctor
        public FeatureComponentImage(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
            : base(content, publishedValueFallback)
        {
            _publishedValueFallback = publishedValueFallback;
        }

        // properties

        ///<summary>
        /// Image
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [global::System.Diagnostics.CodeAnalysis.MaybeNull]
        [ImplementPropertyType("image")]
        public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Image => GetImage(this, _publishedValueFallback);

        /// <summary>Static getter for Image</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
        public static global::Umbraco.Cms.Core.Models.MediaWithCrops GetImage(IFeatureComponentImage that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(publishedValueFallback, "image");
    }
}
