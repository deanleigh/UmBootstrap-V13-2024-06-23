//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.4.0+6e3a691
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "featureComponentCode"
	/// <summary>Feature Component - Code</summary>
	public partial interface IFeatureComponentCode : IPublishedElement
	{
		/// <summary>Code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string FeaturePropertyFeatureCode { get; }
	}

	/// <summary>Feature Component - Code</summary>
	[PublishedModel("featureComponentCode")]
	public partial class FeatureComponentCode : PublishedElementModel, IFeatureComponentCode
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		public new const string ModelTypeAlias = "featureComponentCode";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<FeatureComponentCode, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public FeatureComponentCode(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("featurePropertyFeatureCode")]
		public virtual string FeaturePropertyFeatureCode => GetFeaturePropertyFeatureCode(this, _publishedValueFallback);

		/// <summary>Static getter for Code</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.0+6e3a691")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetFeaturePropertyFeatureCode(IFeatureComponentCode that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "featurePropertyFeatureCode");
	}
}
