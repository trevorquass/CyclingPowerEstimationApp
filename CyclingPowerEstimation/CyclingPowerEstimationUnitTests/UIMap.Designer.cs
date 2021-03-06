﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CyclingPowerEstimationUnitTests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// UploadTCXFile
        /// </summary>
        public void UploadTCXFile()
        {
            #region Variable Declarations
            WinButton uIUploadTCXButton = this.UICyclingPowerEstimatiWindow.UIUploadTCXWindow.UIUploadTCXButton;
            WinEdit uINameEdit = this.UIUploadRideWindow.UIItemWindow.UISprintWorkouttcxListItem.UINameEdit;
            WinSplitButton uIOpenSplitButton = this.UIUploadRideWindow.UIOpenWindow.UIOpenSplitButton;
            WinButton uIEstimatePowerButton = this.UICyclingPowerEstimatiWindow.UIEstimatePowerWindow.UIEstimatePowerButton;
            #endregion

            // Click 'Upload TCX' button
            Mouse.Click(uIUploadTCXButton, new Point(45, 7));

            // Click 'Name' text box
            Mouse.Click(uINameEdit, new Point(46, 12));

            // Click '&Open' split button
            Mouse.Click(uIOpenSplitButton, new Point(27, 13));

            // Click 'Estimate Power' button
            Mouse.Click(uIEstimatePowerButton, new Point(42, 17));
        }
        
        #region Properties
        public UICyclingPowerEstimatiWindow UICyclingPowerEstimatiWindow
        {
            get
            {
                if ((this.mUICyclingPowerEstimatiWindow == null))
                {
                    this.mUICyclingPowerEstimatiWindow = new UICyclingPowerEstimatiWindow();
                }
                return this.mUICyclingPowerEstimatiWindow;
            }
        }
        
        public UIUploadRideWindow UIUploadRideWindow
        {
            get
            {
                if ((this.mUIUploadRideWindow == null))
                {
                    this.mUIUploadRideWindow = new UIUploadRideWindow();
                }
                return this.mUIUploadRideWindow;
            }
        }
        #endregion
        
        #region Fields
        private UICyclingPowerEstimatiWindow mUICyclingPowerEstimatiWindow;
        
        private UIUploadRideWindow mUIUploadRideWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UICyclingPowerEstimatiWindow : WinWindow
    {
        
        public UICyclingPowerEstimatiWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Cycling Power Estimation";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Cycling Power Estimation");
            #endregion
        }
        
        #region Properties
        public UIUploadTCXWindow UIUploadTCXWindow
        {
            get
            {
                if ((this.mUIUploadTCXWindow == null))
                {
                    this.mUIUploadTCXWindow = new UIUploadTCXWindow(this);
                }
                return this.mUIUploadTCXWindow;
            }
        }
        
        public UIEstimatePowerWindow UIEstimatePowerWindow
        {
            get
            {
                if ((this.mUIEstimatePowerWindow == null))
                {
                    this.mUIEstimatePowerWindow = new UIEstimatePowerWindow(this);
                }
                return this.mUIEstimatePowerWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIUploadTCXWindow mUIUploadTCXWindow;
        
        private UIEstimatePowerWindow mUIEstimatePowerWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIUploadTCXWindow : WinWindow
    {
        
        public UIUploadTCXWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "buttonUpload";
            this.WindowTitles.Add("Cycling Power Estimation");
            #endregion
        }
        
        #region Properties
        public WinButton UIUploadTCXButton
        {
            get
            {
                if ((this.mUIUploadTCXButton == null))
                {
                    this.mUIUploadTCXButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIUploadTCXButton.SearchProperties[WinButton.PropertyNames.Name] = "Upload TCX";
                    this.mUIUploadTCXButton.WindowTitles.Add("Cycling Power Estimation");
                    #endregion
                }
                return this.mUIUploadTCXButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIUploadTCXButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIEstimatePowerWindow : WinWindow
    {
        
        public UIEstimatePowerWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "buttonProcess";
            this.WindowTitles.Add("Cycling Power Estimation");
            #endregion
        }
        
        #region Properties
        public WinButton UIEstimatePowerButton
        {
            get
            {
                if ((this.mUIEstimatePowerButton == null))
                {
                    this.mUIEstimatePowerButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIEstimatePowerButton.SearchProperties[WinButton.PropertyNames.Name] = "Estimate Power";
                    this.mUIEstimatePowerButton.WindowTitles.Add("Cycling Power Estimation");
                    #endregion
                }
                return this.mUIEstimatePowerButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIEstimatePowerButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIUploadRideWindow : WinWindow
    {
        
        public UIUploadRideWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Upload Ride";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Upload Ride");
            #endregion
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
        
        public UIOpenWindow UIOpenWindow
        {
            get
            {
                if ((this.mUIOpenWindow == null))
                {
                    this.mUIOpenWindow = new UIOpenWindow(this);
                }
                return this.mUIOpenWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIOpenWindow mUIOpenWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("Upload Ride");
            #endregion
        }
        
        #region Properties
        public UISampletcxListItem UISampletcxListItem
        {
            get
            {
                if ((this.mUISampletcxListItem == null))
                {
                    this.mUISampletcxListItem = new UISampletcxListItem(this);
                }
                return this.mUISampletcxListItem;
            }
        }
        
        public UISprintWorkouttcxListItem UISprintWorkouttcxListItem
        {
            get
            {
                if ((this.mUISprintWorkouttcxListItem == null))
                {
                    this.mUISprintWorkouttcxListItem = new UISprintWorkouttcxListItem(this);
                }
                return this.mUISprintWorkouttcxListItem;
            }
        }
        #endregion
        
        #region Fields
        private UISampletcxListItem mUISampletcxListItem;
        
        private UISprintWorkouttcxListItem mUISprintWorkouttcxListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UISampletcxListItem : WinListItem
    {
        
        public UISampletcxListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "sample.tcx";
            this.WindowTitles.Add("Upload Ride");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Upload Ride");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UISprintWorkouttcxListItem : WinListItem
    {
        
        public UISprintWorkouttcxListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "SprintWorkout.tcx";
            this.WindowTitles.Add("Upload Ride");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Upload Ride");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIOpenWindow : WinWindow
    {
        
        public UIOpenWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("Upload Ride");
            #endregion
        }
        
        #region Properties
        public WinSplitButton UIOpenSplitButton
        {
            get
            {
                if ((this.mUIOpenSplitButton == null))
                {
                    this.mUIOpenSplitButton = new WinSplitButton(this);
                    #region Search Criteria
                    this.mUIOpenSplitButton.SearchProperties[WinButton.PropertyNames.Name] = "Open";
                    this.mUIOpenSplitButton.WindowTitles.Add("Upload Ride");
                    #endregion
                }
                return this.mUIOpenSplitButton;
            }
        }
        #endregion
        
        #region Fields
        private WinSplitButton mUIOpenSplitButton;
        #endregion
    }
}
