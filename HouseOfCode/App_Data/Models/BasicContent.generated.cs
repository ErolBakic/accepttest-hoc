//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "basicContent"
	/// <summary>Hero</summary>
	public partial interface IBasicContent : IPublishedContent
	{
		/// <summary>Baggrundsbillede</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		global::Umbraco.Core.Models.PublishedContent.IPublishedContent Baggrundsbillede { get; }

		/// <summary>Overskrift</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		string Overskrift { get; }

		/// <summary>Underskrift</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		string Underskrift { get; }
	}

	/// <summary>Hero</summary>
	[PublishedModel("basicContent")]
	public partial class BasicContent : PublishedContentModel, IBasicContent
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public new const string ModelTypeAlias = "basicContent";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasicContent, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public BasicContent(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Baggrundsbillede
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("baggrundsbillede")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent Baggrundsbillede => GetBaggrundsbillede(this);

		/// <summary>Static getter for Baggrundsbillede</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public static global::Umbraco.Core.Models.PublishedContent.IPublishedContent GetBaggrundsbillede(IBasicContent that) => that.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("baggrundsbillede");

		///<summary>
		/// Overskrift
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("overskrift")]
		public string Overskrift => GetOverskrift(this);

		/// <summary>Static getter for Overskrift</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public static string GetOverskrift(IBasicContent that) => that.Value<string>("overskrift");

		///<summary>
		/// Underskrift
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("underskrift")]
		public string Underskrift => GetUnderskrift(this);

		/// <summary>Static getter for Underskrift</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public static string GetUnderskrift(IBasicContent that) => that.Value<string>("underskrift");
	}
}
