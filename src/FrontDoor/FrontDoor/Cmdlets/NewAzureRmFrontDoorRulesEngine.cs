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
    /// Defines the New-AzFrontDoorRulesEngine cmdlet.
    /// </summary>
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "FrontDoorRulesEngine", SupportsShouldProcess = true, DefaultParameterSetName = FieldsParameterSet), OutputType(typeof(PSRulesEngine))]
    public class NewAzureRmFrontDoorRulesEngine : AzureFrontDoorCmdletBase
    {
        /// <summary>
        /// The resource group name that the rules engine will be created in.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The resource group name that the rules engine will be created in.")]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// The Front Door name.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Front Door name.")]
        [ValidateNotNullOrEmpty]
        public string FrontDoorName { get; set; }

        /// <summary>
        /// The name of the rule engine.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The name of the rule engine.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        /// <summary>
        /// A list of rules that define a particular Rules Engine Configuration.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "A list of rules that define a particular Rules Engine Configuration.")]
        public PSRulesEngineRule[] Rules { get; set; }

        public override void ExecuteCmdlet()
        {
            var FrontDoor = FrontDoorManagementClient.FrontDoors.ListByResourceGroup(ResourceGroupName)
                .Where(p => p.Name.ToLower() == FrontDoorName.ToLower());

            if(FrontDoor.Count() == 0)
            {
                throw new PSArgumentException(string.Format(Resources.Error_NonExistingFrontDoor,
                                FrontDoorName,
                                ResourceGroupName));
            }

            var existingRulesEngine = FrontDoorManagementClient.RulesEngines.ListByFrontDoor(ResourceGroupName, FrontDoorName);
            if(existingRulesEngine.Count() != 0)
            {
                throw new PSArgumentException(string.Format(Resources.Error_NonExistingFrontDoor,
                                Name,
                                FrontDoorName));
            }

            var createParameters = new Management.FrontDoor.Models.RulesEngine(
                name : Name,
                rules : Rules.Select(x => x.ToSdkRulesEngineRule()).ToList()
                );

            if (ShouldProcess(Resources.RulesEngineTarget, string.Format(Resources.CreateRulesEngine, Name)))
            {
                try
                {
                    var rulesEngine = FrontDoorManagementClient.RulesEngines.CreateOrUpdate(
                                    ResourceGroupName,
                                    FrontDoorName,
                                    Name,
                                    createParameters
                                    );
                    WriteObject(rulesEngine.ToPSRulesEngine());
                }
                catch (Microsoft.Azure.Management.FrontDoor.Models.ErrorResponseException e)
                {
                    throw new PSArgumentException(string.Format(Resources.Error_ErrorResponseFromServer,
                                         e.Response.Content));
                }
            }
        }
    }
}
