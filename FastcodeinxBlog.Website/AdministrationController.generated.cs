// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace FastcodeinxBlog.Website.Controllers
{
    public partial class AdministrationController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected AdministrationController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> EditBlogEntry()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditBlogEntry);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> PerformPingbacks()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PerformPingbacks);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> FileUpload()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FileUpload);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> FileDelete()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FileDelete);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ImageUpload()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ImageUpload);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public AdministrationController Actions { get { return MVC.Administration; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Administration";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Administration";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Statistics = "Statistics";
            public readonly string EditBlogEntry = "EditBlogEntry";
            public readonly string PerformPingbacks = "PerformPingbacks";
            public readonly string FileUpload = "FileUpload";
            public readonly string FileDelete = "FileDelete";
            public readonly string Images = "Images";
            public readonly string ImageUpload = "ImageUpload";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Statistics = "Statistics";
            public const string EditBlogEntry = "EditBlogEntry";
            public const string PerformPingbacks = "PerformPingbacks";
            public const string FileUpload = "FileUpload";
            public const string FileDelete = "FileDelete";
            public const string Images = "Images";
            public const string ImageUpload = "ImageUpload";
        }


        static readonly ActionParamsClass_EditBlogEntry s_params_EditBlogEntry = new ActionParamsClass_EditBlogEntry();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditBlogEntry EditBlogEntryParams { get { return s_params_EditBlogEntry; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditBlogEntry
        {
            public readonly string id = "id";
            public readonly string blogEntry = "blogEntry";
            public readonly string formValues = "formValues";
        }
        static readonly ActionParamsClass_PerformPingbacks s_params_PerformPingbacks = new ActionParamsClass_PerformPingbacks();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PerformPingbacks PerformPingbacksParams { get { return s_params_PerformPingbacks; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PerformPingbacks
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_FileUpload s_params_FileUpload = new ActionParamsClass_FileUpload();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_FileUpload FileUploadParams { get { return s_params_FileUpload; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_FileUpload
        {
            public readonly string id = "id";
            public readonly string file = "file";
        }
        static readonly ActionParamsClass_FileDelete s_params_FileDelete = new ActionParamsClass_FileDelete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_FileDelete FileDeleteParams { get { return s_params_FileDelete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_FileDelete
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_ImageUpload s_params_ImageUpload = new ActionParamsClass_ImageUpload();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ImageUpload ImageUploadParams { get { return s_params_ImageUpload; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ImageUpload
        {
            public readonly string file = "file";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _BlogEntryFileControl = "_BlogEntryFileControl";
                public readonly string EditBlogEntry = "EditBlogEntry";
                public readonly string Images = "Images";
                public readonly string Index = "Index";
                public readonly string Pingback = "Pingback";
                public readonly string Statistics = "Statistics";
            }
            public readonly string _BlogEntryFileControl = "~/Views/Administration/_BlogEntryFileControl.cshtml";
            public readonly string EditBlogEntry = "~/Views/Administration/EditBlogEntry.cshtml";
            public readonly string Images = "~/Views/Administration/Images.cshtml";
            public readonly string Index = "~/Views/Administration/Index.cshtml";
            public readonly string Pingback = "~/Views/Administration/Pingback.cshtml";
            public readonly string Statistics = "~/Views/Administration/Statistics.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_AdministrationController : FastcodeinxBlog.Website.Controllers.AdministrationController
    {
        public T4MVC_AdministrationController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void StatisticsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Statistics()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Statistics);
            StatisticsOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void EditBlogEntryOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid? id);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> EditBlogEntry(System.Guid? id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditBlogEntry);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            EditBlogEntryOverride(callInfo, id);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void EditBlogEntryOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid? id, FastcodeinxBlog.Core.Entities.BlogEntry blogEntry, System.Web.Mvc.FormCollection formValues);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> EditBlogEntry(System.Guid? id, FastcodeinxBlog.Core.Entities.BlogEntry blogEntry, System.Web.Mvc.FormCollection formValues)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditBlogEntry);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "blogEntry", blogEntry);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "formValues", formValues);
            EditBlogEntryOverride(callInfo, id, blogEntry, formValues);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void PerformPingbacksOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid id);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> PerformPingbacks(System.Guid id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PerformPingbacks);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            PerformPingbacksOverride(callInfo, id);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void FileUploadOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid id, System.Web.HttpPostedFileBase file);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> FileUpload(System.Guid id, System.Web.HttpPostedFileBase file)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FileUpload);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "file", file);
            FileUploadOverride(callInfo, id, file);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void FileDeleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid id);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> FileDelete(System.Guid id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FileDelete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            FileDeleteOverride(callInfo, id);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void ImagesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Images()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Images);
            ImagesOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [NonAction]
        partial void ImageUploadOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Web.HttpPostedFileBase file);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ImageUpload(System.Web.HttpPostedFileBase file)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ImageUpload);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "file", file);
            ImageUploadOverride(callInfo, file);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009