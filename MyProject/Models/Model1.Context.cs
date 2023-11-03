﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class cloneTempleteEntities1 : DbContext
    {
        public cloneTempleteEntities1()
            : base("name=cloneTempleteEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CloneTamplate> CloneTamplates { get; set; }
        public virtual DbSet<CloneTamplate1> CloneTamplate1 { get; set; }
    
        public virtual int CloneTemplate(Nullable<int> cloneId, Nullable<int> templateId, Nullable<int> k, string templateName, Nullable<System.DateTime> createdOn, string createdBy, Nullable<bool> isWorking)
        {
            var cloneIdParameter = cloneId.HasValue ?
                new ObjectParameter("CloneId", cloneId) :
                new ObjectParameter("CloneId", typeof(int));
    
            var templateIdParameter = templateId.HasValue ?
                new ObjectParameter("TemplateId", templateId) :
                new ObjectParameter("TemplateId", typeof(int));
    
            var kParameter = k.HasValue ?
                new ObjectParameter("K", k) :
                new ObjectParameter("K", typeof(int));
    
            var templateNameParameter = templateName != null ?
                new ObjectParameter("TemplateName", templateName) :
                new ObjectParameter("TemplateName", typeof(string));
    
            var createdOnParameter = createdOn.HasValue ?
                new ObjectParameter("CreatedOn", createdOn) :
                new ObjectParameter("CreatedOn", typeof(System.DateTime));
    
            var createdByParameter = createdBy != null ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(string));
    
            var isWorkingParameter = isWorking.HasValue ?
                new ObjectParameter("IsWorking", isWorking) :
                new ObjectParameter("IsWorking", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CloneTemplate", cloneIdParameter, templateIdParameter, kParameter, templateNameParameter, createdOnParameter, createdByParameter, isWorkingParameter);
        }
    
        public virtual int DeleteCloneTemplate(Nullable<int> cloneId)
        {
            var cloneIdParameter = cloneId.HasValue ?
                new ObjectParameter("cloneId", cloneId) :
                new ObjectParameter("cloneId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCloneTemplate", cloneIdParameter);
        }
    
        public virtual int InsertCloneTemplate(string templateName, Nullable<System.DateTime> createdOn, string createdBy, Nullable<bool> isWorking)
        {
            var templateNameParameter = templateName != null ?
                new ObjectParameter("TemplateName", templateName) :
                new ObjectParameter("TemplateName", typeof(string));
    
            var createdOnParameter = createdOn.HasValue ?
                new ObjectParameter("CreatedOn", createdOn) :
                new ObjectParameter("CreatedOn", typeof(System.DateTime));
    
            var createdByParameter = createdBy != null ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(string));
    
            var isWorkingParameter = isWorking.HasValue ?
                new ObjectParameter("IsWorking", isWorking) :
                new ObjectParameter("IsWorking", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCloneTemplate", templateNameParameter, createdOnParameter, createdByParameter, isWorkingParameter);
        }
    
        public virtual ObjectResult<SelectCloneTemplate_Result> SelectCloneTemplate()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectCloneTemplate_Result>("SelectCloneTemplate");
        }
    
        public virtual int UpdateCloneTemplate(Nullable<int> cloneId, Nullable<int> tamplateid, string templateName, Nullable<System.DateTime> createdOn, string createdBy, Nullable<bool> isWorking)
        {
            var cloneIdParameter = cloneId.HasValue ?
                new ObjectParameter("cloneId", cloneId) :
                new ObjectParameter("cloneId", typeof(int));
    
            var tamplateidParameter = tamplateid.HasValue ?
                new ObjectParameter("Tamplateid", tamplateid) :
                new ObjectParameter("Tamplateid", typeof(int));
    
            var templateNameParameter = templateName != null ?
                new ObjectParameter("TemplateName", templateName) :
                new ObjectParameter("TemplateName", typeof(string));
    
            var createdOnParameter = createdOn.HasValue ?
                new ObjectParameter("CreatedOn", createdOn) :
                new ObjectParameter("CreatedOn", typeof(System.DateTime));
    
            var createdByParameter = createdBy != null ?
                new ObjectParameter("CreatedBy", createdBy) :
                new ObjectParameter("CreatedBy", typeof(string));
    
            var isWorkingParameter = isWorking.HasValue ?
                new ObjectParameter("IsWorking", isWorking) :
                new ObjectParameter("IsWorking", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCloneTemplate", cloneIdParameter, tamplateidParameter, templateNameParameter, createdOnParameter, createdByParameter, isWorkingParameter);
        }
    }
}
