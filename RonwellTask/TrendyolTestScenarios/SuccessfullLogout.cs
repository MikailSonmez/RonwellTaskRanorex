///////////////////////////////////////////////////////////////////////////////
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
    ///The SuccessfullLogout recording.
    /// </summary>
    [TestModule("13c5bb0c-11c5-4b6b-aa5e-2e33e932071d", ModuleType.Recording, 1)]
    public partial class SuccessfullLogout : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RonwellTask.RonwellTaskRepository repository.
        /// </summary>
        public static global::RonwellTask.RonwellTaskRepository repo = global::RonwellTask.RonwellTaskRepository.Instance;

        static SuccessfullLogout instance = new SuccessfullLogout();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SuccessfullLogout()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SuccessfullLogout Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move at {X=1287,Y=127}.", new RecordItemIndex(0));
            Mouse.MoveTo(1287, 127);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move at {X=1250,Y=460}.", new RecordItemIndex(1));
            Mouse.MoveTo(1250, 460);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at {X=1250,Y=460}.", new RecordItemIndex(2));
            Mouse.MoveTo(1250, 460);
            Mouse.Click(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(1270);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at {X=1896,Y=12}.", new RecordItemIndex(3));
            Mouse.MoveTo(1896, 12);
            Mouse.Click(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
