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
	/// <summary>Service Item Template</summary>
	[PublishedModel("serviceItemTemplate")]
	public partial class ServiceItemTemplate : PublishedContentModel, ISidebarBox
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "serviceItemTemplate";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ServiceItemTemplate, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ServiceItemTemplate(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Email Input
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("emailInput")]
		public virtual string EmailInput => this.Value<string>(_publishedValueFallback, "emailInput");

		///<summary>
		/// Layout
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("layout")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockGridModel Layout => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockGridModel>(_publishedValueFallback, "layout");

		///<summary>
		/// Page Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageContent")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString PageContent => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "pageContent");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// Preamble
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("preamble")]
		public virtual string Preamble => this.Value<string>(_publishedValueFallback, "preamble");

		///<summary>
		/// Question Form
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("questionForm")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel QuestionForm => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(_publishedValueFallback, "questionForm");

		///<summary>
		/// Thumbnail Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("thumbnailImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ThumbnailImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "thumbnailImage");

		///<summary>
		/// Background Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("backgroundColor")]
		public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor BackgroundColor => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetBackgroundColor(this, _publishedValueFallback);

		///<summary>
		/// Email Icon
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("emailIcon")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops EmailIcon => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetEmailIcon(this, _publishedValueFallback);

		///<summary>
		/// Input Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("inputEmail")]
		public virtual string InputEmail => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetInputEmail(this, _publishedValueFallback);

		///<summary>
		/// Sidebar Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sidebarHeadline")]
		public virtual string SidebarHeadline => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetSidebarHeadline(this, _publishedValueFallback);

		///<summary>
		/// Sidebar Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sidebarImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SidebarImage => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetSidebarImage(this, _publishedValueFallback);

		///<summary>
		/// Sidebar Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sidebarText")]
		public virtual string SidebarText => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetSidebarText(this, _publishedValueFallback);

		///<summary>
		/// Sidebar Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sidebarTitle")]
		public virtual string SidebarTitle => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetSidebarTitle(this, _publishedValueFallback);

		///<summary>
		/// Support Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("supportText")]
		public virtual string SupportText => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetSupportText(this, _publishedValueFallback);

		///<summary>
		/// Support Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("supportTitle")]
		public virtual string SupportTitle => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetSupportTitle(this, _publishedValueFallback);

		///<summary>
		/// Tags
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tags")]
		public virtual global::System.Collections.Generic.IEnumerable<string> Tags => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetTags(this, _publishedValueFallback);

		///<summary>
		/// Tag Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tagTitle")]
		public virtual string TagTitle => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetTagTitle(this, _publishedValueFallback);

		///<summary>
		/// With Border
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[ImplementPropertyType("withBorder")]
		public virtual bool WithBorder => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetWithBorder(this, _publishedValueFallback);

		///<summary>
		/// With Border Radius
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[ImplementPropertyType("withBorderRadius")]
		public virtual bool WithBorderRadius => global::Umbraco.Cms.Web.Common.PublishedModels.SidebarBox.GetWithBorderRadius(this, _publishedValueFallback);
	}
}
