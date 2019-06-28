﻿// ----------------------------------------------------------------------------------
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
    /// Defines the New-AzFrontDoorRulesEngineActionObject cmdlet.
    /// </summary>
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "FrontDoorRulesEngineActionObject"), OutputType(typeof(PSRulesEngineAction))]
    public class NewFrontDoorRulesEngineActionObject : AzureFrontDoorCmdletBase
    {
        /// <summary>
        /// A list of header actions to apply from the request from AFD to the origin.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "A list of header actions to apply from the request from AFD to the origin.")]
        public PSHeaderAction[] RequestHeaderActions { get; set; }

        /// <summary>
        /// A list of header actions to apply from the response from AFD to the origin.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "A list of header actions to apply from the response from AFD to the origin.")]
        public PSHeaderAction[] ResponseHeaderActions { get; set; }

        /// <summary>
        /// Override the route configuration.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Override the route configuration.")]
        public PSRouteConfiguration RouteConfigurationOverride { get; set; }

        public override void ExecuteCmdlet()
        {
            var rulesEngineAction = new PSRulesEngineAction
            {
                RequestHeaderActions = RequestHeaderActions.ToList(),
                ResponseHeaderActions = ResponseHeaderActions.ToList(),
                RouteConfigurationOverride = RouteConfigurationOverride
            };

            WriteObject(rulesEngineAction);
        }
    }
}