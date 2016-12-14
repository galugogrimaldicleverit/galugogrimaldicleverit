﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace FabrikamFiber.Web.UITests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Loadhttp127001100 - Test Case 79 - Use 'Loadhttp127001100Params' to pass parameters into this method.
        /// </summary>
        public void Loadhttp127001100()
        {
            #region Variable Declarations
            WinEdit uIAddressandsearchusinEdit = this.UIBlankPageWindowsInteWindow.UIItemWindow.UIAddressandsearchusinEdit;
            #endregion

            // Go to web page 'about:blank' using new browser instance
            this.UIBlankPageWindowsInteWindow.LaunchUrl(new System.Uri(this.Loadhttp127001100Params.UIBlankPageWindowsInteWindowUrl));

            // Type 'http://127.0.0.1:100/' in 'Address and search using Bing' text box
            uIAddressandsearchusinEdit.Text = this.Loadhttp127001100Params.UIAddressandsearchusinEditText;

            // Type '{Enter}' in 'Address and search using Bing' text box
            Keyboard.SendKeys(uIAddressandsearchusinEdit, this.Loadhttp127001100Params.UIAddressandsearchusinEditSendKeys, ModifierKeys.None);
        }
        
        /// <summary>
        /// ClickonCustomerslink - Test Case 79
        /// </summary>
        public void ClickonCustomerslink()
        {
            #region Variable Declarations
            HtmlHyperlink uICustomersHyperlink = this.UIBlankPageWindowsInteWindow.UIHomePageDocument.UICustomersHyperlink;
            #endregion

            // Click 'Customers' link
            Mouse.Click(uICustomersHyperlink, new Point(43, 10));
        }
        
        /// <summary>
        /// ClickonCreateNewbutton - Test Case 79
        /// </summary>
        public void ClickonCreateNewbutton()
        {
            #region Variable Declarations
            HtmlHyperlink uICreateNewHyperlink = this.UICustomersWindowsInteWindow.UICustomersDocument.UIContentCustom.UICreateNewHyperlink;
            #endregion

            // Click 'Create New' link
            Mouse.Click(uICreateNewHyperlink, new Point(64, 15));
        }
        
        /// <summary>
        /// EntercustomerdetailsFirstNameLastNameStreetCityStateZip - Test Case 79 - Use 'EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams' to pass parameters into this method.
        /// </summary>
        public void EntercustomerdetailsFirstNameLastNameStreetCityStateZip()
        {
            #region Variable Declarations
            HtmlEdit uIFirstNameEdit = this.UICreateWindowsInterneWindow.UICreateDocument.UIFirstNameEdit;
            HtmlEdit uILastNameEdit = this.UICreateWindowsInterneWindow.UICreateDocument.UILastNameEdit;
            HtmlEdit uIStreetEdit = this.UICreateWindowsInterneWindow.UICreateDocument.UIStreetEdit;
            HtmlEdit uICityEdit = this.UICreateWindowsInterneWindow.UICreateDocument.UICityEdit;
            HtmlEdit uIStateEdit = this.UICreateWindowsInterneWindow.UICreateDocument.UIStateEdit;
            HtmlEdit uIZipEdit = this.UICreateWindowsInterneWindow.UICreateDocument.UIZipEdit;
            #endregion

            // Type 'Brian' in 'First Name' text box
            uIFirstNameEdit.Text = this.EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams.UIFirstNameEditText;

            // Type '{Tab}' in 'First Name' text box
            Keyboard.SendKeys(uIFirstNameEdit, this.EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams.UIFirstNameEditSendKeys, ModifierKeys.None);

            // Type 'Keller' in 'Last Name' text box
            uILastNameEdit.Text = this.EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams.UILastNameEditText;

            // Type '{Tab}' in 'Last Name' text box
            Keyboard.SendKeys(uILastNameEdit, this.EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams.UILastNameEditSendKeys, ModifierKeys.None);

            // Type '361 North Avenue' in 'Street' text box
            uIStreetEdit.Text = this.EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams.UIStreetEditText;

            // Type '{Tab}' in 'Street' text box
            Keyboard.SendKeys(uIStreetEdit, this.EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams.UIStreetEditSendKeys, ModifierKeys.None);

            // Type 'Redmond' in 'City' text box
            uICityEdit.Text = this.EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams.UICityEditText;

            // Type '{Tab}' in 'City' text box
            Keyboard.SendKeys(uICityEdit, this.EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams.UICityEditSendKeys, ModifierKeys.None);

            // Type 'WA' in 'State' text box
            uIStateEdit.Text = this.EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams.UIStateEditText;

            // Type '{Tab}' in 'State' text box
            Keyboard.SendKeys(uIStateEdit, this.EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams.UIStateEditSendKeys, ModifierKeys.None);

            // Type '98052' in 'Zip' text box
            uIZipEdit.Text = this.EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams.UIZipEditText;

            // Type '{Tab}' in 'Zip' text box
            Keyboard.SendKeys(uIZipEdit, this.EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams.UIZipEditSendKeys, ModifierKeys.None);
        }
        
        /// <summary>
        /// ClickCreate - Test Case 79
        /// </summary>
        public void ClickCreate()
        {
            #region Variable Declarations
            HtmlInputButton uICreateButton = this.UICreateWindowsInterneWindow.UICreateDocument.UIContentCustom.UICreateButton;
            WinButton uICloseButton = this.UICustomersWindowsInteWindow.UICustomersWindowsInteTitleBar.UICloseButton;
            #endregion

            // Click 'Create' button
            Mouse.Click(uICreateButton, new Point(146, 19));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(22, 7));
        }
        
        #region Properties
        public virtual Loadhttp127001100Params Loadhttp127001100Params
        {
            get
            {
                if ((this.mLoadhttp127001100Params == null))
                {
                    this.mLoadhttp127001100Params = new Loadhttp127001100Params();
                }
                return this.mLoadhttp127001100Params;
            }
        }
        
        public virtual EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams
        {
            get
            {
                if ((this.mEntercustomerdetailsFirstNameLastNameStreetCityStateZipParams == null))
                {
                    this.mEntercustomerdetailsFirstNameLastNameStreetCityStateZipParams = new EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams();
                }
                return this.mEntercustomerdetailsFirstNameLastNameStreetCityStateZipParams;
            }
        }
        
        public UIBlankPageWindowsInteWindow UIBlankPageWindowsInteWindow
        {
            get
            {
                if ((this.mUIBlankPageWindowsInteWindow == null))
                {
                    this.mUIBlankPageWindowsInteWindow = new UIBlankPageWindowsInteWindow();
                }
                return this.mUIBlankPageWindowsInteWindow;
            }
        }
        
        public UICustomersWindowsInteWindow UICustomersWindowsInteWindow
        {
            get
            {
                if ((this.mUICustomersWindowsInteWindow == null))
                {
                    this.mUICustomersWindowsInteWindow = new UICustomersWindowsInteWindow();
                }
                return this.mUICustomersWindowsInteWindow;
            }
        }
        
        public UICreateWindowsInterneWindow UICreateWindowsInterneWindow
        {
            get
            {
                if ((this.mUICreateWindowsInterneWindow == null))
                {
                    this.mUICreateWindowsInterneWindow = new UICreateWindowsInterneWindow();
                }
                return this.mUICreateWindowsInterneWindow;
            }
        }
        #endregion
        
        #region Fields
        private Loadhttp127001100Params mLoadhttp127001100Params;
        
        private EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams mEntercustomerdetailsFirstNameLastNameStreetCityStateZipParams;
        
        private UIBlankPageWindowsInteWindow mUIBlankPageWindowsInteWindow;
        
        private UICustomersWindowsInteWindow mUICustomersWindowsInteWindow;
        
        private UICreateWindowsInterneWindow mUICreateWindowsInterneWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Loadhttp127001100'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class Loadhttp127001100Params
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'about:blank' using new browser instance
        /// </summary>
        public string UIBlankPageWindowsInteWindowUrl = "about:blank";
        
        /// <summary>
        /// Type 'http://127.0.0.1:100/' in 'Address and search using Bing' text box
        /// </summary>
        public string UIAddressandsearchusinEditText = "http://127.0.0.1:100/";
        
        /// <summary>
        /// Type '{Enter}' in 'Address and search using Bing' text box
        /// </summary>
        public string UIAddressandsearchusinEditSendKeys = "{Enter}";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'EntercustomerdetailsFirstNameLastNameStreetCityStateZip'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class EntercustomerdetailsFirstNameLastNameStreetCityStateZipParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'Brian' in 'First Name' text box
        /// </summary>
        public string UIFirstNameEditText = "Brian";
        
        /// <summary>
        /// Type '{Tab}' in 'First Name' text box
        /// </summary>
        public string UIFirstNameEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type 'Keller' in 'Last Name' text box
        /// </summary>
        public string UILastNameEditText = "Keller";
        
        /// <summary>
        /// Type '{Tab}' in 'Last Name' text box
        /// </summary>
        public string UILastNameEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '361 North Avenue' in 'Street' text box
        /// </summary>
        public string UIStreetEditText = "361 North Avenue";
        
        /// <summary>
        /// Type '{Tab}' in 'Street' text box
        /// </summary>
        public string UIStreetEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type 'Redmond' in 'City' text box
        /// </summary>
        public string UICityEditText = "Redmond";
        
        /// <summary>
        /// Type '{Tab}' in 'City' text box
        /// </summary>
        public string UICityEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type 'WA' in 'State' text box
        /// </summary>
        public string UIStateEditText = "WA";
        
        /// <summary>
        /// Type '{Tab}' in 'State' text box
        /// </summary>
        public string UIStateEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '98052' in 'Zip' text box
        /// </summary>
        public string UIZipEditText = "98052";
        
        /// <summary>
        /// Type '{Tab}' in 'Zip' text box
        /// </summary>
        public string UIZipEditSendKeys = "{Tab}";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIBlankPageWindowsInteWindow : BrowserWindow
    {
        
        public UIBlankPageWindowsInteWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Blank Page";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Blank Page");
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIHomePageDocument UIHomePageDocument
        {
            get
            {
                if ((this.mUIHomePageDocument == null))
                {
                    this.mUIHomePageDocument = new UIHomePageDocument(this);
                }
                return this.mUIHomePageDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIHomePageDocument mUIHomePageDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "41477";
            this.WindowTitles.Add("Blank Page");
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public WinEdit UIAddressandsearchusinEdit
        {
            get
            {
                if ((this.mUIAddressandsearchusinEdit == null))
                {
                    this.mUIAddressandsearchusinEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIAddressandsearchusinEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Address and search using Bing";
                    this.mUIAddressandsearchusinEdit.WindowTitles.Add("Blank Page");
                    this.mUIAddressandsearchusinEdit.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIAddressandsearchusinEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIAddressandsearchusinEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHomePageDocument : HtmlDocument
    {
        
        public UIHomePageDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home Page";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://127.0.0.1:100/";
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UICustomersHyperlink
        {
            get
            {
                if ((this.mUICustomersHyperlink == null))
                {
                    this.mUICustomersHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUICustomersHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUICustomersHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUICustomersHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUICustomersHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Customers";
                    this.mUICustomersHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Customers";
                    this.mUICustomersHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUICustomersHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://127.0.0.1:100/Customers";
                    this.mUICustomersHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUICustomersHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Customers\"";
                    this.mUICustomersHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "3";
                    this.mUICustomersHyperlink.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUICustomersHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUICustomersHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICustomersWindowsInteWindow : BrowserWindow
    {
        
        public UICustomersWindowsInteWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Customers";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Customers");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UICustomersDocument UICustomersDocument
        {
            get
            {
                if ((this.mUICustomersDocument == null))
                {
                    this.mUICustomersDocument = new UICustomersDocument(this);
                }
                return this.mUICustomersDocument;
            }
        }
        
        public UICustomersWindowsInteTitleBar UICustomersWindowsInteTitleBar
        {
            get
            {
                if ((this.mUICustomersWindowsInteTitleBar == null))
                {
                    this.mUICustomersWindowsInteTitleBar = new UICustomersWindowsInteTitleBar(this);
                }
                return this.mUICustomersWindowsInteTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UICustomersDocument mUICustomersDocument;
        
        private UICustomersWindowsInteTitleBar mUICustomersWindowsInteTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICustomersDocument : HtmlDocument
    {
        
        public UICustomersDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Customers";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Customers";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://127.0.0.1:100/Customers";
            this.WindowTitles.Add("Customers");
            #endregion
        }
        
        #region Properties
        public UIContentCustom UIContentCustom
        {
            get
            {
                if ((this.mUIContentCustom == null))
                {
                    this.mUIContentCustom = new UIContentCustom(this);
                }
                return this.mUIContentCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIContentCustom mUIContentCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIContentCustom : HtmlCustom
    {
        
        public UIContentCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["Id"] = "content";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.SearchProperties["TagName"] = "SECTION";
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"content\"";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("Customers");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UICreateNewHyperlink
        {
            get
            {
                if ((this.mUICreateNewHyperlink == null))
                {
                    this.mUICreateNewHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUICreateNewHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUICreateNewHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUICreateNewHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUICreateNewHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Create New";
                    this.mUICreateNewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Customers/Create";
                    this.mUICreateNewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUICreateNewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://127.0.0.1:100/Customers/Create";
                    this.mUICreateNewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "glossyBox createNew";
                    this.mUICreateNewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"glossyBox createNew\" href=\"/Custo";
                    this.mUICreateNewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUICreateNewHyperlink.WindowTitles.Add("Customers");
                    #endregion
                }
                return this.mUICreateNewHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUICreateNewHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICustomersWindowsInteTitleBar : WinTitleBar
    {
        
        public UICustomersWindowsInteTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Customers");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Customers");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICreateWindowsInterneWindow : BrowserWindow
    {
        
        public UICreateWindowsInterneWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Create";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Create");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UICreateDocument UICreateDocument
        {
            get
            {
                if ((this.mUICreateDocument == null))
                {
                    this.mUICreateDocument = new UICreateDocument(this);
                }
                return this.mUICreateDocument;
            }
        }
        #endregion
        
        #region Fields
        private UICreateDocument mUICreateDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICreateDocument : HtmlDocument
    {
        
        public UICreateDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Create";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Customers/Create";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://127.0.0.1:100/Customers/Create";
            this.WindowTitles.Add("Create");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UIFirstNameEdit
        {
            get
            {
                if ((this.mUIFirstNameEdit == null))
                {
                    this.mUIFirstNameEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIFirstNameEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "FirstName";
                    this.mUIFirstNameEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "FirstName";
                    this.mUIFirstNameEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "First Name";
                    this.mUIFirstNameEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIFirstNameEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIFirstNameEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUIFirstNameEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "id=\"FirstName\" class=\"text-box single-li";
                    this.mUIFirstNameEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "2";
                    this.mUIFirstNameEdit.WindowTitles.Add("Create");
                    #endregion
                }
                return this.mUIFirstNameEdit;
            }
        }
        
        public HtmlEdit UILastNameEdit
        {
            get
            {
                if ((this.mUILastNameEdit == null))
                {
                    this.mUILastNameEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUILastNameEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "LastName";
                    this.mUILastNameEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "LastName";
                    this.mUILastNameEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Last Name";
                    this.mUILastNameEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUILastNameEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUILastNameEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUILastNameEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "id=\"LastName\" class=\"text-box single-lin";
                    this.mUILastNameEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "3";
                    this.mUILastNameEdit.WindowTitles.Add("Create");
                    #endregion
                }
                return this.mUILastNameEdit;
            }
        }
        
        public HtmlEdit UIStreetEdit
        {
            get
            {
                if ((this.mUIStreetEdit == null))
                {
                    this.mUIStreetEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIStreetEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Address_Street";
                    this.mUIStreetEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Address.Street";
                    this.mUIStreetEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Street";
                    this.mUIStreetEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIStreetEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIStreetEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUIStreetEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "id=\"Address_Street\" class=\"text-box sing";
                    this.mUIStreetEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "4";
                    this.mUIStreetEdit.WindowTitles.Add("Create");
                    #endregion
                }
                return this.mUIStreetEdit;
            }
        }
        
        public HtmlEdit UICityEdit
        {
            get
            {
                if ((this.mUICityEdit == null))
                {
                    this.mUICityEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUICityEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Address_City";
                    this.mUICityEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Address.City";
                    this.mUICityEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "City";
                    this.mUICityEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUICityEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUICityEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUICityEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "id=\"Address_City\" class=\"text-box single";
                    this.mUICityEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "5";
                    this.mUICityEdit.WindowTitles.Add("Create");
                    #endregion
                }
                return this.mUICityEdit;
            }
        }
        
        public HtmlEdit UIStateEdit
        {
            get
            {
                if ((this.mUIStateEdit == null))
                {
                    this.mUIStateEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIStateEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Address_State";
                    this.mUIStateEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Address.State";
                    this.mUIStateEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "State";
                    this.mUIStateEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIStateEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIStateEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUIStateEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "id=\"Address_State\" class=\"text-box singl";
                    this.mUIStateEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "6";
                    this.mUIStateEdit.WindowTitles.Add("Create");
                    #endregion
                }
                return this.mUIStateEdit;
            }
        }
        
        public HtmlEdit UIZipEdit
        {
            get
            {
                if ((this.mUIZipEdit == null))
                {
                    this.mUIZipEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIZipEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "Address_Zip";
                    this.mUIZipEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "Address.Zip";
                    this.mUIZipEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Zip";
                    this.mUIZipEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIZipEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIZipEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "text-box single-line";
                    this.mUIZipEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "id=\"Address_Zip\" class=\"text-box single-";
                    this.mUIZipEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "7";
                    this.mUIZipEdit.WindowTitles.Add("Create");
                    #endregion
                }
                return this.mUIZipEdit;
            }
        }
        
        public UIContentCustom1 UIContentCustom
        {
            get
            {
                if ((this.mUIContentCustom == null))
                {
                    this.mUIContentCustom = new UIContentCustom1(this);
                }
                return this.mUIContentCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUIFirstNameEdit;
        
        private HtmlEdit mUILastNameEdit;
        
        private HtmlEdit mUIStreetEdit;
        
        private HtmlEdit mUICityEdit;
        
        private HtmlEdit mUIStateEdit;
        
        private HtmlEdit mUIZipEdit;
        
        private UIContentCustom1 mUIContentCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIContentCustom1 : HtmlCustom
    {
        
        public UIContentCustom1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["Id"] = "content";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.SearchProperties["TagName"] = "SECTION";
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"content\"";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("Create");
            #endregion
        }
        
        #region Properties
        public HtmlInputButton UICreateButton
        {
            get
            {
                if ((this.mUICreateButton == null))
                {
                    this.mUICreateButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUICreateButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.mUICreateButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    this.mUICreateButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Create";
                    this.mUICreateButton.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUICreateButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUICreateButton.FilterProperties[HtmlButton.PropertyNames.Class] = "glossyBox";
                    this.mUICreateButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "class=\"glossyBox\" value=\"Create\" type=\"s";
                    this.mUICreateButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "7";
                    this.mUICreateButton.WindowTitles.Add("Create");
                    #endregion
                }
                return this.mUICreateButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlInputButton mUICreateButton;
        #endregion
    }
}
