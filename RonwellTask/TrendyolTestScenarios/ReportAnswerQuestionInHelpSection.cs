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

namespace RonwellTask.TrendyolTestScenarios
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ReportAnswerQuestionInHelpSection recording.
    /// </summary>
    [TestModule("6660227c-abf0-4147-a6da-f2fa810b455a", ModuleType.Recording, 1)]
    public partial class ReportAnswerQuestionInHelpSection : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RonwellTask.RonwellTaskRepository repository.
        /// </summary>
        public static global::RonwellTask.RonwellTaskRepository repo = global::RonwellTask.RonwellTaskRepository.Instance;

        static ReportAnswerQuestionInHelpSection instance = new ReportAnswerQuestionInHelpSection();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ReportAnswerQuestionInHelpSection()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ReportAnswerQuestionInHelpSection Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl1.Suepermarket' at 68;15.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl1.SuepermarketInfo, new RecordItemIndex(0));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl1.Suepermarket.Click("68;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl1.CustomStampBoxWrapper' at 93;56.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl1.CustomStampBoxWrapperInfo, new RecordItemIndex(1));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl1.CustomStampBoxWrapper.Click("93;56");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnTrendUEruenlerTuerkiyeninOnlineAl1.HttpsWwwTrendyolComKbKoycegizYor' at 160;9.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl1.HttpsWwwTrendyolComKbKoycegizYorInfo, new RecordItemIndex(2));
            repo.EnTrendUEruenlerTuerkiyeninOnlineAl1.HttpsWwwTrendyolComKbKoycegizYor.Click("160;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EnTrendUEruenlerTuerkiyeninOnlineAl1.Item'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl1.ItemInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.EnTrendUEruenlerTuerkiyeninOnlineAl1.ItemInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'EnTrendUEruenlerTuerkiyeninOnlineAl1.Answer'.", repo.EnTrendUEruenlerTuerkiyeninOnlineAl1.AnswerInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.EnTrendUEruenlerTuerkiyeninOnlineAl1.AnswerInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at {X=1896,Y=12}.", new RecordItemIndex(6));
            Mouse.MoveTo(1896, 12);
            Mouse.Click(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
