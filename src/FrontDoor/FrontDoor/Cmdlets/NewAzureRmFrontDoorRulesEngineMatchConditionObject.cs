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
    /// Defines the New-AzFrontDoorRulesEngineMatchConditionObject cmdlet.
    /// </summary>
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "FrontDoorRulesEngineMatchConditionObject"), OutputType(typeof(PSRulesEngineMatchCondition))]
    public class NewFrontDoorRulesEngineMatchConditionObject : AzureFrontDoorCmdletBase
    {
        /// <summary>
        /// Match Variable
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Match Variable.")]
        [ValidateNotNullOrEmpty]
        string MatchVariable;

        /// <summary>
        /// Name of selector in RequestHeader or RequestBody to be matched
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Name of selector in RequestHeader or RequestBody to be matched.")]
        [ValidateNotNullOrEmpty]
        string Selector;

        /// <summary>
        /// Describes operator to apply to the match condition
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Describes operator to apply to the match condition.")]
        [ValidateNotNullOrEmpty]
        string Operator;

        /// <summary>
        /// Describes if this is negate condition or not
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Describes if this is negate condition or not.")]
        [ValidateNotNullOrEmpty]
        SwitchParameter NegateCondition;

        /// <summary>
        /// Match values to match against. The operator will apply to each value in here with OR semantics. If any of them match the variable with the given operator this match condition is considered a match
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Match values to match against.The operator will apply to each value in here with OR semantics.If any of them match the variable with the given operator this match condition is considered a match.")]
        [ValidateNotNullOrEmpty]
        string[] MatchValues;

        /// <summary>
        /// List of transforms
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "List of transforms.")]
        [ValidateNotNullOrEmpty]
        string[] Transforms;

        public override void ExecuteCmdlet()
        {
        }
    }
}