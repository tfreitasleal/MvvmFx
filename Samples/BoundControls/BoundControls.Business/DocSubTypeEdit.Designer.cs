//  This file was generated by CSLA Object Generator - CslaGenFork v4.5
//
// Filename:    DocSubTypeEdit
// ObjectType:  DocSubTypeEdit
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace BoundControls.Business
{

    /// <summary>
    /// Types of document (editable child object).<br/>
    /// This is a generated base class of <see cref="DocSubTypeEdit"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="DocSubTypeEditColl"/> collection.
    /// </remarks>
    [Serializable]
    public partial class DocSubTypeEdit : BusinessBase<DocSubTypeEdit>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="DocSubTypeID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> DocSubTypeIDProperty = RegisterProperty<int>(p => p.DocSubTypeID, "Doc Sub Type ID");
        /// <summary>
        /// Gets or sets the Doc Sub Type ID.
        /// </summary>
        /// <value>The Doc Sub Type ID.</value>
        public int DocSubTypeID
        {
            get { return GetProperty(DocSubTypeIDProperty); }
            set { SetProperty(DocSubTypeIDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DocSubTypeParentID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> DocSubTypeParentIDProperty = RegisterProperty<int?>(p => p.DocSubTypeParentID, "Doc Sub Type Parent ID");
        /// <summary>
        /// Gets or sets the Doc Sub Type Parent ID.
        /// </summary>
        /// <value>The Doc Sub Type Parent ID.</value>
        public int? DocSubTypeParentID
        {
            get { return GetProperty(DocSubTypeParentIDProperty); }
            set { SetProperty(DocSubTypeParentIDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DocSubTypeName"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DocSubTypeNameProperty = RegisterProperty<string>(p => p.DocSubTypeName, "Doc Sub Type Name");
        /// <summary>
        /// Gets or sets the Doc Sub Type Name.
        /// </summary>
        /// <value>The Doc Sub Type Name.</value>
        public string DocSubTypeName
        {
            get { return GetProperty(DocSubTypeNameProperty); }
            set { SetProperty(DocSubTypeNameProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DocSubTypeEdit"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DocSubTypeEdit"/> object.</returns>
        internal static DocSubTypeEdit NewDocSubTypeEdit()
        {
            return DataPortal.CreateChild<DocSubTypeEdit>();
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DocSubTypeEdit"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DocSubTypeEdit()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        protected override void DataPortal_Create()
        {

        }

    }
}