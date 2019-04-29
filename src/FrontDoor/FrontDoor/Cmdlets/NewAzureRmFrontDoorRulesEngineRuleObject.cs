// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Management.Automation;
using System.Net;
using Microsoft.Azure.Commands.FrontDoor.Common;
using Microsoft.Azure.Commands.FrontDoor.Helpers;
using Microsoft.Azure.Commands.FrontDoor.Models;
using Microsoft.Azure.Commands.FrontDoor.Properties;
using Microsoft.Azure.Management.FrontDoor;
using System.Linq;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

namespace Microsoft.Azure.Commands.FrontDoor.Cmdlets
{
    /// <summary>
    /// Defines the New-AzFrontDoorRulesEngineRuleObject cmdlet.
    /// </summary>
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "FrontDoorRulesEngineRuleObject"), OutputType(typeof(PSRulesEngineRule))]
    public class NewFrontDoorRulesEngineRuleObject : AzureFrontDoorCmdletBase
    {
        /// <summary>
        /// A name to refer to this specific rule.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "A name to refer to this specific rule.")]
        [ValidateNotNullOrEmpty]
        string Name;

        /// <summary>
        /// A priority assigned to this rule. 
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "A priority assigned to this rule.")]
        int Priority;

        /// <summary>
        /// Actions to perform on the request and response if all of the match conditions are met.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Actions to perform on the request and response if all of the match conditions are met.")]
        PSRulesEngineAction Action;

        /// <summary>
        /// A list of match conditions that must meet in order for the actions of this rule to run. Having no match conditions means the actions will always run.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "A list of match conditions that must meet in order for the actions of this rule to run. Having no match conditions means the actions will always run.")]
        PSRulesEngineMatchCondition[] MatchConditions;

        /// <summary>
        /// If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue.")]
        [PSArgumentCompleter("Continue", "Stop")]
        string MatchProcessingBehavior = PSMatchProcessingBehavior.Continue.ToString();

        public override void ExecuteCmdlet()
        {
            var rulesEngineRule = new PSRulesEngineRule
            {
                Name = Name,
                Priority = Priority,
                Action = Action,
                MatchConditions = MatchConditions,
                MatchProcessingBehavior = MatchProcessingBehavior
            };

            WriteObject(rulesEngineRule);
        }
    }
}
