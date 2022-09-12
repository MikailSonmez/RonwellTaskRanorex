﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace RonwellTask
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CASE5 recording.
    /// </summary>
    [TestModule("82bf8544-4a24-477c-b22a-d955808a0b0c", ModuleType.Recording, 1)]
    public partial class CASE5 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RonwellTaskRepository repository.
        /// </summary>
        public static RonwellTaskRepository repo = RonwellTaskRepository.Instance;

        static CASE5 instance = new CASE5();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CASE5()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CASE5 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ErkekButikleriYeniSezonUEruenler.Graphic1' at 34;43.", repo.ErkekButikleriYeniSezonUEruenler.Graphic1Info, new RecordItemIndex(0));
            repo.ErkekButikleriYeniSezonUEruenler.Graphic1.Click("34;43");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ErkekButikleriYeniSezonUEruenler.EnTrendUEruenlerTuerkiyeninOnlineAl.Graphic2' at 115;163.", repo.ErkekButikleriYeniSezonUEruenler.EnTrendUEruenlerTuerkiyeninOnlineAl.Graphic2Info, new RecordItemIndex(1));
            repo.ErkekButikleriYeniSezonUEruenler.EnTrendUEruenlerTuerkiyeninOnlineAl.Graphic2.Click("115;163");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ErkekButikleriYeniSezonUEruenler.OEdemeTrendyol.None' at 919;257.", repo.ErkekButikleriYeniSezonUEruenler.OEdemeTrendyol.NoneInfo, new RecordItemIndex(2));
            repo.ErkekButikleriYeniSezonUEruenler.OEdemeTrendyol.None.Click("919;257");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ErkekButikleriYeniSezonUEruenler.Back' at 18;10.", repo.ErkekButikleriYeniSezonUEruenler.BackInfo, new RecordItemIndex(3));
            repo.ErkekButikleriYeniSezonUEruenler.Back.Click("18;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ErkekButikleriYeniSezonUEruenler.EnTrendUEruenlerTuerkiyeninOnlineAl.Graphic3' at 133;196.", repo.ErkekButikleriYeniSezonUEruenler.EnTrendUEruenlerTuerkiyeninOnlineAl.Graphic3Info, new RecordItemIndex(4));
            repo.ErkekButikleriYeniSezonUEruenler.EnTrendUEruenlerTuerkiyeninOnlineAl.Graphic3.Click("133;196");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ErkekButikleriYeniSezonUEruenler.OEdemeTrendyol.None' at 912;274.", repo.ErkekButikleriYeniSezonUEruenler.OEdemeTrendyol.NoneInfo, new RecordItemIndex(5));
            repo.ErkekButikleriYeniSezonUEruenler.OEdemeTrendyol.None.Click("912;274");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ErkekButikleriYeniSezonUEruenler.Favorilerim' at 17;2.", repo.ErkekButikleriYeniSezonUEruenler.FavorilerimInfo, new RecordItemIndex(6));
            repo.ErkekButikleriYeniSezonUEruenler.Favorilerim.Click("17;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'ErkekButikleriYeniSezonUEruenler.Grouping'.", repo.ErkekButikleriYeniSezonUEruenler.GroupingInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ErkekButikleriYeniSezonUEruenler.GroupingInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Valid='True') on item 'ErkekButikleriYeniSezonUEruenler.Grouping'.", repo.ErkekButikleriYeniSezonUEruenler.GroupingInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.ErkekButikleriYeniSezonUEruenler.GroupingInfo, "Valid", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'ErkekButikleriYeniSezonUEruenler.Grouping'.", repo.ErkekButikleriYeniSezonUEruenler.GroupingInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.ErkekButikleriYeniSezonUEruenler.GroupingInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
