﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("TestModel", "FK_Product_Division", "Division", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Glimpse.EF1Test.Division), "Product", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Glimpse.EF1Test.Product))]

// Original file name:
// Generation date: 12.07.2013 13:23:01
namespace Glimpse.EF1Test
{
    
    /// <summary>
    /// There are no comments for TestEntities in the schema.
    /// </summary>
    public partial class TestEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new TestEntities object using the connection string found in the 'TestEntities' section of the application configuration file.
        /// </summary>
        public TestEntities() : 
                base("name=TestEntities", "TestEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new TestEntities object.
        /// </summary>
        public TestEntities(string connectionString) : 
                base(connectionString, "TestEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new TestEntities object.
        /// </summary>
        public TestEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "TestEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Division in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<Division> Division
        {
            get
            {
                if ((this._Division == null))
                {
                    this._Division = base.CreateQuery<Division>("[Division]");
                }
                return this._Division;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<Division> _Division;
        /// <summary>
        /// There are no comments for Product in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<Product> Product
        {
            get
            {
                if ((this._Product == null))
                {
                    this._Product = base.CreateQuery<Product>("[Product]");
                }
                return this._Product;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<Product> _Product;
        /// <summary>
        /// There are no comments for Division in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddToDivision(Division division)
        {
            base.AddObject("Division", division);
        }
        /// <summary>
        /// There are no comments for Product in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddToProduct(Product product)
        {
            base.AddObject("Product", product);
        }
    }
    /// <summary>
    /// There are no comments for TestModel.Division in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Guid
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="TestModel", Name="Division")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Division : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Division object.
        /// </summary>
        /// <param name="guid">Initial value of Guid.</param>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static Division CreateDivision(global::System.Guid guid, string name)
        {
            Division division = new Division();
            division.Guid = guid;
            division.Name = name;
            return division;
        }
        /// <summary>
        /// There are no comments for property Guid in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Guid Guid
        {
            get
            {
                return this._Guid;
            }
            set
            {
                this.OnGuidChanging(value);
                this.ReportPropertyChanging("Guid");
                this._Guid = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Guid");
                this.OnGuidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Guid _Guid;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnGuidChanging(global::System.Guid value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnGuidChanged();
        /// <summary>
        /// There are no comments for property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _Name;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnNameChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Product in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("TestModel", "FK_Product_Division", "Product")]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<Product> Product
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Product>("TestModel.FK_Product_Division", "Product");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Product>("TestModel.FK_Product_Division", "Product", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for TestModel.Product in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Guid
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="TestModel", Name="Product")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Product : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="guid">Initial value of Guid.</param>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static Product CreateProduct(global::System.Guid guid, string name)
        {
            Product product = new Product();
            product.Guid = guid;
            product.Name = name;
            return product;
        }
        /// <summary>
        /// There are no comments for property Guid in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Guid Guid
        {
            get
            {
                return this._Guid;
            }
            set
            {
                this.OnGuidChanging(value);
                this.ReportPropertyChanging("Guid");
                this._Guid = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Guid");
                this.OnGuidChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Guid _Guid;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnGuidChanging(global::System.Guid value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnGuidChanged();
        /// <summary>
        /// There are no comments for property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _Name;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnNameChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Division in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("TestModel", "FK_Product_Division", "Division")]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public Division Division
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Division>("TestModel.FK_Product_Division", "Division").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Division>("TestModel.FK_Product_Division", "Division").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for Division in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<Division> DivisionReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Division>("TestModel.FK_Product_Division", "Division");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Division>("TestModel.FK_Product_Division", "Division", value);
                }
            }
        }
    }
}
