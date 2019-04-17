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
    /// Defines the New-AzFrontDoorRulesEngineHeaderAction cmdlet.
    /// </summary>
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "FrontDoorRulesEngineActionObject"), OutputType(typeof(PSRuleAction))]
    public class NewFrontDoorRulesEngineActionObject : AzureFrontDoorCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = "Which type of manipulation to apply to the header.")]
        [ValidateNotNullOrEmpty]
        public PSActionType? ActionType { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The name of the header this action will apply to.")]
        [ValidateNotNullOrEmpty]
        public string HeaderName { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The value to update the given header name with. This value is not used if the actionType is Delete.")]
        [ValidateNotNullOrEmpty]
        public string Value { get; set; }

        public override void ExecuteCmdlet()
        {

        }
    }
}