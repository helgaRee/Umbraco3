//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
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
	/// <summary>Projects List Page</summary>
	[PublishedModel("projectsListPage")]
	public partial class ProjectsListPage : PublishedContentModel, IServiceListPage
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "projectsListPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ProjectsListPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ProjectsListPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Aside Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("asideTitle")]
		public virtual string AsideTitle => this.Value<string>(_publishedValueFallback, "asideTitle");

		///<summary>
		/// Background Color Support
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("backgroundColorSupport")]
		public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor BackgroundColorSupport => this.Value<global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor>(_publishedValueFallback, "backgroundColorSupport");

		///<summary>
		/// Bodytext Support
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bodytextSupport")]
		public virtual string BodytextSupport => this.Value<string>(_publishedValueFallback, "bodytextSupport");

		///<summary>
		/// Content Support
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contentSupport")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString ContentSupport => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "contentSupport");

		///<summary>
		/// Headline Support
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("headlineSupport")]
		public virtual string HeadlineSupport => this.Value<string>(_publishedValueFallback, "headlineSupport");

		///<summary>
		/// Keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("keywords")]
		public virtual global::System.Collections.Generic.IEnumerable<string> Keywords => this.Value<global::System.Collections.Generic.IEnumerable<string>>(_publishedValueFallback, "keywords");

		///<summary>
		/// Recent Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentHeadline")]
		public virtual string RecentHeadline => this.Value<string>(_publishedValueFallback, "recentHeadline");

		///<summary>
		/// Recent Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops RecentImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "recentImage");

		///<summary>
		/// Recent Project Publiched
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectPubliched")]
		public virtual string RecentProjectPubliched => this.Value<string>(_publishedValueFallback, "recentProjectPubliched");

		///<summary>
		/// Recent Project Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectTitle")]
		public virtual string RecentProjectTitle => this.Value<string>(_publishedValueFallback, "recentProjectTitle");

		///<summary>
		/// Custom Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("customHeadline")]
		public virtual string CustomHeadline => global::Umbraco.Cms.Web.Common.PublishedModels.ServiceListPage.GetCustomHeadline(this, _publishedValueFallback);

		///<summary>
		/// Layout
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("layout")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockGridModel Layout => global::Umbraco.Cms.Web.Common.PublishedModels.ServiceListPage.GetLayout(this, _publishedValueFallback);

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => global::Umbraco.Cms.Web.Common.PublishedModels.ServiceListPage.GetPageTitle(this, _publishedValueFallback);
	}
}
