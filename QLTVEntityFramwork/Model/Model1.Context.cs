﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTVEntityFramwork.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLThuVienEntities : DbContext
    {
        public QLThuVienEntities()
            : base("name=QLThuVienEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CARD> CARDS { get; set; }
        public virtual DbSet<MUONSACH> MUONSACHes { get; set; }
        public virtual DbSet<NXB> NXBs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<Authenticate_User> Authenticate_User { get; set; }
        public virtual DbSet<Book_Info> Book_Info { get; set; }
        public virtual DbSet<Borrower_Info> Borrower_Info { get; set; }
        public virtual DbSet<Publisher_Info> Publisher_Info { get; set; }
    
        public virtual int Delete_Cards(Nullable<int> macard)
        {
            var macardParameter = macard.HasValue ?
                new ObjectParameter("macard", macard) :
                new ObjectParameter("macard", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Cards", macardParameter);
        }
    
        public virtual int Delete_Muon(Nullable<int> mauser)
        {
            var mauserParameter = mauser.HasValue ?
                new ObjectParameter("mauser", mauser) :
                new ObjectParameter("mauser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Muon", mauserParameter);
        }
    
        public virtual int Delete_SACH(Nullable<int> masach)
        {
            var masachParameter = masach.HasValue ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_SACH", masachParameter);
        }
    
        public virtual int Delete_User(Nullable<int> mauser)
        {
            var mauserParameter = mauser.HasValue ?
                new ObjectParameter("mauser", mauser) :
                new ObjectParameter("mauser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_User", mauserParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_Create_Book(Nullable<int> maNXB, Nullable<int> maTG, string tensach, string linhvuc, Nullable<int> gia, string vitri, Nullable<int> dangduocmuon, Nullable<int> soluongbimat, Nullable<int> tongsoluong)
        {
            var maNXBParameter = maNXB.HasValue ?
                new ObjectParameter("MaNXB", maNXB) :
                new ObjectParameter("MaNXB", typeof(int));
    
            var maTGParameter = maTG.HasValue ?
                new ObjectParameter("MaTG", maTG) :
                new ObjectParameter("MaTG", typeof(int));
    
            var tensachParameter = tensach != null ?
                new ObjectParameter("Tensach", tensach) :
                new ObjectParameter("Tensach", typeof(string));
    
            var linhvucParameter = linhvuc != null ?
                new ObjectParameter("Linhvuc", linhvuc) :
                new ObjectParameter("Linhvuc", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("Gia", gia) :
                new ObjectParameter("Gia", typeof(int));
    
            var vitriParameter = vitri != null ?
                new ObjectParameter("Vitri", vitri) :
                new ObjectParameter("Vitri", typeof(string));
    
            var dangduocmuonParameter = dangduocmuon.HasValue ?
                new ObjectParameter("Dangduocmuon", dangduocmuon) :
                new ObjectParameter("Dangduocmuon", typeof(int));
    
            var soluongbimatParameter = soluongbimat.HasValue ?
                new ObjectParameter("Soluongbimat", soluongbimat) :
                new ObjectParameter("Soluongbimat", typeof(int));
    
            var tongsoluongParameter = tongsoluong.HasValue ?
                new ObjectParameter("Tongsoluong", tongsoluong) :
                new ObjectParameter("Tongsoluong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Create_Book", maNXBParameter, maTGParameter, tensachParameter, linhvucParameter, giaParameter, vitriParameter, dangduocmuonParameter, soluongbimatParameter, tongsoluongParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_Delete_Book(string tensach)
        {
            var tensachParameter = tensach != null ?
                new ObjectParameter("Tensach", tensach) :
                new ObjectParameter("Tensach", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Delete_Book", tensachParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_Update_Book(Nullable<int> maNXB, Nullable<int> maTG, string tensach, string linhvuc, Nullable<int> gia, string vitri, Nullable<int> dangduocmuon, Nullable<int> soluongbimat, Nullable<int> tongsoluong)
        {
            var maNXBParameter = maNXB.HasValue ?
                new ObjectParameter("MaNXB", maNXB) :
                new ObjectParameter("MaNXB", typeof(int));
    
            var maTGParameter = maTG.HasValue ?
                new ObjectParameter("MaTG", maTG) :
                new ObjectParameter("MaTG", typeof(int));
    
            var tensachParameter = tensach != null ?
                new ObjectParameter("Tensach", tensach) :
                new ObjectParameter("Tensach", typeof(string));
    
            var linhvucParameter = linhvuc != null ?
                new ObjectParameter("Linhvuc", linhvuc) :
                new ObjectParameter("Linhvuc", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("Gia", gia) :
                new ObjectParameter("Gia", typeof(int));
    
            var vitriParameter = vitri != null ?
                new ObjectParameter("Vitri", vitri) :
                new ObjectParameter("Vitri", typeof(string));
    
            var dangduocmuonParameter = dangduocmuon.HasValue ?
                new ObjectParameter("Dangduocmuon", dangduocmuon) :
                new ObjectParameter("Dangduocmuon", typeof(int));
    
            var soluongbimatParameter = soluongbimat.HasValue ?
                new ObjectParameter("Soluongbimat", soluongbimat) :
                new ObjectParameter("Soluongbimat", typeof(int));
    
            var tongsoluongParameter = tongsoluong.HasValue ?
                new ObjectParameter("Tongsoluong", tongsoluong) :
                new ObjectParameter("Tongsoluong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Update_Book", maNXBParameter, maTGParameter, tensachParameter, linhvucParameter, giaParameter, vitriParameter, dangduocmuonParameter, soluongbimatParameter, tongsoluongParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
