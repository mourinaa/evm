﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using System.ComponentModel;
using System.Web.UI.Design.WebControls;
using System.Web.UI.Design;
using System.Web.UI.WebControls;

namespace CONFDB.Web.UI
{
    /// <summary>
    /// A designer class for a strongly typed repeater <c>UserRepeater</c>
    /// </summary>
	public class UserRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:UserRepeaterDesigner"/> class.
        /// </summary>
		public UserRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is UserRepeater))
			{ 
				throw new ArgumentException("Component is not a UserRepeater."); 
			} 
			base.Initialize(component); 
			base.SetViewFlags(ViewFlags.TemplateEditing, true); 
		}


		/// <summary>
		/// Generate HTML for the designer
		/// </summary>
		/// <returns>a string of design time HTML</returns>
		public override string GetDesignTimeHtml()
		{

			// Get the instance this designer applies to
			//
			UserRepeater z = (UserRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();

			//return z.RenderAtDesignTime();

			//	ControlCollection c = z.Controls;
			//Totem z = (Totem) Component;
			//Totem z = (Totem) Component;
			//return ("<div style='border: 1px gray dotted; background-color: lightgray'><b>TagStat :</b> zae |  qsdds</div>");

		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <c cref="UserRepeater"></c> Type.
    /// </summary>
	[Designer(typeof(UserRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:UserRepeater runat=\"server\"></{0}:UserRepeater>")]
	public class UserRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:UserRepeater"/> class.
        /// </summary>
		public UserRepeater()
		{
		}

		/// <summary>
        /// Gets a <see cref="T:System.Web.UI.ControlCollection"></see> object that represents the child controls for a specified server control in the UI hierarchy.
        /// </summary>
        /// <value></value>
        /// <returns>The collection of child controls for the specified server control.</returns>
		public override ControlCollection Controls
		{
			get
			{
				this.EnsureChildControls();
				return base.Controls;
			}
		}

		private ITemplate m_headerTemplate;
		/// <summary>
        /// Gets or sets the header template.
        /// </summary>
        /// <value>The header template.</value>
		[Browsable(false)]
		[TemplateContainer(typeof(UserItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate HeaderTemplate
		{
			get { return m_headerTemplate; }
			set { m_headerTemplate = value; }
		}

		private ITemplate m_itemTemplate;
		/// <summary>
        /// Gets or sets the item template.
        /// </summary>
        /// <value>The item template.</value>
		[Browsable(false)]
		[TemplateContainer(typeof(UserItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate ItemTemplate
		{
			get { return m_itemTemplate; }
			set { m_itemTemplate = value; }
		}
			

		private ITemplate m_altenateItemTemplate;
        /// <summary>
        /// Gets or sets the alternating item template.
        /// </summary>
        /// <value>The alternating item template.</value>
		[Browsable(false)]
		[TemplateContainer(typeof(UserItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate AlternatingItemTemplate
		{
			get { return m_altenateItemTemplate; }
			set { m_altenateItemTemplate = value; }
		}

		private ITemplate m_footerTemplate;
        /// <summary>
        /// Gets or sets the footer template.
        /// </summary>
        /// <value>The footer template.</value>
		[Browsable(false)]
		[TemplateContainer(typeof(UserItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate FooterTemplate
		{
			get { return m_footerTemplate; }
			set { m_footerTemplate = value; }
		}

      /// <summary>
      /// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
      /// </summary>
		protected override void CreateChildControls()
      {
         if (ChildControlsCreated)
         {
            return;
         }

         Controls.Clear();

         //Instantiate the Header template (if exists)
         if (m_headerTemplate != null)
         {
            Control headerItem = new Control();
            m_headerTemplate.InstantiateIn(headerItem);
            Controls.Add(headerItem);
         }

         //Instantiate the Footer template (if exists)
         if (m_footerTemplate != null)
         {
            Control footerItem = new Control();
            m_footerTemplate.InstantiateIn(footerItem);
            Controls.Add(footerItem);
         }

         ChildControlsCreated = true;
      }
		
		/// <summary>
      /// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
      /// </summary>
		protected override int CreateChildControls(System.Collections.IEnumerable dataSource, bool dataBinding)
      {
         int pos = 0;

         if (dataBinding)
         {
            foreach (object o in dataSource)
            {
					CONFDB.Entities.User entity = o as CONFDB.Entities.User;
					UserItem container = new UserItem(entity);

					if (m_itemTemplate != null && (pos % 2) == 0)
					{
						m_itemTemplate.InstantiateIn(container);
					}
					else
					{
						if (m_altenateItemTemplate != null)
						{
							m_altenateItemTemplate.InstantiateIn(container);
						}
						else if (m_itemTemplate != null)
						{
							m_itemTemplate.InstantiateIn(container);
						}
						else
						{
							// no template !!!
						}
					}
					Controls.Add(container);
					
					container.DataBind();
					
					pos++;
				}
			}
			
			return pos;
		}

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.PreRender"></see> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"></see> object that contains the event data.</param>
		protected override void OnPreRender(EventArgs e)
		{
			base.DataBind();
		}

		#region Design time
        /// <summary>
        /// Renders at design time.
        /// </summary>
        /// <returns>a  string of the Designed HTML</returns>
		internal string RenderAtDesignTime()
		{			
			return "Designer currently not implemented"; 
		}

		#endregion
	}

    /// <summary>
    /// A wrapper type for the entity
    /// </summary>
	[System.ComponentModel.ToolboxItem(false)]
	public class UserItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private CONFDB.Entities.User _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UserItem"/> class.
        /// </summary>
		public UserItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:UserItem"/> class.
        /// </summary>
		public UserItem(CONFDB.Entities.User entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the UserId
        /// </summary>
        /// <value>The UserId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 UserId
		{
			get { return _entity.UserId; }
		}
        /// <summary>
        /// Gets the Username
        /// </summary>
        /// <value>The Username.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Username
		{
			get { return _entity.Username; }
		}
        /// <summary>
        /// Gets the Password
        /// </summary>
        /// <value>The Password.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Password
		{
			get { return _entity.Password; }
		}
        /// <summary>
        /// Gets the DisplayName
        /// </summary>
        /// <value>The DisplayName.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DisplayName
		{
			get { return _entity.DisplayName; }
		}
        /// <summary>
        /// Gets the Email
        /// </summary>
        /// <value>The Email.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Email
		{
			get { return _entity.Email; }
		}
        /// <summary>
        /// Gets the Telephone
        /// </summary>
        /// <value>The Telephone.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Telephone
		{
			get { return _entity.Telephone; }
		}
        /// <summary>
        /// Gets the Enabled
        /// </summary>
        /// <value>The Enabled.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean Enabled
		{
			get { return _entity.Enabled; }
		}
        /// <summary>
        /// Gets the CompanyId
        /// </summary>
        /// <value>The CompanyId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? CompanyId
		{
			get { return _entity.CompanyId; }
		}
        /// <summary>
        /// Gets the SalesPersonId
        /// </summary>
        /// <value>The SalesPersonId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SalesPersonId
		{
			get { return _entity.SalesPersonId; }
		}
        /// <summary>
        /// Gets the RoleId
        /// </summary>
        /// <value>The RoleId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? RoleId
		{
			get { return _entity.RoleId; }
		}
        /// <summary>
        /// Gets the MustChangePassword
        /// </summary>
        /// <value>The MustChangePassword.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? MustChangePassword
		{
			get { return _entity.MustChangePassword; }
		}
        /// <summary>
        /// Gets the Address1
        /// </summary>
        /// <value>The Address1.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Address1
		{
			get { return _entity.Address1; }
		}
        /// <summary>
        /// Gets the Address2
        /// </summary>
        /// <value>The Address2.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Address2
		{
			get { return _entity.Address2; }
		}
        /// <summary>
        /// Gets the City
        /// </summary>
        /// <value>The City.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String City
		{
			get { return _entity.City; }
		}
        /// <summary>
        /// Gets the Country
        /// </summary>
        /// <value>The Country.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Country
		{
			get { return _entity.Country; }
		}
        /// <summary>
        /// Gets the Region
        /// </summary>
        /// <value>The Region.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Region
		{
			get { return _entity.Region; }
		}
        /// <summary>
        /// Gets the PostalCode
        /// </summary>
        /// <value>The PostalCode.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String PostalCode
		{
			get { return _entity.PostalCode; }
		}
        /// <summary>
        /// Gets the CharityId
        /// </summary>
        /// <value>The CharityId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? CharityId
		{
			get { return _entity.CharityId; }
		}
        /// <summary>
        /// Gets the WebMemberId
        /// </summary>
        /// <value>The WebMemberId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String WebMemberId
		{
			get { return _entity.WebMemberId; }
		}
        /// <summary>
        /// Gets the UserUniqueId
        /// </summary>
        /// <value>The UserUniqueId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Guid UserUniqueId
		{
			get { return _entity.UserUniqueId; }
		}

        /// <summary>
        /// Gets a <see cref="T:CONFDB.Entities.User"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public CONFDB.Entities.User Entity
        {
            get { return _entity; }
        }
	}
}
